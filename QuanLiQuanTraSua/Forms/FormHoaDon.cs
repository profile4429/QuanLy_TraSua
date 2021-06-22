using QuanLiTraSua.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
            Form_Load();
        }

        void Form_Load()
        {
            DateTime t = DateTime.Now;
            string a = t.DayOfWeek.ToString();

            label1.Text = t.ToString("ddd,dd/MM/yy");
            label2.Text = t.ToString("HH:mm:ss");
            label3.Text = FormTongQuan.Tablename.ToString();

        }
        void ShowBill(int id)
        {

            CultureInfo culture = new CultureInfo("vi-VN");
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
            label8.Text = FormTongQuan.ThucDon.ToString("c", culture);
            label9.Text = FormTongQuan.GiamGia.ToString();
            label10.Text = FormTongQuan.TongCong.ToString("c", culture);


        }
        private void captureScreen()
        {



        }
        Bitmap bitmap;
        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);
            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

    }
}
}