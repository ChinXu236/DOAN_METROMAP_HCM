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
            string infoPath = Path.Combine(Application.StartupPath, "Resources", "nhanvien_info.txt");
            if (File.Exists(infoPath))
            {
                string[] data = File.ReadAllText(infoPath).Split('|');
                if (data.Length >= 6)
                {
                    txtMaNV.Text = data[0];
                    txtTenNV.Text = data[1];
                    txtChucVu.Text = data[2];
                    txtEmail.Text = data[3];
                    txtSDT.Text = data[4];
                    if (File.Exists(data[5]))
                    {
                        picAvatar.Image = System.Drawing.Image.FromFile(data[5]);
                        picAvatar.Tag = data[5];
                    }
                }
            }

        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh đại diện";
                ofd.Filter = "File ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picAvatar.Image = System.Drawing.Image.FromFile(ofd.FileName);

                    // Sao chép ảnh vào thư mục Resources (có thể đổi nơi lưu)
                    string destDir = Path.Combine(Application.StartupPath, "Resources");
                    if (!Directory.Exists(destDir)) Directory.CreateDirectory(destDir);

                    string destFile = Path.Combine(destDir, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destFile, true);

                    // Lưu đường dẫn ảnh vào Tag (để dùng khi lưu DB)
                    picAvatar.Tag = destFile;
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string chucVu = txtChucVu.Text.Trim();
            string email = txtEmail.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string avatarPath = picAvatar.Tag?.ToString();

            if (string.IsNullOrWhiteSpace(tenNV) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên và email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đảm bảo thư mục Resources tồn tại
            string resourcesDir = Path.Combine(Application.StartupPath, "Resources");
            if (!Directory.Exists(resourcesDir))
                Directory.CreateDirectory(resourcesDir);

            string infoPath = Path.Combine(resourcesDir, "nhanvien_info.txt");
            File.WriteAllText(infoPath, $"{maNV}|{tenNV}|{chucVu}|{email}|{sdt}|{avatarPath}");

            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
