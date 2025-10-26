using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MetroMap_HCM.DAL;

namespace MetroMap_HCM.BUS
{
    public class GaService
    {
        public List<Ga> GetAll()
        {
            using (var db = new Model1())
            {
                return db.Gas
                         .Include(g => g.Tuyen)  // nếu muốn thông tin Tuyen
                         .OrderBy(g => g.MaGa)
                         .ToList();
            }
        }

        public Ga GetById(string maGa)
        {
            using (var db = new Model1())
            {
                return db.Gas.Find(maGa);
            }
        }

        public void Add(Ga g)
        {
            using (var db = new Model1())
            {
                db.Gas.Add(g);
                db.SaveChanges();
            }
        }

        public void Update(Ga g)
        {
            using (var db = new Model1())
            {
                var old = db.Gas.Find(g.MaGa);
                if (old == null) throw new Exception("Ga khong ton tai");
                old.TenGa = g.TenGa;
                old.MaTuyen = g.MaTuyen;
                old.ThuTu = g.ThuTu;
                db.SaveChanges();
            }
        }

        public void Delete(string maGa)
        {
            using (var db = new Model1())
            {
                var g = db.Gas.Find(maGa);
                if (g != null)
                {
                    db.Gas.Remove(g);
                    db.SaveChanges();
                }
            }
        }
        public List<Ga> GetByTuyen(string maTuyen)
        {
            using (var db = new Model1())
            {
                return db.Gas.Where(g => g.MaTuyen == maTuyen)
                             .OrderBy(g => g.ThuTu)
                             .ToList();
            }
        }

    }
}
