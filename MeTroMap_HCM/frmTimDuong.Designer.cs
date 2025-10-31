namespace MetroMap_HCM
{
    partial class frmTimDuong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblGaĐi;
        private System.Windows.Forms.Label lblGaĐến;
        private System.Windows.Forms.TextBox txtTu;
        private System.Windows.Forms.TextBox txtDen;
        private System.Windows.Forms.Button btnTimDuong;
        private System.Windows.Forms.Button btnDoiChieu;
        private System.Windows.Forms.DataGridView dgvLoTrinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblGaĐi = new System.Windows.Forms.Label();
            this.lblGaĐến = new System.Windows.Forms.Label();
            this.txtTu = new System.Windows.Forms.TextBox();
            this.txtDen = new System.Windows.Forms.TextBox();
            this.btnTimDuong = new System.Windows.Forms.Button();
            this.btnDoiChieu = new System.Windows.Forms.Button();
            this.dgvLoTrinh = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GaDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoangCach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioXuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.BtnQuayLai = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.tlpSearch = new System.Windows.Forms.TableLayoutPanel();
            this.flpRow3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRow1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpRow2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lxtGioXP = new System.Windows.Forms.Label();
            this.lxtGioD = new System.Windows.Forms.Label();
            this.txtXP = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.dtvThoiGian = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoTrinh)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.tlpSearch.SuspendLayout();
            this.flpRow3.SuspendLayout();
            this.flpRow1.SuspendLayout();
            this.flpRow2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGaĐi
            // 
            this.lblGaĐi.AutoSize = true;
            this.lblGaĐi.Location = new System.Drawing.Point(3, 0);
            this.lblGaĐi.Name = "lblGaĐi";
            this.lblGaĐi.Size = new System.Drawing.Size(62, 26);
            this.lblGaĐi.TabIndex = 0;
            this.lblGaĐi.Text = "Ga đi";
            this.lblGaĐi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGaĐến
            // 
            this.lblGaĐến.AutoSize = true;
            this.lblGaĐến.Location = new System.Drawing.Point(3, 47);
            this.lblGaĐến.Name = "lblGaĐến";
            this.lblGaĐến.Size = new System.Drawing.Size(46, 51);
            this.lblGaĐến.TabIndex = 1;
            this.lblGaĐến.Text = "Ga đến";
            // 
            // txtTu
            // 
            this.txtTu.Location = new System.Drawing.Point(83, 3);
            this.txtTu.Name = "txtTu";
            this.txtTu.Size = new System.Drawing.Size(354, 34);
            this.txtTu.TabIndex = 2;
            // 
            // txtDen
            // 
            this.txtDen.Location = new System.Drawing.Point(83, 50);
            this.txtDen.Name = "txtDen";
            this.txtDen.Size = new System.Drawing.Size(354, 34);
            this.txtDen.TabIndex = 3;
            // 
            // btnTimDuong
            // 
            this.btnTimDuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnTimDuong.FlatAppearance.BorderSize = 0;
            this.btnTimDuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDuong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDuong.ForeColor = System.Drawing.Color.White;
            this.btnTimDuong.Location = new System.Drawing.Point(576, 47);
            this.btnTimDuong.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnTimDuong.Name = "btnTimDuong";
            this.btnTimDuong.Size = new System.Drawing.Size(140, 40);
            this.btnTimDuong.TabIndex = 4;
            this.btnTimDuong.Text = "Tìm đường";
            this.btnTimDuong.UseVisualStyleBackColor = false;
            // 
            // btnDoiChieu
            // 
            this.btnDoiChieu.BackColor = System.Drawing.Color.PowderBlue;
            this.btnDoiChieu.Location = new System.Drawing.Point(443, 3);
            this.btnDoiChieu.Name = "btnDoiChieu";
            this.btnDoiChieu.Size = new System.Drawing.Size(50, 41);
            this.btnDoiChieu.TabIndex = 5;
            this.btnDoiChieu.Text = "⇄";
            this.btnDoiChieu.UseVisualStyleBackColor = false;
            // 
            // dgvLoTrinh
            // 
            this.dgvLoTrinh.AllowUserToAddRows = false;
            this.dgvLoTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoTrinh.BackgroundColor = System.Drawing.Color.White;
            this.dgvLoTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoTrinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.GaDi,
            this.GaDen,
            this.Tuyen,
            this.KhoangCach,
            this.GioXuatPhat});
            this.dgvLoTrinh.Location = new System.Drawing.Point(199, 241);
            this.dgvLoTrinh.Name = "dgvLoTrinh";
            this.dgvLoTrinh.ReadOnly = true;
            this.dgvLoTrinh.RowHeadersVisible = false;
            this.dgvLoTrinh.RowHeadersWidth = 51;
            this.dgvLoTrinh.RowTemplate.Height = 40;
            this.dgvLoTrinh.Size = new System.Drawing.Size(1288, 430);
            this.dgvLoTrinh.TabIndex = 6;
            // 
            // STT
            // 
            this.STT.FillWeight = 30F;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // GaDi
            // 
            this.GaDi.FillWeight = 90F;
            this.GaDi.HeaderText = "Ga đi";
            this.GaDi.MinimumWidth = 6;
            this.GaDi.Name = "GaDi";
            this.GaDi.ReadOnly = true;
            // 
            // GaDen
            // 
            this.GaDen.FillWeight = 90F;
            this.GaDen.HeaderText = "Ga đến";
            this.GaDen.MinimumWidth = 6;
            this.GaDen.Name = "GaDen";
            this.GaDen.ReadOnly = true;
            // 
            // Tuyen
            // 
            this.Tuyen.FillWeight = 50F;
            this.Tuyen.HeaderText = "Tuyến";
            this.Tuyen.MinimumWidth = 6;
            this.Tuyen.Name = "Tuyen";
            this.Tuyen.ReadOnly = true;
            // 
            // KhoangCach
            // 
            this.KhoangCach.FillWeight = 50F;
            this.KhoangCach.HeaderText = "Khoảng cách";
            this.KhoangCach.MinimumWidth = 6;
            this.KhoangCach.Name = "KhoangCach";
            this.KhoangCach.ReadOnly = true;
            // 
            // GioXuatPhat
            // 
            this.GioXuatPhat.HeaderText = "Giờ xuất phát / Thông tin";
            this.GioXuatPhat.MinimumWidth = 6;
            this.GioXuatPhat.Name = "GioXuatPhat";
            this.GioXuatPhat.ReadOnly = true;
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.BackColor = System.Drawing.Color.White;
            this.btnChiTiet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.btnChiTiet.FlatAppearance.BorderSize = 2;
            this.btnChiTiet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.btnChiTiet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTiet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnChiTiet.Location = new System.Drawing.Point(8, 0);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(120, 40);
            this.btnChiTiet.TabIndex = 7;
            this.btnChiTiet.Text = "Chi Tiết";
            this.btnChiTiet.UseVisualStyleBackColor = false;
            // 
            // BtnQuayLai
            // 
            this.BtnQuayLai.BackColor = System.Drawing.Color.White;
            this.BtnQuayLai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(163)))), ((int)(((byte)(255)))));
            this.BtnQuayLai.FlatAppearance.BorderSize = 2;
            this.BtnQuayLai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.BtnQuayLai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.BtnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuayLai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.BtnQuayLai.Location = new System.Drawing.Point(8, 0);
            this.BtnQuayLai.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.BtnQuayLai.Name = "BtnQuayLai";
            this.BtnQuayLai.Size = new System.Drawing.Size(120, 40);
            this.BtnQuayLai.TabIndex = 8;
            this.BtnQuayLai.Text = "Quay Lại";
            this.BtnQuayLai.UseVisualStyleBackColor = false;
            this.BtnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.tlpSearch);
            this.pnlTop.Controls.Add(this.txtD);
            this.pnlTop.Controls.Add(this.txtXP);
            this.pnlTop.Controls.Add(this.lxtGioD);
            this.pnlTop.Controls.Add(this.lxtGioXP);
            this.pnlTop.Location = new System.Drawing.Point(199, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(16);
            this.pnlTop.Size = new System.Drawing.Size(1288, 196);
            this.pnlTop.TabIndex = 9;
            // 
            // tlpSearch
            // 
            this.tlpSearch.ColumnCount = 6;
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 441F));
            this.tlpSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSearch.Controls.Add(this.flpRow3, 5, 1);
            this.tlpSearch.Controls.Add(this.lblGaĐi, 0, 0);
            this.tlpSearch.Controls.Add(this.txtTu, 1, 0);
            this.tlpSearch.Controls.Add(this.lblGaĐến, 0, 1);
            this.tlpSearch.Controls.Add(this.txtDen, 1, 1);
            this.tlpSearch.Controls.Add(this.flpRow1, 4, 0);
            this.tlpSearch.Controls.Add(this.flpRow2, 5, 0);
            this.tlpSearch.Controls.Add(this.btnDoiChieu, 2, 0);
            this.tlpSearch.Controls.Add(this.btnTimDuong, 4, 1);
            this.tlpSearch.Location = new System.Drawing.Point(59, 19);
            this.tlpSearch.Name = "tlpSearch";
            this.tlpSearch.RowCount = 2;
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tlpSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tlpSearch.Size = new System.Drawing.Size(1208, 98);
            this.tlpSearch.TabIndex = 0;
            // 
            // flpRow3
            // 
            this.flpRow3.Controls.Add(this.BtnQuayLai);
            this.flpRow3.Location = new System.Drawing.Point(1012, 50);
            this.flpRow3.Name = "flpRow3";
            this.flpRow3.Size = new System.Drawing.Size(193, 44);
            this.flpRow3.TabIndex = 10;
            this.flpRow3.WrapContents = false;
            // 
            // flpRow1
            // 
            this.flpRow1.Controls.Add(this.dtvThoiGian);
            this.flpRow1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpRow1.Location = new System.Drawing.Point(571, 3);
            this.flpRow1.Name = "flpRow1";
            this.flpRow1.Size = new System.Drawing.Size(402, 41);
            this.flpRow1.TabIndex = 6;
            this.flpRow1.WrapContents = false;
            // 
            // flpRow2
            // 
            this.flpRow2.Controls.Add(this.btnChiTiet);
            this.flpRow2.Location = new System.Drawing.Point(1012, 3);
            this.flpRow2.Name = "flpRow2";
            this.flpRow2.Size = new System.Drawing.Size(193, 41);
            this.flpRow2.TabIndex = 7;
            // 
            // lxtGioXP
            // 
            this.lxtGioXP.AutoSize = true;
            this.lxtGioXP.Location = new System.Drawing.Point(62, 120);
            this.lxtGioXP.Name = "lxtGioXP";
            this.lxtGioXP.Size = new System.Drawing.Size(137, 26);
            this.lxtGioXP.TabIndex = 1;
            this.lxtGioXP.Text = "Giờ xuất phát";
            // 
            // lxtGioD
            // 
            this.lxtGioD.AutoSize = true;
            this.lxtGioD.Location = new System.Drawing.Point(62, 161);
            this.lxtGioD.Name = "lxtGioD";
            this.lxtGioD.Size = new System.Drawing.Size(91, 26);
            this.lxtGioD.TabIndex = 2;
            this.lxtGioD.Text = "Giờ Đến";
            // 
            // txtXP
            // 
            this.txtXP.Location = new System.Drawing.Point(238, 121);
            this.txtXP.Name = "txtXP";
            this.txtXP.Size = new System.Drawing.Size(204, 34);
            this.txtXP.TabIndex = 3;
            this.txtXP.TextChanged += new System.EventHandler(this.txtGio_TextChanged);
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(238, 161);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(204, 34);
            this.txtD.TabIndex = 4;
            this.txtD.TextChanged += new System.EventHandler(this.txtPhut_TextChanged);
            // 
            // dtvThoiGian
            // 
            this.dtvThoiGian.Location = new System.Drawing.Point(3, 3);
            this.dtvThoiGian.Name = "dtvThoiGian";
            this.dtvThoiGian.Size = new System.Drawing.Size(382, 34);
            this.dtvThoiGian.TabIndex = 0;
            this.dtvThoiGian.ValueChanged += new System.EventHandler(this.dtvThoiGian_ValueChanged);
            // 
            // frmTimDuong
            // 
            this.AcceptButton = this.btnTimDuong;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 698);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.dgvLoTrinh);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTimDuong";
            this.Text = "MetroMap HCM - Tìm đường";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoTrinh)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tlpSearch.ResumeLayout(false);
            this.tlpSearch.PerformLayout();
            this.flpRow3.ResumeLayout(false);
            this.flpRow1.ResumeLayout(false);
            this.flpRow2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.Button BtnQuayLai;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tlpSearch;
        private System.Windows.Forms.FlowLayoutPanel flpRow1;
        private System.Windows.Forms.FlowLayoutPanel flpRow2;
        private System.Windows.Forms.FlowLayoutPanel flpRow3;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GaDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoangCach;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioXuatPhat;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtXP;
        private System.Windows.Forms.Label lxtGioD;
        private System.Windows.Forms.Label lxtGioXP;
        private System.Windows.Forms.DateTimePicker dtvThoiGian;
    }
}
