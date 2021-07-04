using QuanLiQuanTraSua.DAO;
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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
            LoadListBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            LoadDateTimePickerBill();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerFrom.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo.Value = dateTimePickerFrom.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dataGridViewThongKe.DataSource = BillDAL.Instance.GetBillListByDate(checkIn, checkOut);
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            SoLuongBill();
            TongTien();
            TongTienKhuyenMai();
            DoanhThu();  
        }
        #region Tính Toán 
        public void SoLuongBill()
        {
            int bill = dataGridViewThongKe.Rows.Count;
            bill = bill - 1;
            textBoxSoLuong.Text = bill.ToString();
        }
        public void TongTien()
        {
            CultureInfo culture = new CultureInfo("vi-VN");

            int count = dataGridViewThongKe.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < count - 1; i++)
            {
                thanhtien += float.Parse(dataGridViewThongKe.Rows[i].Cells["Thành tiền"].Value.ToString());
            }
            textBoxDoangSo1.Text = thanhtien.ToString();
            textBoxDoanhSo.Text = thanhtien.ToString("c", culture);
        }
        public void TongTienKhuyenMai()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            int count = dataGridViewThongKe.Rows.Count;
            float a = 0;
            float b = 0;
            float thanhtien = 0;
            for (int i = 0; i < count - 1; i++)
            {
                a = float.Parse(dataGridViewThongKe.Rows[i].Cells["Thành tiền"].Value.ToString());
                b = float.Parse(dataGridViewThongKe.Rows[i].Cells["Giảm giá %"].Value.ToString());
                if (b != 100)
                {
                    thanhtien += a / (1 - b / 100);
                }
            }
            textBoxTongTien1.Text = thanhtien.ToString();
            textBoxTongTien.Text = thanhtien.ToString("c", culture);
        }

        public void DoanhThu()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            float doanhthu = 0;
            doanhthu = float.Parse(textBoxTongTien1.Text) - float.Parse(textBoxDoangSo1.Text);
            textBoxDoanhThu.Text = doanhthu.ToString("c", culture);
        }
        #endregion

    }
}
