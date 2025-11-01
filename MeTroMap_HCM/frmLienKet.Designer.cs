namespace MetroMap_HCM
{
    partial class frmLienKet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLienKet = new System.Windows.Forms.DataGridView();
            this.cboGa1 = new System.Windows.Forms.ComboBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.lblGa1 = new System.Windows.Forms.Label();
            this.lblGa2 = new System.Windows.Forms.Label();
            this.lblKC = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlRowGa2 = new System.Windows.Forms.Panel();
            this.cboGa2 = new System.Windows.Forms.ComboBox();
            this.pnlRowGa1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.pnlRowGa2.SuspendLayout();
            this.pnlRowGa1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLienKet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.dgvLienKet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLienKet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLienKet.BackgroundColor = System.Drawing.Color.White;
            this.dgvLienKet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLienKet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLienKet.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLienKet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLienKet.EnableHeadersVisualStyles = false;
            this.dgvLienKet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(245)))));
            this.dgvLienKet.Location = new System.Drawing.Point(215, 315);
            this.dgvLienKet.Name = "dgvLienKet";
            this.dgvLienKet.RowHeadersVisible = false;
            this.dgvLienKet.RowHeadersWidth = 51;
            this.dgvLienKet.RowTemplate.Height = 40;
            this.dgvLienKet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLienKet.Size = new System.Drawing.Size(1117, 366);
            this.dgvLienKet.TabIndex = 0;
            // 
            // cboGa1
            // 
            this.cboGa1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGa1.Location = new System.Drawing.Point(119, 5);
            this.cboGa1.Name = "cboGa1";
            this.cboGa1.Size = new System.Drawing.Size(427, 34);
            this.cboGa1.TabIndex = 1;
            // 
            // txtKhoangCach
            // 
            this.txtKhoangCach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKhoangCach.Location = new System.Drawing.Point(343, 172);
            this.txtKhoangCach.Name = "txtKhoangCach";
            this.txtKhoangCach.Size = new System.Drawing.Size(329, 34);
            this.txtKhoangCach.TabIndex = 3;
            this.txtKhoangCach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblGa1
            // 
            this.lblGa1.Location = new System.Drawing.Point(12, 9);
            this.lblGa1.Name = "lblGa1";
            this.lblGa1.Size = new System.Drawing.Size(76, 24);
            this.lblGa1.TabIndex = 4;
            this.lblGa1.Text = "Ga 1:";
            this.lblGa1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGa2
            // 
            this.lblGa2.Location = new System.Drawing.Point(12, 10);
            this.lblGa2.Name = "lblGa2";
            this.lblGa2.Size = new System.Drawing.Size(120, 24);
            this.lblGa2.TabIndex = 5;
            this.lblGa2.Text = "Ga 2:";
            this.lblGa2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKC
            // 
            this.lblKC.Location = new System.Drawing.Point(108, 174);
            this.lblKC.Name = "lblKC";
            this.lblKC.Size = new System.Drawing.Size(198, 46);
            this.lblKC.TabIndex = 6;
            this.lblKC.Text = "Khoảng cách (km):";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(806, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 40);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(197)))), ((int)(((byte)(253)))));
            this.btnXoa.FlatAppearance.BorderSize = 2;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.btnXoa.Location = new System.Drawing.Point(806, 45);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(140, 40);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.txtKhoangCach);
            this.pnlCard.Controls.Add(this.pnlRowGa2);
            this.pnlCard.Controls.Add(this.pnlRowGa1);
            this.pnlCard.Controls.Add(this.btnThem);
            this.pnlCard.Controls.Add(this.btnXoa);
            this.pnlCard.Controls.Add(this.lblKC);
            this.pnlCard.Location = new System.Drawing.Point(215, 12);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(16);
            this.pnlCard.Size = new System.Drawing.Size(1117, 263);
            this.pnlCard.TabIndex = 9;
            // 
            // pnlRowGa2
            // 
            this.pnlRowGa2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRowGa2.Controls.Add(this.cboGa2);
            this.pnlRowGa2.Controls.Add(this.lblGa2);
            this.pnlRowGa2.Location = new System.Drawing.Point(113, 103);
            this.pnlRowGa2.Name = "pnlRowGa2";
            this.pnlRowGa2.Size = new System.Drawing.Size(559, 46);
            this.pnlRowGa2.TabIndex = 11;
            // 
            // cboGa2
            // 
            this.cboGa2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGa2.FormattingEnabled = true;
            this.cboGa2.Location = new System.Drawing.Point(119, 7);
            this.cboGa2.Name = "cboGa2";
            this.cboGa2.Size = new System.Drawing.Size(427, 34);
            this.cboGa2.TabIndex = 6;
            // 
            // pnlRowGa1
            // 
            this.pnlRowGa1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRowGa1.Controls.Add(this.lblGa1);
            this.pnlRowGa1.Controls.Add(this.cboGa1);
            this.pnlRowGa1.Location = new System.Drawing.Point(113, 39);
            this.pnlRowGa1.Name = "pnlRowGa1";
            this.pnlRowGa1.Size = new System.Drawing.Size(559, 46);
            this.pnlRowGa1.TabIndex = 10;
            // 
            // frmLienKet
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 698);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.dgvLienKet);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLienKet";
            this.Text = "Quản lý Liên Kết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLienKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlRowGa2.ResumeLayout(false);
            this.pnlRowGa1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dgvLienKet;
        private System.Windows.Forms.ComboBox cboGa1;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Label lblGa1;
        private System.Windows.Forms.Label lblGa2;
        private System.Windows.Forms.Label lblKC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Panel pnlRowGa1;
        private System.Windows.Forms.Panel pnlRowGa2;
        private System.Windows.Forms.ComboBox cboGa2;
    }
}
