using System;
using System.Linq;
using System.Windows.Forms;
using MetroMap_HCM.BUS;

namespace MetroMap_HCM
{
    public partial class frmDatVe : Form
    {
        private readonly TuyenService _tuyenService = new TuyenService();
        private readonly GaService _gaService = new GaService();

        public frmDatVe()
        {
            InitializeComponent();
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            cboTuyen.DataSource = _tuyenService.GetAll();
            cboTuyen.DisplayMember = "TenTuyen";
            cboTuyen.ValueMember = "MaTuyen";
        }

        private void cboTuyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTuyen.SelectedValue == null) return;

            string maTuyen = cboTuyen.SelectedValue.ToString();
            var gas = _gaService.GetByTuyen(maTuyen);

            cboGaDi.DataSource = gas.ToList();
            cboGaDi.DisplayMember = "TenGa";
            cboGaDi.ValueMember = "MaGa";

            cboGaDen.DataSource = gas.ToList();
            cboGaDen.DisplayMember = "TenGa";
            cboGaDen.ValueMember = "MaGa";
        }

        private void btnTinhGia_Click(object sender, EventArgs e)
        {
            if (cboGaDi.SelectedValue == null || cboGaDen.SelectedValue == null) return;

            string maGa1 = cboGaDi.SelectedValue.ToString();
            string maGa2 = cboGaDen.SelectedValue.ToString();

            double khoangCach = new DijkstraService().TinhKhoangCach(maGa1, maGa2);
            double gia = khoangCach * 7000; // giả lập 7000đ/km

            txtGia.Text = gia.ToString("N0");
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đặt vé thành công!\nTổng tiền: {txtGia.Text} VNĐ", "Thông báo");
        }
    }
}
