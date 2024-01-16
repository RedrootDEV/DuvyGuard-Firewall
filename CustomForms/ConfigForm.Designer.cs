
namespace DuvyGuard_Firewall.CustomForms
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.portsLabel = new System.Windows.Forms.Label();
            this.maxConnectionLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.winFirewallLabel = new System.Windows.Forms.Label();
            this.antiProxyLabel = new System.Windows.Forms.Label();
            this.langLabel = new System.Windows.Forms.Label();
            this.discordEnableLabel = new System.Windows.Forms.Label();
            this.discordUrlLabel = new System.Windows.Forms.Label();
            this.enabledByDefaultLabel = new System.Windows.Forms.Label();
            this.textBoxPortsToMonitor = new System.Windows.Forms.TextBox();
            this.textBoxCleanupTimerIntervalSeconds = new System.Windows.Forms.TextBox();
            this.textBoxDiscordWebhook = new System.Windows.Forms.TextBox();
            this.textBoxMaxConnections = new System.Windows.Forms.TextBox();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxEnabledByDefault = new System.Windows.Forms.ComboBox();
            this.comboBoxEnableFirewallBlock = new System.Windows.Forms.ComboBox();
            this.comboBoxAntiProxyModule = new System.Windows.Forms.ComboBox();
            this.comboBoxDiscordEnabled = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // portsLabel
            // 
            this.portsLabel.AutoSize = true;
            this.portsLabel.Location = new System.Drawing.Point(12, 79);
            this.portsLabel.Name = "portsLabel";
            this.portsLabel.Size = new System.Drawing.Size(46, 13);
            this.portsLabel.TabIndex = 0;
            this.portsLabel.Text = "Puertos:";
            // 
            // maxConnectionLabel
            // 
            this.maxConnectionLabel.AutoSize = true;
            this.maxConnectionLabel.Location = new System.Drawing.Point(12, 105);
            this.maxConnectionLabel.Name = "maxConnectionLabel";
            this.maxConnectionLabel.Size = new System.Drawing.Size(108, 13);
            this.maxConnectionLabel.TabIndex = 1;
            this.maxConnectionLabel.Text = "Conexiones máximas:";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(12, 131);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(51, 13);
            this.intervalLabel.TabIndex = 2;
            this.intervalLabel.Text = "Intervalo:";
            // 
            // winFirewallLabel
            // 
            this.winFirewallLabel.AutoSize = true;
            this.winFirewallLabel.Location = new System.Drawing.Point(12, 157);
            this.winFirewallLabel.Name = "winFirewallLabel";
            this.winFirewallLabel.Size = new System.Drawing.Size(102, 13);
            this.winFirewallLabel.TabIndex = 3;
            this.winFirewallLabel.Text = "Módulo WinFirewall:";
            // 
            // antiProxyLabel
            // 
            this.antiProxyLabel.AutoSize = true;
            this.antiProxyLabel.Location = new System.Drawing.Point(12, 184);
            this.antiProxyLabel.Name = "antiProxyLabel";
            this.antiProxyLabel.Size = new System.Drawing.Size(92, 13);
            this.antiProxyLabel.TabIndex = 4;
            this.antiProxyLabel.Text = "Módulo AntiProxy:";
            // 
            // langLabel
            // 
            this.langLabel.AutoSize = true;
            this.langLabel.Location = new System.Drawing.Point(12, 25);
            this.langLabel.Name = "langLabel";
            this.langLabel.Size = new System.Drawing.Size(54, 13);
            this.langLabel.TabIndex = 5;
            this.langLabel.Text = "Lenguaje:";
            // 
            // discordEnableLabel
            // 
            this.discordEnableLabel.AutoSize = true;
            this.discordEnableLabel.Location = new System.Drawing.Point(12, 211);
            this.discordEnableLabel.Name = "discordEnableLabel";
            this.discordEnableLabel.Size = new System.Drawing.Size(116, 13);
            this.discordEnableLabel.TabIndex = 6;
            this.discordEnableLabel.Text = "Notificaciones Discord:";
            // 
            // discordUrlLabel
            // 
            this.discordUrlLabel.AutoSize = true;
            this.discordUrlLabel.Location = new System.Drawing.Point(12, 236);
            this.discordUrlLabel.Name = "discordUrlLabel";
            this.discordUrlLabel.Size = new System.Drawing.Size(121, 13);
            this.discordUrlLabel.TabIndex = 7;
            this.discordUrlLabel.Text = "Discord Webhook URL:";
            // 
            // enabledByDefaultLabel
            // 
            this.enabledByDefaultLabel.AutoSize = true;
            this.enabledByDefaultLabel.Location = new System.Drawing.Point(12, 52);
            this.enabledByDefaultLabel.Name = "enabledByDefaultLabel";
            this.enabledByDefaultLabel.Size = new System.Drawing.Size(81, 13);
            this.enabledByDefaultLabel.TabIndex = 8;
            this.enabledByDefaultLabel.Text = "Activar al inicio:";
            // 
            // textBoxPortsToMonitor
            // 
            this.textBoxPortsToMonitor.Location = new System.Drawing.Point(160, 76);
            this.textBoxPortsToMonitor.Name = "textBoxPortsToMonitor";
            this.textBoxPortsToMonitor.Size = new System.Drawing.Size(100, 20);
            this.textBoxPortsToMonitor.TabIndex = 9;
            // 
            // textBoxCleanupTimerIntervalSeconds
            // 
            this.textBoxCleanupTimerIntervalSeconds.Location = new System.Drawing.Point(160, 128);
            this.textBoxCleanupTimerIntervalSeconds.Name = "textBoxCleanupTimerIntervalSeconds";
            this.textBoxCleanupTimerIntervalSeconds.Size = new System.Drawing.Size(100, 20);
            this.textBoxCleanupTimerIntervalSeconds.TabIndex = 10;
            // 
            // textBoxDiscordWebhook
            // 
            this.textBoxDiscordWebhook.Location = new System.Drawing.Point(15, 252);
            this.textBoxDiscordWebhook.Name = "textBoxDiscordWebhook";
            this.textBoxDiscordWebhook.Size = new System.Drawing.Size(245, 20);
            this.textBoxDiscordWebhook.TabIndex = 11;
            // 
            // textBoxMaxConnections
            // 
            this.textBoxMaxConnections.Location = new System.Drawing.Point(160, 102);
            this.textBoxMaxConnections.Name = "textBoxMaxConnections";
            this.textBoxMaxConnections.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxConnections.TabIndex = 12;
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(160, 22);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(100, 21);
            this.comboBoxLanguage.TabIndex = 17;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(163, 288);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(97, 42);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxEnabledByDefault
            // 
            this.comboBoxEnabledByDefault.FormattingEnabled = true;
            this.comboBoxEnabledByDefault.Location = new System.Drawing.Point(160, 49);
            this.comboBoxEnabledByDefault.Name = "comboBoxEnabledByDefault";
            this.comboBoxEnabledByDefault.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEnabledByDefault.TabIndex = 19;
            // 
            // comboBoxEnableFirewallBlock
            // 
            this.comboBoxEnableFirewallBlock.FormattingEnabled = true;
            this.comboBoxEnableFirewallBlock.Location = new System.Drawing.Point(159, 154);
            this.comboBoxEnableFirewallBlock.Name = "comboBoxEnableFirewallBlock";
            this.comboBoxEnableFirewallBlock.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEnableFirewallBlock.TabIndex = 20;
            // 
            // comboBoxAntiProxyModule
            // 
            this.comboBoxAntiProxyModule.FormattingEnabled = true;
            this.comboBoxAntiProxyModule.Location = new System.Drawing.Point(159, 181);
            this.comboBoxAntiProxyModule.Name = "comboBoxAntiProxyModule";
            this.comboBoxAntiProxyModule.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAntiProxyModule.TabIndex = 21;
            // 
            // comboBoxDiscordEnabled
            // 
            this.comboBoxDiscordEnabled.FormattingEnabled = true;
            this.comboBoxDiscordEnabled.Location = new System.Drawing.Point(159, 208);
            this.comboBoxDiscordEnabled.Name = "comboBoxDiscordEnabled";
            this.comboBoxDiscordEnabled.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDiscordEnabled.TabIndex = 22;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 339);
            this.Controls.Add(this.comboBoxDiscordEnabled);
            this.Controls.Add(this.comboBoxAntiProxyModule);
            this.Controls.Add(this.comboBoxEnableFirewallBlock);
            this.Controls.Add(this.comboBoxEnabledByDefault);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.textBoxMaxConnections);
            this.Controls.Add(this.textBoxDiscordWebhook);
            this.Controls.Add(this.textBoxCleanupTimerIntervalSeconds);
            this.Controls.Add(this.textBoxPortsToMonitor);
            this.Controls.Add(this.enabledByDefaultLabel);
            this.Controls.Add(this.discordUrlLabel);
            this.Controls.Add(this.discordEnableLabel);
            this.Controls.Add(this.langLabel);
            this.Controls.Add(this.antiProxyLabel);
            this.Controls.Add(this.winFirewallLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.maxConnectionLabel);
            this.Controls.Add(this.portsLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "DuvyGuard Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portsLabel;
        private System.Windows.Forms.Label maxConnectionLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label winFirewallLabel;
        private System.Windows.Forms.Label antiProxyLabel;
        private System.Windows.Forms.Label langLabel;
        private System.Windows.Forms.Label discordEnableLabel;
        private System.Windows.Forms.Label discordUrlLabel;
        private System.Windows.Forms.Label enabledByDefaultLabel;
        private System.Windows.Forms.TextBox textBoxPortsToMonitor;
        private System.Windows.Forms.TextBox textBoxCleanupTimerIntervalSeconds;
        private System.Windows.Forms.TextBox textBoxDiscordWebhook;
        private System.Windows.Forms.TextBox textBoxMaxConnections;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxEnabledByDefault;
        private System.Windows.Forms.ComboBox comboBoxEnableFirewallBlock;
        private System.Windows.Forms.ComboBox comboBoxAntiProxyModule;
        private System.Windows.Forms.ComboBox comboBoxDiscordEnabled;
    }
}