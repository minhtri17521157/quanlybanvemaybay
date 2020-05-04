using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class CTDoanhthuthang
    {

        public string thang { get; set; }
        public string machuyenbay { get; set; }
        public int sovebanduoc { get; set; }
        public long doanhthu { get; set; }

        public CTDoanhthuthang()
        {
        }

        public CTDoanhthuthang(string _thang, string _machuyenbay, int _sovebanduoc, long _doanhThu)
        {
            this.thang = _thang;
            this.machuyenbay = _machuyenbay;
            this.sovebanduoc = _sovebanduoc;
            this.doanhthu = _doanhThu;
        }

    }
}
