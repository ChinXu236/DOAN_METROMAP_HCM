using MetroMap_HCM.DAL;
using System.Collections.Generic;
using System.Linq;

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
        private readonly Model1 db = new Model1();

        // Hàm này chạy thuật toán Dijkstra để tìm khoảng cách ngắn nhất giữa 2 ga
        public double RunDijkstra(string gaDi, string gaDen)
        {
            // graph: lưu danh sách kề theo mã ga và khoảng cách
            var graph = new Dictionary<string, List<(string neighbor, double distance)>>();

            // Duyệt toàn bộ bảng Liên Kết
            foreach (var lk in db.LienKets.Include("Ga1").Include("Ga2").ToList())
            {
                if (lk.Ga1 == null || lk.Ga2 == null) continue; // bỏ qua dòng bị thiếu dữ liệu

                string maGa1 = lk.Ga1.MaGa;
                string maGa2 = lk.Ga2.MaGa;
                double kc = lk.KhoangCach ?? 0;

                if (!graph.ContainsKey(maGa1))
                    graph[maGa1] = new List<(string neighbor, double distance)>();
                if (!graph.ContainsKey(maGa2))
                    graph[maGa2] = new List<(string neighbor, double distance)>();

                graph[maGa1].Add((maGa2, kc));
                graph[maGa2].Add((maGa1, kc));
            }


            // Tạo danh sách lưu khoảng cách
            var dist = graph.Keys.ToDictionary(k => k, k => double.MaxValue);
            var visited = new HashSet<string>();
            dist[gaDi] = 0;

            while (visited.Count < graph.Count)
            {
                var u = dist
                    .Where(x => !visited.Contains(x.Key))
                    .OrderBy(x => x.Value)
                    .Select(x => x.Key)
                    .FirstOrDefault();

                if (u == null || u == gaDen)
                    break;

                visited.Add(u);

                foreach (var (neighbor, d) in graph[u])
                {
                    if (dist[u] + d < dist[neighbor])
                        dist[neighbor] = dist[u] + d;
                }
            }

            return dist.ContainsKey(gaDen) ? dist[gaDen] : double.MaxValue;
        }
    }
}