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
                         .Include(g => g.Tuyen)  // nếu muốn thông tin tuyến
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

        public void Add(Ga ga)
        {
            using (var db = new Model1())
            {
                db.Gas.Add(ga);
                db.SaveChanges();
            }
        }

        public void Update(Ga ga)
        {
            using (var db = new Model1())
            {
                var old = db.Gas.Find(ga.MaGa);
                if (old == null)
                    throw new Exception("Ga không tồn tại!");

                old.TenGa = ga.TenGa;
                old.MaTuyen = ga.MaTuyen;
                old.ThuTu = ga.ThuTu;
                db.SaveChanges();
            }
        }

        // ✅ CHỈ GIỮ LẠI 1 THAM SỐ MA GA
        public void Delete(string maGa)
        {
            using (var db = new Model1())
            {
                var ga = db.Gas.Find(maGa);
                if (ga == null)
                    throw new Exception("Không tìm thấy ga để xóa!");

                // Kiểm tra nếu ga đang tồn tại trong bảng Liên Kết
                bool coLienKet = db.LienKets.Any(lk => lk.MaGa1 == maGa || lk.MaGa2 == maGa);
                if (coLienKet)
                    throw new Exception("Không thể xóa ga này vì đang tồn tại trong bảng Liên Kết!");

                // Kiểm tra nếu ga có trong Lịch Trình
                bool coLichTrinh = db.LichTrinhs.Any(lt => lt.MaGa == maGa);
                if (coLichTrinh)
                    throw new Exception("Không thể xóa ga này vì đang được dùng trong Lịch Trình!");

                db.Gas.Remove(ga);
                db.SaveChanges();
            }
        }

        public List<Ga> GetByTuyen(string maTuyen)
        {
            using (var db = new Model1())
            {
                return db.Gas
                         .Where(g => g.MaTuyen == maTuyen)
                         .OrderBy(g => g.ThuTu)
                         .ToList();
            }
        }
    }
}
