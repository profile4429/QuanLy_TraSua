using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiQuanTraSua.DTO
{
    public class Table
    {
        public Table(int id, string name, string trangthai)
        {
            this.ID = id;
            this.Name = name;
            this.Trangthai = trangthai;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }

        public Table(DataTable data)
        {
        }

        public Table()
        {
        }

        private string trangthai;
        private string name;
        private int iD;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
