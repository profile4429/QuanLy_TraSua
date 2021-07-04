using QuanLiQuanTraSua.DAL;
using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormHoSoCaNhan : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        void ChangeAccount(Account acc)

        {
            textBoxTenDagNhap.Text = LoginAccount.UserName;

        }
        public FormHoSoCaNhan(Account acc)
        {

           
            InitializeComponent();
            LoginAccount = acc;

            LoadAccountInfoByUserName();

        }

        public FormHoSoCaNhan()
        {
        }

        public void LoadAccountInfoByUserName()

        {
            DataTable data = AccountInfoDAL.Instance.GetAccountInfoByUserName(textBoxTenDagNhap.Text);
            //textBoxSoCmnd.DataBindings.Add("Text",data,"socmnd");
            //textBoxHoVaTen.DataBindings.Add("Text", data, "hovaten");
            //textBoxGioiTinh.DataBindings.Add("Text", data, "gioitinh");
            //textBoxSoDt.DataBindings.Add("Text", data, "sodt");
            //textBoxNgaySinh.DataBindings.Add("Text", data, "ngaysinh");
            //textBoxEmail.DataBindings.Add("Text", data, "email");
            //textBoxQueQuan.DataBindings.Add("Text", data, "quequan");
            //textBoxTenNguoiThan.DataBindings.Add("Text", data, "tennguoithan");
            //textBoxSoDtThan.DataBindings.Add("Text", data, "Sodtnguoithan");
            //textBoxNoioHienTai.DataBindings.Add("Text", data, "noiohientai");
            textBoxSoCmnd.Text = data.Rows[0]["socmnd"].ToString();
            textBoxHoVaTen.Text = data.Rows[0]["hovaten"].ToString();
            textBoxGioiTinh.Text = data.Rows[0]["gioitinh"].ToString();
            textBoxSoDt.Text = data.Rows[0]["sodt"].ToString();
            textBoxNgaySinh.Text = data.Rows[0]["ngaysinh"].ToString();
            textBoxEmail.Text = data.Rows[0]["email"].ToString();
            textBoxQueQuan.Text = data.Rows[0]["quequan"].ToString();
            textBoxTenNguoiThan.Text = data.Rows[0]["tennguoithan"].ToString();
            textBoxSoDtThan.Text = data.Rows[0]["sodtnguoithan"].ToString();
            textBoxNoioHienTai.Text = data.Rows[0]["noiohientai"].ToString();

        }
        void UpdateAccount(string username, int socmnd, string hovaten, string gioitinh, string sodt, string ngaysinh, string email, string quequan, string tennguoithan, string sodtnguoithan, string noiohientai)
        {

            if (AccountDAL.Instance.UpdateAccountInfo(username, socmnd, hovaten, gioitinh, sodt, ngaysinh, email, quequan, tennguoithan, sodtnguoithan, noiohientai))
            {
      

                MessageBox.Show("Cập nhật hồ sơ thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật hồ sơ thất bại");
            }
        }
 

        private void button2_Click(object sender, EventArgs e)
        {

            string username = textBoxTenDagNhap.Text;
            int socmnd = int.Parse(textBoxSoCmnd.Text);
            string hovaten = textBoxHoVaTen.Text;
            string gioitinh = textBoxGioiTinh.Text;
            string sodt = textBoxSoDt.Text;
            string ngaysinh = textBoxNgaySinh.Text;
            string email = textBoxEmail.Text;
            string quequan = textBoxQueQuan.Text;
            string tennguoithan = textBoxTenNguoiThan.Text;
            string sodtnguoithan = textBoxSoDtThan.Text;
            string noiohientai = textBoxNoioHienTai.Text;

            UpdateAccount(username,socmnd, hovaten, gioitinh, sodt, ngaysinh, email, quequan, tennguoithan, sodtnguoithan, noiohientai);

        }
    }
}
