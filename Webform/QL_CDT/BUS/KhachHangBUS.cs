using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_CDT.DAO;

namespace QL_CDT.BUS
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

        public bool validate(KHACHHANG kh)
        {
            return kh.TENKH.Length > 0 &&
                kh.CMND.Length > 0 &&
                IsValidEmail(kh.EMAIL);
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
