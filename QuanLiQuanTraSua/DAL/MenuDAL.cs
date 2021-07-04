using QuanLiQuanTraSua.DAO;
using QuanLiTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DAO
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance
        {
            get { if (instance == null) instance = new MenuDAL(); return MenuDAL.instance; }
            private set { MenuDAL.instance = value; }
        }
        private MenuDAL() { }
        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select f.name , bi.soluong , f.gia ,f.gia*bi.soluong as totalPrice from dbo.billinfo as bi , dbo.bill as b , dbo.food as f where bi.idbill = b.id and bi.idfood = f.id and b.trangthai=0 and b.idTable = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
        public List<Menu> GetListMenuByFood(int id)
        {
            List<Menu> listMenu = new List<Menu>();

            string query = "select f.name , bi.soluong , f.gia ,f.gia*bi.soluong as totalPrice from dbo.billinfo as bi , dbo.bill as b , dbo.food as f where bi.idbill = b.id and bi.idfood = f.id and b.trangthai=0 and f.idTable = " + id;

            DataTable data = Dataprovider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listMenu.Add(menu);
            }
            return listMenu;
        }
    }
}
