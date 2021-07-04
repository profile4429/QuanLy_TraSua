using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DTO
{
    public class AccountInfo
    {
        public AccountInfo(string username, int socmnd, string hovaten, string gioitinh, string sodt, string ngaysinh, string email, string quequan, string tennguoithan, string sodtnguoithan, string noiohientai)
        {
            this.UserName = username;
            this.Socmnd = socmnd;
            this.Hovaten = hovaten;
            this.Gioitinh = gioitinh;
            this.Sodt = sodt;
            this.Ngaysinh = ngaysinh;
            this.Email = email;
            this.Quequan = quequan;
            this.Tennguoithan = tennguoithan;
            this.Sodtnguoithan = sodtnguoithan;
            this.Noiohientai = noiohientai;
        }

        public AccountInfo(DataRow row)
        {
            this.UserName = row["username"].ToString();
            this.Socmnd = (int)row["socmnd"];
            this.Hovaten = row["hovaten"].ToString();
            this.Gioitinh = row["gioitinh"].ToString();
            this.Sodt = row["sodt"].ToString();
            this.Ngaysinh = row["ngaysinh"].ToString();
            this.Email = row["email"].ToString();
            this.Quequan = row["quequan"].ToString();
            this.Tennguoithan = row["tennguoithan"].ToString();
            this.Sodtnguoithan = row["sodtnguoithan"].ToString();
            this.Noiohientai = row["noiohientai"].ToString();
        }
        private int socmnd;
        private string hovaten;
        private string gioitinh;
        private string sodt;
        private string ngaysinh;
        private string email;
        private string quequan;
        private string tennguoithan;
        private string sodtnguoithan;
        private string noiohientai;
        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public int Socmnd { get => socmnd; set => socmnd = value; }
        public string Hovaten { get => hovaten; set => hovaten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Sodt { get => sodt; set => sodt = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Email { get => email; set => email = value; }
        public string Quequan { get => quequan; set => quequan = value; }
        public string Tennguoithan { get => tennguoithan; set => tennguoithan = value; }
        public string Sodtnguoithan { get => sodtnguoithan; set => sodtnguoithan = value; }
        public string Noiohientai { get => noiohientai; set => noiohientai = value; }
    }
}
