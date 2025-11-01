using System;
using System.Windows.Forms;

namespace MeTroMap_HCM
{
    public partial class frmThongTinVe : Form
    {
        // Event gửi dữ liệu cập nhật về Main
        public event Action<string, string, string, string, string, string, double, DateTime, DateTime> ThongTinVeCapNhat;

        private string _maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe;
        private double _giaVe;
        private DateTime _ngayBatDau, _ngayHetHan;

        public frmThongTinVe(string maVe, string tuyenDi, string tuyenDen,
                     string gaDi, string gaDen, string loaiVe, double giaVe,
                     DateTime ngayBatDau, DateTime ngayHetHan)
        {
            InitializeComponent();
            _maVe = maVe;
            _tuyenDi = tuyenDi;
            _tuyenDen = tuyenDen;
            _gaDi = gaDi;
            _gaDen = gaDen;
            _loaiVe = loaiVe;
            _giaVe = giaVe;
            _ngayBatDau = ngayBatDau;
            _ngayHetHan = ngayHetHan;

            LoadThongTinVe();
        }

        private void LoadThongTinVe()
        {
            lblMaVe.Text = "Mã vé: " + _maVe;
            lblTuyenDi.Text = $"Tuyến: {_tuyenDi} → {_tuyenDen}";
            lblGaDi.Text = $"Ga đi: {_gaDi}";
            lblGaDen.Text = $"Ga đến: {_gaDen}";
            lblLoaiVe.Text = "Loại vé: " + _loaiVe;
            lblGiaVe.Text = "Giá vé: " + _giaVe.ToString("N0") + " VNĐ";
            lblNgayBatDau.Text = "Ngày bắt đầu: " + _ngayBatDau.ToString("dd/MM/yyyy");
            lblNgayHetHan.Text = "Ngày hết hạn: " + _ngayHetHan.ToString("dd/MM/yyyy");
            lblTrangThai.Text = "Trạng thái: Còn hạn ✅";
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn gia hạn vé thêm 1 tháng không?",
                                "Gia hạn vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ngayBatDau = _ngayHetHan.AddDays(1);
                _ngayHetHan = _ngayHetHan.AddMonths(1);
                lblTrangThai.Text = "Trạng thái: Đã gia hạn ✅";
                LoadThongTinVe();

                // Gửi dữ liệu cập nhật về Main
                ThongTinVeCapNhat?.Invoke(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe, _giaVe, _ngayBatDau, _ngayHetHan);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_maVe) &&
                MessageBox.Show("Bạn có chắc muốn hủy vé này không?\n(Vé đã hủy sẽ không được hoàn lại tiền)",
                                "Xác nhận hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lblTrangThai.Text = "Trạng thái: Đã hủy ❌";
                lblNgayBatDau.Text = lblNgayHetHan.Text = "-";

                // Xóa dữ liệu nội bộ
                _maVe = _tuyenDi = _tuyenDen = _gaDi = _gaDen = _loaiVe = null;
                _giaVe = 0;
                _ngayBatDau = _ngayHetHan = DateTime.MinValue;

                // Gửi dữ liệu đã hủy về Main
                ThongTinVeCapNhat?.Invoke(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe, _giaVe, _ngayBatDau, _ngayHetHan);
            }
        }
    }
}
