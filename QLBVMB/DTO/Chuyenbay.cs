using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Chuyenbay
    {
        public string macb { set; get; }
        public string matb { set; get; }
        public DateTime ngaygio { set; get; }
        public float thoigianbay { set; get; }
        //public int slghehang1 { set; get; }
        //public int slghehang2 { set; get; }
        public string madg { set; get; }

        public Chuyenbay(string macb_, string matb_, DateTime ngaygio_,float tgbay_ ,string madg_)
        {
            this.macb = macb_;
            this.matb = matb_;
            this.ngaygio = ngaygio_;
            this.thoigianbay = tgbay_;
            this.madg = madg_;
        }

    }
}
