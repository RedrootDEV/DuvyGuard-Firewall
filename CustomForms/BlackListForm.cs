using System;
using System.Windows.Forms;

namespace RRGuard_Firewall.CustomForms
{
    public partial class BlackListForm : Form
    {
        private static Main mainInstance;

        public BlackListForm(Main main)
        {
            mainInstance = main;
        }
        public BlackListForm()
        {
            InitializeComponent();
        }

        private void BlackListForm_Load(object sender, EventArgs e)
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
            string pais = WhiteListCountriesForm.GetCountryForIP(textBoxIpAddress.Text);
            mainInstance.AgregarBloqueo(textBoxIpAddress.Text, "All", pais);
            BlackListManager.AgregarIpABlackList(textBoxIpAddress.Text);
            Close();
        }
    }
}
