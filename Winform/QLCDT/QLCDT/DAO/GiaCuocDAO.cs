using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCDT.DAO
{
    class GiaCuocDAO
    {
        QLCDTEntities db = new QLCDTEntities();
        GIACUOC tts = new GIACUOC();

        public static List<GIACUOC> LoadGiaCuoc()
        {
            QLCDTEntities db = new QLCDTEntities();
            var result = (
                from t in db.GIACUOCs
                select new
                {
                    ID = t.ID,
                    TGBD = t.TGBD,
                    TGKT = t.TGKT,
                    GIACUOC = t.GIACUOC1
                }).ToList();
            List<GIACUOC> listReturn = new List<GIACUOC>();

            foreach (var item in result)
            {
                GIACUOC kh_list = new GIACUOC();

                kh_list.ID = item.ID;
                kh_list.TGBD = item.TGBD;
                kh_list.TGKT = item.TGKT;
                kh_list.GIACUOC1 = item.GIACUOC;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }


        public void AddGiaCuoc(GIACUOC t)
        {
            db.GIACUOCs.Add(t);
            db.SaveChanges();
        }

        public void EditGiaCuoc(GIACUOC t)
        {
            this.tts = (from c in db.GIACUOCs
                        where c.ID == t.ID
                        select c).Single();

            this.tts.ID = t.ID;
            this.tts.TGBD = t.TGBD;
            this.tts.TGKT = t.TGKT;
            this.tts.GIACUOC1 = t.GIACUOC1;

            db.SaveChanges();
        }

        public GIACUOC GetByID(int id)
        {
            return db.GIACUOCs.Single(c => c.ID == id);
        }

        public void DeleteGiaCuoc(int id)
        {
            GIACUOC t = new GIACUOC();
            t = db.GIACUOCs.Single(c => c.ID == id);
            db.GIACUOCs.Remove(t);
            db.SaveChanges();
        }
    }
}
