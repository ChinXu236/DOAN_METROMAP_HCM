namespace MetroMap_HCM
{
    partial class frmTaiKhoanNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();

            // picAvatar
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(40, 30);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 120);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabStop = false;

            // lblMaNV
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(200, 40);
            this.lblMaNV.Text = "Mã NV:";

            // lblTenNV
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(200, 75);
            this.lblTenNV.Text = "Tên NV:";

            // lblChucVu
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(200, 110);
            this.lblChucVu.Text = "Chức vụ:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 145);
            this.lblEmail.Text = "Email:";

            // lblSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(200, 180);
            this.lblSDT.Text = "SĐT:";

            // txtMaNV
            this.txtMaNV.Location = new System.Drawing.Point(280, 35);
            this.txtMaNV.Width = 200;

            // txtTenNV
            this.txtTenNV.Location = new System.Drawing.Point(280, 70);
            this.txtTenNV.Width = 200;

            // txtChucVu
            this.txtChucVu.Location = new System.Drawing.Point(280, 105);
            this.txtChucVu.Width = 200;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(280, 140);
            this.txtEmail.Width = 200;

            // txtSDT
            this.txtSDT.Location = new System.Drawing.Point(280, 175);
            this.txtSDT.Width = 200;

            // btnCapNhat
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(280, 215);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // frmTaiKhoanNhanVien
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnCapNhat);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản nhân viên";
            this.Load += new System.EventHandler(this.frmTaiKhoanNhanVien_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
