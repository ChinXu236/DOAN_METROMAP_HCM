using System;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmLogin : Form
    {
        public string UserRole { get; private set; }  // Thuộc tính để truyền quyền sang frmMain

        public frmLogin()
        {
            InitializeComponent();
            cboRole.SelectedIndex = 0; // Giả định bạn có ComboBox chọn vai trò
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();
            string role = cboRole.Text;

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tài khoản và mật khẩu!", "Thông báo");
                return;
            }

            // Giả lập kiểm tra đăng nhập
            if (role == "Người quản lý" && user == "admin" && pass == "123")
            {
                UserRole = "Admin";
                MessageBox.Show("Đăng nhập thành công với quyền Quản lý!");
                this.DialogResult = DialogResult.OK;  // Trả kết quả cho Program.cs
            }
            else if (role == "Người dùng" && user == "user" && pass == "123")
            {
                UserRole = "User";
                MessageBox.Show("Đăng nhập thành công với quyền Người dùng!");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Cảnh báo");
            }
        }
    }
}
