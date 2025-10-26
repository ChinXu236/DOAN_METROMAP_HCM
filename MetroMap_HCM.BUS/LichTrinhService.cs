using MetroMap_HCM.DAL;
using System.Collections.Generic;
using System.Linq;

namespace MetroMap_HCM.BUS
{
    public class LichTrinhService
    {
        private readonly Model1 db = new Model1();

        public List<LichTrinh> GetAll()
        {
            return db.LichTrinhs.ToList();
        }

        public List<LichTrinh> GetByTuyen(string maTuyen)
        {
            return db.LichTrinhs.Where(l => l.MaTuyen == maTuyen).ToList();
        }
    }
}
