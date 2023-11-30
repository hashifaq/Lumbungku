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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
    }
}
