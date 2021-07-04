using QuanLiQuanTraSua.DAO;
using QuanLiTraSua.DAO;
using QuanLiTraSua.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanTraSua.Forms
{
    public partial class FormChiSo : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLi;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader Dr;
        public FormChiSo()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePickerFrom.Value = new DateTime(today.Year, today.Month, 1);
            dateTimePickerTo.Value = dateTimePickerFrom.Value.AddMonths(1).AddDays(-1);
        }
        #region Top 5 Sản Phẩm Bán Chạy Nhất
        private void TopBanChay(DateTime CheckIn, DateTime CheckOut)
        {

            ChartTopFood.Controls.Clear();
            cmd = new SqlCommand("USP_TopBanChay", connection);
            cmd.Parameters.Add("@checkIn", SqlDbType.DateTime);
            cmd.Parameters["@checkIn"].Value = CheckIn;
            cmd.Parameters.Add("@checkOut", SqlDbType.DateTime);
            cmd.Parameters["@checkOut"].Value = CheckOut;

            cmd.CommandType = CommandType.StoredProcedure;
            connection.Open();
            ArrayList FoodName = new ArrayList();
            ArrayList FoodCount = new ArrayList();
            Dr = cmd.ExecuteReader();
            while (Dr.Read())
            {

                FoodName.Add(Dr.GetString(0));
                FoodCount.Add(Dr.GetInt32(1));
            }
            ChartTopFood.Series[0].Points.DataBindXY(FoodName, FoodCount);

            Dr.Close();
            connection.Close();
        }
        #endregion

        #region Thống Kê Chỉ Số
        private void ListNgayTrongThang(DateTime CheckIn, DateTime CheckOut)
        {
            Chart.Controls.Clear();
            cmd = new SqlCommand("USP_GetTongTien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@checkIn", SqlDbType.DateTime);
            cmd.Parameters["@checkIn"].Value = CheckIn;
            cmd.Parameters.Add("@checkOut", SqlDbType.DateTime);
            cmd.Parameters["@checkOut"].Value = CheckOut;
            connection.Open();
            Dr = cmd.ExecuteReader();

            ArrayList DayName = new ArrayList();
            ArrayList Sum = new ArrayList();

            while (Dr.Read())
            {

                DayName.Add(Dr.GetDateTime(0).ToString().Split(' ')[0]);
                Sum.Add(Dr.GetDouble(2));
            }
            Chart.Series[0].Points.DataBindXY(DayName, Sum);
            Dr.Close();
            connection.Close();
        }

        #endregion

        #region Tính Tiền 
        public void TongTien()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            DataTable data = BillDAL.Instance.GetListBill(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            int count = data.Rows.Count;
            float thanhtien = 0;
            for (int i = 0; i < count; i++)
            {
                thanhtien += float.Parse(data.Rows[i]["totalPrice"].ToString());
            }

            labelThucNhan.Text = thanhtien.ToString("c", culture);
            float a = 0;
            float b = 0;
            float thanhtien1 = 0;
            float thanhtien2 = 0;
            for (int i = 0; i < count; i++)
            {
                a = float.Parse(data.Rows[i]["totalPrice"].ToString());
                b = float.Parse(data.Rows[i]["discount"].ToString());
                if (b != 100)
                {
                    thanhtien1 += a / (1 - b / 100);
                }
            }
            thanhtien2 = thanhtien1 - thanhtien;

            labelTienKhuyenMai.Text = thanhtien2.ToString("c", culture);
            labelTongTien.Text = thanhtien1.ToString("c", culture);
        }

        #endregion
        #region Thành Viên
        public void Account()
        {
            DataTable data = AccountDAL.Instance.GetListAcc();
            int count = data.Rows.Count;
            labelTongThanhVien.Text = count.ToString();
            DataTable dataadmin = AccountDAL.Instance.GetListAdmin();
            int countadmin = dataadmin.Rows.Count;
            labelQuanTriVien.Text = countadmin.ToString();
            DataTable datanhanvien = AccountDAL.Instance.GetListNhanVien();
            int countnhanvien = datanhanvien.Rows.Count;
            labelNhanVien.Text = countnhanvien.ToString();
        }
        #endregion
        #region Chỉ Số Khác
        public void Food()
        {
            DataTable data = FoodDAL.Instance.GetList();
            int count = data.Rows.Count;
            labelTongSanPham.Text = count.ToString();
            DataTable datahoadon = BillDAL.Instance.GetList();
            int counthoadon = datahoadon.Rows.Count;
            labelHoaDon.Text = counthoadon.ToString();
            DataTable databan = TableDAL.Instance.GetListTable();
            int countban = databan.Rows.Count;
            labelBan.Text = countban.ToString();
        }
        #endregion


        private void btnThongKe_Click(object sender, EventArgs e)
        {
           
            ListNgayTrongThang(dateTimePickerFrom.Value,dateTimePickerTo.Value);
            TopBanChay(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            TongTien();
            Account();
            Food();
           
        }
    }
}
