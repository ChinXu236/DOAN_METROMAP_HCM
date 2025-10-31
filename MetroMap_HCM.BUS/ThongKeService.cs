using System.Collections.Generic;
using System.Linq;
using MetroMap_HCM.DAL;
namespace MetroMap_HCM.BUS
{
    public class ThongKeService
    {
        private readonly Model1 _context = new Model1();
        public List<ThongKeView> GetDoanhThuTheoThang(int thang)
        {
            // ⚠ Giả lập thống kê (sau này sẽ dựa vào bảng Vé) 
            var ds = _context.Tuyens.Select(t => new ThongKeView
            {
                TenTuyen = t.TenTuyen,
                SoVe = thang * 100 + t.MaTuyen.Length, // giả lập
                DoanhThu = (thang * 100 + t.MaTuyen.Length) * 15000
            }).ToList();

            return ds;
        }
        public class ThongKeView
        {
            public string TenTuyen { get; set; }
            public int SoVe { get; set; }
            public double DoanhThu { get; set; }
        }
    }
}