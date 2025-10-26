using System;
using System.IO;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmTaiKhoanNhanVien : Form
    {
        public frmTaiKhoanNhanVien()
        {
            InitializeComponent();
        }

        private void frmTaiKhoanNhanVien_Load(object sender, EventArgs e)
        {
            // Giả lập thông tin nhân viên (sau này có thể lấy từ DB)
            txtMaNV.Text = "NV001";
            txtTenNV.Text = "Phan Quốc Minh";
            txtChucVu.Text = "Quản lý";
            txtEmail.Text = "minh@example.com";
            txtSDT.Text = "0909123456";

            string avatarPath = Path.Combine(Application.StartupPath, "Resources", "manager.png");
            if (File.Exists(avatarPath))
                picAvatar.Image = System.Drawing.Image.FromFile(avatarPath);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo");
        }
    }
}
