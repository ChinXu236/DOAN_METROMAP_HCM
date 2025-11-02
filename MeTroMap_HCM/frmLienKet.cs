using MetroMap_HCM.BUS;
using MetroMap_HCM.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmLienKet : Form
    {
        private readonly LienKetService _lienKetService = new LienKetService();
        private readonly GaService _gaService = new GaService();

        public frmLienKet()
        {
            InitializeComponent();
        }

        private void frmLienKet_Load(object sender, EventArgs e)
        {
            LoadGaCombo();
            LoadLienKetGrid();
        }

        private void LoadGaCombo()
        {
            var gaList = _gaService.GetAll();
            cboGa1.DataSource = gaList.ToList();
            cboGa1.DisplayMember = "TenGa";
            cboGa1.ValueMember = "MaGa";

            cboGa2.DataSource = gaList.ToList();
            cboGa2.DisplayMember = "TenGa";
            cboGa2.ValueMember = "MaGa";
        }

        private void LoadLienKetGrid()
        {
            dgvLienKet.DataSource = _lienKetService.GetAll();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboGa1.SelectedValue.ToString() == cboGa2.SelectedValue.ToString())
                {
                    MessageBox.Show("Không thể liên kết cùng một ga!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtKhoangCach.Text, out double kc))
                {
                    MessageBox.Show("Vui lòng nhập khoảng cách hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var lk = new LienKet
                {
                    MaGa1 = cboGa1.SelectedValue.ToString(),
                    MaGa2 = cboGa2.SelectedValue.ToString(),
                    KhoangCach = kc
                };

                _lienKetService.Add(lk);
                LoadLienKetGrid();
                MessageBox.Show("Thêm liên kết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm liên kết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn liên kết cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = (int)dgvLienKet.CurrentRow.Cells["ID"].Value;
            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa liên kết này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _lienKetService.Delete(id);
                    LoadLienKetGrid();
                    MessageBox.Show("Xóa liên kết thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa liên kết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ Thêm sự kiện CellClick
        private void dgvLienKet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLienKet.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                var row = dgvLienKet.Rows[e.RowIndex];

                // Gán lại combobox theo mã ga
                cboGa1.SelectedValue = row.Cells["MaGa1"].Value.ToString();
                cboGa2.SelectedValue = row.Cells["MaGa2"].Value.ToString();

                // Hiển thị khoảng cách
                txtKhoangCach.Text = row.Cells["KhoangCach"].Value?.ToString();
            }
        }
    }
}
