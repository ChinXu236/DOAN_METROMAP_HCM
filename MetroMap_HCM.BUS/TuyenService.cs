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
                return db.Tuyens
                         .Include(t => t.LichTrinhs) // load các lịch trình nếu cần
                         .OrderBy(t => t.MaTuyen)
                         .ToList();
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
                // ⚠️ Kiểm tra trùng mã tuyến trước khi thêm
                bool exists = db.Tuyens.Any(x => x.MaTuyen.Equals(t.MaTuyen, StringComparison.OrdinalIgnoreCase));
                if (exists)
                    throw new Exception($"Mã tuyến '{t.MaTuyen}' đã tồn tại! Vui lòng nhập mã khác.");

                db.Tuyens.Add(t);
                db.SaveChanges();
            }
        }

        public void Update(Tuyen t)
        {
            using (var db = new Model1())
            {
                var old = db.Tuyens.Find(t.MaTuyen);
                if (old == null)
                    throw new Exception("Tuyến không tồn tại!");

                old.TenTuyen = t.TenTuyen;
                old.MoTa = t.MoTa;
                db.SaveChanges();
            }
        }

        public void Delete(string ma)
        {
            using (var db = new Model1())
            {
                var tuyen = db.Tuyens.Find(ma);
                if (tuyen == null)
                    throw new Exception("Không tìm thấy tuyến để xóa!");

                // Kiểm tra xem tuyến có ga hay lịch trình không
                bool coGa = db.Gas.Any(g => g.MaTuyen == ma);
                bool coLichTrinh = db.LichTrinhs.Any(l => l.MaTuyen == ma);
                if (coGa || coLichTrinh)
                    throw new Exception("Không thể xóa tuyến này vì đang chứa ga hoặc lịch trình!");

                db.Tuyens.Remove(tuyen);
                db.SaveChanges();
            }
        }
    }
}
