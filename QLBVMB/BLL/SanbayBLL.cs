using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class SanbayBLL
    {
        SanbayDAL dalSB;
        public SanbayBLL()
        {
            dalSB = new SanbayDAL();
        }

        public DataTable getAllSanbay()
        {
            return dalSB.getAllSanbay();      
        }

        public bool InsertSanbay(Sanbay sb)
        {
            return dalSB.InsertSanbay(sb);
        }

        public bool UpdateSanbay(Sanbay sb)
        {
            return dalSB.UpdateSanbay(sb);
        }

        public bool DeleteSanbay(Sanbay sb)
        {
            return dalSB.DeleteSanbay(sb);
        }

        public DataTable GetSL_SB_Hoat_Dong()
        {
            return dalSB.GetSL_SB_Hoat_Dong();
        }

        public DataTable getallSanbay_hoatdong()
        {
            return dalSB.getallSanbay_hoatdong();
        }

    }
}
