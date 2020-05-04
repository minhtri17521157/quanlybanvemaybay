using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class VechuyenbayBLL
    {
        DAL.VechuyenbayDAL dal = new DAL.VechuyenbayDAL();
        public DataTable Get()
        {
            return dal.getAllVechuyenbay();
        }

        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }

        public bool InsertVechuyenbay(DTO.Vechuyenbay vcb)
        {
            return dal.InsertVechuyenbay(vcb);
        }


        public bool UpdateVechuyenbay(DTO.Vechuyenbay vcb)
        {
            return dal.UpdateVechuyenbay(vcb);
        }

        public bool DeleteVechuyenbay(DTO.Vechuyenbay vcb)
        {
            return dal.DeleteVechuyenbay(vcb);
        }

        public DataTable FindVebyMAVE(string mv)
        {
            return dal.FindVebyMAVE(mv);
        }

        public DataTable FindMAVE(string maHK, string maCB, string maHV)
        {
            return dal.FindMAVE(maHK, maCB, maHV);
        }

        public DataTable FindChitietVE(string MAVE)
        {
            return dal.FindChitietVE(MAVE);
        }

        public bool HuyVE(string mave)
        {
            return dal.HuyVE(mave);
        }

        public bool ThanhtoanVE(string mave)
        {
            return dal.ThanhtoanVE(mave);
        }

        public string Get_SLVE_MUA_by_MACB(string maChuyenBay)
        {
            return dal.Get_SLVE_MUA_by_MACB(maChuyenBay);
        }

        public string Get_SLVE_MUA_by_MACB_MONTH(string maChuyenBay, string mon)
        {
            return dal.Get_SLVE_MUA_by_MACB_MONTH(maChuyenBay, mon);
        }

    }
}
