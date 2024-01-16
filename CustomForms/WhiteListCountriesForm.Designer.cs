
namespace DuvyGuard_Firewall.CustomForms
{
    partial class WhiteListCountriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteListCountriesForm));
            this.listBoxAvailableCountries = new System.Windows.Forms.ListBox();
            this.listBoxWhiteListCountries = new System.Windows.Forms.ListBox();
            this.btnAddToWhiteList = new System.Windows.Forms.Button();
            this.btnRemoveFromWhiteList = new System.Windows.Forms.Button();
            this.availableLabel = new System.Windows.Forms.Label();
            this.whistelistedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAvailableCountries
            // 
            this.listBoxAvailableCountries.FormattingEnabled = true;
            this.listBoxAvailableCountries.Location = new System.Drawing.Point(12, 38);
            this.listBoxAvailableCountries.Name = "listBoxAvailableCountries";
            this.listBoxAvailableCountries.Size = new System.Drawing.Size(174, 407);
            this.listBoxAvailableCountries.TabIndex = 0;
            // 
            // listBoxWhiteListCountries
            // 
            this.listBoxWhiteListCountries.FormattingEnabled = true;
            this.listBoxWhiteListCountries.Location = new System.Drawing.Point(313, 35);
            this.listBoxWhiteListCountries.Name = "listBoxWhiteListCountries";
            this.listBoxWhiteListCountries.Size = new System.Drawing.Size(174, 407);
            this.listBoxWhiteListCountries.TabIndex = 1;
            // 
            // btnAddToWhiteList
            // 
            this.btnAddToWhiteList.Location = new System.Drawing.Point(213, 176);
            this.btnAddToWhiteList.Name = "btnAddToWhiteList";
            this.btnAddToWhiteList.Size = new System.Drawing.Size(75, 34);
            this.btnAddToWhiteList.TabIndex = 2;
            this.btnAddToWhiteList.Text = ">";
            this.btnAddToWhiteList.UseVisualStyleBackColor = true;
            this.btnAddToWhiteList.Click += new System.EventHandler(this.btnAddToWhiteList_Click);
            // 
            // btnRemoveFromWhiteList
            // 
            this.btnRemoveFromWhiteList.Location = new System.Drawing.Point(213, 216);
            this.btnRemoveFromWhiteList.Name = "btnRemoveFromWhiteList";
            this.btnRemoveFromWhiteList.Size = new System.Drawing.Size(75, 34);
            this.btnRemoveFromWhiteList.TabIndex = 3;
            this.btnRemoveFromWhiteList.Text = "<";
            this.btnRemoveFromWhiteList.UseVisualStyleBackColor = true;
            this.btnRemoveFromWhiteList.Click += new System.EventHandler(this.btnRemoveFromWhiteList_Click);
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.Location = new System.Drawing.Point(12, 19);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(96, 13);
            this.availableLabel.TabIndex = 4;
            this.availableLabel.Text = "Paises disponibles:";
            // 
            // whistelistedLabel
            // 
            this.whistelistedLabel.AutoSize = true;
            this.whistelistedLabel.Location = new System.Drawing.Point(310, 19);
            this.whistelistedLabel.Name = "whistelistedLabel";
            this.whistelistedLabel.Size = new System.Drawing.Size(117, 13);
            this.whistelistedLabel.TabIndex = 5;
            this.whistelistedLabel.Text = "Paises en Lista Blanca:";
            // 
            // WhiteListCountriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 463);
            this.Controls.Add(this.whistelistedLabel);
            this.Controls.Add(this.availableLabel);
            this.Controls.Add(this.btnRemoveFromWhiteList);
            this.Controls.Add(this.btnAddToWhiteList);
            this.Controls.Add(this.listBoxWhiteListCountries);
            this.Controls.Add(this.listBoxAvailableCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhiteListCountriesForm";
            this.Text = "GeoIP WhiteList Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableCountries;
        private System.Windows.Forms.ListBox listBoxWhiteListCountries;
        private System.Windows.Forms.Button btnAddToWhiteList;
        private System.Windows.Forms.Button btnRemoveFromWhiteList;
        private System.Windows.Forms.Label availableLabel;
        private System.Windows.Forms.Label whistelistedLabel;
    }
}