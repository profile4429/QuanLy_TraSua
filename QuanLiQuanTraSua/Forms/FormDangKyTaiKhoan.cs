using QuanLiQuanTraSua.DAL;
using QuanLiQuanTraSua.DAO;
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
    public partial class FormDangKyTaiKhoan : Form
    {
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormDangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
        void AddAccount(string userName, string displayName , string matkhau)
        {
            //string tendangnhap = bunifuTextBoxTenDangNhap.Text;
            if (string.IsNullOrEmpty(bunifuTextBoxTenDangNhap.Text) || string.IsNullOrEmpty(bunifuTextBoxHoVaTen.Text) || string.IsNullOrEmpty(bunifuTextBoxMatKhau.Text) || string.IsNullOrEmpty(bunifuTextBoxReMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            DataTable data = AccountDAL.Instance.ListAccountByUserName(userName);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                return;
            }
            if (AccountDAL.Instance.AddAccount(userName, displayName,matkhau) && AccountInfoDAL.Instance.InsertAccountInfo(userName))
            {
                MessageBox.Show("Đăng ký tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Đăng Ký tài khoản thất bại");
            }


        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
         
          
            if (bunifuTextBoxMatKhau.Text != bunifuTextBoxReMatKhau.Text)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Mật Khẩu");
                return;
            }
            else
            {
                string username = bunifuTextBoxTenDangNhap.Text;
                string hovaten = bunifuTextBoxHoVaTen.Text;
                string matkhau = bunifuTextBoxMatKhau.Text;
                AddAccount(username, hovaten, matkhau);
            }
        }
    }
}
