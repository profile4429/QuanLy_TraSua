using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using QuanLiQuanTraSua.DTO;
using System.Threading;
using QuanLiQuanTraSua.Forms;

namespace QuanLiQuanTraSua
{
    public partial class FormMainMenu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private Action<object, EventArgs> A_InsertFood;
        private Action<object, EventArgs> A_DeleteFood;
        private Action<object, EventArgs> A_UpdateFood;
      


        public Action<object, EventArgs> InsertFood { get; private set; }
        public Action<object, EventArgs> DeleteFood { get; private set; }
        public Action<object, EventArgs> UpdateFood { get; private set; }


        //Constructor
        private Account loginAccount;
       

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }


        public Action<object, AccountEvent> UpdateAccount { get; private set; }

        void ChangeAccount(int type)
        {
            btnProducts.Enabled = type == 1;
            iconButtonAdmin.Enabled = type == 1;
            iconButtonGiaHanPhanMem.Enabled = type == 1;
            labelHienThi.Text = LoginAccount.DisplayName;
        }
        public FormMainMenu(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            this.WindowState = FormWindowState.Maximized;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);

        }

        //Methods
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                //currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.BackColor = Color.Transparent;



                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Current Child Form Icon
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {

                //currentBtn.BackColor = Color.FromArgb(31, 30, 90);
                currentBtn.BackColor = Color.Transparent;


                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChildForm.Text = "Home";
        }

        //Events
        //Reset
        private void btnHome_Click_2(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();

        }
        //Menu Button_Clicks
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.FormTongQuan());
        }
       
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormMenu());
            InsertFood += A_InsertFood;
            DeleteFood += A_DeleteFood;
            UpdateFood += A_UpdateFood;
        }
       

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormChiSo());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormThongTinCaNhan(LoginAccount));
           
            UpdateAccount += f_UpdateAccount;
            
        }
        void f_UpdateAccount(object sender, AccountEvent e)
        {
            labelHienThi.Text = e.Acc.DisplayName;
           
        }

        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormThongKe());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenChildForm(new Forms.FormCaiDat());
        }
        private void iconButtonAdmin_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new Forms.FormAdmin(/*LoginAccount*/));
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new Forms.FormLienHe());

        }
        private void iconButtonGiaHanPhanMem_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.FormGiaHanPhanMem());
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new Forms.FormHuongDanSuDung());
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

            

        //Close-Maximize-Minimize

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

       
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();

            CultureInfo culture = new CultureInfo("en-US");
            //string cultureName = "vi-VN";
            //Thread.CurrentThread.CurrentCulture = new CultureInfo(cultureName);

            labelDayofWeek.Text = DateTime.Now.DayOfWeek.ToString(culture) + ", " + " " + DateTime.Now.ToString("M" , culture) + ", "+ DateTime.Now.Year.ToString(culture);
            //CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month.ToString())



            btnTongQuan.FlatAppearance.MouseOverBackColor = Color.FromArgb(30,30,90);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            btnProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            btnThongTinCaNhan.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            btnThongKe.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            iconButtonAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            btnSetting.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
          
            iconButton3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);
            iconButtonGiaHanPhanMem.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 90);



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

  
    }
}
