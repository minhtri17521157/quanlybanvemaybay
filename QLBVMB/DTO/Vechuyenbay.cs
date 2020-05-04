using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Vechuyenbay
    {

        public string mave { set; get; }
        public string mahk { set; get; }
        public string macb { set; get; }
        public string mahv { set; get; }
        public decimal gia { set; get; }

        public DateTime ngaygd { set; get; }
        public DateTime ngayhuy { set; get; }
        public string loaive { set; get; }

        public Vechuyenbay(string maVe, string maKhachHang, string maChuyenBay, string maHangVe,  decimal giaTien, DateTime ngayGioGD, DateTime ngayHuy, string loaiVe)
        {
            this.mave = maVe;
            this.mahk = maKhachHang;
            this.macb = maChuyenBay;
            this.mahv = maHangVe;
          
            this.gia= giaTien;
            this.ngaygd = ngayGioGD;
            this.ngayhuy = ngayHuy;
            this.loaive = loaiVe;
        }

    }
}
