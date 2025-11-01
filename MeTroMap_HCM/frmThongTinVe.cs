using System;
using System.Windows.Forms;

namespace MeTroMap_HCM
{
    public partial class frmThongTinVe : Form
    {
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
            lblMaVe.Text = $"Mã vé: {_maVe}";
            lblTuyenDi.Text = $"Tuyến: {_tuyenDi}";
            lblTuyenDen.Text = $"Tuyến: {_tuyenDen}";
            lblGaDi.Text = $"Ga đi: {_gaDi}";
            lblGaDen.Text = $"Ga đến: {_gaDen}";
            lblLoaiVe.Text = $"Loại vé: {_loaiVe}";
            lblGiaVe.Text = $"Giá vé: {_giaVe:N0} VNĐ";

            if (_loaiVe.ToLower().Contains("vé thường") || _loaiVe.ToLower().Contains("1 lần"))
            {
                lblNgayBatDau.Text = lblNgayHetHan.Text = "-";
                btnGiaHan.Enabled = false;
                lblTrangThai.Text = "Trạng thái: Vé sử dụng 1 lần";
            }
            else
            {
                lblNgayBatDau.Text = $"Ngày bắt đầu: {_ngayBatDau:dd/MM/yyyy}";
                lblNgayHetHan.Text = $"Ngày hết hạn: {_ngayHetHan:dd/MM/yyyy}";
                btnGiaHan.Enabled = true;
                lblTrangThai.Text = "Trạng thái: Còn hạn ✅";
            }
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (!btnGiaHan.Enabled) return;

            // Xác định số ngày, tháng, năm dựa trên loại vé
            int soNgay = 0, soThang = 0;
            bool giaHanNam = false;

            string loaiVeLower = _loaiVe.ToLower();

            if (loaiVeLower.Contains("ngày"))
            {
                soNgay = 1;
            }
            else if (loaiVeLower.Contains("tháng"))
            {
                if (loaiVeLower.Contains("3 tháng")) soThang = 3;
                else if (loaiVeLower.Contains("6 tháng")) soThang = 6;
                else soThang = 1; // vé 1 tháng
            }
            else if (loaiVeLower.Contains("năm"))
            {
                giaHanNam = true;
            }

            // Xác nhận gia hạn
            if (MessageBox.Show($"Bạn có muốn gia hạn vé {_maVe}?", "Gia hạn", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            // Tạo QR cho thanh toán gia hạn
            string bankCode = "BIDV";
            string accountNo = "8851532871";
            string accountName = "LE DOAN VAN TU";
            string note = $"Gia hạn vé {_maVe}";
            string qrUrl = $"https://img.vietqr.io/image/{bankCode}-{accountNo}-compact2.png" +
                           $"?accountName={Uri.EscapeDataString(accountName)}&amount={_giaVe}&addInfo={Uri.EscapeDataString(note)}";

            // Tính ngày bắt đầu và hết hạn mới
            DateTime ngayBatDauMoi = _ngayHetHan.AddDays(1);
            DateTime ngayHetHanMoi;

            if (soNgay > 0)
            {
                ngayHetHanMoi = ngayBatDauMoi.AddDays(soNgay - 1);
            }
            else if (soThang > 0)
            {
                ngayHetHanMoi = ngayBatDauMoi.AddMonths(soThang).AddDays(-1);
            }
            else if (giaHanNam)
            {
                ngayHetHanMoi = ngayBatDauMoi.AddYears(1).AddDays(-1);
            }
            else
            {
                // Nếu không xác định được loại vé, giữ nguyên
                ngayHetHanMoi = _ngayHetHan;
            }

            // Mở form thanh toán
            frmThanhToan frmTT = new frmThanhToan(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, 1, _loaiVe, _giaVe, qrUrl, ngayBatDauMoi, ngayHetHanMoi);
            if (frmTT.ShowDialog(this) == DialogResult.OK)
            {
                // Cập nhật ngày bắt đầu và hết hạn sau khi thanh toán thành công
                _ngayBatDau = ngayBatDauMoi;
                _ngayHetHan = ngayHetHanMoi;

                LoadThongTinVe();
                lblTrangThai.Text = "Đã gia hạn ✅";
                ThongTinVeCapNhat?.Invoke(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe, _giaVe, _ngayBatDau, _ngayHetHan);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy vé này không?", "Xác nhận hủy vé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                lblTrangThai.Text = "Đã hủy ❌";
                lblNgayBatDau.Text = lblNgayHetHan.Text = "-";
                _maVe = _tuyenDi = _tuyenDen = _gaDi = _gaDen = _loaiVe = null;
                _giaVe = 0;
                _ngayBatDau = _ngayHetHan = DateTime.MinValue;

                ThongTinVeCapNhat?.Invoke(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe, _giaVe, _ngayBatDau, _ngayHetHan);
            }
        }
    }
}
