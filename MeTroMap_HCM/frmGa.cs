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

            Control parent = dgvGa.Parent;
            void Center() => dgvGa.Left = (parent.ClientSize.Width - dgvGa.Width) / 2;

            this.Resize += (s, ev) => Center();
            parent.Resize += (s, ev) => Center();
            Center();
            dgvGa.Anchor = AnchorStyles.Top; // không kéo dãn theo chiều ngang
        }

        private void LoadTuyenCombo()
        {
            var tuyens = _tuyenService.GetAll();
            cboTuyen.DataSource = tuyens;
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
        }

        private void LoadDanhSachGa()
        {
            dgvGa.DataSource = _gaService.GetAll()
                .Select(g => new
                {
                    g.MaGa,
                    g.TenGa,
                    g.MaTuyen,
                    TenTuyen = g.Tuyen.TenTuyen,
                    g.ThuTu
                }).ToList();
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var g = new Ga
                {
                    MaGa = txtMaGa.Text.Trim(),
                    TenGa = txtTenGa.Text.Trim(),
                    MaTuyen = cboTuyen.SelectedValue.ToString(),
                    ThuTu = int.TryParse(txtThuTu.Text, out int tt) ? tt : (int?)null
                };

                _gaService.Add(g);
                LoadDanhSachGa();
                MessageBox.Show("Thêm ga thành công!");
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var g = new Ga
                {
                    MaGa = txtMaGa.Text.Trim(),
                    TenGa = txtTenGa.Text.Trim(),
                    MaTuyen = cboTuyen.SelectedValue.ToString(),
                    ThuTu = int.TryParse(txtThuTu.Text, out int tt) ? tt : (int?)null
                };

                _gaService.Update(g);
                LoadDanhSachGa();
                MessageBox.Show("Sửa thông tin ga thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaGa.Text))
            {
                MessageBox.Show("Vui lòng chọn ga cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa ga này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                _gaService.Delete(txtMaGa.Text.Trim());
                LoadDanhSachGa();
                ClearInput();
                MessageBox.Show("Xóa ga thành công!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim().ToLower();
            var result = _gaService.GetAll()
                .Where(g => g.TenGa.ToLower().Contains(tuKhoa) ||
                            g.MaGa.ToLower().Contains(tuKhoa))
                .Select(g => new
                {
                    g.MaGa,
                    g.TenGa,
                    g.MaTuyen,
                    TenTuyen = g.Tuyen.TenTuyen,
                    g.ThuTu
                })
                .ToList();

            dgvGa.DataSource = result;
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
