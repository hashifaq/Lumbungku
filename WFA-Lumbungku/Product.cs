using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WFA_Lumbungku
{
    internal class Product
    {
        private int _id;
        private string _name;
        private int _quantity;
        private string _unit;
        private string _type;
        private Stream _photo;

        private NpgsqlConnection conn;
        private string connstring = "Host=rain.db.elephantsql.com;Port=5432;Username=xlkrufuv;Password=QetnzAz_gisckBoMl6z4CRuwpKpYPLY2;Database=xlkrufuv";
        private static NpgsqlCommand cmd;
        private string sql = null;

        // Encapsulation
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public Stream Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public static List<Product> GetAllProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }

        // Metode untuk mendapatkan produk berdasarkan ID
        public static Product GetAllProducts(List<Product> products, int id)
        {
            throw new NotImplementedException();
        }

        // Metode untuk mendapatkan produk berdasarkan kategori
        public static Product GetProductByCategory(List<Product> products, string _type)
        {
            throw new NotImplementedException();
        }

        // Metode untuk membuat produk baru
        public static void CreateProduct(List<Product> products, Product product)
        {
            throw new NotImplementedException();
        }

        // Metode untuk mengupdate produk
        public static void UpdateProduct(List<Product> products, int id, Product updatedProduct)
        {
            throw new NotImplementedException();
        }

        // Metode untuk menghapus produk berdasarkan ID
        public static void DeleteProduct(List<Product> products, int id)
        {
            throw new NotImplementedException();
        }

        // Metode untuk menambah persediaan produk
        public void Restock(int quantityToAdd, int id)
        {
            throw new NotImplementedException();
        }
    }
}
