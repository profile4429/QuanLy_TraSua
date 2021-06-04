using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DTO
{
    public class BillInfo
    {
        public BillInfo(int billID, int foodID, int id, int count)
        {

            this.BillID = billID;
            this.FoodID = foodID;
            this.ID = id;
            this.Count = count;
        }
        public BillInfo(DataRow Row)
        {

            this.BillID = (int)Row["idbill"];
            this.FoodID = (int)Row["idfood"];
            this.ID = (int)Row["id"];
            this.Count = (int)Row["soluong"];

        }

        private int count;
        private int foodID;
        private int billID;
        private int iD;
        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }
    }
}
