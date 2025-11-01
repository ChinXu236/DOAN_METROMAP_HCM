using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroMap_HCM.DAL;

namespace MetroMap_HCM
{
    public partial class frmTimDuong : Form
    {
        private List<DoanDuong> selectedChiTiet;

        public frmTimDuong()
        {
            InitializeComponent();
            SetupDataGridView();
            RegisterEvents();
        }

        private void SetupDataGridView()
        {
            dgvLoTrinh.Columns.Clear();
            dgvLoTrinh.Columns.Add("STT", "STT");
            dgvLoTrinh.Columns.Add("GaDi", "Ga đi");
            dgvLoTrinh.Columns.Add("GaDen", "Ga đến");
            dgvLoTrinh.Columns.Add("Tuyen", "Tuyến");
            dgvLoTrinh.Columns.Add("KhoangCach", "Khoảng cách (km)");
            dgvLoTrinh.Columns.Add("GioXuatPhat", "Giờ xuất phát / Thông tin");

            dgvLoTrinh.ReadOnly = true;
            dgvLoTrinh.AllowUserToAddRows = false;
            dgvLoTrinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoTrinh.RowHeadersVisible = false;

            // Cột giờ xuất phát rộng hơn
            dgvLoTrinh.Columns["GioXuatPhat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoTrinh.Columns["GioXuatPhat"].MinimumWidth = 150;
            dgvLoTrinh.Columns["GioXuatPhat"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            dgvLoTrinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void RegisterEvents()
        {
            btnTimDuong.Click += BtnTimDuong_Click;
            btnDoiChieu.Click += BtnDoiChieu_Click;
            btnChiTiet.Click += BtnChiTiet_Click;
        }

        private void BtnDoiChieu_Click(object sender, EventArgs e)
        {
            (txtTu.Text, txtDen.Text) = (txtDen.Text, txtTu.Text);
        }

        // Biến toàn cục để lưu giờ xuất phát 5 chuyến tổng quan
        private List<TimeSpan> gioXuatPhatChuyen;

        private void BtnTimDuong_Click(object sender, EventArgs e)
        {
            string gaDi = txtTu.Text.Trim();
            string gaDen = txtDen.Text.Trim();

            if (string.IsNullOrEmpty(gaDi) || string.IsNullOrEmpty(gaDen))
            {
                MessageBox.Show("Nhập ga đi và ga đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ketQuaChiTiet = Dijkstra.TimDuongChiTiet(gaDi, gaDen);
            if (ketQuaChiTiet == null || ketQuaChiTiet.Count == 0)
            {
                MessageBox.Show("Không tìm thấy đường đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Lấy giờ xuất phát hoặc giờ đến
            bool coNhapGioXP = TimeSpan.TryParse(txtXP.Text.Trim(), out TimeSpan gioXPCanTim);
            
            bool coNhapGioD = TimeSpan.TryParse(txtD.Text.Trim(), out TimeSpan gioDCanTim);
            

            // Nếu không nhập cả hai, dùng giờ hiện tại
            if (!coNhapGioXP && !coNhapGioD)
            {
                gioXPCanTim = DateTime.Now.TimeOfDay;
            }

            // Giới hạn giờ hợp lệ: 05:00 -> 23:00
            TimeSpan gioDau = new TimeSpan(5, 0, 0);
            TimeSpan gioCuoi = new TimeSpan(23, 0, 0);

            if (coNhapGioXP)
            {
                if (gioXPCanTim < gioDau) gioXPCanTim = gioDau;
                if (gioXPCanTim > gioCuoi) gioXPCanTim = gioCuoi;
            }

            if (coNhapGioD)
            {
                if (gioDCanTim < gioDau) gioDCanTim = gioDau;
                if (gioDCanTim > gioCuoi) gioDCanTim = gioCuoi;
            }

            using (var db = new Model1())
            {
                var gaStart = db.Gas.FirstOrDefault(g => g.TenGa.Equals(gaDi, StringComparison.OrdinalIgnoreCase));
                if (gaStart == null)
                {
                    MessageBox.Show("Không tìm thấy ga xuất phát!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy lịch trình trong khung giờ hoạt động
                var danhSachLich = db.LichTrinhs
                    .Where(l => l.MaGa == gaStart.MaGa && l.GioXuatPhat >= gioDau && l.GioXuatPhat <= gioCuoi)
                    .OrderBy(l => l.GioXuatPhat)
                    .ToList();

                if (!danhSachLich.Any())
                {
                    MessageBox.Show("Không có lịch trình cho ga xuất phát trong giờ 05:00 - 23:00!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int tongPhut = ketQuaChiTiet.Sum(d => d.ThoiGianDenTiepTheo);

                // Nếu nhập giờ đến → lọc theo giờ đến
                if (coNhapGioD)
                {
                    danhSachLich = danhSachLich
                        .Where(l => l.GioXuatPhat.Add(TimeSpan.FromMinutes(tongPhut)) <= gioDCanTim)
                        .ToList();

                    if (!danhSachLich.Any())
                    {
                        MessageBox.Show("Không có chuyến nào kết thúc trước giờ nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Suy ra giờ xuất phát gần nhất (ngược lại từ giờ đến)
                    gioXPCanTim = gioDCanTim - TimeSpan.FromMinutes(tongPhut);
                }

                // Tìm chuyến gần nhất với giờ xuất phát
                var lichGanNhat = danhSachLich
                    .OrderBy(l => Math.Abs((l.GioXuatPhat - gioXPCanTim).TotalMinutes))
                    .FirstOrDefault();

                if (lichGanNhat == null) return;

                // Sinh 5 chuyến gần nhất
                List<LichTrinh> chuyenGanNhat5 = new List<LichTrinh>();
                TimeSpan gioHienTai = lichGanNhat.GioXuatPhat;

                for (int i = 0; i < 5; i++)
                {
                    var lich = danhSachLich.FirstOrDefault(l => l.GioXuatPhat >= gioHienTai);
                    if (lich != null)
                    {
                        chuyenGanNhat5.Add(lich);
                        gioHienTai = lich.GioXuatPhat.Add(new TimeSpan(0, 10, 0));
                    }
                }

                // Hiển thị kết quả
                dgvLoTrinh.Rows.Clear();
                int stt = 1;
                double tongKm = ketQuaChiTiet.Sum(d => d.KhoangCach);
                string cacTuyen = string.Join(", ", ketQuaChiTiet.Select(d => d.MaTuyen).Distinct());

                gioXuatPhatChuyen = new List<TimeSpan>();

                foreach (var lich in chuyenGanNhat5)
                {
                    dgvLoTrinh.Rows.Add(
                        stt++,
                        gaDi,
                        gaDen,
                        cacTuyen,
                        tongKm.ToString("0.00"),
                        $"Giờ xuất phát: {lich.GioXuatPhat:hh\\:mm}\nTổng thời gian: {tongPhut / 60} giờ {tongPhut % 60} phút"
                    );
                    gioXuatPhatChuyen.Add(lich.GioXuatPhat);
                }

                selectedChiTiet = ketQuaChiTiet;
            }
        }


        private void BtnChiTiet_Click(object sender, EventArgs e)
        {
            if (selectedChiTiet == null || selectedChiTiet.Count == 0)
            {
                MessageBox.Show("Chưa có kết quả tổng quan để hiển thị chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvLoTrinh.CurrentRow == null)
            {
                MessageBox.Show("Chọn một chuyến để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvLoTrinh.CurrentRow.Index;
            if (index < 0 || index >= gioXuatPhatChuyen.Count) return;

            TimeSpan gioBatDauChuyen = gioXuatPhatChuyen[index];

            dgvLoTrinh.Rows.Clear();
            int stt = 1;

            // Hiển thị tất cả các đoạn của tuyến, tính giờ xuất phát từng đoạn
            foreach (var d in selectedChiTiet)
            {
                dgvLoTrinh.Rows.Add(
                    stt++,
                    d.GaDi,
                    d.GaDen,
                    d.MaTuyen,
                    d.KhoangCach.ToString("0.00"),
                    gioBatDauChuyen.ToString(@"hh\:mm")
                );

                // Mỗi đoạn giả lập 3 phút
                gioBatDauChuyen = gioBatDauChuyen.Add(TimeSpan.FromMinutes(3));
            }
        }


        private void BtnQuayLai_Click(object sender, EventArgs e)
        {
            if (gioXuatPhatChuyen == null || gioXuatPhatChuyen.Count == 0) return;

            dgvLoTrinh.Rows.Clear();
            int stt = 1;

            double tongKm = selectedChiTiet.Sum(d => d.KhoangCach);
            int tongPhut = selectedChiTiet.Sum(d => d.ThoiGianDenTiepTheo);
            string cacTuyen = string.Join(", ", selectedChiTiet.Select(d => d.MaTuyen).Distinct());

            string gaDi = txtTu.Text.Trim();
            string gaDen = txtDen.Text.Trim();

            foreach (var gioBatDau in gioXuatPhatChuyen)
            {
                string thongTin = $"Tổng thời gian: {tongPhut / 60} giờ {tongPhut % 60} phút\n" +
                                  $"Chuyến bắt đầu: {gioBatDau:hh\\:mm}";

                dgvLoTrinh.Rows.Add(
                    stt++,
                    gaDi,
                    gaDen,
                    cacTuyen,
                    tongKm.ToString("0.00"),
                    thongTin
                );
            }
        }

        private void dtvThoiGian_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtGio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhut_TextChanged(object sender, EventArgs e)
        {

        }
    }
}