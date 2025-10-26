namespace MetroMap_HCM
{
    partial class frmThongKe
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
            this.lblThang = new System.Windows.Forms.Label();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.dgvDoanhThu = new System.Windows.Forms.DataGridView();
            this.colTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtTongDoanhThu = new System.Windows.Forms.TextBox();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).BeginInit();
            this.SuspendLayout();

            // lblThang
            this.lblThang.AutoSize = true;
            this.lblThang.Location = new System.Drawing.Point(30, 30);
            this.lblThang.Text = "Chọn tháng:";

            // cboThang
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Location = new System.Drawing.Point(120, 27);
            this.cboThang.Width = 100;

            // btnThongKe
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Location = new System.Drawing.Point(250, 25);
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // dgvDoanhThu
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTuyen, this.colSoVe, this.colDoanhThu });
            this.dgvDoanhThu.Location = new System.Drawing.Point(30, 70);
            this.dgvDoanhThu.Size = new System.Drawing.Size(500, 200);
            this.dgvDoanhThu.ReadOnly = true;

            // colTuyen
            this.colTuyen.HeaderText = "Tuyến";
            this.colTuyen.DataPropertyName = "TenTuyen";

            // colSoVe
            this.colSoVe.HeaderText = "Số vé bán";
            this.colSoVe.DataPropertyName = "SoVe";

            // colDoanhThu
            this.colDoanhThu.HeaderText = "Doanh thu (VNĐ)";
            this.colDoanhThu.DataPropertyName = "DoanhThu";

            // lblTong
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(30, 290);
            this.lblTong.Text = "Tổng doanh thu:";

            // txtTongDoanhThu
            this.txtTongDoanhThu.Location = new System.Drawing.Point(150, 287);
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Width = 150;

            // frmThongKe
            this.ClientSize = new System.Drawing.Size(580, 340);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Text = "Thống kê doanh thu theo tháng";
            this.Load += new System.EventHandler(this.frmThongKe_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridView dgvDoanhThu;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtTongDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThu;
    }
}
