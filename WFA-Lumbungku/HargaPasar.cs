using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WFA_Lumbungku
{
    public partial class HargaPasar : Form
    {
        public HargaPasar()
        {
            InitializeComponent();
            getHargaProduk();
            labelUpdate.Text = "Terakhir diupdate " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
        }
        private async void getHargaProduk()
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
                int nilaiBulanIni = Convert.ToInt32(price.GetType().GetProperty(currentMonth).GetValue(price, null));

                if (komoditas == "GKP Tingkat Petani")
                {
                    labelGKPTP.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
                else if (komoditas == "GKP Tingkat Penggilingan")
                {
                    labelGKPPeng.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
                else if (komoditas == "GKG Tingkat Penggilingan")
                {
                    labelGKGPeng.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
                else if (komoditas == "Beras Medium Penggilingan")
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
                else if (komoditas == "Cabai Rawit Merah")
                {
                    labelCRM.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
                else if (komoditas == "Ayam Ras Pedaging (Hidup)")
                {
                    labelARP.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
                else if (komoditas == "Telur Ayam Ras")
                {
                    labelTAR.Text = "Rp." + nilaiBulanIni.ToString() + "/kg";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
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
    }
    public class KomoditasData
    {
        public string Komoditas { get; set; }
        public string Tahun { get; set; }
        public int Januari { get; set; }
        public int Februari { get; set; }
        public int Maret { get; set; }
        public int April { get; set; }
        public int Mei { get; set; }
        public int Juni { get; set; }
        public int Juli { get; set; }
        public int Agustus { get; set; }
        public int September { get; set; }
        public int Oktober { get; set; }
        public int November { get; set; }
        public int Desember { get; set; }
    }
}
