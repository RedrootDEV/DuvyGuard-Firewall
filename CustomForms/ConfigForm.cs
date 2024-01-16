using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuvyGuard_Firewall.CustomForms
{
    public partial class ConfigForm : Form
    {
        ConfigLoader.AppConfig config = ConfigLoader.LoadConfig();

        public ConfigForm()
        {
            InitializeComponent();

            // Configuración inicial
            config = ConfigLoader.LoadConfig();

            // Inicializar valores en los controles
            textBoxPortsToMonitor.Text = string.Join(", ", config.PortsToMonitor);
            textBoxCleanupTimerIntervalSeconds.Text = config.CleanupTimerIntervalSeconds.ToString();
            textBoxMaxConnections.Text = config.MaxConnections.ToString();
            textBoxDiscordWebhook.Text = config.DiscordWebhook;

            // Llenar el ComboBox con idiomas
            comboBoxLanguage.Items.Add("Español");
            comboBoxLanguage.Items.Add("Português");
            comboBoxLanguage.Items.Add("English");

            // Seleccionar el idioma actual
            switch (config.Language)
            {
                case "es":
                    comboBoxLanguage.SelectedIndex = 0;
                    break;
                case "pt":
                    comboBoxLanguage.SelectedIndex = 1;
                    break;
                default:
                    comboBoxLanguage.SelectedIndex = 2;
                    break;
            }

            // Inicializar valores en ComboBox para opciones booleanas
            comboBoxEnableFirewallBlock.DataSource = new List<string> { "True", "False" };
            comboBoxAntiProxyModule.DataSource = new List<string> { "True", "False" };
            comboBoxDiscordEnabled.DataSource = new List<string> { "True", "False" };
            comboBoxEnabledByDefault.DataSource = new List<string> { "True", "False" };

            // Seleccionar el valor actual
            comboBoxEnableFirewallBlock.SelectedItem = config.EnableFirewallBlock.ToString();
            comboBoxAntiProxyModule.SelectedItem = config.AntiProxyModule.ToString();
            comboBoxDiscordEnabled.SelectedItem = config.DiscordEnabled.ToString();
            comboBoxEnabledByDefault.SelectedItem = config.EnabledByDefault.ToString();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Actualizar los valores en la configuración
                config.PortsToMonitor = Array.ConvertAll(textBoxPortsToMonitor.Text.Split(','), int.Parse);
                config.CleanupTimerIntervalSeconds = int.Parse(textBoxCleanupTimerIntervalSeconds.Text);
                config.MaxConnections = int.Parse(textBoxMaxConnections.Text);
                config.DiscordWebhook = textBoxDiscordWebhook.Text;

                // Actualizar el idioma
                switch (comboBoxLanguage.SelectedIndex)
                {
                    case 0:
                        config.Language = "es";
                        break;
                    case 1:
                        config.Language = "pt";
                        break;
                    default:
                        config.Language = "en";
                        break;
                }

                // Actualizar opciones booleanas
                config.EnableFirewallBlock = bool.Parse(comboBoxEnableFirewallBlock.SelectedItem.ToString());
                config.AntiProxyModule = bool.Parse(comboBoxAntiProxyModule.SelectedItem.ToString());
                config.DiscordEnabled = bool.Parse(comboBoxDiscordEnabled.SelectedItem.ToString());
                config.EnabledByDefault = bool.Parse(comboBoxEnabledByDefault.SelectedItem.ToString());

                // Guardar la configuración
                ConfigLoader.SaveConfig(config);

                string successMessage;

                // Mensaje de éxito según el idioma
                if (config.Language == "es")
                {
                    successMessage = "Configuración guardada correctamente";
                }
                else if (config.Language == "pt")
                {
                    successMessage = "Configuração salva com sucesso";
                }
                else
                {
                    successMessage = "Configuration saved successfully";
                }

                MessageBox.Show(successMessage, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Preguntar al usuario si desea reiniciar la aplicación
                string restartMessage;

                // Mensaje de reinicio según el idioma
                if (config.Language == "es")
                {
                    restartMessage = "¿Desea reiniciar la aplicación para aplicar los cambios?";
                }
                else if (config.Language == "pt")
                {
                    restartMessage = "Deseja reiniciar o aplicativo para aplicar as alterações?";
                }
                else
                {
                    restartMessage = "Do you want to restart the application to apply the changes?";
                }

                DialogResult result = MessageBox.Show(restartMessage, "Reiniciar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Reiniciar la aplicación
                    Application.Restart();
                    Environment.Exit(0); // Salir del proceso actual
                }
            }
            catch (Exception ex)
            {
                string errorMessage;

                // Mensaje de error según el idioma
                if (config.Language == "es")
                {
                    errorMessage = $"Error al guardar la configuración: {ex.Message}";
                }
                else if (config.Language == "pt")
                {
                    errorMessage = $"Erro ao salvar as configurações: {ex.Message}";
                }
                else
                {
                    errorMessage = $"Error saving configuration: {ex.Message}";
                }

                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}