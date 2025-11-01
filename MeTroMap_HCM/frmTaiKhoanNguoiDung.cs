using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace MetroMap_HCM
{
    public partial class frmTaiKhoanNguoiDung : Form
    {
        // 🧩 Biến lưu đường dẫn ảnh đại diện của người dùng
        private string avatarPath;

        public frmTaiKhoanNguoiDung()
        {
            InitializeComponent();
        }

        private void frmTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            // 🔹 Load thông tin người dùng (giả lập — sau này sẽ lấy từ DB)
            txtHoTen.Text = "Trần Thanh Hằng";
            txtEmail.Text = "hang@example.com";
            txtDiaChi.Text = "Quận 1, TP.HCM";
            txtNN.Text = "Sinh Viên";
            txtSDT.Text = "0912345678";

            // 🔹 Đọc đường dẫn ảnh từ file tạm (giả sử lưu ở file cấu hình)
            string pathFile = Path.Combine(Application.StartupPath, "user_avatar.txt");
            if (File.Exists(pathFile))
            {
                avatarPath = File.ReadAllText(pathFile);
            }
            else
            {
                avatarPath = Path.Combine(Application.StartupPath, "Resources", "user.png");
            }

            // 🔹 Hiển thị ảnh
            if (File.Exists(avatarPath))
                picAvatar.Image = Image.FromFile(avatarPath);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // 🔹 Lưu thông tin (giả lập)
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");

            // 🔹 Ghi lại đường dẫn ảnh đã chọn
            string pathFile = Path.Combine(Application.StartupPath, "user_avatar.txt");
            File.WriteAllText(pathFile, avatarPath);
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Title = "Chọn ảnh đại diện";
                open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    avatarPath = open.FileName;
                    picAvatar.Image = Image.FromFile(avatarPath);
                }
            }
        }
    }
}
