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

            if (dgvTuyen.Columns["MaTuyen"] != null)
                dgvTuyen.Columns["MaTuyen"].HeaderText = "Mã Tuyến";
            if (dgvTuyen.Columns["TenTuyen"] != null)
                dgvTuyen.Columns["TenTuyen"].HeaderText = "Tên Tuyến";
            if (dgvTuyen.Columns["MoTa"] != null)
                dgvTuyen.Columns["MoTa"].HeaderText = "Mô tả";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string maTuyen = txtMaTuyen.Text.Trim();
                string tenTuyen = txtTenTuyen.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                if (string.IsNullOrWhiteSpace(maTuyen) || string.IsNullOrWhiteSpace(tenTuyen))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ Mã tuyến và Tên tuyến!",
                                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tuyenMoi = new Tuyen
                {
                    MaTuyen = maTuyen,
                    TenTuyen = tenTuyen,
                    MoTa = moTa
                };

                _tuyenService.Add(tuyenMoi);
                LoadTuyenGrid();
                ClearInput();

                MessageBox.Show("Thêm tuyến mới thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // ⚠️ Hiển thị thông báo lỗi rõ ràng ra MessageBox
                MessageBox.Show(ex.Message,
                                "Lỗi khi thêm tuyến",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maTuyen = txtMaTuyen.Text.Trim();
                string tenTuyen = txtTenTuyen.Text.Trim();
                string moTa = txtMoTa.Text.Trim();

                if (string.IsNullOrWhiteSpace(maTuyen))
                {
                    MessageBox.Show("Vui lòng chọn tuyến cần sửa!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var tuyen = new Tuyen
                {
                    MaTuyen = maTuyen,
                    TenTuyen = tenTuyen,
                    MoTa = moTa
                };

                _tuyenService.Update(tuyen);
                LoadTuyenGrid();
                MessageBox.Show("Cập nhật tuyến thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Lỗi khi cập nhật tuyến",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maTuyen = txtMaTuyen.Text.Trim();

                if (string.IsNullOrWhiteSpace(maTuyen))
                {
                    MessageBox.Show("Vui lòng chọn tuyến cần xóa!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("Bạn có chắc muốn xóa tuyến này?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _tuyenService.Delete(maTuyen);
                    LoadTuyenGrid();
                    ClearInput();
                    MessageBox.Show("Xóa tuyến thành công!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Lỗi khi xóa tuyến",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTuyenGrid();
            ClearInput();
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

        private void ClearInput()
        {
            txtMaTuyen.Clear();
            txtTenTuyen.Clear();
            txtMoTa.Clear();
        }
    }
}
