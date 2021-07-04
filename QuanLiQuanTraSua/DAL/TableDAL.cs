using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAO
{
    public class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance
        {
            get { if (instance == null) instance = new TableDAL(); return TableDAL.instance; }

            private set { TableDAL.instance = value; }
        }
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private TableDAL() { }
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();
            DataTable data = Dataprovider.Instance.ExecuteQuery("dbo.USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public void ChuyenBan(int Table1, int Table2)
        {
            Dataprovider.Instance.ExecuteQuery("USP_Switchtable @idtable1 , @idtable2", new object[] { Table1, Table2 });
        }
        public void InsertTable()
        {
            Dataprovider.Instance.ExecuteQuery("USP_InsertTable");
        }
        public void DeleteTable()
        {
            Dataprovider.Instance.ExecuteQuery("USP_DeleteTable");
        }
        public DataTable GetListTable()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from tablefood ");
        }
    }
}
