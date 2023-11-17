using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Lumbungku
{
    public partial class SchedulePage : Form
    {
        public SchedulePage()
        {
            InitializeComponent();
        }

        private void SchedulePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
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
    }
}
