using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Doanhthuthang
    {


        public string thang { get ; set; }
        public string nam { get; set; }
        public int sochuyenbay { get; set; }
        public long doanhthu { get; set; }

        public Doanhthuthang()
        {
        }

        public Doanhthuthang(string _thang, string _nam, int _soChuyenBay, long _doanhThu)
        {
            this.thang = _thang;
            this.nam = _nam;
            this.sochuyenbay = _soChuyenBay;
            this.doanhthu = _doanhThu;
        }

       

    }
}
