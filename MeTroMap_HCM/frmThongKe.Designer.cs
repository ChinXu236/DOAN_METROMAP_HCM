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
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThang.Location = new System.Drawing.Point(115, 40);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(199, 42);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Chọn tháng:";
            // 
            // cboThang
            // 
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.Location = new System.Drawing.Point(421, 37);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(400, 50);
            this.cboThang.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(912, 37);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(162, 50);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // dgvDoanhThu
            // 
            this.dgvDoanhThu.AllowUserToAddRows = false;
            this.dgvDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.dgvDoanhThu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDoanhThu.ColumnHeadersHeight = 29;
            this.dgvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTuyen,
            this.colSoVe,
            this.colDoanhThu});
            this.dgvDoanhThu.Location = new System.Drawing.Point(122, 117);
            this.dgvDoanhThu.Name = "dgvDoanhThu";
            this.dgvDoanhThu.ReadOnly = true;
            this.dgvDoanhThu.RowHeadersWidth = 51;
            this.dgvDoanhThu.Size = new System.Drawing.Size(1304, 492);
            this.dgvDoanhThu.TabIndex = 3;
            // 
            // colTuyen
            // 
            this.colTuyen.DataPropertyName = "TenTuyen";
            this.colTuyen.HeaderText = "Tuyến";
            this.colTuyen.MinimumWidth = 6;
            this.colTuyen.Name = "colTuyen";
            this.colTuyen.ReadOnly = true;
            // 
            // colSoVe
            // 
            this.colSoVe.DataPropertyName = "SoVe";
            this.colSoVe.HeaderText = "Số vé bán";
            this.colSoVe.MinimumWidth = 6;
            this.colSoVe.Name = "colSoVe";
            this.colSoVe.ReadOnly = true;
            // 
            // colDoanhThu
            // 
            this.colDoanhThu.DataPropertyName = "DoanhThu";
            this.colDoanhThu.HeaderText = "Doanh thu (VNĐ)";
            this.colDoanhThu.MinimumWidth = 6;
            this.colDoanhThu.Name = "colDoanhThu";
            this.colDoanhThu.ReadOnly = true;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(297, 644);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(261, 42);
            this.lblTong.TabIndex = 4;
            this.lblTong.Text = "Tổng doanh thu:";
            // 
            // txtTongDoanhThu
            // 
            this.txtTongDoanhThu.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongDoanhThu.Location = new System.Drawing.Point(666, 636);
            this.txtTongDoanhThu.Name = "txtTongDoanhThu";
            this.txtTongDoanhThu.ReadOnly = true;
            this.txtTongDoanhThu.Size = new System.Drawing.Size(351, 50);
            this.txtTongDoanhThu.TabIndex = 5;
            // 
            // frmThongKe
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 720);
            this.Controls.Add(this.lblThang);
            this.Controls.Add(this.cboThang);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dgvDoanhThu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtTongDoanhThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu theo tháng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
