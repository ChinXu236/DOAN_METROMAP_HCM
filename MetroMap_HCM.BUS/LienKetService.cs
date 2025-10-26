using System;
using System.Collections.Generic;
using System.Linq;
using MetroMap_HCM.DAL;

namespace MetroMap_HCM.BUS
{
    public class LienKetService
    {
        public List<LienKet> GetAll()
        {
            using (var db = new Model1())
            {
                return db.LienKets.ToList();
            }
        }

        public bool Exists(string g1, string g2)
        {
            using (var db = new Model1())
            {
                return db.LienKets.Any(x => x.MaGa1 == g1 && x.MaGa2 == g2);
            }
        }

        public void Add(LienKet lk)
        {
            using (var db = new Model1())
            {
                if (!Exists(lk.MaGa1, lk.MaGa2))
                {
                    db.LienKets.Add(lk);
                    db.SaveChanges();
                }
                else throw new Exception("Lien ket da ton tai");
            }
        }

        public void Update(LienKet lk)
        {
            using (var db = new Model1())
            {
                var old = db.LienKets.Find(lk.ID);
                if (old == null) throw new Exception("Khong tim thay lien ket");
                old.KhoangCach = lk.KhoangCach;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new Model1())
            {
                var e = db.LienKets.Find(id);
                if (e != null)
                {
                    db.LienKets.Remove(e);
                    db.SaveChanges();
                }
            }
        }
    }
}
