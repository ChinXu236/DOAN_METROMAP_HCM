using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroMap_HCM.BUS;

namespace MetroMap_HCM
{
    public partial class frmThongKe : Form
    {
        private readonly ThongKeService _service = new ThongKeService();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            cboThang.DataSource = Enumerable.Range(1, 12).ToList();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int thang = (int)cboThang.SelectedItem;
            var ds = _service.GetDoanhThuTheoThang(thang);

            dgvDoanhThu.DataSource = ds;
            txtTongDoanhThu.Text = ds.Sum(x => x.DoanhThu).ToString("N0");
        }
    }
}
