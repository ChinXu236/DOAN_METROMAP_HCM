using MetroMap_HCM.BUS;
using MetroMap_HCM.DAL;
using MeTroMap_HCM;
using System;
using System.Linq;
using System.Windows.Forms;


namespace MetroMap_HCM
{
    public partial class frmDatVe : Form
    {
        private readonly TuyenService _tuyenService = new TuyenService();
        private readonly GaService _gaService = new GaService();
        private readonly Model1 db = new Model1(); // EF context
        private readonly DijkstraService dijkstraService = new DijkstraService();

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            // Load danh sách tuyến
            var tuyenList = db.Tuyens
                .Select(t => new { t.MaTuyen, t.TenTuyen })
                .ToList();

            cboTuyen.DataSource = tuyenList;
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
            cboTuyen.SelectedIndex = -1;

            // Sự kiện khi chọn số lượng vé
            numSoLuong.ValueChanged += (s, ev) => CapNhatGiaVe();
        }

        private void cboTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null) return;

            string maTuyen = cboTuyen.SelectedValue.ToString();
            var gaList = db.Gas
                .Where(g => g.MaTuyen == maTuyen)
                .Select(g => new { g.MaGa, g.TenGa })
                .ToList();

            cboGaDi.DataSource = gaList.ToList();
            cboGaDi.DisplayMember = "TenGa";
            cboGaDi.ValueMember = "MaGa";
            cboGaDi.SelectedIndex = -1;

            cboGaDen.DataSource = gaList.ToList();
            cboGaDen.DisplayMember = "TenGa";
            cboGaDen.ValueMember = "MaGa";
            cboGaDen.SelectedIndex = -1;

            // Gắn sự kiện SelectedIndexChanged
            cboGaDi.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboGaDen.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
        }

        // Hàm tính và cập nhật giá vé
        private void CapNhatGiaVe()
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null)
            {
                giaVe.Text = "";
                return;
            }

            string gaDi = cboGaDi.SelectedValue.ToString();
            string gaDen = cboGaDen.SelectedValue.ToString();

            if (gaDi == gaDen)
            {
                giaVe.Text = "Ga đi và ga đến trùng nhau!";
                return;
            }

            try
            {
                // Tính khoảng cách
                double distance = dijkstraService.RunDijkstra(gaDi, gaDen);

                if (double.IsInfinity(distance))
                {
                    giaVe.Text = "Không có đường đi!";
                    return;
                }

                int soLuong = (int)numSoLuong.Value;

                // Giá vé 1 km = 2.000 VND
                double giaVeTien = distance * 2000 * soLuong;

                // Hiển thị tổng tiền
                giaVe.Text = string.Format("{0:N0} VND", giaVeTien);
            }
            catch (Exception ex)
            {
                giaVe.Text = "Lỗi tính giá: " + ex.Message;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maVe = "VE" + DateTime.Now.Ticks.ToString().Substring(10);
            string gaDi = cboGaDi.Text;
            string gaDen = cboGaDen.Text;
            int soLuong = (int)numSoLuong.Value;

            // ✅ Tính khoảng cách bằng Dijkstra
            double distance = dijkstraService.RunDijkstra(cboGaDi.SelectedValue.ToString(), cboGaDen.SelectedValue.ToString());

            if (double.IsInfinity(distance))
            {
                MessageBox.Show("Không có đường đi giữa hai ga!", "Thông báo");
                return;
            }

            // ✅ Tính giá vé
            double giaVe = distance * 2000 * soLuong; // nhân với số lượng vé

            // Truyền giá vé vào form thanh toán
            frmThanhToan frm = new frmThanhToan(maVe, gaDi, gaDen, soLuong, giaVe);
            frm.ShowDialog();
        }
    }
}