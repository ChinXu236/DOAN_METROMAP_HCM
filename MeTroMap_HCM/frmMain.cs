using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
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
            ConfigureForRole(_userRole);
        }

        private void ConfigureForRole(string role)
        {
            // Ẩn hết
            mniQuanLy.Visible = false;
            mniGa.Visible = false;
            mniTuyen.Visible = false;
            mniLienKet.Visible = false;
            mniThongKe.Visible = false;
            mniTaiKhoanNhanVien.Visible = false;

            mniNguoiDung.Visible = false;
            mniTimDuong.Visible = false;
            mniDatVe.Visible = false;
            mniTaiKhoanNguoiDung.Visible = false;

            // Hiện theo quyền
            if (role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
            {
                mniQuanLy.Visible = true;
                mniGa.Visible = true;
                mniTuyen.Visible = true;
                mniLienKet.Visible = true;
                mniThongKe.Visible = true;
                mniTaiKhoanNhanVien.Visible = true;
            }
            else if (role.Equals("User", StringComparison.OrdinalIgnoreCase))
            {
                mniNguoiDung.Visible = true;
                mniTimDuong.Visible = true;
                mniDatVe.Visible = true;
                mniTaiKhoanNguoiDung.Visible = true;
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

        private void mniGa_Click(object sender, EventArgs e) => OpenChildForm(new frmGa());
        private void mniTuyen_Click(object sender, EventArgs e) => OpenChildForm(new frmTuyen());
        private void mniLienKet_Click(object sender, EventArgs e) => OpenChildForm(new frmLienKet());
        private void mniThongKe_Click(object sender, EventArgs e) => OpenChildForm(new frmThongKe());
        private void mniTimDuong_Click(object sender, EventArgs e) => OpenChildForm(new frmTimDuong());
        private void mniDatVe_Click(object sender, EventArgs e) => OpenChildForm(new frmDatVe());
        private void mniTaiKhoanNguoiDung_Click(object sender, EventArgs e) => OpenChildForm(new frmTaiKhoanNguoiDung());
        private void mniTaiKhoanNhanVien_Click(object sender, EventArgs e) => OpenChildForm(new frmTaiKhoanNhanVien());

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Hide();
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmMain main = new frmMain(login.UserRole);
                    main.Show();
                }
                Close();
            }
        }

    }
}
