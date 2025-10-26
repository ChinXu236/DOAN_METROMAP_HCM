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
            var lk = new LienKet
            {
                MaGa1 = cboGa1.SelectedValue.ToString(),
                MaGa2 = cboGa2.SelectedValue.ToString(),
                KhoangCach = double.Parse(txtKhoangCach.Text)
            };
            _lienKetService.Add(lk);

            LoadLienKetGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLienKet.CurrentRow != null)
            {
                int id = (int)dgvLienKet.CurrentRow.Cells["ID"].Value;
                _lienKetService.Delete(id);
                LoadLienKetGrid();
            }
        }
    }
}
