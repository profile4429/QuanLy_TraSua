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
    public partial class FormThongTinCaNhan : Form
    {
        public string _textBoxTenHienThi1 { get { return textBoxTenHienThi1.Text; } }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public FormThongTinCaNhan(Account acc)
        {
            InitializeComponent();
            OpenChildForm(new Forms.FormHoSoCaNhan(acc));
            LoginAccount = acc; 
        }
        private void OpenChildForm(Form childForm)
        {
          
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelHoSoCaNhan.Controls.Add(childForm);
            panelHoSoCaNhan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
           
        }
        void ChangeAccount(Account acc)
        {
            TextBoxDangNhap1.Text = LoginAccount.UserName;
            textBoxTenHienThi1.Text = LoginAccount.DisplayName;
        }
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        void UpdateAccountInfo()
        {
            string displayName = textBoxTenHienThi1.Text;
            string password = textBox1.Text;
            string newpass = textBox2.Text;
            string reenterPass = textBox3.Text;
            string userName = TextBoxDangNhap1.Text;
            if (string.IsNullOrEmpty(textBoxTenHienThi1.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (!newpass.Equals(reenterPass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAL.Instance.UpdateAccount(userName, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    updateAccount?.Invoke(this, new AccountEvent(AccountDAL.Instance.GetAccountByUserName(userName)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }

    }
}
