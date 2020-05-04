using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class ChuyenbayBLL
    {

        DAL.ChuyenbayDAL dal;
        public ChuyenbayBLL()
        {
            dal = new DAL.ChuyenbayDAL();
        }

        public DataTable Search(string maSanBayDi, string maSanBayDen, DateTime ngayKH, DateTime ngayKH2, string tmp)
        {
            return dal.Search(maSanBayDi, maSanBayDen, ngayKH,ngayKH2,tmp);
        }

        public DataTable Get()
        {
            return dal.getAllSanbay();
        }
        public bool InsertChuyenbay(DTO.Chuyenbay dto)
        {
            return dal.InsertChuyenbay(dto);
        }
        public bool UpdateChuyenbay(DTO.Chuyenbay dto)
        {
            return dal.UpdateChuyenbay(dto);
        }
        public bool DeleteChuyenbay(string str)
        {
            return dal.DeleteChuyenbay(str);
        }
        public DataTable GetOfMaChuyenBay(string maChuyenBay)
        {
            return dal.GetOfMaChuyenBay(maChuyenBay);
        }
        public DateTime GetDateTimeOfMaChuyenBay(string str)
        {
            return dal.GetDateTimeOfMaChuyenBay(str);
        }
        public DataTable GetToDisplay()
        {
            return dal.GetToDisplay();
        }
        public DataTable SearchOfMaChuyenBay(string str)
        {
            return dal.SearchOfMaChuyenBay(str);
        }

        public DataTable SearchDGbyMACB(string str)
        {
            return dal.SearchDGbyMACB(str);
        }

       

    }
}
