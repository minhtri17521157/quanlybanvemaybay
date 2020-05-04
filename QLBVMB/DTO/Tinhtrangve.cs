using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Tinhtrangve
    {

        public string mattve { set; get; }
        public string macb { set; get; }
        public string mahv { set; get; }
        public int slghe { set; get; }
        public int slghetrong { set; get; }
        public int slghedat { set; get; }

        public Tinhtrangve()
        {
        }
        public Tinhtrangve(string mattv, string maChuyenBay, string maHangVe, int tongSoGhe, int soGheTrong, int soGheDat)
        {
            this.mattve = mattv;
            this.macb = maChuyenBay;
            this.mahv = maHangVe;
            this.slghe = tongSoGhe;
            this.slghetrong = soGheTrong;
            this.slghedat = soGheDat;
        }


    }
}
