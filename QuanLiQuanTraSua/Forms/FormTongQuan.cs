using FontAwesome.Sharp;
using QuanLiQuanTraSua.DAO;
using QuanLiQuanTraSua.DTO;
using QuanLiTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{

    public partial class FormTongQuan : Form
    {

        public FormTongQuan()
        {
            InitializeComponent();
            LoadTable();
            LoadTableListByID(comboBoxChuyenBan);
            
        }
        public static int IDtable;
        public static string Tablename;



        public static double ThucDon;
        public static double TongCong;
        public static double GiamGia;
        #region Show Bill
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<QuanLiTraSua.DTO.Menu> listBillInfo = MenuDAL.Instance.GetListMenuByTable(id);
            float TongTien = 0;
            foreach (QuanLiTraSua.DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                TongTien += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txbTongTien.Text = TongTien.ToString("c", culture);
            textBoxThucDon.Text = TongTien.ToString("c", culture);

        }
        #endregion

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            Button btn = sender as Button;
            
            label6.Text = btn.Text.Substring(0,6);
            label61.Text = btn.Text.Substring(0,6);
            string[] str = btn.Text.Split(' ');
            if(str.Length >=4)
                //labelTrangThai.Text = btn.Text.Split(' ')[2] + btn.Text.Split(' ')[3];
                labelTrangThai.Text = str[2] + " " + str[3];
            else
                labelTrangThai.Text = str[2];

            ShowBill(tableID);

        }
        #region LoadTable
        void LoadTable()
        {
            fPanel.Controls.Clear();
            List<Table> tableList = TableDAL.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };
                btn.Text = item.Name + Environment.NewLine + " " + item.Trangthai;
                btn.Click += btn_Click;
                btn.Tag = item;
                switch (item.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.DodgerBlue;
                        btn.ForeColor = Color.White;
                        break;

                    default:
                        btn.BackColor = Color.Purple;
                        btn.ForeColor = Color.White;
                        break;
                }
                fPanel.Controls.Add(btn);
            }
        }
        #endregion


        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAL.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        void LoadTableListByID(ComboBox cb)
        {
            cb.DataSource = TableDAL.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }
        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategoryID(id);
        }


        #region hamkhoitao
        public void A_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }
        public void A_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
            LoadTable();
        }

         public void A_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
            if (lsvBill.Tag != null)
                ShowBill((lsvBill.Tag as Table).ID);
        }

        #endregion 
      

        #region Hiển Thị Món Ăn
        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadCategory();
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAL.Instance.GetListTraSua();
            bool flag = true;
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAL.FoodWidth, Height = FoodDAL.FoodHeight };
                btn.Text = item.Name;
                btn.ForeColor = Color.White;
                btn.Image = Image.FromFile("images/trasua.png");

                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.DeepPink;
                btn.Click += Btn_Click1;

                flowLayoutPanel.Controls.Add(btn);
                if (flag) btn.BackColor = Color.DarkRed; ;
                flag = false;
            }
            cbCategory.Text = "Trà Sữa";
        }
        private void iconButtonCaPhe_Click(object sender, EventArgs e)
        {
            LoadCategory();
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAL.Instance.GetListCaPhe();
            bool flag = true;
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAL.FoodWidth, Height = FoodDAL.FoodHeight };
                btn.Text = item.Name;
                btn.ForeColor = Color.White;
                btn.Image = Image.FromFile("images/caphe.png");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.DeepPink;
                btn.Click += Btn_Click1;

                flowLayoutPanel.Controls.Add(btn);
                if (flag) btn.BackColor = Color.DarkRed; ;
                flag = false;
            }
            cbCategory.Text = "Cà Phê";
        }

        private void iconButtonMonThem_Click(object sender, EventArgs e)
        {
            LoadCategory();
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAL.Instance.GetListMonThem();
            bool flag = true;
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAL.FoodWidth, Height = FoodDAL.FoodHeight };
                btn.Text = item.Name;
                btn.ForeColor = Color.White;
                btn.Image = Image.FromFile("images/them.png");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.DeepPink;
                btn.Click += Btn_Click1;
                flowLayoutPanel.Controls.Add(btn);
                if (flag) btn.BackColor = Color.DarkRed; ;
                flag = false;
            }
            cbCategory.Text = "Món Thêm";

        }

        private void iconButtonNuocEp_Click(object sender, EventArgs e)
        {
            LoadCategory();
            flowLayoutPanel.Controls.Clear();
            List<Food> foodList = FoodDAL.Instance.GetListNuocEp();
            bool flag = true;
            foreach (Food item in foodList)
            {
                Button btn = new Button() { Width = FoodDAL.FoodWidth, Height = FoodDAL.FoodHeight };
                btn.Text = item.Name;
                btn.ForeColor = Color.White;
                btn.Image = Image.FromFile("images/nuocep.png");
                btn.ImageAlign = ContentAlignment.MiddleLeft;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.DeepPink;
                btn.Click += Btn_Click1;
                if (flag) btn.BackColor = Color.DarkRed; ;
                flag = false;
                flowLayoutPanel.Controls.Add(btn);
            }
            cbCategory.Text = "Nước Ép Trái Cây";

        }

        #endregion

        private void Btn_Click1(object sender, EventArgs e)
        {
            foreach(Control con in flowLayoutPanel.Controls)
                {
                Button btn = con as Button;
                btn.BackColor = Color.DarkRed;
            }
            Button clickedBtn = sender as Button;
            clickedBtn.BackColor = Color.DeepPink;
            cbFood.Text = clickedBtn.Text;
            btnAddFood_Click(sender, e);
        }
        #region Thêm Món
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            labelTrangThai.Text = "Có Người";
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Cần Thêm");
                return;
            }
            if (cbCategory.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Loại Nước");
                return;
            }


            int idBill = BillDAL.Instance.GetUnCheckBillIDByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if (idBill == -1)
            {
                BillDAL.Instance.InsertBill(table.ID);
                BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxIDBill(), foodID, count);
            }

            else
            {
                BillInfoDAL.Instance.InsertBillInfo(idBill, foodID, count);
            }


            ShowBill(table.ID);
            LoadTable();

        }
        #endregion

        #region  Thanh Toán
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Cần Thanh Toán ");
                return;
            }

            int idBill = BillDAL.Instance.GetUnCheckBillIDByTableID(table.ID);
            int discount = (int)numericUpDownGiamGia.Value;
            double totalPrice = Convert.ToDouble(txbTongTien.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;
            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho bàn {0}\nTổng tiền - Giảm giá\n= {3}", table.Name, totalPrice, discount, finalTotalPrice), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAL.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }

            }
        }
        #endregion

        #region Hủy Hóa Đơn
        private void iconButton4_Click(object sender, EventArgs e)
        {
            //find
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Cần Hủy Hóa Đơn");
                return;
            }
            double finalTotalPrice = 0;
            int discount = (int)numericUpDownGiamGia.Value;
            int idBill = BillDAL.Instance.GetUnCheckBillIDByTableID(table.ID);

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có chắc hủy hóa đơn cho bàn {0}", table.Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAL.Instance.DropBill(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);

                    LoadTable();
                }
            }
        }
        #endregion


        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            TableDAL.Instance.InsertTable();
            LoadTable();
            LoadTableListByID(comboBoxChuyenBan);
        }
        #region Bớt Bàn
        private void iconButton3_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            if (table == null)
            {
                MessageBox.Show("Vui Lòng Chọn Bàn Trước Khi Xóa");
                return;
            }
            if (table.Trangthai == "Có Người")
            {
                MessageBox.Show("Không Thể Xóa Bàn Đang Có Người");
                return;
            }
            TableDAL.Instance.DeleteTable();
            LoadTableListByID(comboBoxChuyenBan);
            LoadTable();
        }
        #endregion

        #region Chuyển Bàn
        private void iconButtonChuyenBan_Click(object sender, EventArgs e)
        {
            int IDTable1 = (lsvBill.Tag as Table).ID;
            int IDTable2 = (comboBoxChuyenBan.SelectedItem as Table).ID;
            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển từ bàn{0} qua bàn {1}", (lsvBill.Tag as Table).Name, (comboBoxChuyenBan.SelectedItem as Table).Name), " Thông Báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                TableDAL.Instance.ChuyenBan(IDTable1, IDTable2);
                LoadTable();
            }

        }
        #endregion

        #region Xuất Hóa Đơn
        private void iconButton2_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            if (table == null)
                MessageBox.Show("Vui lòng chọn bàn cần in hóa đơn");
            else
            {
                if (lsvBill.Items.Count < 1)
                    MessageBox.Show("Bàn không có hóa đơn");
                else
                {
                    ThucDon = Convert.ToDouble(txbTongTien.Text.Split(',')[0]);
                    GiamGia = (int)numericUpDownGiamGia.Value;
                    TongCong = (ThucDon - (ThucDon / 100) * GiamGia);
                    IDtable = table.ID;
                    Tablename = table.Name.ToString();
                    FormHoaDon fm = new FormHoaDon();
                    fm.ShowDialog();
                }
            }

        }
        #endregion



    }

}
