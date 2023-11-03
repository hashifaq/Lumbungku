using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;s
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Lumbungku
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        private NpgsqlConnection conn;
        string connstring = "Host=rain.db.elephantsql.com;Port=5432;Username=xlkrufuv;Password=QetnzAz_gisckBoMl6z4CRuwpKpYPLY2;Database=xlkrufuv";
        public static NpgsqlCommand cmd;
        public DataTable dt;
        private string sql = null;
        private DataGridViewRow r;

        private void Inventory_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvBarang.DataSource = null;    

                sql = "SELECT * FROM public.product";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                dgvBarang.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"INSERT INTO public.product (user_id, name, quantity, unit, type, photo)
                        VALUES (:_user_id, :_name, :_quantity, :_unit, :_type, :_photo);";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_user_id", 1);
                cmd.Parameters.AddWithValue("_name", tbNama.Text);
                if (int.TryParse(tbStok.Text, out int quantity))
                {
                    cmd.Parameters.AddWithValue("_quantity", quantity);
                }
                else
                {
                    throw new ArgumentException("Invalid quantity value.");
                }
                cmd.Parameters.AddWithValue("_unit", tbUnit.Text);
                cmd.Parameters.AddWithValue("_type", tbTipe.Text);
                cmd.Parameters.AddWithValue("_photo", pictureBoxFoto.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil disimpan: ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    btnReadHasil.PerformClick();
                    tbNama.Text = tbStok.Text = tbTipe.Text = tbUnit.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Insert Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                r = dgvBarang.Rows[e.RowIndex];
                tbNama.Text = r.Cells["name"].Value.ToString();
                tbStok.Text = r.Cells["quantity"].Value.ToString();
                tbUnit.Text = r.Cells["unit"].Value.ToString();
                tbTipe.Text = r.Cells["type"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan diupdate", "Good!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();
                sql = "SELECT * FROM update_product(product_id, name , quantity, unit, type)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("product_id", r.Cells["product_id"].Value.ToString());
                cmd.Parameters.AddWithValue("name", tbNama.Text);
                cmd.Parameters.AddWithValue("quantity", tbStok.Text);
                cmd.Parameters.AddWithValue("unit", tbUnit.Text);
                cmd.Parameters.AddWithValue("type", tbUnit.Text);
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diupdate: ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    tbNama.Text = tbStok.Text = tbTipe.Text = tbUnit.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Mohon pilih baris data yang akan dihapus", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Apakah benar Anda ingin menghapus data "+r.Cells["name"].Value.ToString()+" ?", "Hapus data terkonfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    sql = "SELECT * FROM delete_product(product_id)";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("product_id", r.Cells["product_id"].Value.ToString());
                    if ((int)cmd.ExecuteScalar() == 1)
                    {
                        MessageBox.Show("Data berhasil dihapus: ", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        tbNama.Text = tbStok.Text = tbTipe.Text = tbUnit.Text = null;
                        r = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReadHasil_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvBarang.DataSource = null;

                sql = "SELECT * FROM select_products_by_type('hasil');";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                dgvBarang.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadBibit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvBarang.DataSource = null;

                sql = "SELECT * FROM select_products_by_type('bibit');";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                dgvBarang.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadAlat_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                dgvBarang.DataSource = null;

                sql = "SELECT * FROM select_products_by_type('alat');";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                dgvBarang.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchByName(string name)
        {
            try
            {
                conn.Open();
                dgvBarang.DataSource = null;

                sql = "SELECT * FROM public.product WHERE name ILIKE @name";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("name", "%" + name + "%"); // Use ILIKE for case-insensitive search
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);

                dgvBarang.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnFind_Click(object sender, EventArgs e)
        {
            string nameToSearch = tbSearch.Text;
            SearchByName(nameToSearch);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                pictureBoxFoto.Text = selectedFilePath;
            }
        }
    }
}
