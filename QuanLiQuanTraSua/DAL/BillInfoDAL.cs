using QuanLiQuanTraSua.DAO;
using QuanLiTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DAO
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance
        {
            get { if (instance == null) instance = new BillInfoDAL(); return BillInfoDAL.instance; }
            private set { BillInfoDAL.instance = value; }
        }
        private BillInfoDAL() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from billinfo where idbill = " + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }


            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            Dataprovider.Instance.ExecuteNonQuery("USP_InserBillInfo @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        }
        public void DeleteBillInfoByFoodID(int id)
        {

            string query = string.Format("Delete BillInfo where idFood = {0}", id);
            Dataprovider.Instance.ExecuteQuery(query);
        }
    }
}
