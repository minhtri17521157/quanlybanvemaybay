using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class HangveBLL
    {
        DAL.HangveDAL dal = new DAL.HangveDAL();

        public DataTable Get()
        {
            return dal.getAllHangve();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool InsertHangve(DTO.Hangve dto)
        {
            return dal.InsertHangve(dto);
        }
        public bool UpdateHangve(string ten_hv,string ma_hv,string tinh_trang, string ty_le )
        {
            return dal.UpdateHangve(ten_hv,ma_hv,tinh_trang,ty_le);
        }
        public bool DeleteHangve(DTO.Hangve dto)
        {
            return dal.DeleteHangve(dto);
        }
        public DataTable SearchOfMaHangVe(string str)
        {
            return dal.SearchOfMaHangVe(str);
        }

        public DataTable SearchTLbyID(string str)
        {
            return dal.SearchTLbyID(str);
        }

        public DataTable getHangveKhadungbyMACB(string machuyenbay)
        {
            return dal.getHangveKhadungbyMACB(machuyenbay);
        }


        public DataTable Count_SLHV()
        {
            return dal.Count_SLHV();
        }

        public string Get_MAVE_by_TENHV(string ma_hve)
        {
            return dal.Get_MAVE_by_TENHV(ma_hve);
        }


    }
}
