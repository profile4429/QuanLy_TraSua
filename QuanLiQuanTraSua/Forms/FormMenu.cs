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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            LoadListFood();
            LoadCategoryIntoCombobox(comboBoxTheLoai);
           

        }
        void LoadListFood()
        {
          
            dataGridViewMenu.DataSource = FoodDAL.Instance.GetListFood();
            dataGridViewMenu.Columns[0].HeaderText = "ID";
            dataGridViewMenu.Columns[2].HeaderText = "Loại Nước";
            dataGridViewMenu.Columns[3].HeaderText = "Tên";
            dataGridViewMenu.Columns[1].HeaderText = "Giá";

            dataGridViewMenu.Columns["ID"].DisplayIndex = 0;
            dataGridViewMenu.Columns["Name"].DisplayIndex = 1;
            dataGridViewMenu.Columns["Price"].DisplayIndex = 2;
            dataGridViewMenu.Columns["CategoryID"].DisplayIndex = 3;

            Load();

        }
        public void Load()
        {
            int count = dataGridViewMenu.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                int temp = int.Parse(dataGridViewMenu.Rows[i].Cells["CategoryID"].Value.ToString());
                switch (temp)
                {
                    case 6:
                        dataGridViewMenu.Rows[i].Cells["CategoryID"].Value = "Trà Sữa";
                        break;
                    case 7:
                        dataGridViewMenu.Rows[i].Cells["CategoryID"].Value = "Cà Phê";
                        break;
                    case 8:
                        dataGridViewMenu.Rows[i].Cells["CategoryID"].Value = "Nước Ép Trái Cây";
                        break;
                    default:
                        dataGridViewMenu.Rows[i].Cells["CategoryID"].Value = "Thêm";
                        break;
                }          
            }
        }


        private void iconButtonHienThi_Click(object sender, EventArgs e)
        {
            LoadListFood();
            
        }
        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAL.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        #region Thêm Xóa Sửa

        private void iconButtonThem_Click(object sender, EventArgs e)
        {
            string name = textBoxTen.Text;
            int id = (comboBoxTheLoai.SelectedItem as Category).ID;
            float price = (float)numericUpDownGia.Value;

            if (FoodDAL.Instance.InsertFood(name, id, price))
            {
                MessageBox.Show("Thêm thành công");
                LoadListFood();
                insertFood?.Invoke(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại ? Vui Lòng Kiểm Tra Lại");
            }
        }

        private void iconButtonChinhSua_Click(object sender, EventArgs e)
        {
            string name = textBoxTen.Text;
            int categoryID = (comboBoxTheLoai.SelectedItem as Category).ID;
            float price = (float)numericUpDownGia.Value;
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin ");
                return;
            }

            int id = Convert.ToInt32(textBoxId.Text);

            if (FoodDAL.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                updateFood?.Invoke(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Có lỗi khi chỉnh sửa ? Vui Lòng Kiểm Tra Lại ");
            }

        }
        private void iconButtonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text == "")
            {
                MessageBox.Show("Vui Lòng Chọn Sản Phẩm Cần Xóa ");
                return;
            }
            int id = Convert.ToInt32(textBoxId.Text);

            if (FoodDAL.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
                deleteFood?.Invoke(this, new EventArgs());

            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn");
            }
        }
        #endregion



        private void dataGridViewMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow == -1)
                return;
            textBoxId.Text = dataGridViewMenu.Rows[numrow].Cells[0].Value.ToString();
            textBoxTen.Text = dataGridViewMenu.Rows[numrow].Cells[3].Value.ToString();
            

        }
        #region EventHandler
        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        #endregion


    }
}
