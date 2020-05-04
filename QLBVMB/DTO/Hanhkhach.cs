using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Hanhkhach
    {

        public string mahk { set; get; }
        public string tenhk { set; get; }
        public string cmnd { set; get; }
        public string sdt { set; get; }



        public Hanhkhach()
        {

        }

        public Hanhkhach(string maKhachHang, string tenKhachHang, string CMND, string SDT)
        {
            this.mahk = maKhachHang;
            this.tenhk = tenKhachHang;
            this.cmnd = CMND;
            this.sdt = SDT;
        }
    }
}
