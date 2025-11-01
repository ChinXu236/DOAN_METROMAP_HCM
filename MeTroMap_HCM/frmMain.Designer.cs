namespace MetroMap_HCM
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.ảnhCácTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLienKet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTaiKhoanNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTimDuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDatVe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTaiKhoanNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinVéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.flpInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlHero = new System.Windows.Forms.Panel();
            this.pbHero = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.flpInfo.SuspendLayout();
            this.pnlHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(44)))));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHeThong,
            this.mniQuanLy,
            this.mniNguoiDung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1625, 72);
            this.menuStrip1.TabIndex = 0;
            // 
            // mniHeThong
            // 
            this.mniHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangXuat,
            this.ảnhCácTuyếnToolStripMenuItem});
            this.mniHeThong.ForeColor = System.Drawing.Color.White;
            this.mniHeThong.Name = "mniHeThong";
            this.mniHeThong.Size = new System.Drawing.Size(119, 66);
            this.mniHeThong.Text = "Hệ thống";
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(253, 30);
            this.mniDangXuat.Text = "Đăng xuất";
            this.mniDangXuat.Click += new System.EventHandler(this.mniDangXuat_Click);
            // 
            // ảnhCácTuyếnToolStripMenuItem
            // 
            this.ảnhCácTuyếnToolStripMenuItem.Name = "ảnhCácTuyếnToolStripMenuItem";
            this.ảnhCácTuyếnToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.ảnhCácTuyếnToolStripMenuItem.Text = "Ảnh Các Tuyến";
            this.ảnhCácTuyếnToolStripMenuItem.Click += new System.EventHandler(this.ảnhCácTuyếnToolStripMenuItem_Click);
            // 
            // mniQuanLy
            // 
            this.mniQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGa,
            this.mniTuyen,
            this.mniLienKet,
            this.mniThongKe,
            this.mniTaiKhoanNhanVien});
            this.mniQuanLy.ForeColor = System.Drawing.Color.White;
            this.mniQuanLy.Name = "mniQuanLy";
            this.mniQuanLy.Size = new System.Drawing.Size(105, 66);
            this.mniQuanLy.Text = "Quản lý";
            // 
            // mniGa
            // 
            this.mniGa.Name = "mniGa";
            this.mniGa.Size = new System.Drawing.Size(300, 30);
            this.mniGa.Text = "Ga";
            this.mniGa.Click += new System.EventHandler(this.mniGa_Click);
            // 
            // mniTuyen
            // 
            this.mniTuyen.Name = "mniTuyen";
            this.mniTuyen.Size = new System.Drawing.Size(300, 30);
            this.mniTuyen.Text = "Tuyến";
            this.mniTuyen.Click += new System.EventHandler(this.mniTuyen_Click);
            // 
            // mniLienKet
            // 
            this.mniLienKet.Name = "mniLienKet";
            this.mniLienKet.Size = new System.Drawing.Size(300, 30);
            this.mniLienKet.Text = "Liên kết";
            this.mniLienKet.Click += new System.EventHandler(this.mniLienKet_Click);
            // 
            // mniThongKe
            // 
            this.mniThongKe.Name = "mniThongKe";
            this.mniThongKe.Size = new System.Drawing.Size(300, 30);
            this.mniThongKe.Text = "Thống kê doanh thu";
            this.mniThongKe.Click += new System.EventHandler(this.mniThongKe_Click);
            // 
            // mniTaiKhoanNhanVien
            // 
            this.mniTaiKhoanNhanVien.Name = "mniTaiKhoanNhanVien";
            this.mniTaiKhoanNhanVien.Size = new System.Drawing.Size(300, 30);
            this.mniTaiKhoanNhanVien.Text = "Tài khoản nhân viên";
            this.mniTaiKhoanNhanVien.Click += new System.EventHandler(this.mniTaiKhoanNhanVien_Click);
            // 
            // mniNguoiDung
            // 
            this.mniNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTimDuong,
            this.mniDatVe,
            this.mniTaiKhoanNguoiDung,
            this.thôngTinVéToolStripMenuItem});
            this.mniNguoiDung.ForeColor = System.Drawing.Color.White;
            this.mniNguoiDung.Name = "mniNguoiDung";
            this.mniNguoiDung.Size = new System.Drawing.Size(144, 66);
            this.mniNguoiDung.Text = "Người dùng";
            // 
            // mniTimDuong
            // 
            this.mniTimDuong.Name = "mniTimDuong";
            this.mniTimDuong.Size = new System.Drawing.Size(318, 30);
            this.mniTimDuong.Text = "Tìm đường";
            this.mniTimDuong.Click += new System.EventHandler(this.mniTimDuong_Click);
            // 
            // mniDatVe
            // 
            this.mniDatVe.Name = "mniDatVe";
            this.mniDatVe.Size = new System.Drawing.Size(318, 30);
            this.mniDatVe.Text = "Đặt vé Metro";
            this.mniDatVe.Click += new System.EventHandler(this.mniDatVe_Click);
            // 
            // mniTaiKhoanNguoiDung
            // 
            this.mniTaiKhoanNguoiDung.Name = "mniTaiKhoanNguoiDung";
            this.mniTaiKhoanNguoiDung.Size = new System.Drawing.Size(318, 30);
            this.mniTaiKhoanNguoiDung.Text = "Tài khoản người dùng";
            this.mniTaiKhoanNguoiDung.Click += new System.EventHandler(this.mniTaiKhoanNguoiDung_Click);
            // 
            // thôngTinVéToolStripMenuItem
            // 
            this.thôngTinVéToolStripMenuItem.Name = "thôngTinVéToolStripMenuItem";
            this.thôngTinVéToolStripMenuItem.Size = new System.Drawing.Size(318, 30);
            this.thôngTinVéToolStripMenuItem.Text = "Thông tin chi tiết vé";
            this.thôngTinVéToolStripMenuItem.Click += new System.EventHandler(this.thôngTinVéToolStripMenuItem_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlHero);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 72);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1625, 983);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Controls.Add(this.flpInfo);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 520);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1625, 463);
            this.pnlContent.TabIndex = 0;
            // 
            // flpInfo
            // 
            this.flpInfo.AutoSize = true;
            this.flpInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpInfo.Controls.Add(this.label1);
            this.flpInfo.Controls.Add(this.label2);
            this.flpInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpInfo.Location = new System.Drawing.Point(0, 0);
            this.flpInfo.Name = "flpInfo";
            this.flpInfo.Padding = new System.Windows.Forms.Padding(24);
            this.flpInfo.Size = new System.Drawing.Size(1625, 169);
            this.flpInfo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.flpInfo.SetFlowBreak(this.label1, true);
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1091, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "METRO HO CHI MINH LINE – OVERVIEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 22.2F);
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create OCT 2025";
            // 
            // pnlHero
            // 
            this.pnlHero.BackColor = System.Drawing.Color.Black;
            this.pnlHero.Controls.Add(this.pbHero);
            this.pnlHero.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHero.Location = new System.Drawing.Point(0, 0);
            this.pnlHero.Name = "pnlHero";
            this.pnlHero.Size = new System.Drawing.Size(1625, 520);
            this.pnlHero.TabIndex = 1;
            // 
            // pbHero
            // 
            this.pbHero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbHero.Image = global::MeTroMap_HCM.Properties.Resources.backgroundFrmMain;
            this.pbHero.Location = new System.Drawing.Point(0, 0);
            this.pbHero.Name = "pbHero";
            this.pbHero.Size = new System.Drawing.Size(1625, 520);
            this.pbHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHero.TabIndex = 0;
            this.pbHero.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(32, 65);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 1055);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetroMap HCM - Hệ thống quản lý và tra cứu Metro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.flpInfo.ResumeLayout(false);
            this.flpInfo.PerformLayout();
            this.pnlHero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniHeThong;
        private System.Windows.Forms.ToolStripMenuItem mniDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mniQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mniGa;
        private System.Windows.Forms.ToolStripMenuItem mniTuyen;
        private System.Windows.Forms.ToolStripMenuItem mniLienKet;
        private System.Windows.Forms.ToolStripMenuItem mniThongKe;
        private System.Windows.Forms.ToolStripMenuItem mniTaiKhoanNhanVien; // thêm mới
        private System.Windows.Forms.ToolStripMenuItem mniNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mniTimDuong;
        private System.Windows.Forms.ToolStripMenuItem mniDatVe;
        private System.Windows.Forms.ToolStripMenuItem mniTaiKhoanNguoiDung; // thêm mới
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlHero;
        private System.Windows.Forms.PictureBox pbHero;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem thôngTinVéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ảnhCácTuyếnToolStripMenuItem;
    }
}
