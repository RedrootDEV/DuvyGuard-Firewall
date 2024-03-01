using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace RRGuard_Firewall
{
    public class AntiProxyModule
    {
        public static Dictionary<string, bool> proxyList = new Dictionary<string, bool>();

        public static void CargarListaProxy()
        {
            try
            {
                string url = "https://lists.blocklist.de/lists/all.txt";

                using (WebClient client = new WebClient())
                {
                    try
                    {
                        string proxyListText = client.DownloadString(url);

                        string[] lines = proxyListText.Split('\n');

                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("#"))
                            {
                                proxyList[line.Trim()] = true;
                            }
                        }
                    }
                    catch (WebException webEx)
                    {
                        if (webEx.Response is HttpWebResponse response && response.StatusCode == HttpStatusCode.NotFound)
                        {
                            // La lista remota no fue encontrada (Error 404)
                            Console.WriteLine("Error 404: Lista remota no encontrada. Cargando lista local.");
                            CargarListaProxyLocal();
                        }
                        else
                        {
                            // Otro tipo de error al descargar la lista remota
                            Console.WriteLine($"Error al descargar la lista remota: {webEx.Message}. Cargando lista local.");
                            CargarListaProxyLocal();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la lista de proxy: {ex.Message}");
            }
        }

        private static void CargarListaProxyLocal()
        {
            try
            {
                // Ruta del archivo local
                string localFilePath = "ProxyDB.db";

                if (File.Exists(localFilePath))
                {
                    // Cargar la lista local
                    string[] lines = File.ReadAllLines(localFilePath);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            proxyList[line.Trim()] = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error: Lista local de proxy no encontrada.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la lista local de proxy: {ex.Message}");
            }
        }
    }
}
