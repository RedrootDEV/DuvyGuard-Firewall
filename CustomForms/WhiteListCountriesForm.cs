using MaxMind.GeoIP2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
namespace RRGuard_Firewall.CustomForms
{
    public partial class WhiteListCountriesForm : Form
    {
        public static HashSet<string> whiteListCountries = new HashSet<string>();
        private HashSet<string> availableCountriesSet = new HashSet<string>();

        public WhiteListCountriesForm()
        {
            InitializeComponent();

            if (Main.lang == "es")
            {
                availableLabel.Text = "Paises disponibles:";
                whistelistedLabel.Text = "Paises en Lista Blanca:";
            }
            else if (Main.lang == "pt")
            {
                availableLabel.Text = "Países disponíveis:";
                whistelistedLabel.Text = "Países na Lista Branca:";
            }
            else
            {
                availableLabel.Text = "Available countries:";
                whistelistedLabel.Text = "White List Countries:";
            }

            // Llenar la primera ListBox con la lista de países disponibles
            FillAvailableCountriesList();

            LoadWhiteListCountries();
        }
        public void SoftLoadWhiteListCountries()
        {
            ConfigLoader.AppConfig config = ConfigLoader.LoadConfig();
            if (config != null && config.WhiteListCountries != null)
            {
                whiteListCountries = config.WhiteListCountries;

                // Guardar el contenido de whiteListCountries en un archivo de texto
                //SaveWhiteListToFile("DebugWhiteList.txt");
            }
        }

        private void SaveWhiteListToFile(string filePath)
        {
            try
            {
                File.WriteAllLines(filePath, whiteListCountries);
                Console.WriteLine($"WhiteListCountries saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving WhiteListCountries to file: {ex.Message}");
            }
        }


        private void LoadWhiteListCountries()
        {
            ConfigLoader.AppConfig config = ConfigLoader.LoadConfig();
            if (config != null && config.WhiteListCountries != null)
            {
                whiteListCountries = config.WhiteListCountries;
                UpdateWhiteListCountriesListBox();
                UpdateAvailableCountriesListBox(); // Actualizar la lista de países disponibles
            }
        }

        public static bool IsCountryInWhiteList(string ipAddress)
        {
            using (DatabaseReader reader = new DatabaseReader("database.mmdb"))
            {
                try
                {
                    MaxMind.GeoIP2.Responses.CountryResponse response = reader.Country(ipAddress);
                    string countryName = response.Country.Name;

                    return whiteListCountries.Contains(countryName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al verificar el país: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false; // Puedes manejar el error según tus necesidades específicas
                }
            }
        }

        private void FillAvailableCountriesList()
        {
            // Lista de países en inglés (puedes cambiarlos según sea necesario)
            string[] availableCountries =
            {
                "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina",
                "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados",
                "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina",
                "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia",
                "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia",
                "Comoros", "Congo", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czechia",
                "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador",
                "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France",
                "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea",
                "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia",
                "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya",
                "Kiribati", "Korea, North", "Korea, South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia",
                "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar",
                "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius",
                "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique",
                "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger",
                "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama",
                "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania",
                "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines",
                "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles",
                "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa",
                "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan",
                "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago",
                "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates",
                "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela",
                "Vietnam", "Yemen", "Zambia", "Zimbabwe"
            };

            availableCountriesSet = new HashSet<string>(availableCountries);
            listBoxAvailableCountries.DataSource = availableCountries;
        }

        private void btnAddToWhiteList_Click(object sender, EventArgs e)
        {
            // Agregar país seleccionado a la whitelist
            string selectedCountry = listBoxAvailableCountries.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCountry) && !whiteListCountries.Contains(selectedCountry))
            {
                whiteListCountries.Add(selectedCountry);
                UpdateWhiteListCountriesListBox();

                // Actualizar el conjunto de países disponibles y las listas
                availableCountriesSet.Remove(selectedCountry);
                UpdateAvailableCountriesListBox();

                // Guardar cambios en la configuración
                SaveConfigChanges();
            }
        }

        private void btnRemoveFromWhiteList_Click(object sender, EventArgs e)
        {
            // Remover país seleccionado de la whitelist
            string selectedCountry = listBoxWhiteListCountries.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedCountry))
            {
                whiteListCountries.Remove(selectedCountry);
                UpdateWhiteListCountriesListBox();

                // Actualizar el conjunto de países disponibles y las listas
                availableCountriesSet.Add(selectedCountry);
                UpdateAvailableCountriesListBox();

                // Guardar cambios en la configuración
                SaveConfigChanges();
            }
        }

        private void SaveConfigChanges()
        {
            ConfigLoader.AppConfig config = ConfigLoader.LoadConfig();
            config.WhiteListCountries = whiteListCountries;
            ConfigLoader.SaveConfig(config);
        }

        private void UpdateAvailableCountriesListBox()
        {
            listBoxAvailableCountries.DataSource = new List<string>(availableCountriesSet);
        }

        private void UpdateWhiteListCountriesListBox()
        {
            // Actualizar la segunda ListBox con los países en la whitelist
            listBoxWhiteListCountries.DataSource = new List<string>(whiteListCountries);
        }

        public static string GetCountryForIP(string ipAddress)
        {
            using (DatabaseReader reader = new DatabaseReader("database.mmdb"))
            {
                try
                {
                    MaxMind.GeoIP2.Responses.CountryResponse response = reader.Country(ipAddress);
                    return response.Country.Name;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el país para la IP {ipAddress}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Desconocido"; // Puedes manejar el error según tus necesidades específicas
                }
            }
        }

    }
}
