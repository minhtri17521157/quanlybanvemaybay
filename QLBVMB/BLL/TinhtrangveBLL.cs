using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class TinhtrangveBLL
    {

        DAL.TinhtrangveDAL dal = new DAL.TinhtrangveDAL();

        public DataTable Get()
        {
            return dal.Get();
        }
        public DataTable GetForDisplayOfMaChuyenBay(string str)
        {
            return dal.GetForDisplayOfMaChuyenBay(str);
        }
        public bool InsertTinhtrangve(DTO.Tinhtrangve ttv)
        {
            return dal.InsertTinhtrangve(ttv);
        }
        public bool UpdateTinhtrangve(DTO.Tinhtrangve ttv)
        {
            return dal.UpdateTinhtrangve(ttv);
        }

        public bool DeleteTinhtrangve(DTO.Tinhtrangve ttv)
        {
            return dal.DeleteTinhtrangve(ttv);
        }

        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            return dal.GetOfMaChuyenBay(maChuyenBay);
        }
        public string GetSoGheTrongOfMaChuyenBayAndMaHangVe(string maChuyenBay, string maHangVe)
        {
            return dal.GetSoGheTrongOfMaChuyenBayAndMaHangVe(maChuyenBay, maHangVe);
        }

        public string Get_SL_GHE_by_MACB(string maChuyenBay)
        {
            return dal.Get_SL_GHE_by_MACB(maChuyenBay);
        }


    }
}
