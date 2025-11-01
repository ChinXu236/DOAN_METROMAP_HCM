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
        private double _tyLeGiamGia = 0;

        private string _maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe;
        private double _giaVe;
        private DateTime _ngayBatDau, _ngayHetHan;

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            LoadTuyenDi();
            LoadTuyenDen();
            LoadLoaiVe();
            LoadGiamGia();

            cboTuyenDi.SelectedIndexChanged += CboTuyenDi_SelectedIndexChanged;
            cboTuyenDen.SelectedIndexChanged += CboTuyenDen_SelectedIndexChanged;
            cboGaDi.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboGaDen.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboLoai.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
            cboGG.SelectedIndexChanged += (s, ev) => CapNhatGiaVe();
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

        private void LoadGiamGia()
        {
            cboGG.Items.Clear();
            cboGG.Items.Add("Không giảm giá");
            cboGG.Items.Add("Học sinh / Sinh viên - 50%");
            cboGG.Items.Add("Công chức - 10%");
            cboGG.Items.Add("Người lớn tuổi - 40%");
            cboGG.Items.Add("Người khuyết tật - 100%");
            cboGG.Items.Add("Thương binh / Liệt sĩ - 100%");
            cboGG.Items.Add("Nhân viên Metro - 70%");
            cboGG.SelectedIndex = 0;
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

            _gaDi = cboGaDi.SelectedValue.ToString();
            _gaDen = cboGaDen.SelectedValue.ToString();
            _loaiVe = cboLoai.SelectedItem.ToString();
            _tuyenDi = cboTuyenDi.Text;
            _tuyenDen = cboTuyenDen.Text;

            if (_gaDi == _gaDen && _loaiVe == "Vé thường")
            {
                txtGiave.Text = "Ga đi và ga đến trùng nhau!";
                _giaVeHienTai = 0;
                return;
            }

            if (_loaiVe == "Vé ngày - 40k" && cboTuyenDi.SelectedValue.ToString() != cboTuyenDen.SelectedValue.ToString())
            {
                txtGiave.Text = "Vé ngày chỉ được đi trên cùng 1 tuyến!";
                _giaVeHienTai = 0;
                return;
            }

            double giaVeCoBan = 0;
            double phiDoiTuyen = 0;
            int soTuyenDoi = TinhSoTuyenDoi(cboTuyenDi.SelectedValue.ToString(), cboTuyenDen.SelectedValue.ToString());

            switch (_loaiVe)
            {
                case "Vé thường": giaVeCoBan = dijkstraService.RunDijkstra(_gaDi, _gaDen) * 2000; break;
                case "Vé ngày - 40k": giaVeCoBan = 40000; break;
                case "Vé tháng - 300k": giaVeCoBan = 300000; break;
                case "Vé 3 tháng - 900k": giaVeCoBan = 900000; break;
                case "Vé 6 tháng - 1800k": giaVeCoBan = 1800000; break;
                case "Vé 1 năm - 3600k": giaVeCoBan = 3600000; break;
            }

            if (_loaiVe != "Vé thường" && _loaiVe != "Vé ngày - 40k")
            {
                switch (soTuyenDoi)
                {
                    case 1: phiDoiTuyen = 150000; break;
                    case 2: phiDoiTuyen = 250000; break;
                    case 3: phiDoiTuyen = 200000; break;
                    default: phiDoiTuyen = 0; break;
                }
            }

            double giaGoc = giaVeCoBan + phiDoiTuyen;

            switch (cboGG.SelectedIndex)
            {
                case 1: _tyLeGiamGia = 0.50; break;
                case 2: _tyLeGiamGia = 0.10; break;
                case 3: _tyLeGiamGia = 0.40; break;
                case 4: _tyLeGiamGia = 1.00; break;
                case 5: _tyLeGiamGia = 1.00; break;
                case 6: _tyLeGiamGia = 0.70; break;
                default: _tyLeGiamGia = 0; break;
            }

            _giaVeHienTai = giaGoc * (1 - _tyLeGiamGia);
            _giaVe = _giaVeHienTai;

            txtGiave.Text = phiDoiTuyen > 0
                ? $"Giá cơ bản: {giaVeCoBan:N0} VND + Phí đổi tuyến: {phiDoiTuyen:N0} VND = {giaGoc:N0} VND\nGiảm giá: {_tyLeGiamGia * 100}% → Còn lại: {_giaVeHienTai:N0} VND"
                : $"Giá cơ bản: {giaVeCoBan:N0} VND\nGiảm giá: {_tyLeGiamGia * 100}% → Còn lại: {_giaVeHienTai:N0} VND";
        }

        private int TinhSoTuyenDoi(string tuyenDi, string tuyenDen)
        {
            if (tuyenDi == tuyenDen) return 0;
            string[] allTuyen = { "T1", "T2", "T3", "T4" };
            int idxDi = Array.IndexOf(allTuyen, tuyenDi);
            int idxDen = Array.IndexOf(allTuyen, tuyenDen);
            return (idxDi < 0 || idxDen < 0) ? 1 : Math.Abs(idxDi - idxDen);
        }

        private void BtnDatVe_Click(object sender, EventArgs e)
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null || cboLoai.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đủ thông tin hợp lệ!", "Thông báo");
                return;
            }

            if (_loaiVe == "Vé ngày - 40k" && cboTuyenDi.SelectedValue.ToString() != cboTuyenDen.SelectedValue.ToString())
            {
                MessageBox.Show("Vé ngày chỉ được đi trên cùng 1 tuyến!", "Thông báo");
                return;
            }

            Random rnd = new Random();
            _maVe = "VE" + DateTime.Now.Ticks.ToString().Substring(10) + rnd.Next(100, 999);
            _ngayBatDau = DateTime.Now;
            _ngayHetHan = _ngayBatDau.AddDays(30);

            string bankCode = "BIDV";
            string accountNo = "8851532871";
            string accountName = "LE DOAN VAN TU";
            decimal amount = (decimal)_giaVe;
            string note = $"Thanh toán vé {_maVe} - {_tuyenDi} -> {_tuyenDen}";
            string qrUrl = $"https://img.vietqr.io/image/{bankCode}-{accountNo}-compact2.png" +
                           $"?accountName={Uri.EscapeDataString(accountName)}&amount={amount}&addInfo={Uri.EscapeDataString(note)}";

            frmThanhToan frmTT = new frmThanhToan(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen,
                                                  1, _loaiVe, _giaVe, qrUrl, _ngayBatDau, _ngayHetHan);
            frmTT.ShowDialog();
        }
    }
}
