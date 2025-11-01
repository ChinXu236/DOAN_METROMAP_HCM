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
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlRowTen = new System.Windows.Forms.Panel();
            this.pnlInputTen = new System.Windows.Forms.Panel();
            this.pnlRowMoTa = new System.Windows.Forms.Panel();
            this.pnlInputMoTa = new System.Windows.Forms.Panel();
            this.pnlRowMa = new System.Windows.Forms.Panel();
            this.pnlInputMa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.pnlRowTen.SuspendLayout();
            this.pnlInputTen.SuspendLayout();
            this.pnlRowMoTa.SuspendLayout();
            this.pnlInputMoTa.SuspendLayout();
            this.pnlRowMa.SuspendLayout();
            this.pnlInputMa.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.BackgroundColor = System.Drawing.Color.White;
            this.dgvTuyen.ColumnHeadersHeight = 29;
            this.dgvTuyen.Location = new System.Drawing.Point(117, 263);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.RowHeadersVisible = false;
            this.dgvTuyen.RowHeadersWidth = 51;
            this.dgvTuyen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTuyen.Size = new System.Drawing.Size(957, 346);
            this.dgvTuyen.TabIndex = 0;
            this.dgvTuyen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellClick);
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(112, 44);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(100, 23);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "Mã Tuyến:";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(112, 96);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(100, 23);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên Tuyến:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(112, 160);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(100, 23);
            this.lblMoTa.TabIndex = 3;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.BackColor = System.Drawing.Color.White;
            this.txtMaTuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaTuyen.Location = new System.Drawing.Point(8, 6);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(403, 27);
            this.txtMaTuyen.TabIndex = 4;
            // 
            // txtTenTuyen
            // 
            this.txtTenTuyen.BackColor = System.Drawing.Color.White;
            this.txtTenTuyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenTuyen.Location = new System.Drawing.Point(8, 6);
            this.txtTenTuyen.Name = "txtTenTuyen";
            this.txtTenTuyen.Size = new System.Drawing.Size(405, 27);
            this.txtTenTuyen.TabIndex = 5;
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.Color.White;
            this.txtMoTa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Location = new System.Drawing.Point(8, 6);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(405, 84);
            this.txtMoTa.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(735, 35);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 54);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnSua.FlatAppearance.BorderSize = 2;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSua.Location = new System.Drawing.Point(932, 36);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 54);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnXoa.Location = new System.Drawing.Point(932, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 54);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.White;
            this.btnTaiLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 2;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnTaiLai.Location = new System.Drawing.Point(735, 129);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(118, 54);
            this.btnTaiLai.TabIndex = 10;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.lblMa);
            this.pnlCard.Controls.Add(this.pnlRowTen);
            this.pnlCard.Controls.Add(this.dgvTuyen);
            this.pnlCard.Controls.Add(this.pnlRowMoTa);
            this.pnlCard.Controls.Add(this.btnTaiLai);
            this.pnlCard.Controls.Add(this.btnXoa);
            this.pnlCard.Controls.Add(this.btnSua);
            this.pnlCard.Controls.Add(this.btnThem);
            this.pnlCard.Controls.Add(this.lblMoTa);
            this.pnlCard.Controls.Add(this.lblTen);
            this.pnlCard.Controls.Add(this.pnlRowMa);
            this.pnlCard.Location = new System.Drawing.Point(180, 22);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(24);
            this.pnlCard.Size = new System.Drawing.Size(1180, 650);
            this.pnlCard.TabIndex = 11;
            // 
            // pnlRowTen
            // 
            this.pnlRowTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pnlRowTen.Controls.Add(this.pnlInputTen);
            this.pnlRowTen.Location = new System.Drawing.Point(259, 84);
            this.pnlRowTen.Name = "pnlRowTen";
            this.pnlRowTen.Padding = new System.Windows.Forms.Padding(2);
            this.pnlRowTen.Size = new System.Drawing.Size(425, 40);
            this.pnlRowTen.TabIndex = 17;
            // 
            // pnlInputTen
            // 
            this.pnlInputTen.BackColor = System.Drawing.Color.White;
            this.pnlInputTen.Controls.Add(this.txtTenTuyen);
            this.pnlInputTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputTen.Location = new System.Drawing.Point(2, 2);
            this.pnlInputTen.Name = "pnlInputTen";
            this.pnlInputTen.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlInputTen.Size = new System.Drawing.Size(421, 36);
            this.pnlInputTen.TabIndex = 0;
            // 
            // pnlRowMoTa
            // 
            this.pnlRowMoTa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pnlRowMoTa.Controls.Add(this.pnlInputMoTa);
            this.pnlRowMoTa.Location = new System.Drawing.Point(259, 144);
            this.pnlRowMoTa.Name = "pnlRowMoTa";
            this.pnlRowMoTa.Padding = new System.Windows.Forms.Padding(2);
            this.pnlRowMoTa.Size = new System.Drawing.Size(425, 100);
            this.pnlRowMoTa.TabIndex = 18;
            // 
            // pnlInputMoTa
            // 
            this.pnlInputMoTa.BackColor = System.Drawing.Color.White;
            this.pnlInputMoTa.Controls.Add(this.txtMoTa);
            this.pnlInputMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputMoTa.Location = new System.Drawing.Point(2, 2);
            this.pnlInputMoTa.Name = "pnlInputMoTa";
            this.pnlInputMoTa.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlInputMoTa.Size = new System.Drawing.Size(421, 96);
            this.pnlInputMoTa.TabIndex = 0;
            // 
            // pnlRowMa
            // 
            this.pnlRowMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pnlRowMa.Controls.Add(this.pnlInputMa);
            this.pnlRowMa.Location = new System.Drawing.Point(259, 27);
            this.pnlRowMa.Name = "pnlRowMa";
            this.pnlRowMa.Padding = new System.Windows.Forms.Padding(2);
            this.pnlRowMa.Size = new System.Drawing.Size(423, 40);
            this.pnlRowMa.TabIndex = 16;
            // 
            // pnlInputMa
            // 
            this.pnlInputMa.BackColor = System.Drawing.Color.White;
            this.pnlInputMa.Controls.Add(this.txtMaTuyen);
            this.pnlInputMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputMa.Location = new System.Drawing.Point(2, 2);
            this.pnlInputMa.Name = "pnlInputMa";
            this.pnlInputMa.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pnlInputMa.Size = new System.Drawing.Size(419, 36);
            this.pnlInputMa.TabIndex = 0;
            // 
            // frmTuyen
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 713);
            this.Controls.Add(this.pnlCard);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTuyen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Tuyến Metro";
            this.Load += new System.EventHandler(this.frmTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlRowTen.ResumeLayout(false);
            this.pnlInputTen.ResumeLayout(false);
            this.pnlInputTen.PerformLayout();
            this.pnlRowMoTa.ResumeLayout(false);
            this.pnlInputMoTa.ResumeLayout(false);
            this.pnlInputMoTa.PerformLayout();
            this.pnlRowMa.ResumeLayout(false);
            this.pnlInputMa.ResumeLayout(false);
            this.pnlInputMa.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlRowMa;
        private System.Windows.Forms.Panel pnlInputMa;
        private System.Windows.Forms.Panel pnlRowTen;
        private System.Windows.Forms.Panel pnlInputTen;
        private System.Windows.Forms.Panel pnlRowMoTa;
        private System.Windows.Forms.Panel pnlInputMoTa;
    }
}
