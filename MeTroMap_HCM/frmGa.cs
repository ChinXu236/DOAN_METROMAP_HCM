using System;
using System.Linq;
using System.Windows.Forms;
using MetroMap_HCM.BUS;
using MetroMap_HCM.DAL;

namespace MetroMap_HCM
{
    public partial class frmGa : Form
    {
        private readonly GaService _gaService = new GaService();
        private readonly TuyenService _tuyenService = new TuyenService();

        public frmGa()
        {
            InitializeComponent();
        }

        private void frmGa_Load(object sender, EventArgs e)
        {
            LoadTuyenCombo();
            LoadDanhSachGa();

            // Căn giữa DataGridView
            Control parent = dgvGa.Parent;
            void Center() => dgvGa.Left = (parent.ClientSize.Width - dgvGa.Width) / 2;
            this.Resize += (s, ev) => Center();
            parent.Resize += (s, ev) => Center();
            Center();
            dgvGa.Anchor = AnchorStyles.Top;
        }

        private void LoadTuyenCombo()
        {
            var dsTuyen = _tuyenService.GetAll();
            cboTuyen.DataSource = dsTuyen;
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
        }

        private void LoadDanhSachGa()
        {
            dgvGa.DataSource = _gaService.GetAll()
                .Select(item => new
                {
                    item.MaGa,
                    item.TenGa,
                    item.MaTuyen,
                    TenTuyen = item.Tuyen.TenTuyen,
                    item.ThuTu
                })
                .ToList();
        }

        private void dgvGa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvGa.Rows[e.RowIndex];
                txtMaGa.Text = row.Cells["MaGa"].Value.ToString();
                txtTenGa.Text = row.Cells["TenGa"].Value.ToString();
                cboTuyen.SelectedValue = row.Cells["MaTuyen"].Value.ToString();
                txtThuTu.Text = row.Cells["ThuTu"].Value?.ToString();
            }
        }

        // =========================
        // ===== THÊM GA MỚI ======
        // =========================
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maGa = txtMaGa.Text.Trim();
                string tenGa = txtTenGa.Text.Trim();
<<<<<<< HEAD
                string maTuyen = cboTuyen.SelectedValue.ToString();
                int? thuTu = int.TryParse(txtThuTu.Text, out int tt) ? tt : (int?)null;

                if (string.IsNullOrWhiteSpace(maGa) || string.IsNullOrWhiteSpace(tenGa) || thuTu == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã ga, Tên ga và Thứ tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng mã ga
                bool trungMa = _gaService.GetAll().Any(ga => ga.MaGa.Equals(maGa, StringComparison.OrdinalIgnoreCase));
                if (trungMa)
                {
                    MessageBox.Show("Mã ga đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra trùng thứ tự trong cùng tuyến
                bool trungThuTu = _gaService.GetAll().Any(ga => ga.MaTuyen == maTuyen && ga.ThuTu == thuTu);
                if (trungThuTu)
                {
                    MessageBox.Show("Thứ tự ga này đã tồn tại trong tuyến! Vui lòng chọn thứ tự khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var gaMoi = new Ga
=======
                string maTuyen = cboTuyen.SelectedValue?.ToString();
                string thuTuText = txtThuTu.Text.Trim();

                
                if (string.IsNullOrEmpty(maGa) ||
                    string.IsNullOrEmpty(tenGa) ||
                    string.IsNullOrEmpty(maTuyen) ||
                    string.IsNullOrEmpty(thuTuText))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã ga, Tên ga, Tuyến và Thứ tự!",
                                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                if (!int.TryParse(thuTuText, out int thuTu))
                {
                    MessageBox.Show("Thứ tự phải là số nguyên!",
                                    "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                var danhSachGa = _gaService.GetAll();
                if (danhSachGa.Any(x => x.MaGa.Equals(maGa, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Mã ga đã tồn tại! Vui lòng nhập mã khác.",
                                    "Trùng mã ga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                Ga ga = new Ga
>>>>>>> c27a5c22ebd170b5498a2a51fb71a22309757a27
                {
                    MaGa = maGa,
                    TenGa = tenGa,
                    MaTuyen = maTuyen,
                    ThuTu = thuTu
                };

<<<<<<< HEAD
                _gaService.Add(gaMoi);
=======
                _gaService.Add(ga);
>>>>>>> c27a5c22ebd170b5498a2a51fb71a22309757a27
                LoadDanhSachGa();
                MessageBox.Show("Thêm ga thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // ===== SỬA GA ============
        // =========================
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maGa = txtMaGa.Text.Trim();
                string tenGa = txtTenGa.Text.Trim();
                string maTuyen = cboTuyen.SelectedValue.ToString();
                int? thuTu = int.TryParse(txtThuTu.Text, out int tt) ? tt : (int?)null;

                if (string.IsNullOrWhiteSpace(maGa) || string.IsNullOrWhiteSpace(tenGa) || thuTu == null)
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã ga, Tên ga và Thứ tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng thứ tự trong cùng tuyến (ngoại trừ chính nó)
                bool trungThuTu = _gaService.GetAll().Any(ga => ga.MaTuyen == maTuyen && ga.ThuTu == thuTu && !ga.MaGa.Equals(maGa, StringComparison.OrdinalIgnoreCase));
                if (trungThuTu)
                {
                    MessageBox.Show("Thứ tự này đã tồn tại trong tuyến! Không thể cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var gaCanSua = new Ga
                {
                    MaGa = maGa,
                    TenGa = tenGa,
                    MaTuyen = maTuyen,
                    ThuTu = thuTu
                };

                _gaService.Update(gaCanSua);
                LoadDanhSachGa();
                MessageBox.Show("Cập nhật thông tin ga thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =========================
        // ===== XÓA GA ============
        // =========================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maGa = txtMaGa.Text.Trim();

            if (string.IsNullOrEmpty(maGa))
            {
                MessageBox.Show("Vui lòng chọn ga cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa ga này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _gaService.Delete(maGa);
                    LoadDanhSachGa();
                    ClearInput();
                    MessageBox.Show("Xóa ga thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // =========================
        // ===== TÌM KIẾM ==========
        // =========================
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim().ToLower();
            var ketQua = _gaService.GetAll()
                .Where(ga => ga.TenGa.ToLower().Contains(tuKhoa) ||
                             ga.MaGa.ToLower().Contains(tuKhoa))
                .Select(ga => new
                {
                    ga.MaGa,
                    ga.TenGa,
                    ga.MaTuyen,
                    TenTuyen = ga.Tuyen.TenTuyen,
                    ga.ThuTu
                })
                .ToList();

            dgvGa.DataSource = ketQua;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            txtTim.Clear();
            ClearInput();
            LoadDanhSachGa();
        }

        private void ClearInput()
        {
            txtMaGa.Clear();
            txtTenGa.Clear();
            txtThuTu.Clear();
            cboTuyen.SelectedIndex = 0;
        }
    }
}
