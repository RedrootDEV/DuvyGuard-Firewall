using RRGuard_Firewall.CustomForms;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace RRGuard_Firewall
{
    public class TCPMonitor
    {
        private static readonly Dictionary<string, int> ipConnectionCount = new Dictionary<string, int>();
        private static readonly Dictionary<string, HashSet<int>> ipPortConnections = new Dictionary<string, HashSet<int>>();
        private static readonly HashSet<string> blockedIps = new HashSet<string>();  // Almacena las IPs ya bloqueadas
        private static readonly object lockObject = new object();
        private static Main mainInstance;

        public TCPMonitor(Main main)
        {
            mainInstance = main;
        }

        public static void CleanupIpConnectionCount(object state, EventArgs e)
        {
            lock (lockObject)
            {
                ipConnectionCount.Clear();
                ipPortConnections.Clear();
            }
        }

        public static void PrintActiveTcpConnections(object state, EventArgs e)
        {
            try
            {
                IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();

                foreach (TcpConnectionInformation connection in connections)
                {
                    if (Array.Exists(Main.portsToMonitor, port => port == connection.LocalEndPoint.Port))
                    {
                        string remoteIpAddress = connection.RemoteEndPoint.Address.ToString();
                        bool isInWhiteList = WhiteListCountriesForm.IsCountryInWhiteList(remoteIpAddress);

                        if (isInWhiteList || WhiteListManager.whitelist.ContainsKey(remoteIpAddress))
                            return;

                        string localIpAddress = connection.LocalEndPoint.Address.ToString();
                        int remotePort = connection.RemoteEndPoint.Port;
                        int localPort = connection.LocalEndPoint.Port;

                        // Resto de tu lógica actual si la IP no está en la whitelist
                        if (blockedIps.Contains(remoteIpAddress) || AntiProxyModule.proxyList.ContainsKey(remoteIpAddress) || BlackListManager.blackList.ContainsKey(remoteIpAddress))
                        {
                            BlockIP.FinalizarConexionTCP(localIpAddress, localPort.ToString(), remoteIpAddress, connection.RemoteEndPoint.Port.ToString());
                        }
                        else
                        {
                            lock (lockObject)
                            {
                                if (!ipConnectionCount.ContainsKey(remoteIpAddress))
                                {
                                    ipConnectionCount[remoteIpAddress] = 1;
                                    ipPortConnections[remoteIpAddress] = new HashSet<int>();
                                }
                                else
                                {
                                    if (ipPortConnections[remoteIpAddress].Contains(remotePort))
                                    {
                                        continue;
                                    }

                                    ipConnectionCount[remoteIpAddress]++;
                                }

                                ipPortConnections[remoteIpAddress].Add(remotePort);
                            }

                            if (ipConnectionCount[remoteIpAddress] > Main.maxIpConnections && !blockedIps.Contains(remoteIpAddress))
                            {
                                BlockIP.FinalizarConexionTCP(localIpAddress, localPort.ToString(), remoteIpAddress, connection.RemoteEndPoint.Port.ToString());

                                blockedIps.Add(remoteIpAddress);

                                if (Main.enableFirewallBlock == true)
                                {
                                    try
                                    {
                                        FirewallBlocker.BlockIp(remoteIpAddress);
                                    }
                                    catch (Exception firewallException)
                                    {
                                        Console.WriteLine($"Error in FirewallBlocker: {firewallException.Message}");
                                    }
                                }

                                if (Main.lang == "es")
                                {
                                    mainInstance.ActualizarTitulo($"{Main.originalTitle} - Bloqueados: {blockedIps.Count} ataques");
                                    if (Main.discordEnabled)
                                    {
                                        DiscordWebhook.SendPlainText($"IP Bloqueada: {remoteIpAddress}");
                                    }
                                }
                                else if (Main.lang == "pt")
                                {
                                    mainInstance.ActualizarTitulo($"{Main.originalTitle} - Bloqueados: {blockedIps.Count} ataques");
                                    if (Main.discordEnabled)
                                        DiscordWebhook.SendPlainText($"IP Bloqueado: {remoteIpAddress}");
                                }
                                else
                                {
                                    mainInstance.ActualizarTitulo($"{Main.originalTitle} - Blocked: {blockedIps.Count} attacks");
                                    if (Main.discordEnabled)
                                        DiscordWebhook.SendPlainText($"Blocked IP: {remoteIpAddress}");
                                }

                                string country = WhiteListCountriesForm.GetCountryForIP(remoteIpAddress);
                                mainInstance.AgregarBloqueo(remoteIpAddress, connection.RemoteEndPoint.Port.ToString(), country);
                                mainInstance.ActualizarConteo(blockedIps.Count.ToString());
                                BlackListManager.AgregarIpABlackList(remoteIpAddress);
                                mainInstance.ActualizarBlackList(BlackListManager.blackList.Count.ToString());
                            }
                        }
                    }
                }

                mainInstance.DurationTime(state, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error printing active connections: {ex.Message}");
            }
        }

        public static void clearBlockList()
        {
            lock (lockObject)
            {
                ipConnectionCount.Clear();
                ipPortConnections.Clear();
                blockedIps.Clear();
            }
        }
    }
}
