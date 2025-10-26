using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MetroMap_HCM.DAL;

namespace MetroMap_HCM.BUS
{
    public class TuyenService
    {
        public List<Tuyen> GetAll()
        {
            using (var db = new Model1())
            {
                // Include để nạp collection Gas (tên property trong Tuyen là Gas)
                return db.Tuyens
                         .Include(t => t.Gas)   // eager load các Ga liên quan
                         .OrderBy(t => t.MaTuyen)
                         .ToList();             // materialize trước khi db.Dispose()
            }
        }

        public Tuyen GetById(string ma)
        {
            using (var db = new Model1())
            {
                return db.Tuyens.Find(ma);
            }
        }

        public void Add(Tuyen t)
        {
            using (var db = new Model1())
            {
                db.Tuyens.Add(t);
                db.SaveChanges();
            }
        }

        public void Update(Tuyen t)
        {
            using (var db = new Model1())
            {
                var old = db.Tuyens.Find(t.MaTuyen);
                if (old == null) throw new Exception("Tuyen khong ton tai");
                old.TenTuyen = t.TenTuyen;
                old.MoTa = t.MoTa;
                db.SaveChanges();
            }
        }

        public void Delete(string ma)
        {
            using (var db = new Model1())
            {
                var t = db.Tuyens.Find(ma);
                if (t != null)
                {
                    db.Tuyens.Remove(t);
                    db.SaveChanges();
                }
            }
        }
    }
}
