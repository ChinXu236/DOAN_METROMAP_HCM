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

        public void Delete(string maGa, string tenGa)
        {
            using (var db = new Model1())
            {
                Ga gaToDelete = null;

                // Nếu có mã ga thì tìm theo mã trước
                if (!string.IsNullOrEmpty(maGa))
                {
                    gaToDelete = db.Gas.Find(maGa);
                }

                // Nếu không có mã hoặc không tìm thấy, thử tìm theo tên ga
                if (gaToDelete == null && !string.IsNullOrEmpty(tenGa))
                {
                    gaToDelete = db.Gas.FirstOrDefault(x => x.TenGa == tenGa);
                }

                if (gaToDelete != null)
                {
                    db.Gas.Remove(gaToDelete);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Không tìm thấy ga để xóa!");
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
