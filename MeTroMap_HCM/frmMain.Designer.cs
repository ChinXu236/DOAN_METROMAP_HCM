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
            this.mniQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTuyen = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLienKet = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTimDuong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDatVe = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHeThong,
            this.mniQuanLy,
            this.mniNguoiDung});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniHeThong
            // 
            this.mniHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangXuat});
            this.mniHeThong.ForeColor = System.Drawing.Color.White;
            this.mniHeThong.Name = "mniHeThong";
            this.mniHeThong.Size = new System.Drawing.Size(97, 27);
            this.mniHeThong.Text = "Hệ thống";
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(178, 28);
            this.mniDangXuat.Text = "Đăng xuất";
            this.mniDangXuat.Click += new System.EventHandler(this.mniDangXuat_Click);
            // 
            // mniQuanLy
            // 
            this.mniQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGa,
            this.mniTuyen,
            this.mniLienKet,
            this.mniThongKe});
            this.mniQuanLy.ForeColor = System.Drawing.Color.White;
            this.mniQuanLy.Name = "mniQuanLy";
            this.mniQuanLy.Size = new System.Drawing.Size(90, 27);
            this.mniQuanLy.Text = "Quản lý";
            // 
            // mniGa
            // 
            this.mniGa.Name = "mniGa";
            this.mniGa.Size = new System.Drawing.Size(249, 28);
            this.mniGa.Text = "Ga";
            this.mniGa.Click += new System.EventHandler(this.mniGa_Click);
            // 
            // mniTuyen
            // 
            this.mniTuyen.Name = "mniTuyen";
            this.mniTuyen.Size = new System.Drawing.Size(249, 28);
            this.mniTuyen.Text = "Tuyến";
            this.mniTuyen.Click += new System.EventHandler(this.mniTuyen_Click);
            // 
            // mniLienKet
            // 
            this.mniLienKet.Name = "mniLienKet";
            this.mniLienKet.Size = new System.Drawing.Size(249, 28);
            this.mniLienKet.Text = "Liên kết";
            this.mniLienKet.Click += new System.EventHandler(this.mniLienKet_Click);
            // 
            // mniThongKe
            // 
            this.mniThongKe.Name = "mniThongKe";
            this.mniThongKe.Size = new System.Drawing.Size(249, 28);
            this.mniThongKe.Text = "Thống kê doanh thu";
            this.mniThongKe.Click += new System.EventHandler(this.mniThongKe_Click);
            // 
            // mniNguoiDung
            // 
            this.mniNguoiDung.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTimDuong,
            this.mniDatVe});
            this.mniNguoiDung.ForeColor = System.Drawing.Color.White;
            this.mniNguoiDung.Name = "mniNguoiDung";
            this.mniNguoiDung.Size = new System.Drawing.Size(121, 27);
            this.mniNguoiDung.Text = "Người dùng";
            // 
            // mniTimDuong
            // 
            this.mniTimDuong.Name = "mniTimDuong";
            this.mniTimDuong.Size = new System.Drawing.Size(267, 28);
            this.mniTimDuong.Text = "Tìm đường ngắn nhất";
            this.mniTimDuong.Click += new System.EventHandler(this.mniTimDuong_Click);
            // 
            // mniDatVe
            // 
            this.mniDatVe.Name = "mniDatVe";
            this.mniDatVe.Size = new System.Drawing.Size(267, 28);
            this.mniDatVe.Text = "Đặt vé Metro";
            this.mniDatVe.Click += new System.EventHandler(this.mniDatVe_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 31);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 669);
            this.pnlMain.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcome.Location = new System.Drawing.Point(20, 40);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 23);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "MetroMap HCM - Hệ thống quản lý và tra cứu Metro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem mniNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mniTimDuong;
        private System.Windows.Forms.ToolStripMenuItem mniDatVe;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblWelcome;
    }
}
