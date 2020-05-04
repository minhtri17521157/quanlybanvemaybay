using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class Tuyenbay
    {
        public string matb { set; get; }
        public string masb_di { set; get; }
        public string masb_den { set; get; }


        public Tuyenbay(string matb, string masb_di, string masb_den)
        {
            this.matb = matb;
            this.masb_di = masb_di;
            this.masb_den = masb_den;
        }
    }
}
