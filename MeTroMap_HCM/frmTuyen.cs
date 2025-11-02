using MetroMap_HCM.BUS;
using MetroMap_HCM.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmTuyen : Form
    {
        private readonly TuyenService _tuyenService = new TuyenService();

        public frmTuyen()
        {
            InitializeComponent();
        }

        private void frmTuyen_Load(object sender, EventArgs e)
        {
            LoadTuyenGrid();
        }

        private void LoadTuyenGrid()
        {
            // Lấy dữ liệu và chỉ chọn 3 cột cần hiển thị
            var data = _tuyenService.GetAll()
                .Select(t => new
                {
                    MaTuyen = t.MaTuyen,
                    TenTuyen = t.TenTuyen,
                    MoTa = t.MoTa
                })
                .ToList();

            dgvTuyen.AutoGenerateColumns = true;
            dgvTuyen.DataSource = data;

            // Đặt lại tiêu đề cột hiển thị
            if (dgvTuyen.Columns["MaTuyen"] != null)
                dgvTuyen.Columns["MaTuyen"].HeaderText = "Mã Tuyến";
            if (dgvTuyen.Columns["TenTuyen"] != null)
                dgvTuyen.Columns["TenTuyen"].HeaderText = "Tên Tuyến";
            if (dgvTuyen.Columns["MoTa"] != null)
                dgvTuyen.Columns["MoTa"].HeaderText = "Mô tả";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text) || string.IsNullOrWhiteSpace(txtTenTuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            var t = new Tuyen
            {
                MaTuyen = txtMaTuyen.Text.Trim(),
                TenTuyen = txtTenTuyen.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };

            _tuyenService.Add(t);
            LoadTuyenGrid();
            MessageBox.Show("Thêm tuyến thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn tuyến cần sửa!");
                return;
            }

            var t = new Tuyen
            {
                MaTuyen = txtMaTuyen.Text.Trim(),
                TenTuyen = txtTenTuyen.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };

            _tuyenService.Update(t);
            LoadTuyenGrid();
            MessageBox.Show("Cập nhật tuyến thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text))
            {
                MessageBox.Show("Vui lòng chọn tuyến cần xóa!");
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa tuyến này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                _tuyenService.Delete(txtMaTuyen.Text.Trim());
                LoadTuyenGrid();
                MessageBox.Show("Xóa tuyến thành công!");
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTuyenGrid();
            txtMaTuyen.Clear();
            txtTenTuyen.Clear();
            txtMoTa.Clear();
        }

        private void dgvTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTuyen.Rows[e.RowIndex];
                txtMaTuyen.Text = row.Cells["MaTuyen"].Value?.ToString();
                txtTenTuyen.Text = row.Cells["TenTuyen"].Value?.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }
    }
}
