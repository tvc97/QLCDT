using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCDT.DAO;

namespace QLCDT.BUS
{
    public class KhachHangBUS
    {
        KhachHangDAO khtemp = new KhachHangDAO();

        public static List<KHACHHANG> LoadKH()
        {
            return KhachHangDAO.LoadKH();
        }

        public void AddKH(KHACHHANG kh)
        {
            khtemp.AddKH(kh);
        }

        public void EditKH(KHACHHANG kh)
        {
            khtemp.EditKH(kh);
        }

        public void DeleteKH(int id)
        {
            khtemp.DeleteKH(id);
        }

        public KHACHHANG GetByID(int id)
        {
            return khtemp.GetByID(id);
        }
    }
}
