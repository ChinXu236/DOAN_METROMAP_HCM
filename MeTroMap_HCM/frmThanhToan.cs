using MetroMap_HCM;
using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeTroMap_HCM
{
    public partial class frmThanhToan : Form
    {
        private readonly string _maVe;
        private readonly string _tuyenDi;
        private readonly string _tuyenDen;
        private readonly string _gaDi;
        private readonly string _gaDen;
        private readonly int _soLuong;
        private readonly string _loaiVe;
        private readonly double _giaVe;
        private readonly string _qrText;
        private int _thoiGianConLai = 300;
        private Timer timerDemNguoc;

        public frmThanhToan(string maVe, string tuyenDi, string tuyenDen,
            string gaDi, string gaDen, int soLuong, string loaiVe, double giaVe, string qrText)
        {
            InitializeComponent();
            _maVe = maVe;
            _tuyenDi = tuyenDi;
            _tuyenDen = tuyenDen;
            _gaDi = gaDi;
            _gaDen = gaDen;
            _soLuong = soLuong;
            _loaiVe = loaiVe;
            _giaVe = giaVe;
            _qrText = qrText;
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lblMaVe.Text = "Mã vé: " + _maVe;
            lblTuyenDi.Text = "Tuyến đi: " + _tuyenDi;
            lblTuyenDen.Text = "Tuyến đến: " + _tuyenDen;
            lblGaDi.Text = "Ga đi: " + _gaDi;
            lblGaDen.Text = "Ga đến: " + _gaDen;
            lblSoLuong.Text = "Số lượng: " + _soLuong;
            lblLoai.Text = "Loại vé: " + _loaiVe;
            lblGia.Text = "Giá vé: " + _giaVe.ToString("N0") + " VNĐ";

            try
            {
                picQR.SizeMode = PictureBoxSizeMode.Zoom;
                picQR.Load(_qrText); // _qrText là qrUrl từ frmDatVe
            }
            catch
            {
                MessageBox.Show("Không thể tạo QR.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Timer đếm ngược
            timerDemNguoc = new Timer();
            timerDemNguoc.Interval = 1000;
            timerDemNguoc.Tick += TimerDemNguoc_Tick;
            timerDemNguoc.Start();
            lblDemNguoc.Text = "⏰ Còn lại: 05:00";
        }

        private void TimerDemNguoc_Tick(object sender, EventArgs e)
        {
            _thoiGianConLai--;
            int minutes = _thoiGianConLai / 60;
            int seconds = _thoiGianConLai % 60;
            lblDemNguoc.Text = $"⏰ Còn lại: {minutes:D2}:{seconds:D2}";

            if (_thoiGianConLai <= 0)
            {
                timerDemNguoc.Stop();
                MessageBox.Show("Hết hạn thanh toán! Vé đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            timerDemNguoc.Stop();
            MessageBox.Show("Thanh toán thành công! Cảm ơn bạn đã sử dụng MetroMap.",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Lấy form chính (frmMain) đang mở
            var mainForm = Application.OpenForms["frmMain"] as frmMain;
            if (mainForm != null)
            {
                // Gửi thông tin vé về form chính
                mainForm.LuuThongTinVe(_maVe, _tuyenDi, _tuyenDen, _gaDi, _gaDen, _loaiVe, _giaVe);
            }

            this.Close(); // Đóng form thanh toán
        }

        private void lblDemNguoc_Click(object sender, EventArgs e)
        {

        }
    }
}
