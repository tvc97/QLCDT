using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CDT.DAO
{
    class SimDAO
    {
        QL_CDTEntities db = new QL_CDTEntities();
        THONGTINSIM tts = new THONGTINSIM();

        public static List<THONGTINSIM> LoadTTS()
        {
            QL_CDTEntities db = new QL_CDTEntities();
            var result = (
                from t in db.THONGTINSIMs
                select new
                {
                    IDSIM = t.IDSIM,
                    SDT = t.SDT,
                    TINHTRANG = t.TINHTRANG
                }).ToList();
            List<THONGTINSIM> listReturn = new List<THONGTINSIM>();

            foreach (var item in result)
            {
                THONGTINSIM kh_list = new THONGTINSIM();

                kh_list.IDSIM = item.IDSIM;
                kh_list.SDT = item.SDT;
                kh_list.TINHTRANG = item.TINHTRANG;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }

        public static List<THONGTINSIM> LoadNotUsedTTS()
        {
            QL_CDTEntities db = new QL_CDTEntities();
            var result = (
                from t in db.THONGTINSIMs
                where !(
                    from w in db.HDDKs
                    select w.IDSIM
                ).Contains(t.IDSIM)
                select new
                {
                    IDSIM = t.IDSIM,
                    SDT = t.SDT,
                    TINHTRANG = t.TINHTRANG
                }).ToList();
            List<THONGTINSIM> listReturn = new List<THONGTINSIM>();

            foreach (var item in result)
            {
                THONGTINSIM kh_list = new THONGTINSIM();

                kh_list.IDSIM = item.IDSIM;
                kh_list.SDT = item.SDT;
                kh_list.TINHTRANG = item.TINHTRANG;

                listReturn.Add(kh_list);
            }

            return listReturn;
        }


        public void AddTTS(THONGTINSIM t)
        {
            db.THONGTINSIMs.Add(t);
            db.SaveChanges();
        }

        public void EditTTS(THONGTINSIM t)
        {
            this.tts = (from c in db.THONGTINSIMs
                       where c.IDSIM == t.IDSIM
                        select c).Single();

            this.tts.IDSIM = t.IDSIM;
            this.tts.SDT = t.SDT;
            this.tts.TINHTRANG = t.TINHTRANG;

            db.SaveChanges();
        }

        public THONGTINSIM GetByID(string id)
        {
            return db.THONGTINSIMs.Single(c => c.IDSIM == id);
        }

        public void DeleteTTS(string id)
        {
            THONGTINSIM t = new THONGTINSIM();
            t = db.THONGTINSIMs.Single(c => c.IDSIM == id);
            db.THONGTINSIMs.Remove(t);
            db.SaveChanges();
        }

        public THONGTINSIM GetRandom()
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            int toSkip = rand.Next(0, db.THONGTINSIMs.Count());

            return db.THONGTINSIMs.OrderBy(x => x.IDSIM).Skip(toSkip).Take(1).First();
        }
    }
}
