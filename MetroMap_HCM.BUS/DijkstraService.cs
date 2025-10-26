using MetroMap_HCM.DAL;
using System.Collections.Generic;

namespace MetroMap_HCM.BUS
{
    public class DijkstraService
    {
        public double TinhKhoangCach(string maGa1, string maGa2)
        {
            return Dijkstra.TinhKhoangCach(maGa1, maGa2);
        }

        public List<string> TimDuong(string gaDau, string gaCuoi)
        {
            return Dijkstra.TimDuongNganNhat(gaDau, gaCuoi);
        }
    }
}
