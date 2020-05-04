using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.BLL
{
    class QuydinhBLL
    {
        DAL.QuydinhDAL dal = new DAL.QuydinhDAL();



        public DataTable GetAllQuydinh()
        {
            return dal.GetAllQuydinh();
        }

        public bool UpdateQuydinh(DTO.Quydinh qd)
        {
            return dal.UpdateQuydinh(qd);
        }

        public bool UpdateSanBayTD(DTO.Quydinh qd)
        {
            return dal.UpdateSanBayTD(qd);
        }

        public bool Update_SL_HangveHienTai(DTO.Quydinh qd)
        {
            return dal.Update_SL_HangveHienTai(qd);
        }

        public void Get_Infor(DTO.Quydinh qd)
        {
            dal.Get_Infor(qd);
        }

        public string Get_So_Sanbay_TG_toida()
        {
            return dal.Get_So_Sanbay_TG_toida();
        }

    }
}
