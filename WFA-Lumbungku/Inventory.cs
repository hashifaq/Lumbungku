using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Lumbungku
{
    public partial class Inventory : Form
    {
        private const string ConnectionString = "Host=rain.db.elephantsql.com;Port=5432;Username=xlkrufuv;Password=QetnzAz_gisckBoMl6z4CRuwpKpYPLY2;Database=xlkrufuv";
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private DataTable dataTable;

        public Inventory()
        {
            InitializeComponent();
            conn = new NpgsqlConnection(ConnectionString);
            dataTable = new DataTable();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // Load data initially
            LoadData();
            tbTipe.Items.AddRange(new object[] { "Bibit", "Peralatan", "Hasil" });
            // You can set a default value if needed
            tbTipe.SelectedItem = "Bibit";
        }

        private void LoadData()
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM product";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn))
                {
                    dataTable.Clear();
                    da.Fill(dataTable);
                    dgvBarang.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Data Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void ClearFields()
        {
            tbNama.Text = tbStok.Text = tbUnit.Text = tbTipe.Text = tbSearch.Text = string.Empty;
            pictureBoxFoto.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO product (user_id, name, quantity, unit, type, photo) VALUES (@user_id, @name, @quantity, @unit, @type, @photo)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("user_id", 1); // Replace with the actual user_id
                cmd.Parameters.AddWithValue("name", tbNama.Text);
                cmd.Parameters.AddWithValue("quantity", Convert.ToInt32(tbStok.Text));
                cmd.Parameters.AddWithValue("unit", tbUnit.Text);
                cmd.Parameters.AddWithValue("type", tbTipe.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("photo", "path_to_photo"); // Replace with the actual path or URL

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data added successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to add data", "Add Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBarang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBarang.SelectedRows[0];

                try
                {
                    conn.Open();
                    string sql = "UPDATE product SET name = @name, quantity = @quantity, unit = @unit, type = @type, photo = @photo WHERE product_id = @product_id";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("product_id", Convert.ToInt32(selectedRow.Cells["product_id"].Value));
                    cmd.Parameters.AddWithValue("name", tbNama.Text);
                    cmd.Parameters.AddWithValue("quantity", Convert.ToInt32(tbStok.Text));
                    cmd.Parameters.AddWithValue("unit", tbUnit.Text);
                    cmd.Parameters.AddWithValue("type", tbTipe.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("photo", "path_to_photo"); // Replace with the actual path or URL

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data", "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update", "Update Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBarang.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBarang.SelectedRows[0];

                if (MessageBox.Show($"Are you sure you want to delete {selectedRow.Cells["name"].Value.ToString()}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string sql = "DELETE FROM product WHERE product_id = @product_id";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("product_id", Convert.ToInt32(selectedRow.Cells["product_id"].Value));

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFields();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete data", "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Delete Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReadHasil_Click(object sender, EventArgs e)
        {
            // Read data with type 'Hasil'
            FilterDataByType("Hasil");
        }

        private void btnReadBibit_Click(object sender, EventArgs e)
        {
            // Read data with type 'Bibit'
            FilterDataByType("Bibit");
        }

        private void btnReadAlat_Click(object sender, EventArgs e)
        {
            // Read data with type 'Peralatan'
            FilterDataByType("Peralatan");
        }

        private void FilterDataByType(string type)
        {
            try
            {
                conn.Open();
                string sql = "SELECT * FROM product WHERE type = @type";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("type", type);
                    dataTable.Clear();
                    da.Fill(dataTable);
                    dgvBarang.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Filter Data Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Load all data
            LoadData();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // Search data based on the provided text
            string searchText = tbSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a search term", "Search Fail!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                conn.Open();
                string sql = "SELECT * FROM product WHERE LOWER(name) LIKE @searchText OR LOWER(type) LIKE @searchText";
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn))
                {
                    da.SelectCommand.Parameters.AddWithValue("searchText", "%" + searchText + "%");
                    dataTable.Clear();
                    da.Fill(dataTable);
                    dgvBarang.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
        private DataGridViewRow r;

        private void dgvBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dgvBarang.Rows[e.RowIndex];
                tbNama.Text = r.Cells["name"].Value.ToString();
                tbStok.Text = r.Cells["quantity"].Value.ToString();
                tbUnit.Text = r.Cells["unit"].Value.ToString();
                tbTipe.Text = r.Cells["type"].Value.ToString();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            SchedulePage schedulePage = new SchedulePage();
            schedulePage.Show();
            Hide();
        }
    }
}
