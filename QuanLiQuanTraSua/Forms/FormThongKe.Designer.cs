namespace QuanLiQuanTraSua.Forms
{
    partial class FormThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThongKe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.dateTimePickerTo = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dateTimePickerFrom = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.dataGridViewThongKe = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.textBoxTongTien1 = new System.Windows.Forms.TextBox();
            this.textBoxDoangSo1 = new System.Windows.Forms.TextBox();
            this.textBoxDoanhSo = new System.Windows.Forms.TextBox();
            this.textBoxDoanhThu = new System.Windows.Forms.TextBox();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.panelDesktop.Controls.Add(this.dateTimePickerTo);
            this.panelDesktop.Controls.Add(this.dateTimePickerFrom);
            this.panelDesktop.Controls.Add(this.dataGridViewThongKe);
            this.panelDesktop.Controls.Add(this.textBoxTongTien1);
            this.panelDesktop.Controls.Add(this.textBoxDoangSo1);
            this.panelDesktop.Controls.Add(this.textBoxDoanhSo);
            this.panelDesktop.Controls.Add(this.textBoxDoanhThu);
            this.panelDesktop.Controls.Add(this.textBoxTongTien);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.textBoxSoLuong);
            this.panelDesktop.Controls.Add(this.label4);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Controls.Add(this.btnThongKe);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1544, 925);
            this.panelDesktop.TabIndex = 6;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerTo.BorderRadius = 1;
            this.dateTimePickerTo.Color = System.Drawing.Color.Silver;
            this.dateTimePickerTo.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateTimePickerTo.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateTimePickerTo.DisabledColor = System.Drawing.Color.Gray;
            this.dateTimePickerTo.DisplayWeekNumbers = false;
            this.dateTimePickerTo.DPHeight = 0;
            this.dateTimePickerTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerTo.FillDatePicker = false;
            this.dateTimePickerTo.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerTo.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerTo.Icon = ((System.Drawing.Image)(resources.GetObject("dateTimePickerTo.Icon")));
            this.dateTimePickerTo.IconColor = System.Drawing.Color.White;
            this.dateTimePickerTo.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateTimePickerTo.LeftTextMargin = 5;
            this.dateTimePickerTo.Location = new System.Drawing.Point(96, 50);
            this.dateTimePickerTo.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(278, 32);
            this.dateTimePickerTo.TabIndex = 19;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.BackColor = System.Drawing.Color.Transparent;
            this.dateTimePickerFrom.BorderRadius = 1;
            this.dateTimePickerFrom.Color = System.Drawing.Color.Silver;
            this.dateTimePickerFrom.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateTimePickerFrom.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateTimePickerFrom.DisabledColor = System.Drawing.Color.Gray;
            this.dateTimePickerFrom.DisplayWeekNumbers = false;
            this.dateTimePickerFrom.DPHeight = 0;
            this.dateTimePickerFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerFrom.FillDatePicker = false;
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFrom.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.Icon = ((System.Drawing.Image)(resources.GetObject("dateTimePickerFrom.Icon")));
            this.dateTimePickerFrom.IconColor = System.Drawing.Color.White;
            this.dateTimePickerFrom.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateTimePickerFrom.LeftTextMargin = 5;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(96, 19);
            this.dateTimePickerFrom.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(278, 32);
            this.dateTimePickerFrom.TabIndex = 18;
            // 
            // dataGridViewThongKe
            // 
            this.dataGridViewThongKe.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewThongKe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewThongKe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThongKe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewThongKe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewThongKe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewThongKe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewThongKe.ColumnHeadersHeight = 40;
            this.dataGridViewThongKe.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.dataGridViewThongKe.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewThongKe.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewThongKe.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dataGridViewThongKe.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewThongKe.CurrentTheme.BackColor = System.Drawing.Color.Crimson;
            this.dataGridViewThongKe.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dataGridViewThongKe.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Crimson;
            this.dataGridViewThongKe.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewThongKe.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewThongKe.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))));
            this.dataGridViewThongKe.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewThongKe.CurrentTheme.Name = null;
            this.dataGridViewThongKe.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            this.dataGridViewThongKe.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewThongKe.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewThongKe.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            this.dataGridViewThongKe.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(208)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(114)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewThongKe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewThongKe.EnableHeadersVisualStyles = false;
            this.dataGridViewThongKe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(184)))), ((int)(((byte)(196)))));
            this.dataGridViewThongKe.HeaderBackColor = System.Drawing.Color.Crimson;
            this.dataGridViewThongKe.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewThongKe.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewThongKe.Location = new System.Drawing.Point(0, 130);
            this.dataGridViewThongKe.Name = "dataGridViewThongKe";
            this.dataGridViewThongKe.RowHeadersVisible = false;
            this.dataGridViewThongKe.RowHeadersWidth = 51;
            this.dataGridViewThongKe.RowTemplate.Height = 40;
            this.dataGridViewThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongKe.Size = new System.Drawing.Size(1544, 795);
            this.dataGridViewThongKe.TabIndex = 17;
            this.dataGridViewThongKe.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Crimson;
            // 
            // textBoxTongTien1
            // 
            this.textBoxTongTien1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxTongTien1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien1.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxTongTien1.Location = new System.Drawing.Point(1328, 81);
            this.textBoxTongTien1.Name = "textBoxTongTien1";
            this.textBoxTongTien1.Size = new System.Drawing.Size(161, 30);
            this.textBoxTongTien1.TabIndex = 16;
            this.textBoxTongTien1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxTongTien1.Visible = false;
            // 
            // textBoxDoangSo1
            // 
            this.textBoxDoangSo1.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxDoangSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoangSo1.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDoangSo1.Location = new System.Drawing.Point(877, 81);
            this.textBoxDoangSo1.Name = "textBoxDoangSo1";
            this.textBoxDoangSo1.ReadOnly = true;
            this.textBoxDoangSo1.Size = new System.Drawing.Size(161, 30);
            this.textBoxDoangSo1.TabIndex = 15;
            this.textBoxDoangSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDoangSo1.Visible = false;
            // 
            // textBoxDoanhSo
            // 
            this.textBoxDoanhSo.BackColor = System.Drawing.Color.DarkRed;
            this.textBoxDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoanhSo.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxDoanhSo.Location = new System.Drawing.Point(877, 57);
            this.textBoxDoanhSo.Name = "textBoxDoanhSo";
            this.textBoxDoanhSo.ReadOnly = true;
            this.textBoxDoanhSo.Size = new System.Drawing.Size(161, 30);
            this.textBoxDoanhSo.TabIndex = 14;
            this.textBoxDoanhSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDoanhThu
            // 
            this.textBoxDoanhThu.BackColor = System.Drawing.Color.DarkOrchid;
            this.textBoxDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDoanhThu.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBoxDoanhThu.Location = new System.Drawing.Point(1328, 53);
            this.textBoxDoanhThu.Name = "textBoxDoanhThu";
            this.textBoxDoanhThu.Size = new System.Drawing.Size(161, 30);
            this.textBoxDoanhThu.TabIndex = 13;
            this.textBoxDoanhThu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBoxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTongTien.ForeColor = System.Drawing.Color.Magenta;
            this.textBoxTongTien.Location = new System.Drawing.Point(1328, 19);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(161, 30);
            this.textBoxTongTien.TabIndex = 12;
            this.textBoxTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(1085, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tổng Tiền Khuyến Mãi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(1085, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Tiền Sản Phẩm ";
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.BackColor = System.Drawing.Color.DarkMagenta;
            this.textBoxSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuong.ForeColor = System.Drawing.Color.White;
            this.textBoxSoLuong.Location = new System.Drawing.Point(877, 17);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(161, 30);
            this.textBoxSoLuong.TabIndex = 8;
            this.textBoxSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(674, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng Số Giao Dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(674, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số Tiền Thực Nhận";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnThongKe.FlatAppearance.BorderSize = 0;
            this.btnThongKe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(88)))), ((int)(((byte)(155)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnThongKe.IconColor = System.Drawing.Color.White;
            this.btnThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongKe.IconSize = 48;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(453, 18);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Rotation = 0D;
            this.btnThongKe.Size = new System.Drawing.Size(143, 67);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê ";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ ";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 925);
            this.Controls.Add(this.panelDesktop);
            this.Name = "FormThongKe";
            this.Text = "Thống Kê Giao Dịch ";
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDoanhThu;
        private System.Windows.Forms.TextBox textBoxTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDoanhSo;
        private System.Windows.Forms.TextBox textBoxTongTien1;
        private System.Windows.Forms.TextBox textBoxDoangSo1;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewThongKe;
        private Bunifu.UI.WinForms.BunifuDatePicker dateTimePickerFrom;
        private Bunifu.UI.WinForms.BunifuDatePicker dateTimePickerTo;
    }
}