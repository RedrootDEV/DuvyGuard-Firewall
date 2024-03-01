using System;
using System.Collections.Generic;
using System.IO;

namespace RRGuard_Firewall
{
    public class BlackListManager
    {
        public static Dictionary<string, bool> blackList = new Dictionary<string, bool>();
        private static readonly string blackListFilePath = "BlackList.db";

        public static void CargarBlackList()
        {
            try
            {
                if (File.Exists(blackListFilePath))
                {
                    string[] lines = File.ReadAllLines(blackListFilePath);

                    foreach (string line in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            blackList[line.Trim()] = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cargar la lista negra: {ex.Message}");
            }
        }

        public static void GuardarBlackList()
        {
            try
            {
                File.WriteAllLines(blackListFilePath, blackList.Keys);
            }
            catch (Exception)
            {

            }
        }

        public static void AgregarIpABlackList(string ipAddress)
        {
            blackList[ipAddress] = true;
            GuardarBlackList();
        }

        public static bool EsIpEnBlackList(string ipAddress)
        {
            return blackList.ContainsKey(ipAddress);
        }

        public static void LimpiarBlackList()
        {
            blackList.Clear();
            GuardarBlackList();
        }

    }
}
