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

            dgvLienKet.ReadOnly = true;
            dgvLienKet.AllowUserToAddRows = false;
            dgvLienKet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadGaCombo()
        {
            // Lấy danh sách ga, loại bỏ ga có mã hoặc tên bị trống/null
            var gaList = _gaService.GetAll()
                                   .Where(g => !string.IsNullOrWhiteSpace(g.MaGa)
                                            && !string.IsNullOrWhiteSpace(g.TenGa))
                                   .ToList();

            // Gán lại cho combobox Ga1
            cboGa1.DataSource = new BindingSource(gaList.ToList(), null);
            cboGa1.DisplayMember = "TenGa";
            cboGa1.ValueMember = "MaGa";
            cboGa1.SelectedIndex = -1; // Không chọn sẵn gì cả

            // Gán lại cho combobox Ga2
            cboGa2.DataSource = new BindingSource(gaList.ToList(), null);
            cboGa2.DisplayMember = "TenGa";
            cboGa2.ValueMember = "MaGa";
            cboGa2.SelectedIndex = -1; // Không chọn sẵn gì cả
        }



        private void LoadLienKetGrid()
        {
            var list = _lienKetService.GetAll();

            var data = from lk in list
                       join g1 in _gaService.GetAll() on lk.MaGa1 equals g1.MaGa
                       join g2 in _gaService.GetAll() on lk.MaGa2 equals g2.MaGa
                       select new
                       {
                           lk.ID,
                           lk.MaGa1,
                           lk.MaGa2,
                           Ga1 = g1.TenGa,
                           Ga2 = g2.TenGa,
                           lk.KhoangCach
                       };

            dgvLienKet.DataSource = data.ToList();

            dgvLienKet.Columns["ID"].HeaderText = "ID";
            dgvLienKet.Columns["MaGa1"].HeaderText = "Mã Ga 1";
            dgvLienKet.Columns["MaGa2"].HeaderText = "Mã Ga 2";
            dgvLienKet.Columns["Ga1"].HeaderText = "Ga 1";
            dgvLienKet.Columns["Ga2"].HeaderText = "Ga 2";
            dgvLienKet.Columns["KhoangCach"].HeaderText = "Khoảng cách (km)";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboGa1.SelectedValue == null || cboGa2.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn cả Ga 1 và Ga 2!", "Thiếu thông tin",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string maGa1 = cboGa1.SelectedValue.ToString();
                string maGa2 = cboGa2.SelectedValue.ToString();

                if (maGa1 == maGa2)
                {
                    MessageBox.Show("Không thể liên kết cùng một ga!", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtKhoangCach.Text, out double khoangCach) || khoangCach <= 0)
                {
                    MessageBox.Show("Vui lòng nhập khoảng cách hợp lệ!", "Cảnh báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var lk = new LienKet
                {
                    MaGa1 = maGa1,
                    MaGa2 = maGa2,
                    KhoangCach = khoangCach
                };

                _lienKetService.Add(lk);
                LoadLienKetGrid();

                MessageBox.Show("Thêm liên kết thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm liên kết: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn liên kết cần xóa!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Xóa liên kết thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa liên kết: {ex.Message}", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvLienKet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLienKet.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                var row = dgvLienKet.Rows[e.RowIndex];
                cboGa1.SelectedValue = row.Cells["MaGa1"].Value.ToString();
                cboGa2.SelectedValue = row.Cells["MaGa2"].Value.ToString();
                txtKhoangCach.Text = row.Cells["KhoangCach"].Value?.ToString();
            }
        }
    }
}
