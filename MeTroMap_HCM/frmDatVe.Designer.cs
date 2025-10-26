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
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnTinhGia = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTuyen
            this.lblTuyen.AutoSize = true;
            this.lblTuyen.Location = new System.Drawing.Point(40, 40);
            this.lblTuyen.Text = "Chọn tuyến:";

            // cboTuyen
            this.cboTuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyen.Location = new System.Drawing.Point(140, 37);
            this.cboTuyen.Width = 200;
            this.cboTuyen.SelectedIndexChanged += new System.EventHandler(this.cboTuyen_SelectedIndexChanged);

            // lblGaDi
            this.lblGaDi.AutoSize = true;
            this.lblGaDi.Location = new System.Drawing.Point(40, 80);
            this.lblGaDi.Text = "Ga đi:";

            // cboGaDi
            this.cboGaDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDi.Location = new System.Drawing.Point(140, 77);
            this.cboGaDi.Width = 200;

            // lblGaDen
            this.lblGaDen.AutoSize = true;
            this.lblGaDen.Location = new System.Drawing.Point(40, 120);
            this.lblGaDen.Text = "Ga đến:";

            // cboGaDen
            this.cboGaDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGaDen.Location = new System.Drawing.Point(140, 117);
            this.cboGaDen.Width = 200;

            // lblGia
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(40, 160);
            this.lblGia.Text = "Giá vé (VNĐ):";

            // txtGia
            this.txtGia.Location = new System.Drawing.Point(140, 157);
            this.txtGia.ReadOnly = true;
            this.txtGia.Width = 200;

            // btnTinhGia
            this.btnTinhGia.Text = "Tính giá vé";
            this.btnTinhGia.Location = new System.Drawing.Point(140, 200);
            this.btnTinhGia.Click += new System.EventHandler(this.btnTinhGia_Click);

            // btnDatVe
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.Location = new System.Drawing.Point(250, 200);
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);

            // frmDatVe
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.lblTuyen);
            this.Controls.Add(this.cboTuyen);
            this.Controls.Add(this.lblGaDi);
            this.Controls.Add(this.cboGaDi);
            this.Controls.Add(this.lblGaDen);
            this.Controls.Add(this.cboGaDen);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.btnTinhGia);
            this.Controls.Add(this.btnDatVe);
            this.Text = "Đặt vé Metro";
            this.Load += new System.EventHandler(this.frmDatVe_Load);

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
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnTinhGia;
        private System.Windows.Forms.Button btnDatVe;
    }
}
