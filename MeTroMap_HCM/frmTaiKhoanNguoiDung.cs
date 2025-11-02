using Newtonsoft.Json; // ⚡ cần cài gói Newtonsoft.Json (qua NuGet)
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmTaiKhoanNguoiDung : Form
    {
        private string avatarPath;
        private string dataFile; // file lưu toàn bộ thông tin người dùng

        public frmTaiKhoanNguoiDung()
        {
            InitializeComponent();
            dataFile = Path.Combine(Application.StartupPath, "user_profile.json");
        }

        private void frmTaiKhoanNguoiDung_Load(object sender, EventArgs e)
        {
            // Nếu có file dữ liệu, đọc lại
            if (File.Exists(dataFile))
            {
                var json = File.ReadAllText(dataFile);
                var user = JsonConvert.DeserializeObject<UserProfile>(json);

                txtHoTen.Text = user.HoTen;
                txtEmail.Text = user.Email;
                txtDiaChi.Text = user.DiaChi;
                txtNN.Text = user.NgheNghiep;
                txtSDT.Text = user.SDT;
                avatarPath = user.AvatarPath;
            }
            else
            {
                // Nếu chưa có file, tạo mặc định
                txtHoTen.Text = "Trần Thanh Hằng";
                txtEmail.Text = "hang@example.com";
                txtDiaChi.Text = "Quận 1, TP.HCM";
                txtNN.Text = "Sinh Viên";
                txtSDT.Text = "0912345678";
                avatarPath = Path.Combine(Application.StartupPath, "Resources", "user.png");
            }

            // Hiển thị ảnh
            if (File.Exists(avatarPath))
                picAvatar.Image = Image.FromFile(avatarPath);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Lưu thông tin ra file JSON
            var user = new UserProfile
            {
                HoTen = txtHoTen.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                DiaChi = txtDiaChi.Text.Trim(),
                NgheNghiep = txtNN.Text.Trim(),
                SDT = txtSDT.Text.Trim(),
                AvatarPath = avatarPath
            };

            var json = JsonConvert.SerializeObject(user, Formatting.Indented);
            File.WriteAllText(dataFile, json);

            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
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

        // 🔹 Lớp phụ mô tả cấu trúc dữ liệu người dùng
        private class UserProfile
        {
            public string HoTen { get; set; }
            public string Email { get; set; }
            public string DiaChi { get; set; }
            public string NgheNghiep { get; set; }
            public string SDT { get; set; }
            public string AvatarPath { get; set; }
        }
    }
}
