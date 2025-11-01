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
        private readonly Model1 db = new Model1();
        private readonly DijkstraService dijkstraService = new DijkstraService();
        private double _giaVeHienTai = 0;

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            LoadTuyenDi();
            LoadTuyenDen();
            LoadLoaiVe();

            cboTuyenDi.SelectedIndexChanged += CboTuyenDi_SelectedIndexChanged;
            cboTuyenDen.SelectedIndexChanged += CboTuyenDen_SelectedIndexChanged;
            cboGaDi.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboGaDen.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboLoai.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            btnDatVe.Click += BtnDatVe_Click;
        }

        private void LoadTuyenDi()
        {
            var tuyenList = db.Tuyens.Select(t => new { t.MaTuyen, t.TenTuyen }).ToList();
            cboTuyenDi.DataSource = tuyenList;
            cboTuyenDi.DisplayMember = "TenTuyen";
            cboTuyenDi.ValueMember = "MaTuyen";
            cboTuyenDi.SelectedIndex = -1;
        }

        private void LoadTuyenDen()
        {
            var tuyenList = db.Tuyens.Select(t => new { t.MaTuyen, t.TenTuyen }).ToList();
            cboTuyenDen.DataSource = tuyenList;
            cboTuyenDen.DisplayMember = "TenTuyen";
            cboTuyenDen.ValueMember = "MaTuyen";
            cboTuyenDen.SelectedIndex = -1;
        }

        private void LoadLoaiVe()
        {
            cboLoai.Items.Clear();
            cboLoai.Items.Add("Vé thường");
            cboLoai.Items.Add("Vé ngày - 40k");
            cboLoai.Items.Add("Vé tháng - 300k");
            cboLoai.Items.Add("Vé 3 tháng - 900k");
            cboLoai.Items.Add("Vé 6 tháng - 1800k");
            cboLoai.Items.Add("Vé 1 năm - 3600k");
            cboLoai.SelectedIndex = 0;
        }

        private void CboTuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyenDi.SelectedValue == null) return;

            string maTuyenDi = cboTuyenDi.SelectedValue.ToString();
            var gaList = db.Gas.Where(g => g.MaTuyen == maTuyenDi)
                .Select(g => new { g.MaGa, g.TenGa }).ToList();

            cboGaDi.DataSource = gaList;
            cboGaDi.DisplayMember = "TenGa";
            cboGaDi.ValueMember = "MaGa";
            cboGaDi.SelectedIndex = -1;

            CapNhatGiaVe();
        }

        private void CboTuyenDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyenDen.SelectedValue == null) return;

            string maTuyenDen = cboTuyenDen.SelectedValue.ToString();
            var gaList = db.Gas.Where(g => g.MaTuyen == maTuyenDen)
                .Select(g => new { g.MaGa, g.TenGa }).ToList();

            cboGaDen.DataSource = gaList;
            cboGaDen.DisplayMember = "TenGa";
            cboGaDen.ValueMember = "MaGa";
            cboGaDen.SelectedIndex = -1;

            CapNhatGiaVe();
        }

        private void CapNhatGiaVe()
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null || cboLoai.SelectedItem == null)
            {
                txtGiave.Text = "";
                _giaVeHienTai = 0;
                return;
            }

            string gaDi = cboGaDi.SelectedValue.ToString();
            string gaDen = cboGaDen.SelectedValue.ToString();
            string loai = cboLoai.SelectedItem.ToString();

            if (gaDi == gaDen && loai == "Vé thường")
            {
                txtGiave.Text = "Ga đi và ga đến trùng nhau!";
                _giaVeHienTai = 0;
                return;
            }

            double giaVeCoBan = 0;
            double phiDoiTuyen = 0;
            int soTuyenDoi = (cboTuyenDi.SelectedValue.ToString() != cboTuyenDen.SelectedValue.ToString()) ? 1 : 0;

            switch (loai)
            {
                case "Vé thường":
                    giaVeCoBan = dijkstraService.RunDijkstra(gaDi, gaDen) * 2000;
                    break;
                case "Vé ngày - 40k":
                    giaVeCoBan = 40000;
                    phiDoiTuyen = soTuyenDoi * 20000;
                    break;
                case "Vé tháng - 300k":
                    giaVeCoBan = 300000;
                    phiDoiTuyen = soTuyenDoi * 150000;
                    break;
                case "Vé 3 tháng - 900k":
                    giaVeCoBan = 900000;
                    phiDoiTuyen = soTuyenDoi * 150000;
                    break;
                case "Vé 6 tháng - 1800k":
                    giaVeCoBan = 1800000;
                    phiDoiTuyen = soTuyenDoi * 150000;
                    break;
                case "Vé 1 năm - 3600k":
                    giaVeCoBan = 3600000;
                    phiDoiTuyen = soTuyenDoi * 150000;
                    break;
            }

            _giaVeHienTai = giaVeCoBan + phiDoiTuyen;

            txtGiave.Text = phiDoiTuyen > 0 ?
                $"Giá cơ bản: {giaVeCoBan:N0} VND + Phí đổi tuyến: {phiDoiTuyen:N0} VND = {_giaVeHienTai:N0} VND" :
                $"{_giaVeHienTai:N0} VND";
        }

        private void BtnDatVe_Click(object sender, EventArgs e)
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null || cboLoai.SelectedItem == null || _giaVeHienTai <= 0)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin hợp lệ!", "Thông báo");
                return;
            }

            Random rnd = new Random();
            string maVe = "VE" + DateTime.Now.Ticks.ToString().Substring(10) + rnd.Next(100, 999);

            string gaDi = cboGaDi.Text;
            string gaDen = cboGaDen.Text;
            string tuyenDi = cboTuyenDi.Text;
            string tuyenDen = cboTuyenDen.Text;
            string loaiVe = cboLoai.SelectedItem.ToString();
            int soLuong = 1;

            // Thông tin thanh toán VietQR BIDV
            string bankCode = "BIDV";
            string accountNo = "8851532871";
            string accountName = "LE DOAN VAN TU";
            decimal amount = (decimal)_giaVeHienTai;
            string note = $"Thanh toán vé {maVe} - {tuyenDi} -> {tuyenDen}";

            // URL QR trực tiếp
            string qrUrl = $"https://img.vietqr.io/image/{bankCode}-{accountNo}-compact2.png" +
                           $"?accountName={Uri.EscapeDataString(accountName)}" +
                           $"&amount={amount}" +
                           $"&addInfo={Uri.EscapeDataString(note)}";

            // Mở form thanh toán và hiện QR
            frmThanhToan frmTT = new frmThanhToan(
                maVe, tuyenDi, tuyenDen, gaDi, gaDen, soLuong, loaiVe, _giaVeHienTai, qrUrl);
            frmTT.ShowDialog();
        }
    }
}
