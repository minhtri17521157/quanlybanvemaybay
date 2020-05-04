using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Quydinh
    {

        public int tgbaytoithieu { set; get; }
        public int sosbtrunggiantoida { set; get; }
        public int tgdungtoithieu { set; get; }
        public int tgdungtoida { set; get; }
        public int tgchamnhatdatve { set; get; }
        public int tgchamnhathuyve { set; get; }
        public int slhangve { set; get; }
        public int slsanbaytoida { set; get; }


        public Quydinh(int tgbaytt,int sbtgntoida,int tgdungtt,int tgdungtd,int tgchamnhatdv,int tgchamnhathv,int slhv,int slsb)
        {
            this.tgbaytoithieu = tgbaytt;
            this.sosbtrunggiantoida = sbtgntoida;
            this.tgdungtoithieu = tgdungtt;
            this.tgdungtoida = tgdungtd;

            this.tgchamnhatdatve = tgchamnhatdv;
            this.tgchamnhathuyve = tgchamnhathv;
            this.slhangve = slhv;
            this.slsanbaytoida = slsb;
        }

    }
}
