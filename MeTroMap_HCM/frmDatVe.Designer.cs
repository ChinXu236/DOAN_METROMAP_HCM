namespace MetroMap_HCM
{
    partial class frmDatVe
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
            this.lblTuyen = new System.Windows.Forms.Label();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.lblGaDi = new System.Windows.Forms.Label();
            this.cboGaDi = new System.Windows.Forms.ComboBox();
            this.lblGaDen = new System.Windows.Forms.Label();
            this.cboGaDen = new System.Windows.Forms.ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.giaVe = new System.Windows.Forms.TextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.sd = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Location = new System.Drawing.Point(40, 40);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(76, 16);
            this.lblTuyen.TabIndex = 0;
            this.lblTuyen.Text = "Chọn tuyến:";
            // 
            // cboTuyen
            // 
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Location = new System.Drawing.Point(196, 37);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(364, 24);
            this.cboTuyen.TabIndex = 1;
            this.cboTuyen.SelectedIndexChanged += new System.EventHandler(this.cboTuyen_SelectedIndexChanged);
            // 
            // lblGaDi
            // 
            this.lblGaDi.AutoSize = true;
            this.lblGaDi.Location = new System.Drawing.Point(40, 80);
            this.lblGaDi.Name = "lblGaDi";
            this.lblGaDi.Size = new System.Drawing.Size(42, 16);
            this.lblGaDi.TabIndex = 2;
            this.lblGaDi.Text = "Ga đi:";
            // 
            // cboGaDi
            // 
            this.cboGaDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDi.Location = new System.Drawing.Point(196, 77);
            this.cboGaDi.Name = "cboGaDi";
            this.cboGaDi.Size = new System.Drawing.Size(364, 24);
            this.cboGaDi.TabIndex = 3;
            // 
            // lblGaDen
            // 
            this.lblGaDen.AutoSize = true;
            this.lblGaDen.Location = new System.Drawing.Point(40, 120);
            this.lblGaDen.Name = "lblGaDen";
            this.lblGaDen.Size = new System.Drawing.Size(54, 16);
            this.lblGaDen.TabIndex = 4;
            this.lblGaDen.Text = "Ga đến:";
            // 
            // cboGaDen
            // 
            this.cboGaDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDen.Location = new System.Drawing.Point(196, 117);
            this.cboGaDen.Name = "cboGaDen";
            this.cboGaDen.Size = new System.Drawing.Size(364, 24);
            this.cboGaDen.TabIndex = 5;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(40, 186);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(88, 16);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá vé (VNĐ):";
            // 
            // giaVe
            // 
            this.giaVe.Location = new System.Drawing.Point(196, 183);
            this.giaVe.Name = "giaVe";
            this.giaVe.ReadOnly = true;
            this.giaVe.Size = new System.Drawing.Size(185, 22);
            this.giaVe.TabIndex = 7;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(444, 159);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(116, 43);
            this.btnDatVe.TabIndex = 9;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(40, 151);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(81, 16);
            this.sd.TabIndex = 10;
            this.sd.Text = "Số lượng vé:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(196, 151);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 22);
            this.numSoLuong.TabIndex = 11;
            // 
            // frmDatVe
            // 
            this.ClientSize = new System.Drawing.Size(589, 234);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.sd);
            this.Controls.Add(this.lblTuyen);
            this.Controls.Add(this.cboTuyen);
            this.Controls.Add(this.lblGaDi);
            this.Controls.Add(this.cboGaDi);
            this.Controls.Add(this.lblGaDen);
            this.Controls.Add(this.cboGaDen);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.giaVe);
            this.Controls.Add(this.btnDatVe);
            this.Name = "frmDatVe";
            this.Text = "Đặt vé Metro";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.Label lblGaDi;
        private System.Windows.Forms.ComboBox cboGaDi;
        private System.Windows.Forms.Label lblGaDen;
        private System.Windows.Forms.ComboBox cboGaDen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox giaVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Label sd;
        private System.Windows.Forms.NumericUpDown numSoLuong;
    }
}
