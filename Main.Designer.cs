
namespace RRGuard_Firewall
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.startstopButton = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualIPControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackListIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteListIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unblockAllIPsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geoIPBlockingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.portsLabel = new System.Windows.Forms.Label();
            this.maxConnectionsLabel = new System.Windows.Forms.Label();
            this.winFirewallLabel = new System.Windows.Forms.Label();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.blockedCountLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.discordLabel = new System.Windows.Forms.Label();
            this.durationLabel = new System.Windows.Forms.Label();
            this.statusSetlabel = new System.Windows.Forms.Label();
            this.maxConnectionsSetlabel = new System.Windows.Forms.Label();
            this.intervalSetlabel = new System.Windows.Forms.Label();
            this.portsSetlabel = new System.Windows.Forms.Label();
            this.winFirewallSetlabel = new System.Windows.Forms.Label();
            this.blockedCountSetlabel = new System.Windows.Forms.Label();
            this.durationSetlabel = new System.Windows.Forms.Label();
            this.discordSetlabel = new System.Windows.Forms.Label();
            this.antiProxyLabel = new System.Windows.Forms.Label();
            this.antiProxySetLabel = new System.Windows.Forms.Label();
            this.blackListLabel = new System.Windows.Forms.Label();
            this.blackListSetLabel = new System.Windows.Forms.Label();
            this.blockDataGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton,
            this.manualIPControlToolStripMenuItem,
            this.geoIPBlockingToolStripMenuItem,
            this.aboutButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileButton
            // 
            this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startstopButton,
            this.configurationToolStripMenuItem});
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(37, 20);
            this.fileButton.Text = "File";
            // 
            // startstopButton
            // 
            this.startstopButton.Name = "startstopButton";
            this.startstopButton.Size = new System.Drawing.Size(148, 22);
            this.startstopButton.Text = "Start Firewall";
            this.startstopButton.Click += new System.EventHandler(this.startstopButton_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // manualIPControlToolStripMenuItem
            // 
            this.manualIPControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackListIPToolStripMenuItem,
            this.whiteListIPToolStripMenuItem,
            this.unblockAllIPsToolStripMenuItem});
            this.manualIPControlToolStripMenuItem.Name = "manualIPControlToolStripMenuItem";
            this.manualIPControlToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manualIPControlToolStripMenuItem.Text = "Manual IP Control";
            // 
            // blackListIPToolStripMenuItem
            // 
            this.blackListIPToolStripMenuItem.Name = "blackListIPToolStripMenuItem";
            this.blackListIPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.blackListIPToolStripMenuItem.Text = "BlackList IP";
            this.blackListIPToolStripMenuItem.Click += new System.EventHandler(this.blackListIPToolStripMenuItem_Click);
            // 
            // whiteListIPToolStripMenuItem
            // 
            this.whiteListIPToolStripMenuItem.Name = "whiteListIPToolStripMenuItem";
            this.whiteListIPToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.whiteListIPToolStripMenuItem.Text = "WhiteList IP";
            this.whiteListIPToolStripMenuItem.Click += new System.EventHandler(this.whiteListIPToolStripMenuItem_Click);
            // 
            // unblockAllIPsToolStripMenuItem
            // 
            this.unblockAllIPsToolStripMenuItem.Name = "unblockAllIPsToolStripMenuItem";
            this.unblockAllIPsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.unblockAllIPsToolStripMenuItem.Text = "Unblock All IPs";
            this.unblockAllIPsToolStripMenuItem.Click += new System.EventHandler(this.unblockAllIPsToolStripMenuItem_Click);
            // 
            // geoIPBlockingToolStripMenuItem
            // 
            this.geoIPBlockingToolStripMenuItem.Name = "geoIPBlockingToolStripMenuItem";
            this.geoIPBlockingToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.geoIPBlockingToolStripMenuItem.Text = "GeoIP Blocking";
            this.geoIPBlockingToolStripMenuItem.Click += new System.EventHandler(this.geoIPBlockingToolStripMenuItem_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(52, 20);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // portsLabel
            // 
            this.portsLabel.AutoSize = true;
            this.portsLabel.Location = new System.Drawing.Point(9, 415);
            this.portsLabel.Name = "portsLabel";
            this.portsLabel.Size = new System.Drawing.Size(46, 13);
            this.portsLabel.TabIndex = 2;
            this.portsLabel.Text = "Puertos:";
            // 
            // maxConnectionsLabel
            // 
            this.maxConnectionsLabel.AutoSize = true;
            this.maxConnectionsLabel.Location = new System.Drawing.Point(9, 175);
            this.maxConnectionsLabel.Name = "maxConnectionsLabel";
            this.maxConnectionsLabel.Size = new System.Drawing.Size(108, 13);
            this.maxConnectionsLabel.TabIndex = 3;
            this.maxConnectionsLabel.Text = "Conexiones máximas:";
            // 
            // winFirewallLabel
            // 
            this.winFirewallLabel.AutoSize = true;
            this.winFirewallLabel.Location = new System.Drawing.Point(9, 295);
            this.winFirewallLabel.Name = "winFirewallLabel";
            this.winFirewallLabel.Size = new System.Drawing.Size(130, 13);
            this.winFirewallLabel.TabIndex = 4;
            this.winFirewallLabel.Text = "Módulo Windows Firewall:";
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(9, 205);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(51, 13);
            this.intervalLabel.TabIndex = 5;
            this.intervalLabel.Text = "Intervalo:";
            // 
            // blockedCountLabel
            // 
            this.blockedCountLabel.AutoSize = true;
            this.blockedCountLabel.Location = new System.Drawing.Point(9, 265);
            this.blockedCountLabel.Name = "blockedCountLabel";
            this.blockedCountLabel.Size = new System.Drawing.Size(107, 13);
            this.blockedCountLabel.TabIndex = 6;
            this.blockedCountLabel.Text = "Ataques bloqueados:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(9, 145);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(43, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Estado:";
            // 
            // discordLabel
            // 
            this.discordLabel.AutoSize = true;
            this.discordLabel.Location = new System.Drawing.Point(9, 385);
            this.discordLabel.Name = "discordLabel";
            this.discordLabel.Size = new System.Drawing.Size(116, 13);
            this.discordLabel.TabIndex = 8;
            this.discordLabel.Text = "Notificaciones Discord:";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(9, 235);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(53, 13);
            this.durationLabel.TabIndex = 9;
            this.durationLabel.Text = "Duración:";
            // 
            // statusSetlabel
            // 
            this.statusSetlabel.AutoSize = true;
            this.statusSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusSetlabel.ForeColor = System.Drawing.Color.Green;
            this.statusSetlabel.Location = new System.Drawing.Point(156, 145);
            this.statusSetlabel.Name = "statusSetlabel";
            this.statusSetlabel.Size = new System.Drawing.Size(43, 13);
            this.statusSetlabel.TabIndex = 10;
            this.statusSetlabel.Text = "Activo";
            // 
            // maxConnectionsSetlabel
            // 
            this.maxConnectionsSetlabel.AutoSize = true;
            this.maxConnectionsSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxConnectionsSetlabel.Location = new System.Drawing.Point(156, 175);
            this.maxConnectionsSetlabel.Name = "maxConnectionsSetlabel";
            this.maxConnectionsSetlabel.Size = new System.Drawing.Size(14, 13);
            this.maxConnectionsSetlabel.TabIndex = 11;
            this.maxConnectionsSetlabel.Text = "0";
            // 
            // intervalSetlabel
            // 
            this.intervalSetlabel.AutoSize = true;
            this.intervalSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalSetlabel.Location = new System.Drawing.Point(156, 205);
            this.intervalSetlabel.Name = "intervalSetlabel";
            this.intervalSetlabel.Size = new System.Drawing.Size(14, 13);
            this.intervalSetlabel.TabIndex = 12;
            this.intervalSetlabel.Text = "0";
            // 
            // portsSetlabel
            // 
            this.portsSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portsSetlabel.Location = new System.Drawing.Point(156, 415);
            this.portsSetlabel.Name = "portsSetlabel";
            this.portsSetlabel.Size = new System.Drawing.Size(184, 76);
            this.portsSetlabel.TabIndex = 13;
            this.portsSetlabel.Text = "0";
            // 
            // winFirewallSetlabel
            // 
            this.winFirewallSetlabel.AutoSize = true;
            this.winFirewallSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winFirewallSetlabel.Location = new System.Drawing.Point(156, 295);
            this.winFirewallSetlabel.Name = "winFirewallSetlabel";
            this.winFirewallSetlabel.Size = new System.Drawing.Size(14, 13);
            this.winFirewallSetlabel.TabIndex = 14;
            this.winFirewallSetlabel.Text = "0";
            // 
            // blockedCountSetlabel
            // 
            this.blockedCountSetlabel.AutoSize = true;
            this.blockedCountSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockedCountSetlabel.Location = new System.Drawing.Point(155, 265);
            this.blockedCountSetlabel.Name = "blockedCountSetlabel";
            this.blockedCountSetlabel.Size = new System.Drawing.Size(14, 13);
            this.blockedCountSetlabel.TabIndex = 15;
            this.blockedCountSetlabel.Text = "0";
            // 
            // durationSetlabel
            // 
            this.durationSetlabel.AutoSize = true;
            this.durationSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationSetlabel.Location = new System.Drawing.Point(156, 235);
            this.durationSetlabel.Name = "durationSetlabel";
            this.durationSetlabel.Size = new System.Drawing.Size(14, 13);
            this.durationSetlabel.TabIndex = 16;
            this.durationSetlabel.Text = "0";
            // 
            // discordSetlabel
            // 
            this.discordSetlabel.AutoSize = true;
            this.discordSetlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordSetlabel.Location = new System.Drawing.Point(156, 385);
            this.discordSetlabel.Name = "discordSetlabel";
            this.discordSetlabel.Size = new System.Drawing.Size(14, 13);
            this.discordSetlabel.TabIndex = 17;
            this.discordSetlabel.Text = "0";
            // 
            // antiProxyLabel
            // 
            this.antiProxyLabel.AutoSize = true;
            this.antiProxyLabel.Location = new System.Drawing.Point(9, 325);
            this.antiProxyLabel.Name = "antiProxyLabel";
            this.antiProxyLabel.Size = new System.Drawing.Size(92, 13);
            this.antiProxyLabel.TabIndex = 18;
            this.antiProxyLabel.Text = "Módulo AntiProxy:";
            // 
            // antiProxySetLabel
            // 
            this.antiProxySetLabel.AutoSize = true;
            this.antiProxySetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antiProxySetLabel.Location = new System.Drawing.Point(156, 325);
            this.antiProxySetLabel.Name = "antiProxySetLabel";
            this.antiProxySetLabel.Size = new System.Drawing.Size(14, 13);
            this.antiProxySetLabel.TabIndex = 19;
            this.antiProxySetLabel.Text = "0";
            // 
            // blackListLabel
            // 
            this.blackListLabel.AutoSize = true;
            this.blackListLabel.Location = new System.Drawing.Point(9, 355);
            this.blackListLabel.Name = "blackListLabel";
            this.blackListLabel.Size = new System.Drawing.Size(62, 13);
            this.blackListLabel.TabIndex = 20;
            this.blackListLabel.Text = "Lista negra:";
            // 
            // blackListSetLabel
            // 
            this.blackListSetLabel.AutoSize = true;
            this.blackListSetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackListSetLabel.Location = new System.Drawing.Point(156, 355);
            this.blackListSetLabel.Name = "blackListSetLabel";
            this.blackListSetLabel.Size = new System.Drawing.Size(14, 13);
            this.blackListSetLabel.TabIndex = 21;
            this.blackListSetLabel.Text = "0";
            // 
            // blockDataGrid
            // 
            this.blockDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blockDataGrid.Location = new System.Drawing.Point(346, 130);
            this.blockDataGrid.Name = "blockDataGrid";
            this.blockDataGrid.ReadOnly = true;
            this.blockDataGrid.Size = new System.Drawing.Size(454, 381);
            this.blockDataGrid.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RRGuard_Firewall.Properties.Resources.Sin_título_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(812, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.blockDataGrid);
            this.Controls.Add(this.blackListSetLabel);
            this.Controls.Add(this.blackListLabel);
            this.Controls.Add(this.antiProxySetLabel);
            this.Controls.Add(this.antiProxyLabel);
            this.Controls.Add(this.discordSetlabel);
            this.Controls.Add(this.durationSetlabel);
            this.Controls.Add(this.blockedCountSetlabel);
            this.Controls.Add(this.winFirewallSetlabel);
            this.Controls.Add(this.portsSetlabel);
            this.Controls.Add(this.intervalSetlabel);
            this.Controls.Add(this.maxConnectionsSetlabel);
            this.Controls.Add(this.statusSetlabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.discordLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.blockedCountLabel);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.winFirewallLabel);
            this.Controls.Add(this.maxConnectionsLabel);
            this.Controls.Add(this.portsLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "RRGuard Firewall";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.Label portsLabel;
        private System.Windows.Forms.Label maxConnectionsLabel;
        private System.Windows.Forms.Label winFirewallLabel;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label blockedCountLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label discordLabel;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Label statusSetlabel;
        private System.Windows.Forms.Label maxConnectionsSetlabel;
        private System.Windows.Forms.Label intervalSetlabel;
        private System.Windows.Forms.Label portsSetlabel;
        private System.Windows.Forms.Label winFirewallSetlabel;
        private System.Windows.Forms.Label blockedCountSetlabel;
        private System.Windows.Forms.Label durationSetlabel;
        private System.Windows.Forms.Label discordSetlabel;
        private System.Windows.Forms.Label antiProxyLabel;
        private System.Windows.Forms.Label antiProxySetLabel;
        private System.Windows.Forms.Label blackListLabel;
        private System.Windows.Forms.Label blackListSetLabel;
        private System.Windows.Forms.DataGridView blockDataGrid;
        private System.Windows.Forms.ToolStripMenuItem manualIPControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackListIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteListIPToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem unblockAllIPsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileButton;
        private System.Windows.Forms.ToolStripMenuItem startstopButton;
        private System.Windows.Forms.ToolStripMenuItem geoIPBlockingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
    }
}

