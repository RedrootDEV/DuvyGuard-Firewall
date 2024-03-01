using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace RRGuard_Firewall
{
    public class ConfigLoader
    {
        public static AppConfig LoadConfig()
        {
            try
            {
                string configFilePath = "Config.json";
                if (File.Exists(configFilePath))
                {
                    string json = File.ReadAllText(configFilePath);
                    return JsonConvert.DeserializeObject<AppConfig>(json);
                }
                else
                {
                    return new AppConfig
                    {
                        Language = "en",
                        EnabledByDefault = false,
                        PortsToMonitor = new int[] { 44405, 55901, 55916, 55999 },
                        CleanupTimerIntervalSeconds = 5,
                        MaxConnections = 3,
                        EnableFirewallBlock = true,
                        AntiProxyModule = true,
                        DiscordEnabled = true,
                        DiscordWebhook = "",
                        WhiteListCountries = new HashSet<string>() // Inicializar la lista blanca
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configuration: {ex.Message}");
                return null;
            }
        }

        public static void SaveConfig(AppConfig config)
        {
            try
            {
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText("Config.json", json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving configuration: {ex.Message}");
            }
        }

        public class AppConfig
        {
            public int[] PortsToMonitor { get; set; }
            public int CleanupTimerIntervalSeconds { get; set; }
            public int MaxConnections { get; set; }
            public bool EnableFirewallBlock { get; set; }
            public bool AntiProxyModule { get; set; }
            public string Language { get; set; }
            public bool DiscordEnabled { get; set; }
            public string DiscordWebhook { get; set; }
            public bool EnabledByDefault { get; set; }

            public HashSet<string> WhiteListCountries { get; set; }

            // Métodos relacionados con la lista blanca
            public void AddToWhiteList(string country)
            {
                if (WhiteListCountries == null)
                {
                    WhiteListCountries = new HashSet<string>();
                }
                WhiteListCountries.Add(country);
            }

            public void RemoveFromWhiteList(string country)
            {
                if (WhiteListCountries != null)
                {
                    WhiteListCountries.Remove(country);
                }
            }
        }
    }
}
