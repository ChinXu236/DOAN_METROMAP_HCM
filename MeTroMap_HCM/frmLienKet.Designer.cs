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
            this.dgvLienKet = new System.Windows.Forms.DataGridView();
            this.cboGa1 = new System.Windows.Forms.ComboBox();
            this.cboGa2 = new System.Windows.Forms.ComboBox();
            this.txtKhoangCach = new System.Windows.Forms.TextBox();
            this.lblGa1 = new System.Windows.Forms.Label();
            this.lblGa2 = new System.Windows.Forms.Label();
            this.lblKC = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).BeginInit();
            this.SuspendLayout();

            // dgv
            this.dgvLienKet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLienKet.Location = new System.Drawing.Point(30, 180);
            this.dgvLienKet.Size = new System.Drawing.Size(740, 220);
            this.dgvLienKet.RowHeadersVisible = false;

            // Labels
            this.lblGa1.Text = "Ga 1:";
            this.lblGa1.Location = new System.Drawing.Point(40, 40);

            this.lblGa2.Text = "Ga 2:";
            this.lblGa2.Location = new System.Drawing.Point(40, 80);

            this.lblKC.Text = "Khoảng cách (km):";
            this.lblKC.Location = new System.Drawing.Point(40, 120);

            // ComboBox & Textbox
            this.cboGa1.Location = new System.Drawing.Point(180, 37);
            this.cboGa2.Location = new System.Drawing.Point(180, 77);
            this.txtKhoangCach.Location = new System.Drawing.Point(180, 117);

            // Buttons
            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new System.Drawing.Point(470, 40);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new System.Drawing.Point(470, 80);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // Form
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvLienKet);
            this.Controls.Add(this.cboGa1);
            this.Controls.Add(this.cboGa2);
            this.Controls.Add(this.txtKhoangCach);
            this.Controls.Add(this.lblGa1);
            this.Controls.Add(this.lblGa2);
            this.Controls.Add(this.lblKC);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Text = "Quản lý Liên Kết";
            this.Load += new System.EventHandler(this.frmLienKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLienKet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLienKet;
        private System.Windows.Forms.ComboBox cboGa1;
        private System.Windows.Forms.ComboBox cboGa2;
        private System.Windows.Forms.TextBox txtKhoangCach;
        private System.Windows.Forms.Label lblGa1;
        private System.Windows.Forms.Label lblGa2;
        private System.Windows.Forms.Label lblKC;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}
