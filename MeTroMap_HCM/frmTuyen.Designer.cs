namespace MetroMap_HCM
{
    partial class frmTuyen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvTuyen = new System.Windows.Forms.DataGridView();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.txtTenTuyen = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvTuyen.ColumnHeadersHeight = 29;
            this.dgvTuyen.Location = new System.Drawing.Point(25, 164);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.RowHeadersVisible = false;
            this.dgvTuyen.RowHeadersWidth = 51;
            this.dgvTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyen.Size = new System.Drawing.Size(740, 246);
            this.dgvTuyen.TabIndex = 0;
            this.dgvTuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellClick);
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(40, 30);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(100, 23);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Tuyến:";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(40, 70);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 23);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Tuyến:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(40, 110);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(100, 23);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Location = new System.Drawing.Point(146, 27);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(300, 22);
            this.txtMaTuyen.TabIndex = 4;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.Location = new System.Drawing.Point(146, 67);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(300, 22);
            this.txtTenTuyen.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(146, 107);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(300, 22);
            this.txtMoTa.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(470, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(570, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(470, 67);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 26);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(570, 67);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(75, 26);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // frmTuyen
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTuyen);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtMaTuyen);
            this.Controls.Add(this.txtTenTuyen);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTaiLai);
            this.Name = "frmTuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tuyến Metro";
            this.Load += new System.EventHandler(this.frmTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvTuyen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.TextBox txtTenTuyen;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTaiLai;
    }
}
