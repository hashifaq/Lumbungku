using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Lumbungku
{
    internal class FoodPrice
    {
        static string DataSetUrl = "https://sementarabelumtahu";
        internal struct DataFood
        {
            int item_id;
            string name;
            int price;
            string unit;
            DateTime date;
        }
        public FoodPrice()
        {
            getFoodPrice();
        }
        public void getFoodPrice()
        {
            
        }
    }
}

