using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCDT.DAO
{
    public class KhachHangDAO
    {
        QLCDTEntities db = new QLCDTEntities();
        KHACHHANG kh = new KHACHHANG();

        public static List<KHACHHANG> LoadKH()
        {
            QLCDTEntities db = new QLCDTEntities();
            var result = (
                from khdb in db.KHACHHANGs
                select new
                {
                    ID = khdb.ID,
                    TENKH = khdb.TENKH,
                    CMND = khdb.CMND,
                    NGHENGHIEP = khdb.NGHENGHIEP,
                    CHUCVU = khdb.CHUCVU,
                    DIACHI = khdb.DIACHI,
                    TINHTRANG = khdb.TINHTRANG
                }).ToList();
            List<KHACHHANG> listReturn = new List<KHACHHANG>();

            foreach (var item in result)
            {
                KHACHHANG kh_list = new KHACHHANG();

                kh_list.ID = item.ID;
                kh_list.TENKH = item.TENKH;
                kh_list.CMND = item.CMND;
                kh_list.NGHENGHIEP = item.NGHENGHIEP;
                kh_list.CHUCVU = item.CHUCVU;
                kh_list.DIACHI = item.DIACHI;
                kh_list.TINHTRANG = item.TINHTRANG;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }


        public void AddKH(KHACHHANG kh)
        {
            db.KHACHHANGs.Add(kh);
            db.SaveChanges();
        }

        public void EditKH(KHACHHANG kh)
        {
            this.kh = (from c in db.KHACHHANGs
                       where c.ID == kh.ID
                       select c).Single();

            this.kh.TENKH = kh.TENKH;
            this.kh.CMND = kh.CMND;
            this.kh.NGHENGHIEP = kh.NGHENGHIEP;
            this.kh.CHUCVU = kh.CHUCVU;
            this.kh.DIACHI = kh.DIACHI;
            this.kh.TINHTRANG = kh.TINHTRANG;

            db.SaveChanges();
        }

        public KHACHHANG GetByID(int id)
        {
            return db.KHACHHANGs.Single(c => c.ID == id);
        }


        public void DeleteKH(int id)
        {
            KHACHHANG khTemp = new KHACHHANG();
            khTemp = db.KHACHHANGs.Single(c => c.ID == id);
            db.KHACHHANGs.Remove(khTemp);
            db.SaveChanges();
        }
    }
}
