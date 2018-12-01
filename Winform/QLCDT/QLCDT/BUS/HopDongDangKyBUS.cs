using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    public class HopDongDangKyBUS
    {
        HopDongDangKyDAO hdDAO = new HopDongDangKyDAO();

        public static List<HDDK> LoadHDDK()
        {
            return HopDongDangKyDAO.LoadHDDK();
        }

        public void AddHDDK(HDDK t)
        {
            hdDAO.AddHDDK(t);
        }

        public void EditHDDK(HDDK t)
        {
            hdDAO.EditHDDK(t);
        }

        public void DeleteHDDK(int id)
        {
            hdDAO.DeleteHDDK(id);
        }

        public HDDK GetByID(int id)
        {
            return hdDAO.GetByID(id);
        }
    }
}
