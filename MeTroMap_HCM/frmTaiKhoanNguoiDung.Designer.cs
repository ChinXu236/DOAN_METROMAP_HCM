namespace MetroMap_HCM
{
    partial class frmTaiKhoanNguoiDung
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
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

            // lblHoTen
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(200, 40);
            this.lblHoTen.Text = "Họ tên:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(200, 80);
            this.lblEmail.Text = "Email:";

            // lblDiaChi
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(200, 120);
            this.lblDiaChi.Text = "Địa chỉ:";

            // lblSDT
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(200, 160);
            this.lblSDT.Text = "Số điện thoại:";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(290, 35);
            this.txtHoTen.Width = 200;

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(290, 75);
            this.txtEmail.Width = 200;

            // txtDiaChi
            this.txtDiaChi.Location = new System.Drawing.Point(290, 115);
            this.txtDiaChi.Width = 200;

            // txtSDT
            this.txtSDT.Location = new System.Drawing.Point(290, 155);
            this.txtSDT.Width = 200;

            // btnCapNhat
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Location = new System.Drawing.Point(290, 200);
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);

            // frmTaiKhoanNguoiDung
            this.ClientSize = new System.Drawing.Size(550, 260);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.btnCapNhat);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản người dùng";
            this.Load += new System.EventHandler(this.frmTaiKhoanNguoiDung_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnCapNhat;
    }
}
