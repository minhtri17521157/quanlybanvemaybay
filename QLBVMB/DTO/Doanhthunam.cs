using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DTO
{
    class Doanhthunam
    {

        public string nam { set; get; }
        public long doanhthu { set; get; }

        public Doanhthunam()
        {
        }

        public Doanhthunam(string _nam, long _doanhThu)
        {
            this.nam = _nam;
            this.doanhthu = _doanhThu;
        }


    }
}
