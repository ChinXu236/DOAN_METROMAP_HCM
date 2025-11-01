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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblMaGa = new System.Windows.Forms.Label();
            this.lblTenGa = new System.Windows.Forms.Label();
            this.lblTuyen = new System.Windows.Forms.Label();
            this.lblThuTu = new System.Windows.Forms.Label();
            this.txtMaGa = new System.Windows.Forms.TextBox();
            this.cboTuyen = new System.Windows.Forms.ComboBox();
            this.txtThuTu = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.dgvGa = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenGa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.Label();
            this.pWrapTim = new System.Windows.Forms.Panel();
            this.pInnerTim = new System.Windows.Forms.Panel();
            this.pWrapThuTu = new System.Windows.Forms.Panel();
            this.pInnerThuTu = new System.Windows.Forms.Panel();
            this.pWrapTuyen = new System.Windows.Forms.Panel();
            this.pInnerTuyen = new System.Windows.Forms.Panel();
            this.pWrapTen = new System.Windows.Forms.Panel();
            this.pInnerTen = new System.Windows.Forms.Panel();
            this.txtTenGa = new System.Windows.Forms.TextBox();
            this.pWrapMa = new System.Windows.Forms.Panel();
            this.pInnerMa = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.pWrapTim.SuspendLayout();
            this.pInnerTim.SuspendLayout();
            this.pWrapThuTu.SuspendLayout();
            this.pInnerThuTu.SuspendLayout();
            this.pWrapTuyen.SuspendLayout();
            this.pInnerTuyen.SuspendLayout();
            this.pWrapTen.SuspendLayout();
            this.pInnerTen.SuspendLayout();
            this.pWrapMa.SuspendLayout();
            this.pInnerMa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaGa
            // 
            this.lblMaGa.AutoSize = true;
            this.lblMaGa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGa.Location = new System.Drawing.Point(32, 30);
            this.lblMaGa.Name = "lblMaGa";
            this.lblMaGa.Size = new System.Drawing.Size(79, 26);
            this.lblMaGa.TabIndex = 1;
            this.lblMaGa.Text = "Mã Ga:";
            this.lblMaGa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTenGa
            // 
            this.lblTenGa.AutoSize = true;
            this.lblTenGa.BackColor = System.Drawing.Color.White;
            this.lblTenGa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenGa.Location = new System.Drawing.Point(32, 88);
            this.lblTenGa.Name = "lblTenGa";
            this.lblTenGa.Size = new System.Drawing.Size(86, 26);
            this.lblTenGa.TabIndex = 2;
            this.lblTenGa.Text = "Tên Ga:";
            // 
            // lblTuyen
            // 
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuyen.Location = new System.Drawing.Point(549, 31);
            this.lblTuyen.Name = "lblTuyen";
            this.lblTuyen.Size = new System.Drawing.Size(77, 26);
            this.lblTuyen.TabIndex = 3;
            this.lblTuyen.Text = "Tuyến:";
            // 
            // lblThuTu
            // 
            this.lblThuTu.AutoSize = true;
            this.lblThuTu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuTu.Location = new System.Drawing.Point(547, 88);
            this.lblThuTu.Name = "lblThuTu";
            this.lblThuTu.Size = new System.Drawing.Size(80, 26);
            this.lblThuTu.TabIndex = 4;
            this.lblThuTu.Text = "Thứ tự:";
            // 
            // txtMaGa
            // 
            this.txtMaGa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaGa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaGa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGa.Location = new System.Drawing.Point(8, 6);
            this.txtMaGa.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaGa.Multiline = true;
            this.txtMaGa.Name = "txtMaGa";
            this.txtMaGa.Size = new System.Drawing.Size(340, 24);
            this.txtMaGa.TabIndex = 5;
            // 
            // cboTuyen
            // 
            this.cboTuyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTuyen.IntegralHeight = false;
            this.cboTuyen.Location = new System.Drawing.Point(8, 7);
            this.cboTuyen.Margin = new System.Windows.Forms.Padding(0);
            this.cboTuyen.Name = "cboTuyen";
            this.cboTuyen.Size = new System.Drawing.Size(340, 24);
            this.cboTuyen.TabIndex = 7;
            // 
            // txtThuTu
            // 
            this.txtThuTu.BackColor = System.Drawing.Color.White;
            this.txtThuTu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtThuTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtThuTu.Location = new System.Drawing.Point(8, 6);
            this.txtThuTu.Multiline = true;
            this.txtThuTu.Name = "txtThuTu";
            this.txtThuTu.Size = new System.Drawing.Size(340, 24);
            this.txtThuTu.TabIndex = 8;
            // 
            // txtTim
            // 
            this.txtTim.BackColor = System.Drawing.Color.White;
            this.txtTim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTim.Location = new System.Drawing.Point(8, 6);
            this.txtTim.Margin = new System.Windows.Forms.Padding(0);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(340, 24);
            this.txtTim.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(1047, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 10;
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
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnSua.Location = new System.Drawing.Point(1047, 80);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 40);
            this.btnSua.TabIndex = 11;
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
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnXoa.Location = new System.Drawing.Point(1047, 129);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.White;
            this.btnTim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnTim.FlatAppearance.BorderSize = 2;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(548, 131);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 40);
            this.btnTim.TabIndex = 13;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.BackColor = System.Drawing.Color.White;
            this.btnTaiLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnTaiLai.FlatAppearance.BorderSize = 2;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(709, 133);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(120, 40);
            this.btnTaiLai.TabIndex = 14;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // dgvGa
            // 
            this.dgvGa.AllowUserToAddRows = false;
            this.dgvGa.AllowUserToDeleteRows = false;
            this.dgvGa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGa.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaGa,
            this.colTenGa,
            this.colTuyen});
            this.dgvGa.Location = new System.Drawing.Point(176, 247);
            this.dgvGa.Name = "dgvGa";
            this.dgvGa.ReadOnly = true;
            this.dgvGa.RowHeadersVisible = false;
            this.dgvGa.RowHeadersWidth = 51;
            this.dgvGa.RowTemplate.Height = 24;
            this.dgvGa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGa.Size = new System.Drawing.Size(1209, 292);
            this.dgvGa.TabIndex = 0;
            this.dgvGa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGa_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 84;
            // 
            // colMaGa
            // 
            this.colMaGa.DataPropertyName = "MaGa";
            this.colMaGa.HeaderText = "Mã ga";
            this.colMaGa.MinimumWidth = 6;
            this.colMaGa.Name = "colMaGa";
            this.colMaGa.ReadOnly = true;
            // 
            // colTenGa
            // 
            this.colTenGa.DataPropertyName = "TenGa";
            this.colTenGa.HeaderText = "Tên ga";
            this.colTenGa.MinimumWidth = 6;
            this.colTenGa.Name = "colTenGa";
            this.colTenGa.ReadOnly = true;
            // 
            // colTuyen
            // 
            this.colTuyen.DataPropertyName = "TenTuyen";
            this.colTuyen.HeaderText = "Tuyến";
            this.colTuyen.MinimumWidth = 6;
            this.colTuyen.Name = "colTuyen";
            this.colTuyen.ReadOnly = true;
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.txtTimKiem);
            this.pnlCard.Controls.Add(this.pWrapTim);
            this.pnlCard.Controls.Add(this.pWrapThuTu);
            this.pnlCard.Controls.Add(this.btnTaiLai);
            this.pnlCard.Controls.Add(this.btnTim);
            this.pnlCard.Controls.Add(this.btnXoa);
            this.pnlCard.Controls.Add(this.btnSua);
            this.pnlCard.Controls.Add(this.btnThem);
            this.pnlCard.Controls.Add(this.pWrapTuyen);
            this.pnlCard.Controls.Add(this.pWrapTen);
            this.pnlCard.Controls.Add(this.lblThuTu);
            this.pnlCard.Controls.Add(this.pWrapMa);
            this.pnlCard.Controls.Add(this.lblTuyen);
            this.pnlCard.Controls.Add(this.lblTenGa);
            this.pnlCard.Controls.Add(this.lblMaGa);
            this.pnlCard.Location = new System.Drawing.Point(176, 23);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard.Size = new System.Drawing.Size(1209, 198);
            this.pnlCard.TabIndex = 15;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoSize = true;
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(32, 137);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(106, 26);
            this.txtTimKiem.TabIndex = 15;
            this.txtTimKiem.Text = "Tìm Kiếm";
            // 
            // pWrapTim
            // 
            this.pWrapTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pWrapTim.Controls.Add(this.pInnerTim);
            this.pWrapTim.Location = new System.Drawing.Point(157, 131);
            this.pWrapTim.Margin = new System.Windows.Forms.Padding(0);
            this.pWrapTim.Name = "pWrapTim";
            this.pWrapTim.Padding = new System.Windows.Forms.Padding(2);
            this.pWrapTim.Size = new System.Drawing.Size(360, 40);
            this.pWrapTim.TabIndex = 6;
            // 
            // pInnerTim
            // 
            this.pInnerTim.BackColor = System.Drawing.Color.White;
            this.pInnerTim.Controls.Add(this.txtTim);
            this.pInnerTim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInnerTim.Location = new System.Drawing.Point(2, 2);
            this.pInnerTim.Margin = new System.Windows.Forms.Padding(0);
            this.pInnerTim.Name = "pInnerTim";
            this.pInnerTim.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pInnerTim.Size = new System.Drawing.Size(356, 36);
            this.pInnerTim.TabIndex = 7;
            // 
            // pWrapThuTu
            // 
            this.pWrapThuTu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pWrapThuTu.Controls.Add(this.pInnerThuTu);
            this.pWrapThuTu.Location = new System.Drawing.Point(660, 78);
            this.pWrapThuTu.Name = "pWrapThuTu";
            this.pWrapThuTu.Padding = new System.Windows.Forms.Padding(2);
            this.pWrapThuTu.Size = new System.Drawing.Size(360, 40);
            this.pWrapThuTu.TabIndex = 5;
            // 
            // pInnerThuTu
            // 
            this.pInnerThuTu.BackColor = System.Drawing.Color.White;
            this.pInnerThuTu.Controls.Add(this.txtThuTu);
            this.pInnerThuTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInnerThuTu.Location = new System.Drawing.Point(2, 2);
            this.pInnerThuTu.Margin = new System.Windows.Forms.Padding(0);
            this.pInnerThuTu.Name = "pInnerThuTu";
            this.pInnerThuTu.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pInnerThuTu.Size = new System.Drawing.Size(356, 36);
            this.pInnerThuTu.TabIndex = 6;
            // 
            // pWrapTuyen
            // 
            this.pWrapTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pWrapTuyen.Controls.Add(this.pInnerTuyen);
            this.pWrapTuyen.Location = new System.Drawing.Point(660, 23);
            this.pWrapTuyen.Name = "pWrapTuyen";
            this.pWrapTuyen.Padding = new System.Windows.Forms.Padding(2);
            this.pWrapTuyen.Size = new System.Drawing.Size(360, 40);
            this.pWrapTuyen.TabIndex = 4;
            // 
            // pInnerTuyen
            // 
            this.pInnerTuyen.BackColor = System.Drawing.Color.White;
            this.pInnerTuyen.Controls.Add(this.cboTuyen);
            this.pInnerTuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInnerTuyen.Location = new System.Drawing.Point(2, 2);
            this.pInnerTuyen.Margin = new System.Windows.Forms.Padding(0);
            this.pInnerTuyen.Name = "pInnerTuyen";
            this.pInnerTuyen.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pInnerTuyen.Size = new System.Drawing.Size(356, 36);
            this.pInnerTuyen.TabIndex = 5;
            // 
            // pWrapTen
            // 
            this.pWrapTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pWrapTen.Controls.Add(this.pInnerTen);
            this.pWrapTen.Location = new System.Drawing.Point(157, 76);
            this.pWrapTen.Name = "pWrapTen";
            this.pWrapTen.Padding = new System.Windows.Forms.Padding(2);
            this.pWrapTen.Size = new System.Drawing.Size(360, 40);
            this.pWrapTen.TabIndex = 3;
            // 
            // pInnerTen
            // 
            this.pInnerTen.BackColor = System.Drawing.Color.White;
            this.pInnerTen.Controls.Add(this.txtTenGa);
            this.pInnerTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pInnerTen.Location = new System.Drawing.Point(2, 2);
            this.pInnerTen.Margin = new System.Windows.Forms.Padding(0);
            this.pInnerTen.Name = "pInnerTen";
            this.pInnerTen.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pInnerTen.Size = new System.Drawing.Size(356, 36);
            this.pInnerTen.TabIndex = 4;
            // 
            // txtTenGa
            // 
            this.txtTenGa.BackColor = System.Drawing.Color.White;
            this.txtTenGa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenGa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenGa.Location = new System.Drawing.Point(8, 6);
            this.txtTenGa.Multiline = true;
            this.txtTenGa.Name = "txtTenGa";
            this.txtTenGa.Size = new System.Drawing.Size(340, 24);
            this.txtTenGa.TabIndex = 0;
            // 
            // pWrapMa
            // 
            this.pWrapMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.pWrapMa.Controls.Add(this.pInnerMa);
            this.pWrapMa.Location = new System.Drawing.Point(157, 23);
            this.pWrapMa.Name = "pWrapMa";
            this.pWrapMa.Padding = new System.Windows.Forms.Padding(2);
            this.pWrapMa.Size = new System.Drawing.Size(360, 40);
            this.pWrapMa.TabIndex = 2;
            // 
            // pInnerMa
            // 
            this.pInnerMa.BackColor = System.Drawing.Color.White;
            this.pInnerMa.Controls.Add(this.txtMaGa);
            this.pInnerMa.Location = new System.Drawing.Point(2, 2);
            this.pInnerMa.Name = "pInnerMa";
            this.pInnerMa.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.pInnerMa.Size = new System.Drawing.Size(356, 36);
            this.pInnerMa.TabIndex = 0;
            // 
            // frmGa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 698);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.dgvGa);
            this.Name = "frmGa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Ga Metro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGa)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pWrapTim.ResumeLayout(false);
            this.pInnerTim.ResumeLayout(false);
            this.pInnerTim.PerformLayout();
            this.pWrapThuTu.ResumeLayout(false);
            this.pInnerThuTu.ResumeLayout(false);
            this.pInnerThuTu.PerformLayout();
            this.pWrapTuyen.ResumeLayout(false);
            this.pInnerTuyen.ResumeLayout(false);
            this.pWrapTen.ResumeLayout(false);
            this.pInnerTen.ResumeLayout(false);
            this.pInnerTen.PerformLayout();
            this.pWrapMa.ResumeLayout(false);
            this.pInnerMa.ResumeLayout(false);
            this.pInnerMa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMaGa;
        private System.Windows.Forms.Label lblTenGa;
        private System.Windows.Forms.Label lblTuyen;
        private System.Windows.Forms.Label lblThuTu;
        private System.Windows.Forms.TextBox txtMaGa;
        private System.Windows.Forms.ComboBox cboTuyen;
        private System.Windows.Forms.TextBox txtThuTu;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.DataGridView dgvGa;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pWrapMa;
        private System.Windows.Forms.Panel pInnerMa;
        private System.Windows.Forms.Panel pInnerTen;
        private System.Windows.Forms.Panel pWrapTen;
        private System.Windows.Forms.TextBox txtTenGa;
        private System.Windows.Forms.Panel pWrapTuyen;
        private System.Windows.Forms.Panel pInnerTuyen;
        private System.Windows.Forms.Panel pWrapThuTu;
        private System.Windows.Forms.Panel pInnerThuTu;
        private System.Windows.Forms.Panel pWrapTim;
        private System.Windows.Forms.Panel pInnerTim;
        private System.Windows.Forms.Label txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaGa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenGa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTuyen;
    }
}
