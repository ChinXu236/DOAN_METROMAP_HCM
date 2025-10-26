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
            dgvTuyen.DataSource = _tuyenService.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTuyen.Text) || string.IsNullOrWhiteSpace(txtTenTuyen.Text))
            {
                MessageBox.Show("Nhập đủ thông tin!");
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var t = new Tuyen
            {
                MaTuyen = txtMaTuyen.Text.Trim(),
                TenTuyen = txtTenTuyen.Text.Trim(),
                MoTa = txtMoTa.Text.Trim()
            };

            _tuyenService.Update(t);
            MessageBox.Show("Cập nhật tuyến thành công!");

            LoadTuyenGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _tuyenService.Delete(txtMaTuyen.Text);
            LoadTuyenGrid();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            LoadTuyenGrid();
        }

        private void dgvTuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvTuyen.Rows[e.RowIndex];
                txtMaTuyen.Text = row.Cells["MaTuyen"].Value.ToString();
                txtTenTuyen.Text = row.Cells["TenTuyen"].Value.ToString();
                txtMoTa.Text = row.Cells["MoTa"].Value?.ToString();
            }
        }
    }
}
