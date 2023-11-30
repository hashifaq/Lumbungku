using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http;

namespace WFA_Lumbungku
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            getHargaProduk();
            getWeatherData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HargaPasar hargaPasar = new HargaPasar();
            hargaPasar.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SchedulePage schedulePage = new SchedulePage();
            schedulePage.Show();
            Hide();
        }

        private async void getWeatherData()
        {
            try
            {
                var weather = new WeatherData();
                string weatherJson = await weather.getWeather();
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(weatherJson);

                labelLastUpdate.Text = weatherData.Current.Last_Updated;
                labelTemp.Text = weatherData.Current.Temp_C.ToString() + "°C";
                labelCondition.Text = weatherData.Current.Condition.Text;
                labelWind.Text = "Wind: " + weatherData.Current.Wind_Mph.ToString();
                labelHumidity.Text = "Humidity: " + weatherData.Current.Humidity.ToString() + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void getHargaProduk()
        {
            try
            {
                var foodPrice = new FoodPrice();
                // Mendapatkan harga dari API
                var json = await foodPrice.getFoodPriceFromAPI();

                // Deserialisasi JSON ke dalam list objek KomoditasData
                List<KomoditasData> prices = JsonConvert.DeserializeObject<List<KomoditasData>>(json);

                // Mendapatkan bulan saat ini
                string currentMonth = DateTime.Now.ToString("MMMM");

                // Iterasi melalui semua komoditas
                foreach (var price in prices)
                {
                    // Mendapatkan nilai komoditas
                    string komoditas = price.Komoditas;

                    // Mendapatkan nilai untuk bulan saat ini
                    // int nilaiBulanIni = Convert.ToInt32(price.GetType().GetProperty(currentMonth).GetValue(price, null));
                    int nilaiBulanIni = Convert.ToInt32(price.GetType().GetProperty("November").GetValue(price, null));

                    if (komoditas == "Beras Medium Penggilingan")
                    {
                        labelBM.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                    else if (komoditas == "Beras Premium Penggilingan")
                    {
                        labelBP.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                    else if (komoditas == "Jagung Pipilan Kering")
                    {
                        labelJagung.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                    else if (komoditas == "Kedelai Biji Kering (Lokal)")
                    {
                        labelKedelai.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                    else if (komoditas == "Bawang Merah")
                    {
                        labelBawMer.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                    else if (komoditas == "Cabai Merah Keriting")
                    {
                        labelCMK.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
