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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadAccount();
    
        }
        public void LoadAccountInfoByUserName()

        {
            if (textBoxId.Text == "")
            {
                return;
            }

            DataTable data = AccountInfoDAL.Instance.GetAccountInfoByUserName(textBoxId.Text);
            if(data.Rows.Count < 1)
            {
                MessageBox.Show("Ten Tai Khoan Khong Ton Tai");
                return;
            }
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

        private void iconButtonXemThongTin_Click(object sender, EventArgs e)
        {
            LoadAccountInfoByUserName();

        }

        void LoadAccount()
        {
            dataGridViewMenu.DataSource = AccountDAL.Instance.GetListAccount();
            dataGridViewMenu.Columns[0].HeaderText = "Tên Đăng Nhập";
            dataGridViewMenu.Columns[1].HeaderText = "Tên Hiển Thị";
            dataGridViewMenu.Columns[2].HeaderText = "Mật Khẩu";
            dataGridViewMenu.Columns[3].HeaderText = "Quyền Quản Trị";
        }

        #region Thêm Xóa Khôi Phục 
        void AddAccount(string userName, string displayName, int type)
        {
            DataTable data = AccountDAL.Instance.ListAccountByUserName(userName);
            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Tên Tài Khoản Đã Tồn Tại");
                return;
            }
            if (textBoxId.Text == "")

            {
                MessageBox.Show("Vui Lòng Điền Đầy Đủ Thông Tin");
                return;
            }
            if (AccountDAL.Instance.InsertAccount(userName, displayName, type) && AccountInfoDAL.Instance.InsertAccountInfo(userName))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }
        void DeleteAccount(string userName)
        {

            if (AccountDAL.Instance.DeleteAccount(userName) /*&& AccountInfoDAL.Instance.DeleteAccountInfo(userName)*/)
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }
        void ResetPass(string userName)
        {
            if (AccountDAL.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        #endregion



        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;
            string displayName = textBoxTen.Text;
            int type = (int)numericUpDown1.Value;

            AddAccount(userName, displayName, type);
        }

        private void iconButtonHienThi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }


        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;

            DeleteAccount(userName);
        }

        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
                return;
            textBoxId.Text = dataGridViewMenu.Rows[numrow].Cells[0].Value.ToString();
            textBoxTen.Text = dataGridViewMenu.Rows[numrow].Cells[1].Value.ToString();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            string userName = textBoxId.Text;

            ResetPass(userName);
            LoadAccount();
        }
    }
}
