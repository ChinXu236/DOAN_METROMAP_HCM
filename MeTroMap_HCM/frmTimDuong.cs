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
        private List<TimeSpan> gioXuatPhatChuyen;

        public frmTimDuong()
        {
            InitializeComponent();
            SetupDataGridView();
            RegisterEvents();
            LoadTuyenToComboBox();
            LoadGioToComboBox();
            cboGioXP.Enabled = false;
            cboGioD.Enabled = false;
        }

        private void LoadTuyenToComboBox()
        {
            using (var db = new Model1())
            {
                var danhSachTuyen = db.Tuyens
                    .OrderBy(t => t.TenTuyen)
                    .Select(t => new { t.MaTuyen, t.TenTuyen })
                    .ToList();

                cboTuyenDi.DataSource = new List<dynamic>(danhSachTuyen);
                cboTuyenDi.DisplayMember = "TenTuyen";
                cboTuyenDi.ValueMember = "MaTuyen";

                cboTuyenDen.DataSource = new List<dynamic>(danhSachTuyen);
                cboTuyenDen.DisplayMember = "TenTuyen";
                cboTuyenDen.ValueMember = "MaTuyen";
            }

            cboTuyenDi.SelectedIndexChanged += CboTuyenDi_SelectedIndexChanged;
            cboTuyenDen.SelectedIndexChanged += CboTuyenDen_SelectedIndexChanged;
        }

        private void CboTuyenDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyenDi.SelectedValue == null) return;
            string maTuyen = cboTuyenDi.SelectedValue.ToString();
            using (var db = new Model1())
            {
                var danhSachGa = db.Gas
                    .Where(g => g.MaTuyen == maTuyen)
                    .OrderBy(g => g.ThuTu)
                    .Select(g => g.TenGa)
                    .ToList();
                cboGaDi.DataSource = danhSachGa;
            }
        }

        private void CboTuyenDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyenDen.SelectedValue == null) return;
            string maTuyen = cboTuyenDen.SelectedValue.ToString();
            using (var db = new Model1())
            {
                var danhSachGa = db.Gas
                    .Where(g => g.MaTuyen == maTuyen)
                    .OrderBy(g => g.ThuTu)
                    .Select(g => g.TenGa)
                    .ToList();
                cboGaDen.DataSource = danhSachGa;
            }
        }

        private void LoadGioToComboBox()
        {
            for (int h = 5; h <= 23; h++)
            {
                for (int m = 0; m < 60; m += 5)
                {
                    string gio = $"{h:00}:{m:00}";
                    cboGioXP.Items.Add(gio);
                    cboGioD.Items.Add(gio);
                }
            }
            cboGioXP.SelectedIndex = 0;
            cboGioD.SelectedIndex = 0;
        }

        private void SetupDataGridView()
        {
            dgvLoTrinh.Rows.Clear();
            dgvLoTrinh.ReadOnly = true;
            dgvLoTrinh.AllowUserToAddRows = false;
            dgvLoTrinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoTrinh.RowHeadersVisible = false;
            dgvLoTrinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void RegisterEvents()
        {
            btnTimDuong.Click += BtnTimDuong_Click;
            btnDoiChieu.Click += BtnDoiChieu_Click;
            btnChiTiet.Click += BtnChiTiet_Click;
            BtnQuayLai.Click += BtnQuayLai_Click;

            chkXP.CheckedChanged += (s, e) => cboGioXP.Enabled = chkXP.Checked;
            chkDen.CheckedChanged += (s, e) => cboGioD.Enabled = chkDen.Checked;
        }

        private void BtnDoiChieu_Click(object sender, EventArgs e)
        {
            var tmpGa = cboGaDi.SelectedItem;
            cboGaDi.SelectedItem = cboGaDen.SelectedItem;
            cboGaDen.SelectedItem = tmpGa;

            var tmpTuyen = cboTuyenDi.SelectedItem;
            cboTuyenDi.SelectedItem = cboTuyenDen.SelectedItem;
            cboTuyenDen.SelectedItem = tmpTuyen;
        }

        private void BtnTimDuong_Click(object sender, EventArgs e)
        {
            string gaDi = cboGaDi.Text.Trim();
            string gaDen = cboGaDen.Text.Trim();
            if (string.IsNullOrEmpty(gaDi) || string.IsNullOrEmpty(gaDen))
            {
                MessageBox.Show("Vui lòng chọn Ga đi và Ga đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new Model1())
            {
                var ketQuaChiTiet = Dijkstra.TimDuongChiTiet(gaDi, gaDen);
                if (ketQuaChiTiet == null || ketQuaChiTiet.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy đường đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                TimeSpan gioDau = new TimeSpan(5, 0, 0);
                TimeSpan gioCuoi = new TimeSpan(23, 55, 0);

                var gaStart = db.Gas.FirstOrDefault(g => g.TenGa.Equals(gaDi, StringComparison.OrdinalIgnoreCase));
                if (gaStart == null)
                {
                    MessageBox.Show("Không tìm thấy ga xuất phát!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var danhSachLich = db.LichTrinhs
                    .Where(l => l.MaGa == gaStart.MaGa && l.GioXuatPhat >= gioDau && l.GioXuatPhat <= gioCuoi)
                    .OrderBy(l => l.GioXuatPhat)
                    .ToList();

                if (!danhSachLich.Any())
                {
                    MessageBox.Show("Không có lịch trình trong khung giờ 05:00 - 23:55!", "Thông báo");
                    return;
                }

                int tongPhut = ketQuaChiTiet.Sum(d => d.ThoiGianDenTiepTheo);
                TimeSpan gioXPCanTim;

                List<LichTrinh> chuyenHienThi = new List<LichTrinh>();

                if (chkXP.Checked && cboGioXP.SelectedItem != null)
                {
                    // Giờ xuất phát: hiển thị 5 chuyến gần nhất
                    TimeSpan.TryParse(cboGioXP.SelectedItem.ToString(), out gioXPCanTim);
                    TimeSpan gioHienTai = gioXPCanTim;

                    for (int i = 0; i < 5; i++)
                    {
                        var lich = danhSachLich.FirstOrDefault(l => l.GioXuatPhat >= gioHienTai);
                        if (lich != null)
                        {
                            chuyenHienThi.Add(lich);
                            gioHienTai = lich.GioXuatPhat.Add(TimeSpan.FromMinutes(10)); // cách nhau 10 phút
                        }
                        else break;
                    }
                }
                else if (chkDen.Checked && cboGioD.SelectedItem != null)
                {
                    // Giờ đến: hiển thị tối đa 2 chuyến kết thúc trước giờ đã chọn
                    TimeSpan gioDCanTim;
                    TimeSpan.TryParse(cboGioD.SelectedItem.ToString(), out gioDCanTim);

                    // Lọc các chuyến có giờ đến <= giờ đã chọn
                    var chuyenTruoc = danhSachLich
                        .Where(l => l.GioXuatPhat.Add(TimeSpan.FromMinutes(tongPhut)) <= gioDCanTim)
                        .GroupBy(l => l.GioXuatPhat)               // Gộp theo giờ xuất phát
                        .Select(g => g.First())                     // Mỗi giờ chỉ lấy 1 bản ghi
                        .OrderByDescending(l => l.GioXuatPhat)      // Lấy gần giờ đến nhất
                        .Take(2)                                    // Lấy tối đa 2 chuyến
                        .OrderBy(l => l.GioXuatPhat)                // Sắp xếp tăng dần khi hiển thị
                        .ToList();

                    if (!chuyenTruoc.Any())
                    {
                        MessageBox.Show("Không có chuyến nào kết thúc trước giờ đã chọn!", "Thông báo");
                        return;
                    }

                    chuyenHienThi = chuyenTruoc;
                }
            
                else
                {
                    // Mặc định: giờ hiện tại
                    gioXPCanTim = DateTime.Now.TimeOfDay;
                    if (gioXPCanTim < gioDau) gioXPCanTim = gioDau;
                    if (gioXPCanTim > gioCuoi) gioXPCanTim = gioCuoi;

                    // hiển thị 5 chuyến gần nhất từ giờ hiện tại
                    TimeSpan gioHienTai = gioXPCanTim;
                    for (int i = 0; i < 5; i++)
                    {
                        var lich = danhSachLich.FirstOrDefault(l => l.GioXuatPhat >= gioHienTai);
                        if (lich != null)
                        {
                            chuyenHienThi.Add(lich);
                            gioHienTai = lich.GioXuatPhat.Add(TimeSpan.FromMinutes(10));
                        }
                        else break;
                    }
                }

                // Hiển thị trên DataGridView
                dgvLoTrinh.Rows.Clear();
                int stt = 1;
                double tongKm = ketQuaChiTiet.Sum(d => d.KhoangCach);
                string cacTuyen = string.Join(", ", ketQuaChiTiet.Select(d => d.MaTuyen).Distinct());
                dgvLoTrinh.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvLoTrinh.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                gioXuatPhatChuyen = new List<TimeSpan>();
                foreach (var lich in chuyenHienThi)
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
            string gaDi = cboGaDi.Text.Trim();
            string gaDen = cboGaDen.Text.Trim();

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
    }
}
