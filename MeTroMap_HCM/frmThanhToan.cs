using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace MeTroMap_HCM
{
    public partial class frmThanhToan : Form
    {

        private readonly string _maVe;
        private readonly string _gaDi;
        private readonly string _gaDen;
        private readonly int _soLuong;
        private readonly double _giaVe;
        private int _thoiGianConLai = 300; // 5 phút = 300 giây
        private Timer timerDemNguoc;

        // ✅ Truyền giá vé từ frmDatVe
        public frmThanhToan(string maVe, string gaDi, string gaDen, int soLuong, double giaVe)
        {
            InitializeComponent();

            _maVe = maVe;
            _gaDi = gaDi;
            _gaDen = gaDen;
            _soLuong = soLuong;
            _giaVe = giaVe; // giờ được truyền đúng
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin vé
            lblMaVe.Text = "Mã vé: " + _maVe;
            lblGaDi.Text = "Ga đi: " + _gaDi;
            lblGaDen.Text = "Ga đến: " + _gaDen;
            lblSoLuong.Text = "Số lượng vé: " + _soLuong;
            lblGiaVe.Text = "Giá vé: " + _giaVe.ToString("N0") + " VNĐ";

            // === Tạo mã QR ===
            string qrContent = $"MAVE:{_maVe}\nGA DI:{_gaDi}\nGA DEN:{_gaDen}\nSO LUONG:{_soLuong}\nGIA VE:{_giaVe:N0}";
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrData = qrGenerator.CreateQrCode(qrContent, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrData);
            picQR.Image = qrCode.GetGraphic(6);

            // === Đếm ngược 5 phút ===
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
            MessageBox.Show("Thanh toán thành công! Cảm ơn bạn đã sử dụng MetroMap.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}