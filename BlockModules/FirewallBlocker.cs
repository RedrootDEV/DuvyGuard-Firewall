using System;
using System.Diagnostics;

namespace DuvyGuard_Firewall
{
    public class FirewallBlocker
    {
        public static void BlockIp(string ip)
        {
            try
            {
                string ruleName = $"DuvyGuard_BlockIP_{ip}";

                // Verificar si la regla ya existe antes de intentar agregarla
                if (RuleExists(ruleName))
                {
                    return;
                }

                // Crear el comando para agregar una regla al Firewall de Windows
                string command = $"netsh advfirewall firewall add rule name=\"{ruleName}\" dir=in action=block remoteip={ip}";

                // Configurar el proceso de CMD
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C {command}",  // /C ejecuta el comando y luego se cierra cmd.exe
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                // Iniciar el proceso de CMD
                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();

                    // Leer y descartar la salida estándar y la salida de error
                    process.StandardOutput.ReadToEnd();
                    process.StandardError.ReadToEnd();

                    // Esperar a que el proceso termine
                    process.WaitForExit();
                }
            }
            catch (Exception)
            {
            }
        }

        private static bool RuleExists(string ruleName)
        {
            try
            {
                // Obtener la lista de reglas del Firewall de Windows
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = $"/C netsh advfirewall firewall show rule name={ruleName}",
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    RedirectStandardOutput = true
                };

                using (Process process = new Process { StartInfo = processStartInfo })
                {
                    process.Start();

                    // Leer la salida estándar
                    string output = process.StandardOutput.ReadToEnd();

                    // Esperar a que el proceso termine
                    process.WaitForExit();

                    // Verificar si la regla existe en la salida
                    return output.Contains(ruleName);
                }
            }
            catch (Exception)
            {
                //Console.WriteLine($"Error checking if rule {ruleName} exists: {ex}");
                return false;
            }
        }
    }
}