using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    class ThanhToanBUS
    {
        ThanhToanDAO ttDAO = new ThanhToanDAO();

        public static List<HDTC> LoadThanhToan()
        {
            return ThanhToanDAO.LoadThanhToan();
        }

        public void AddThanhToan(HDTC t)
        {
            ttDAO.AddThanhToan(t);
        }

        public void EditThanhToan(HDTC t)
        {
            ttDAO.EditThanhToan(t);
        }

        public void DeleteThanhToan(int id)
        {
            ttDAO.DeleteThanhToan(id);
        }

        public HDTC GetByID(int id)
        {
            return ttDAO.GetByID(id);
        }
    }
}
