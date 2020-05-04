using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Chitietchuyenbay
    {

        public string mactcb { set; get; }
        public string macb { set; get; }
        public string masbtg { set; get; }
        public float thoigiandung { set; get; }
        public string ghichu { set; get; }


        public Chitietchuyenbay(string _mactcb, string _macb, string _masbtg, float _thoigiandung, string _ghichu)
        {
            this.mactcb = _mactcb;
            this.macb = _macb;
            this.masbtg = _masbtg;
            this.thoigiandung = _thoigiandung;
            this.ghichu = _ghichu;

        }


    }
}
