using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CDT.DAO
{
    class ThanhToanDAO
    {
        QL_CDTEntities db = new QL_CDTEntities();
        HDTC tts = new HDTC();

        public static List<HDTC> LoadThanhToan()
        {
            QL_CDTEntities db = new QL_CDTEntities();
            var result = (
                from t in db.HDTCs
                select new
                {
                    ID = t.ID,
                    IDSIM = t.IDSIM,
                    KHACHHANG = t.KHACHHANG,
                    THANG = t.THANG,
                    NAM = t.NAM,
                    TONGTIEN = t.TONGTIEN,
                    THANHTOAN = t.THANHTOAN
                }).ToList();
            List<HDTC> listReturn = new List<HDTC>();

            foreach (var item in result)
            {
                HDTC kh_list = new HDTC();

                kh_list.ID = item.ID;
                kh_list.IDSIM = item.IDSIM;
                kh_list.KHACHHANG = item.KHACHHANG;
                kh_list.THANG = item.THANG;
                kh_list.NAM = item.NAM;
                kh_list.TONGTIEN = item.TONGTIEN;
                kh_list.THANHTOAN = item.THANHTOAN;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }


        public void AddThanhToan(HDTC t)
        {
            db.HDTCs.Add(t);
            db.SaveChanges();
        }

        public void EditThanhToan(HDTC t)
        {
            this.tts = (from c in db.HDTCs
                        where c.ID == t.ID
                        select c).Single();

            this.tts.ID = t.ID;
            this.tts.IDSIM = t.IDSIM;
            this.tts.KHACHHANG = t.KHACHHANG;
            this.tts.THANG = t.THANG;
            this.tts.NAM = t.NAM;
            this.tts.TONGTIEN = t.TONGTIEN;
            this.tts.THANHTOAN = t.THANHTOAN;

            db.SaveChanges();
        }

        public HDTC GetByID(int id)
        {
            return db.HDTCs.Single(c => c.ID == id);
        }
        public void DeleteThanhToan(int id)
        {
            HDTC t = new HDTC();
            t = db.HDTCs.Single(c => c.ID == id);
            db.HDTCs.Remove(t);
            db.SaveChanges();
        }

    }
}
