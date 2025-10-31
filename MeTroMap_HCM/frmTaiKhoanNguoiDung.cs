using System;
using System.Windows.Forms;
using System.IO;

namespace MetroMap_HCM
{
    public partial class frmTaiKhoanNguoiDung : Form
    {
        public frmTaiKhoanNguoiDung()
        {
            InitializeComponent();
        }

        private void frmTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            // Giả lập dữ liệu người dùng hiện tại (sau này lấy từ database)
            txtHoTen.Text = "Trần Thanh Hằng";
            txtEmail.Text = "hang@example.com";
            txtDiaChi.Text = "Quận 1, TP.HCM";
            txtSDT.Text = "0912345678";

            string avatarPath = Path.Combine(Application.StartupPath, "Resources", "user.png");
            if (File.Exists(avatarPath))
                picAvatar.Image = System.Drawing.Image.FromFile(avatarPath);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
        }
    }
}
