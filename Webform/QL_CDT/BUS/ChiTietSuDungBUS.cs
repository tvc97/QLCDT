using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CDT.DAO;

namespace QL_CDT.BUS
{
    class ChiTietSuDungBUS
    {
        ChiTietSuDungDAO ctsdDAO = new ChiTietSuDungDAO();

        public static List<CHITIETSD> LoadCTSD()
        {
            return ChiTietSuDungDAO.LoadCTSD();
        }

        public void AddCTSD(CHITIETSD t)
        {
            ctsdDAO.AddCTSD(t);
        }

        public void EditCTSD(CHITIETSD t)
        {
            ctsdDAO.EditCTSD(t);
        }

        public void DeleteCTSD(int id)
        {
            ctsdDAO.DeleteCTSD(id);
        }

        public CHITIETSD GetByID(int id)
        {
            return ctsdDAO.GetByID(id);
        }

        public void CleanAll()
        {
            ctsdDAO.CleanAll();
        }
    }
}
