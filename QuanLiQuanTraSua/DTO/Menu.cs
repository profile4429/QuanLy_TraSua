using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DTO
{
    public class Menu
    {
        public Menu(string foodName, int count, float price, float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.FoodName = foodName;

        }
        public Menu(DataRow row)
        {
            this.FoodName = row["Name"].ToString();
            this.Count = (int)row["soluong"];
            this.Price = (float)Convert.ToDouble(row["gia"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;
        private float price;
        private int count;
        private string foodName;

        public string FoodName { get { return foodName; } set { foodName = value; } }
        public int Count { get { return count; } set { count = value; } }

        public float TotalPrice { get { return totalPrice; } set { totalPrice = value; } }
        public float Price { get { return price; } set { price = value; } }
    }

}
