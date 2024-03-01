using System;
using System.Collections.Generic;
using System.IO;

namespace RRGuard_Firewall
{
    public class WhiteListManager
    {
        public static Dictionary<string, bool> whitelist = new Dictionary<string, bool>();
        private static readonly string wgiteListFilePath = "WhiteList.db";

        public static void CargarWhiteList()
        {
            try
            {
                if (File.Exists(wgiteListFilePath))
                {
                    string[] lines = File.ReadAllLines(wgiteListFilePath);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            whitelist[line.Trim()] = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la lista negra: {ex.Message}");
            }
        }

        public static void GuardarWhiteList()
        {
            try
            {
                File.WriteAllLines(wgiteListFilePath, whitelist.Keys);
            }
            catch (Exception)
            {

            }
        }

        public static void AgregarIpAWhiteList(string ipAddress)
        {
            whitelist[ipAddress] = true;
            GuardarWhiteList();
        }

        public static bool EsIpEnWhiteList(string ipAddress)
        {
            return whitelist.ContainsKey(ipAddress);
        }
    }
}
