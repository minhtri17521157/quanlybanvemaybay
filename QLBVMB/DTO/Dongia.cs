using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Dongia
    {
        public string madg { set; get; }
       // public string matb { set; get; }
        //public string mahv { set; get; }
        public decimal dongia { set; get; }


        public Dongia()
        {

        }

        public Dongia(string maDG, string maTuyenBay, string maHangVe, long donGia)
        {
            this.madg = maDG;
           // this.mahv = maHangVe;
           // this.matb = maTuyenBay;
            this.dongia = donGia;
        }

    }
}
