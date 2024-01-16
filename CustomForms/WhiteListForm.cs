using System;
using System.Windows.Forms;

namespace DuvyGuard_Firewall.CustomForms
{
    public partial class WhiteListForm : Form
    {
        public WhiteListForm()
        {
            InitializeComponent();
        }

        private void WhiteListForm_Load(object sender, EventArgs e)
        {
            if (Main.lang == "es")
            {
                btnAceptar.Text = "Aceptar";
                label1.Text = "Ingrese una dirección IP";
            }
            else if (Main.lang == "pt")
            {
                btnAceptar.Text = "Aceitar";
                label1.Text = "Insira um endereço IP:";
            }
            else
            {
                btnAceptar.Text = "Accept";
                label1.Text = "Enter an IP address:";
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            WhiteListManager.AgregarIpAWhiteList(textBoxIpAddress.Text);
            Close();
        }
    }
}
