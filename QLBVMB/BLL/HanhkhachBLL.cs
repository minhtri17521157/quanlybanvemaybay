using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class HanhkhachBLL
    {

        DAL.HanhkhachDAL dal = new DAL.HanhkhachDAL();

        public DataTable Get()
        {
            return dal.getAllHanhkhach();
        }
        public DataTable GetForDisplay()
        {
            return dal.GetForDisplay();
        }
        public bool InsertHanhkhach(DTO.Hanhkhach hk)
        {
            return dal.InsertHanhkhach(hk);
        }
        public bool Update(DTO.Hanhkhach hk)
        {
            return dal.UpdateHanhkhach(hk);
        }
        public bool Delete(DTO.Hanhkhach hk)
        {
            return dal.DeleteHanhkhach(hk);
        }

        public DataTable GetOfCMND(string maKhachHang)
        {
            return dal.GetOfCMND(maKhachHang);
        }
        public DataTable SearchOfMaKhachHang(string str)
        {
            return dal.SearchOfMaKhachHang(str);
        }

        public DataTable FindMAHK(string CMND)
        {
            return dal.FindMAHK(CMND);
        }

    }
}
