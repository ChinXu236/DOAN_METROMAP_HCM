namespace MetroMap_HCM
{
    partial class frmGa
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
            this.dgvGa = new System.Windows.Forms.DataGridView();
            this.lblMaGa = new System.Windows.Forms.Label();
            this.lblTenGa = new System.Windows.Forms.Label();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.lblThuTu = new System.Windows.Forms.Label();
            this.txtMaGa = new System.Windows.Forms.TextBox();
            this.txtTenGa = new System.Windows.Forms.TextBox();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.txtThuTu = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGa
            // 
            this.dgvGa.AllowUserToAddRows = false;
            this.dgvGa.AllowUserToDeleteRows = false;
            this.dgvGa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGa.BackgroundColor = System.Drawing.Color.White;
            this.dgvGa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGa.Location = new System.Drawing.Point(25, 250);
            this.dgvGa.Name = "dgvGa";
            this.dgvGa.ReadOnly = true;
            this.dgvGa.RowHeadersVisible = false;
            this.dgvGa.RowHeadersWidth = 51;
            this.dgvGa.RowTemplate.Height = 24;
            this.dgvGa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGa.Size = new System.Drawing.Size(740, 200);
            this.dgvGa.TabIndex = 0;
            this.dgvGa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGa_CellClick);
            // 
            // lblMaGa
            // 
            this.lblMaGa.AutoSize = true;
            this.lblMaGa.Location = new System.Drawing.Point(30, 30);
            this.lblMaGa.Name = "lblMaGa";
            this.lblMaGa.Size = new System.Drawing.Size(50, 16);
            this.lblMaGa.TabIndex = 1;
            this.lblMaGa.Text = "Mã Ga:";
            // 
            // lblTenGa
            // 
            this.lblTenGa.AutoSize = true;
            this.lblTenGa.Location = new System.Drawing.Point(30, 70);
            this.lblTenGa.Name = "lblTenGa";
            this.lblTenGa.Size = new System.Drawing.Size(55, 16);
            this.lblTenGa.TabIndex = 2;
            this.lblTenGa.Text = "Tên Ga:";
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Location = new System.Drawing.Point(30, 110);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(48, 16);
            this.lblTuyen.TabIndex = 3;
            this.lblTuyen.Text = "Tuyến:";
            // 
            // lblThuTu
            // 
            this.lblThuTu.AutoSize = true;
            this.lblThuTu.Location = new System.Drawing.Point(30, 150);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(46, 16);
            this.lblThuTu.TabIndex = 4;
            this.lblThuTu.Text = "Thứ tự:";
            // 
            // txtMaGa
            // 
            this.txtMaGa.Location = new System.Drawing.Point(110, 27);
            this.txtMaGa.Name = "txtMaGa";
            this.txtMaGa.Size = new System.Drawing.Size(200, 22);
            this.txtMaGa.TabIndex = 5;
            // 
            // txtTenGa
            // 
            this.txtTenGa.Location = new System.Drawing.Point(110, 67);
            this.txtTenGa.Name = "txtTenGa";
            this.txtTenGa.Size = new System.Drawing.Size(200, 22);
            this.txtTenGa.TabIndex = 6;
            // 
            // cboTuyen
            // 
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Location = new System.Drawing.Point(110, 107);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(200, 24);
            this.cboTuyen.TabIndex = 7;
            // 
            // txtThuTu
            // 
            this.txtThuTu.Location = new System.Drawing.Point(110, 147);
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Size = new System.Drawing.Size(200, 22);
            this.txtThuTu.TabIndex = 8;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(30, 200);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(200, 22);
            this.txtTim.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(470, 25);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(590, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(250, 197);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(80, 27);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Location = new System.Drawing.Point(350, 197);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(80, 27);
            this.btnTaiLai.TabIndex = 14;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // frmGa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.dgvGa);
            this.Controls.Add(this.lblMaGa);
            this.Controls.Add(this.lblTenGa);
            this.Controls.Add(this.lblTuyen);
            this.Controls.Add(this.lblThuTu);
            this.Controls.Add(this.txtMaGa);
            this.Controls.Add(this.txtTenGa);
            this.Controls.Add(this.cboTuyen);
            this.Controls.Add(this.txtThuTu);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnTaiLai);
            this.Name = "frmGa";
            this.Text = "Quản lý Ga Metro";
            this.Load += new System.EventHandler(this.frmGa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGa;
        private System.Windows.Forms.Label lblMaGa;
        private System.Windows.Forms.Label lblTenGa;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.Label lblThuTu;
        private System.Windows.Forms.TextBox txtMaGa;
        private System.Windows.Forms.TextBox txtTenGa;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.TextBox txtThuTu;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTaiLai;
    }
}
