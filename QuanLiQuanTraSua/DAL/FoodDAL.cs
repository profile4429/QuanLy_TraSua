using QuanLiQuanTraSua.DTO;
using QuanLiTraSua.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAO
{
    public class FoodDAL
    {
        private static FoodDAL instance;
        public static int FoodWidth = 335;
        public static int FoodHeight = 50;
        public static FoodDAL Instance
        {
            get { if (instance == null) instance = new FoodDAL(); return FoodDAL.instance; }
            private set { FoodDAL.instance = value; }
        }

        private FoodDAL() { }

        public List<Food> GetFoodByCategoryID(int id)
        {
            List<Food> list = new List<Food>();

            string query = "select * from Food where idtheloai = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }

            return list;
        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();

            //string query = "select f.id , f.name from food as f";
            string query = "select f.id , f.name , f.gia , fc.name  ,f.idtheloai from.dbo.food as f , dbo.foodcategory as fc where f.idtheloai = fc.id";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);


            }

            return list;
        }

        public DataTable GetList()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from food ");
        }
        public List<Food> GetListTraSua()
        {
            List<Food> list = new List<Food>();

            //string query = "select id as [ID] , name as [Tên Nước Uống] , gia as [Giá] , idtheloai as [Loại Nước Uống]  from food";
            string query = "select * from food where idtheloai='6' ";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }

        public List<Food> GetListCaPhe()
        {
            List<Food> list = new List<Food>();

            string query = "select * from food where idtheloai='7' ";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListNuocEp()
        {
            List<Food> list = new List<Food>();
            string query = "select * from food where idtheloai='8' ";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> GetListMonThem()
        {
            List<Food> list = new List<Food>();
            string query = "select * from food where idtheloai='9' ";

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name, int id, float price)
        {
            string query = string.Format("INSERT dbo.Food ( name, idtheloai, gia )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int id, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idtheloai= {1}, gia = {2} WHERE id = {3}", name, id, price, idFood);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAL.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete Food where id = {0}", idFood);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

       

    }
}
