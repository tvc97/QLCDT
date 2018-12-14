using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CDT.DAO
{
    class HopDongDangKyDAO
    {
        QL_CDTEntities db = new QL_CDTEntities();
        HDDK hd = new HDDK();

        public static List<HDDK> LoadHDDK()
        {
            QL_CDTEntities db = new QL_CDTEntities();
            var result = (
                from t in db.HDDKs
                select new
                {
                    ID = t.ID,
                    IDSIM = t.IDSIM,
                    IDKH = t.IDKH,
                    CUOCDK = t.CUOCDK,
                    KHACHHANG = t.KHACHHANG,
                    NGAYBD = t.NGAYBD,
                    NGAYKT = t.NGAYKT
                }).ToList();
            List<HDDK> listReturn = new List<HDDK>();

            foreach (var item in result)
            {
                HDDK kh_list = new HDDK();

                kh_list.ID = item.ID;
                kh_list.IDSIM = item.IDSIM;
                kh_list.IDKH = item.IDKH;
                kh_list.CUOCDK = item.CUOCDK;
                kh_list.KHACHHANG = item.KHACHHANG;
                kh_list.NGAYBD = item.NGAYBD;
                kh_list.NGAYKT = item.NGAYKT;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }


        public void AddHDDK(HDDK t)
        {
            db.HDDKs.Add(t);
            db.SaveChanges();
        }

        public void EditHDDK(HDDK t)
        {
            this.hd = (from c in db.HDDKs
                        where c.ID == t.ID
                       select c).Single();

            this.hd.CUOCDK = t.CUOCDK;
            this.hd.NGAYBD = t.NGAYBD;
            this.hd.NGAYKT = t.NGAYKT;

            db.SaveChanges();
        }

        public HDDK GetByID(int id)
        {
            return db.HDDKs.Single(c => c.ID == id);
        }

        public void DeleteHDDK(int id)
        {
            HDDK t = new HDDK();
            t = db.HDDKs.Single(c => c.ID == id);
            db.HDDKs.Remove(t);
            db.SaveChanges();
        }

        public bool checkExists(string SIM, int idhd, DateTime start, DateTime end)
        {
            return db.HDDKs.Where(x => x.IDSIM == SIM && x.ID != idhd && x.NGAYBD <= end && x.NGAYKT >= start).Count() != 0;
        }
    }
}
