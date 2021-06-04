using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using QuanLiTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiTraSua.DAO
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance

        {
            get { if (instance == null) instance = new BillDAL(); return BillDAL.instance; }
            private set { BillDAL.instance = value; }
        }

        private BillDAL() { }
        public int GetUnCheckBillIDByTableID(int id)
        {

            DataTable data = Dataprovider.Instance.ExecuteQuery("select * from dbo.bill where idTable = " + id + " and trangthai = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            Dataprovider.Instance.ExecuteNonQuery("exec USP_InserBill @idTable", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)Dataprovider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET ngayra = GETDATE(), trangthai = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            Dataprovider.Instance.ExecuteNonQuery(query);
        }
        public void DropBill(int id, int discount, float totalPrice)
        {
            string query = "UPDATE dbo.Bill SET ngayra = GETDATE(), trangthai = 1, " + "discount = " + discount + ", totalPrice = " + totalPrice + " WHERE id = " + id;
            Dataprovider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetBillListByDate(DateTime checkIn, DateTime checkOut)
        {
            return Dataprovider.Instance.ExecuteQuery("exec USP_GetListBillByDate @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable GetListBill(DateTime checkIn, DateTime checkOut)
        {
            return Dataprovider.Instance.ExecuteQuery("exec USP_TongTien @checkIn , @checkOut", new object[] { checkIn, checkOut });
        }
        public DataTable GetList()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from bill ");
        }

    }
}

