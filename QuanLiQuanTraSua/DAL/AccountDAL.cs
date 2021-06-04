using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.DAO
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance
        {
            get { if (instance == null) instance = new AccountDAL(); return instance; }
            private set { instance = value; }
        }
        private AccountDAL() { }

        public bool login(string username, string password)
        {
            string query = "USP_login @userName , @passWord";
            DataTable result = Dataprovider.Instance.ExecuteQuery(query, new object[] { username, password });
            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = Dataprovider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName, displayName, pass, newPass });

            return result > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = Dataprovider.Instance.ExecuteQuery("Select * from account where userName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public DataTable ListAccountByUserName(string username)
        {
            string query = string.Format("Select *from dbo.accountinfo where username=N'{0}'", username);
            return Dataprovider.Instance.ExecuteQuery(query);
        }

        public DataTable GetListAcc()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from account ");
        }

        public DataTable GetListAdmin()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from account where type=1 ");
        }
        public DataTable GetListNhanVien()
        {
            return Dataprovider.Instance.ExecuteQuery("select * from account where type=0 ");
        }



        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, tenhienthi, Type )VALUES  ( N'{0}', N'{1}', {2})", name, displayName, type);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public bool AddAccount(string name, string displayName , string password)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, tenhienthi, password, Type )VALUES  ( N'{0}', N'{1}', N'{2}',{3})", name, displayName,password,1);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable GetListAccount()
        {
            return Dataprovider.Instance.ExecuteQuery("SELECT UserName, tenhienthi, password, Type FROM dbo.Account");
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("update account set password = N'0' where UserName = N'{0}'", name);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateAccountInfo(string username, int socmnd, string hovaten, string gioitinh, string sodt, string ngaysinh, string email, string quequan, string tennguoithan, string sodtnguoithan, string noiohientai)
        {
            string query = string.Format("Update dbo.accountinfo set socmnd = {0} , hovaten = N'{1}' , gioitinh = N'{2}' , sodt = N'{3}' , ngaysinh = N'{4}' , email = N'{5}' , quequan = N'{6}' , tennguoithan = N'{7}' , sodtnguoithan = N'{8}' , noiohientai = N'{9}' where username = N'{10}'", socmnd, hovaten, gioitinh, sodt, ngaysinh, email, quequan, tennguoithan, sodtnguoithan, noiohientai, username);
            int result = Dataprovider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
