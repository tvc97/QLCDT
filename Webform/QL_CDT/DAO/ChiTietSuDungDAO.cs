using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CDT.DAO
{
    class ChiTietSuDungDAO
    {
        QL_CDTEntities db = new QL_CDTEntities();
        CHITIETSD tts = new CHITIETSD();

        public static List<CHITIETSD> LoadCTSD()
        {
            QL_CDTEntities db = new QL_CDTEntities();
            var result = (
                from t in db.CHITIETSDs
                select new
                {
                    ID = t.ID,
                    IDSIM = t.IDSIM,
                    TGBD = t.TGBD,
                    TGKT = t.TGKT,
                    SOPHUTSD = t.SOPHUTSD,
                    CUOCPHI = t.CUOCPHI
                }).ToList();
            List<CHITIETSD> listReturn = new List<CHITIETSD>();

            foreach (var item in result)
            {
                CHITIETSD kh_list = new CHITIETSD();

                kh_list.ID = item.ID;
                kh_list.IDSIM = item.IDSIM;
                kh_list.TGBD = item.TGBD;
                kh_list.TGKT = item.TGKT;
                kh_list.SOPHUTSD = item.SOPHUTSD;
                kh_list.CUOCPHI = item.CUOCPHI;

                listReturn.Add(kh_list);
            }


            return listReturn;
        }


        public void AddCTSD(CHITIETSD t)
        {
            db.CHITIETSDs.Add(t);
            db.SaveChanges();
        }

        public void EditCTSD(CHITIETSD t)
        {
            this.tts = (from c in db.CHITIETSDs
                        where c.ID == t.ID
                        select c).Single();

            this.tts.ID = t.ID;
            this.tts.TGBD = t.TGBD;
            this.tts.TGKT = t.TGKT;
            this.tts.SOPHUTSD = t.SOPHUTSD;
            this.tts.CUOCPHI = t.CUOCPHI;


            db.SaveChanges();
        }

        public CHITIETSD GetByID(int id)
        {
            return db.CHITIETSDs.Single(c => c.ID == id);
        }

        public void DeleteCTSD(int id)
        {
            CHITIETSD t = new CHITIETSD();
            t = db.CHITIETSDs.Single(c => c.ID == id);
            db.CHITIETSDs.Remove(t);
            db.SaveChanges();
        }

        public void CleanAll()
        {
            foreach(CHITIETSD ctsd in db.CHITIETSDs)
            {
                db.CHITIETSDs.Remove(ctsd);
            }
            db.SaveChanges();
        }
    }
}
