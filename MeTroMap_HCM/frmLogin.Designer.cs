namespace MetroMap_HCM
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pmlBg = new System.Windows.Forms.Panel();
            this.pbBg = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pmlBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).BeginInit();
            this.SuspendLayout();
            // 
            // pmlBg
            // 
            this.pmlBg.Controls.Add(this.lblTitle);
            this.pmlBg.Controls.Add(this.lblUser);
            this.pmlBg.Controls.Add(this.txtUser);
            this.pmlBg.Controls.Add(this.lblPass);
            this.pmlBg.Controls.Add(this.txtPass);
            this.pmlBg.Controls.Add(this.lblRole);
            this.pmlBg.Controls.Add(this.cboRole);
            this.pmlBg.Controls.Add(this.btnLogin);
            this.pmlBg.Controls.Add(this.pbBg);
            this.pmlBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pmlBg.Location = new System.Drawing.Point(0, 0);
            this.pmlBg.Name = "pmlBg";
            this.pmlBg.Size = new System.Drawing.Size(1902, 1033);
            this.pmlBg.TabIndex = 0;
            // 
            // pbBg
            // 
            this.pbBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBg.Image = global::MeTroMap_HCM.Properties.Resources.Thiết_kế_chưa_có_tên;
            this.pbBg.Location = new System.Drawing.Point(0, 0);
            this.pbBg.Name = "pbBg";
            this.pbBg.Size = new System.Drawing.Size(1902, 1033);
            this.pbBg.TabIndex = 40;
            this.pbBg.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(320, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1263, 68);
            this.lblTitle.TabIndex = 41;
            this.lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG METROMAP HCM";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(483, 283);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(174, 42);
            this.lblUser.TabIndex = 42;
            this.lblUser.Text = "Tài khoản:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(729, 283);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(337, 42);
            this.txtUser.TabIndex = 43;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(483, 388);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(167, 42);
            this.lblPass.TabIndex = 44;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(729, 388);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(337, 42);
            this.txtPass.TabIndex = 45;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(517, 496);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(124, 42);
            this.lblRole.TabIndex = 46;
            this.lblRole.Text = "Vai trò:";
            // 
            // cboRole
            // 
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRole.Items.AddRange(new object[] {
            "Người dùng",
            "Người quản lý"});
            this.cboRole.Location = new System.Drawing.Point(729, 496);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(337, 42);
            this.cboRole.TabIndex = 47;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(654, 608);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(257, 64);
            this.btnLogin.TabIndex = 48;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.pmlBg);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pmlBg.ResumeLayout(false);
            this.pmlBg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pmlBg;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pbBg;
    }
}
