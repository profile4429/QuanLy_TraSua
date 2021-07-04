using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DAL
{
    public class AccountInfoDAL
    {
        private static AccountInfoDAL instance;

        public static AccountInfoDAL Instance
        {
            get { if (instance == null) instance = new AccountInfoDAL(); return AccountInfoDAL.instance; }

            set { instance = value; }
        }
        public DataTable GetAccountInfoByUserName(string username)
        {
            string query = string.Format("Select *from dbo.accountinfo where username=N'{0}'",username);
           return Dataprovider.Instance.ExecuteQuery(query);
        }
        public bool InsertAccountInfo(string name)
        {
            string query = string.Format("INSERT dbo.accountinfo (username) VALUES (N'{0}')",name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
