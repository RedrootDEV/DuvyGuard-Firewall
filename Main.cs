using DuvyGuard_Firewall.CustomForms;
using System;
using System.Windows.Forms;

namespace DuvyGuard_Firewall
{
    public partial class Main : Form
    {
        public static int maxIpConnections;
        public static string originalTitle;
        public static bool enableFirewallBlock;
        public static bool discordEnabled;
        public static string discordWebhookUrl;
        public static bool antiProxyEnabled;
        public static string lang = "en";
        readonly ConfigLoader.AppConfig config;
        private Timer printTimer;
        private Timer cleanupTimer;
        public static int[] portsToMonitor;
        public DateTime startTime = DateTime.Now;
        public static bool duvyEnable = false;

        public Main()
        {
            InitializeComponent();

            config = ConfigLoader.LoadConfig();

            SetValues();

            if (config.Language == "es")
            {
                Text = $"{originalTitle} - Bloqueados: 0 ataques";
                statusLabel.Text = "Estado:";
                maxConnectionsLabel.Text = "Conexiones máximas:";
                intervalLabel.Text = "Intervalo:";
                portsLabel.Text = "Puertos:";
                winFirewallLabel.Text = "Módulo Windows Firewall:";
                blockedCountLabel.Text = "Ataques bloqueados:";
                durationLabel.Text = "Duración:";
                discordLabel.Text = "Notificaciones Discord:";
                antiProxyLabel.Text = "Módulo AntiProxy:";
                blackListLabel.Text = "Lista negra:";
                aboutButton.Text = "Sobre";
                fileButton.Text = "Archivo";
                configurationToolStripMenuItem.Text = "Configuración";

                blockDataGrid.Columns.Add("IPAddress", "Dirección IP");
                blockDataGrid.Columns.Add("Port", "Puerto");
                blockDataGrid.Columns.Add("BlockedTime", "Hora de bloqueo");
                blockDataGrid.Columns.Add("Country", "Pais");
            }
            else if (config.Language == "pt")
            {
                Text = $"{originalTitle} - Bloqueados: 0 ataques";
                statusLabel.Text = "Estado:";
                maxConnectionsLabel.Text = "Conexões Máximas:";
                intervalLabel.Text = "Intervalo:";
                portsLabel.Text = "Portas:";
                winFirewallLabel.Text = "Módulo do Windows FIrewall:";
                blockedCountLabel.Text = "Ataques Bloqueados:";
                durationLabel.Text = "Duração:";
                discordLabel.Text = "Notificações do Discord:";
                antiProxyLabel.Text = "Módulo AntiProxy:";
                blackListLabel.Text = "Lista negra:";
                aboutButton.Text = "Sobre";
                fileButton.Text = "Arquivo";
                configurationToolStripMenuItem.Text = "Configuração";

                blockDataGrid.Columns.Add("IPAddress", "Direção IP");
                blockDataGrid.Columns.Add("Port", "Porta");
                blockDataGrid.Columns.Add("BlockedTime", "Tempo de bloqueio");
                blockDataGrid.Columns.Add("Country", "Pais");
            }
            else
            {
                Text = $"{originalTitle} - Blocked: 0 attacks";
                statusLabel.Text = "Status:";
                maxConnectionsLabel.Text = "Max Connections:";
                intervalLabel.Text = "Interval:";
                portsLabel.Text = "Ports:";
                winFirewallLabel.Text = "Windows Firewall Module:";
                blockedCountLabel.Text = "Blocked Attacks:";
                durationLabel.Text = "Duration:";
                discordLabel.Text = "Discord Notifications:";
                antiProxyLabel.Text = "AntiProxy Module:";
                blackListLabel.Text = "Black list:";
                aboutButton.Text = "About";
                fileButton.Text = "File";
                configurationToolStripMenuItem.Text = "Configuration";

                blockDataGrid.Columns.Add("IPAddress", "IP Address");
                blockDataGrid.Columns.Add("Port", "Port");
                blockDataGrid.Columns.Add("BlockedTime", "Blocking time");
                blockDataGrid.Columns.Add("Country", "Country");
            }

            MostrarConfiguracion();
        }
        private void SetValues()
        {
            originalTitle = "DuvyGard Firewall";
            lang = config.Language;

            maxIpConnections = config.MaxConnections;
            enableFirewallBlock = config.EnableFirewallBlock;
            discordEnabled = config.DiscordEnabled;
            discordWebhookUrl = config.DiscordWebhook;
            antiProxyEnabled = config.AntiProxyModule;

            portsToMonitor = config.PortsToMonitor;

            duvyEnable = config.EnabledByDefault;

            if (antiProxyEnabled)
            {
                AntiProxyModule.CargarListaProxy();
            }

            WhiteListCountriesForm whiteListCountries = new WhiteListCountriesForm();

            whiteListCountries.SoftLoadWhiteListCountries();

            WhiteListManager.CargarWhiteList();
            BlackListManager.CargarBlackList();

            TCPMonitor tcpMonitor = new TCPMonitor(this);

            BlackListForm blacklistForm = new BlackListForm(this);

            printTimer = new Timer
            {
                Interval = 1  // Intervalo en milisegundos
            };
            printTimer.Tick += new EventHandler(TCPMonitor.PrintActiveTcpConnections);

            if (duvyEnable)
                printTimer.Start();

            cleanupTimer = new Timer
            {
                Interval = config.CleanupTimerIntervalSeconds * 1000  // Intervalo en segundos
            };
            cleanupTimer.Tick += new EventHandler(TCPMonitor.CleanupIpConnectionCount);

            if (duvyEnable)
                cleanupTimer.Start();

            blockDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void MostrarConfiguracion()
        {
            if (config.Language == "es")
            {
                maxConnectionsSetlabel.Text = config.MaxConnections.ToString();
                intervalSetlabel.Text = config.CleanupTimerIntervalSeconds.ToString();
                portsSetlabel.Text = string.Join(", ", config.PortsToMonitor);
                if (enableFirewallBlock)
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Green;
                    winFirewallSetlabel.Text = "Habilitado";
                }
                else
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    winFirewallSetlabel.Text = "Deshabilitado";
                }

                if (discordEnabled)
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Green;
                    discordSetlabel.Text = "Habilitado";
                }
                else
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    discordSetlabel.Text = "Deshabilitado";
                }

