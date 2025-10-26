using System;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmMain : Form
    {
        private readonly string _userRole;

        public frmMain(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, bạn đang đăng nhập với quyền: {_userRole}";

            if (_userRole == "User")
            {
                // Ẩn các chức năng quản lý và thống kê cho người dùng
                mniGa.Visible = false;
                mniTuyen.Visible = false;
                mniLienKet.Visible = false;
                mniThongKe.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            pnlMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void mniGa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGa());
        }

        private void mniTuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTuyen());
        }

        private void mniLienKet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLienKet());
        }

        private void mniTimDuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimDuong());
        }

        private void mniDatVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatVe());
        }

        private void mniThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmMain main = new frmMain(login.UserRole);
                    main.Show();
                }
                this.Close();
            }
        }
    }
}
