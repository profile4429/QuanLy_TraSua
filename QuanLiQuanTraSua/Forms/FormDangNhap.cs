using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
           
        }
        private void ButtonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn Có Thật Sự Muốn Thoát ?", " Thông Báo ", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false;
            }
        }

        private void textBox1_Enter(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBoxDangNhap.Text))
            {
                textBoxDangNhap.SelectionStart = 0;
                textBoxDangNhap.SelectionLength = textBoxDangNhap.Text.Length;
                textBoxMatKhau.SelectionLength = textBoxMatKhau.Text.Length;
            }
        }

        private void ButtonDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBoxDangNhap.Text;
            string password = textBoxMatKhau.Text;
            if (Login(username, password))
            {
                Account loginAccount = AccountDAL.Instance.GetAccountByUserName(username);
                FormMainMenu f = new FormMainMenu(loginAccount);
                this.Hide();
                f.ShowDialog();
                //this.Show();
            }
            else
            {
                labelTrangThai.Text = "Sai Tên Đăng Nhập Hoặc Mật Khẩu . Vui Lòng Kiểm Tra Lại";
            }


        }
        bool Login(string username, string password)
        {
            return AccountDAL.Instance.login(username, password);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FormDangKyTaiKhoan f = new FormDangKyTaiKhoan();
            f.ShowDialog();
        }
    }
}
