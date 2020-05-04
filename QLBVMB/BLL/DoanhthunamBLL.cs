using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class DoanhthunamBLL
    {
        DAL.DoanhthunamDAL dal = new DAL.DoanhthunamDAL();


        public string Get_doanhthu_NAM(string _nam)
        {
            return dal.Get_doanhthu_NAM(_nam);
        }



    }
}