                if (antiProxyEnabled)
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Green;
                    antiProxySetLabel.Text = "Habilitado";
                }
                else
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Crimson;
                    antiProxySetLabel.Text = "Deshabilitado";
                }

                if (duvyEnable)
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Green;
                    statusSetlabel.Text = "Activo";
                    startstopButton.Text = "Detener Firewall";
                }
                else
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    statusSetlabel.Text = "Inactivo";
                    startstopButton.Text = "Activar Firewall";
                }
            }
            else if (config.Language == "pt")
            {
                maxConnectionsSetlabel.Text = config.MaxConnections.ToString();
                intervalSetlabel.Text = config.CleanupTimerIntervalSeconds.ToString();
                portsSetlabel.Text = string.Join(", ", config.PortsToMonitor);
                if (enableFirewallBlock)
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Green;
                    winFirewallSetlabel.Text = "Habilitado";
                }
                else
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    winFirewallSetlabel.Text = "Desabilitado";
                }

                if (discordEnabled)
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Green;
                    discordSetlabel.Text = "Habilitado";
                }
                else
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    discordSetlabel.Text = "Desabilitado";
                }

                if (antiProxyEnabled)
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Green;
                    antiProxySetLabel.Text = "Habilitado";
                }
                else
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Crimson;
                    antiProxySetLabel.Text = "Desabilitado";
                }

                if (duvyEnable)
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Green;
                    statusSetlabel.Text = "Ativo";
                    startstopButton.Text = "Parar Firewall";
                }
                else
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    statusSetlabel.Text = "Parado";
                    startstopButton.Text = "Ativar Firewall";
                }
            }
            else
            {
                maxConnectionsSetlabel.Text = config.MaxConnections.ToString();
                intervalSetlabel.Text = config.CleanupTimerIntervalSeconds.ToString();
                portsSetlabel.Text = string.Join(", ", config.PortsToMonitor);
                if (enableFirewallBlock)
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Green;
                    winFirewallSetlabel.Text = "Enabled";
                }
                else
                {
                    winFirewallSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    winFirewallSetlabel.Text = "Disabled";
                }

                if (discordEnabled)
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Green;
                    discordSetlabel.Text = "Enabled";
                }
                else
                {
                    discordSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    discordSetlabel.Text = "Disabled";
                }

                if (antiProxyEnabled)
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Green;
                    antiProxySetLabel.Text = "Enabled";
                }
                else
                {
                    antiProxySetLabel.ForeColor = System.Drawing.Color.Crimson;
                    antiProxySetLabel.Text = "Disabled";
                }

                if (duvyEnable)
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Green;
                    statusSetlabel.Text = "Active";
                    startstopButton.Text = "Stop Firewall";
                }
                else
                {
                    statusSetlabel.ForeColor = System.Drawing.Color.Crimson;
                    statusSetlabel.Text = "Inactive";
                    startstopButton.Text = "Start Firewall";
                }
            }
            blackListSetLabel.Text = BlackListManager.blackList.Count.ToString();
        }

        public void ActualizarTitulo(string texto)
        {
            Text = texto;
        }

        public void ActualizarConteo(string texto)
        {
            blockedCountSetlabel.Text = texto;
        }

        public void ActualizarBlackList(string texto)
        {
            blackListSetLabel.Text = texto;
        }
        public void AgregarBloqueo(string ip, string puerto, string pais)
        {
            blockDataGrid.SuspendLayout();
            blockDataGrid.Rows.Add(ip, puerto, DateTime.Now.ToString("dddd HH:mm:ss"), pais);
            blockDataGrid.ResumeLayout();
        }

        public void DurationTime(object sender, EventArgs e)
        {
            // Calcula la duración transcurrida
            TimeSpan duration = DateTime.Now - startTime;

            // Actualiza el Label con la duración formateada
            durationSetlabel.Text = $"{duration.Hours:D2}:{duration.Minutes:D2}:{duration.Seconds:D2}";
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DuvyGuard © 2024\n" +
                "AntiDDoS / GeoBlocker\n" +
                "Discord: du_vy\n" +
                "TSM: Duvy");
        }

        private void blackListIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BlackListForm blackListForm = new BlackListForm())
            {
                blackListForm.ShowDialog();
            }
        }

        private void whiteListIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WhiteListForm whiteListForm = new WhiteListForm())
            {
                whiteListForm.ShowDialog();
            }
        }

        private void unblockAllIPsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackListManager.LimpiarBlackList();
            blockDataGrid.Rows.Clear();
            TCPMonitor.clearBlockList();
            blackListSetLabel.Text = "0";
        }

        private void changeStartStopButton()
        {
            if (duvyEnable)
            {
                duvyEnable = false;
                statusSetlabel.ForeColor = System.Drawing.Color.Crimson;
                if (lang == "es")
                {
                    statusSetlabel.Text = "Inactivo";
                    startstopButton.Text = "Iniciar Firewall";
                }
                else if (lang == "pt")
                {
                    statusSetlabel.Text = "Parado";
                    startstopButton.Text = "Ativar Firewall";
                }
                else
                {
                    statusSetlabel.Text = "Inactive";
                    startstopButton.Text = "Start Firewall";
                }
                printTimer.Stop();
                cleanupTimer.Stop();
                durationSetlabel.Text = "0";
            }
            else
            {
                duvyEnable = true;
                statusSetlabel.ForeColor = System.Drawing.Color.Green;
                if (lang == "es")
                {
                    statusSetlabel.Text = "Activo";
                    startstopButton.Text = "Detener Firewall";
                }
                else if (lang == "pt")
                {
                    statusSetlabel.Text = "Ativo";
                    startstopButton.Text = "Parar Firewall";
                }
                else
                {
                    statusSetlabel.Text = "Active";
                    startstopButton.Text = "Stop Firewall";
                }
                printTimer.Start();
                cleanupTimer.Start();
                startTime = DateTime.Now;
            }
        }

        private void startstopButton_Click(object sender, EventArgs e)
        {
            changeStartStopButton();
        }

        private void geoIPBlockingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (WhiteListCountriesForm whiteListCountriesForm = new WhiteListCountriesForm())
            {
                whiteListCountriesForm.ShowDialog();
            }
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ConfigForm configForm = new ConfigForm())
            {
                configForm.ShowDialog();
            }
        }
    }
}
