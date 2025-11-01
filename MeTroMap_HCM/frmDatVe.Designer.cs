using System;
using System.Windows.Forms;
using System.Drawing;

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
            this.grpChuyenDi = new System.Windows.Forms.GroupBox();
            this.lblTuyenDi = new System.Windows.Forms.Label();
            this.cboTuyenDi = new System.Windows.Forms.ComboBox();
            this.lblTuyenDen = new System.Windows.Forms.Label();
            this.cboTuyenDen = new System.Windows.Forms.ComboBox();
            this.lblGaDi = new System.Windows.Forms.Label();
            this.cboGaDi = new System.Windows.Forms.ComboBox();
            this.lblGaDen = new System.Windows.Forms.Label();
            this.cboGaDen = new System.Windows.Forms.ComboBox();
            this.grpVe = new System.Windows.Forms.GroupBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtGiave = new System.Windows.Forms.TextBox();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.grpChuyenDi.SuspendLayout();
            this.grpVe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpChuyenDi
            // 
            this.grpChuyenDi.Controls.Add(this.lblTuyenDi);
            this.grpChuyenDi.Controls.Add(this.cboTuyenDi);
            this.grpChuyenDi.Controls.Add(this.lblTuyenDen);
            this.grpChuyenDi.Controls.Add(this.cboTuyenDen);
            this.grpChuyenDi.Controls.Add(this.lblGaDi);
            this.grpChuyenDi.Controls.Add(this.cboGaDi);
            this.grpChuyenDi.Controls.Add(this.lblGaDen);
            this.grpChuyenDi.Controls.Add(this.cboGaDen);
            this.grpChuyenDi.Location = new System.Drawing.Point(20, 20);
            this.grpChuyenDi.Name = "grpChuyenDi";
            this.grpChuyenDi.Size = new System.Drawing.Size(1094, 137);
            this.grpChuyenDi.TabIndex = 0;
            this.grpChuyenDi.TabStop = false;
            this.grpChuyenDi.Text = "Thông tin chuyến đi";
            // 
            // lblTuyenDi
            // 
            this.lblTuyenDi.Location = new System.Drawing.Point(10, 30);
            this.lblTuyenDi.Name = "lblTuyenDi";
            this.lblTuyenDi.Size = new System.Drawing.Size(80, 20);
            this.lblTuyenDi.TabIndex = 0;
            this.lblTuyenDi.Text = "Tuyến đi:";
            // 
            // cboTuyenDi
            // 
            this.cboTuyenDi.Location = new System.Drawing.Point(90, 27);
            this.cboTuyenDi.Name = "cboTuyenDi";
            this.cboTuyenDi.Size = new System.Drawing.Size(431, 24);
            this.cboTuyenDi.TabIndex = 1;
            // 
            // lblTuyenDen
            // 
            this.lblTuyenDen.Location = new System.Drawing.Point(559, 33);
            this.lblTuyenDen.Name = "lblTuyenDen";
            this.lblTuyenDen.Size = new System.Drawing.Size(120, 21);
            this.lblTuyenDen.TabIndex = 2;
            this.lblTuyenDen.Text = "Tuyến đến:";
            // 
            // cboTuyenDen
            // 
            this.cboTuyenDen.Location = new System.Drawing.Point(685, 30);
            this.cboTuyenDen.Name = "cboTuyenDen";
            this.cboTuyenDen.Size = new System.Drawing.Size(394, 24);
            this.cboTuyenDen.TabIndex = 3;
            // 
            // lblGaDi
            // 
            this.lblGaDi.Location = new System.Drawing.Point(10, 70);
            this.lblGaDi.Name = "lblGaDi";
            this.lblGaDi.Size = new System.Drawing.Size(80, 20);
            this.lblGaDi.TabIndex = 4;
            this.lblGaDi.Text = "Ga đi:";
            // 
            // cboGaDi
            // 
            this.cboGaDi.Location = new System.Drawing.Point(90, 67);
            this.cboGaDi.Name = "cboGaDi";
            this.cboGaDi.Size = new System.Drawing.Size(431, 24);
            this.cboGaDi.TabIndex = 5;
            // 
            // lblGaDen
            // 
            this.lblGaDen.Location = new System.Drawing.Point(559, 67);
            this.lblGaDen.Name = "lblGaDen";
            this.lblGaDen.Size = new System.Drawing.Size(80, 20);
            this.lblGaDen.TabIndex = 6;
            this.lblGaDen.Text = "Ga đến:";
            // 
            // cboGaDen
            // 
            this.cboGaDen.Location = new System.Drawing.Point(685, 70);
            this.cboGaDen.Name = "cboGaDen";
            this.cboGaDen.Size = new System.Drawing.Size(394, 24);
            this.cboGaDen.TabIndex = 7;
            // 
            // grpVe
            // 
            this.grpVe.Controls.Add(this.lblLoai);
            this.grpVe.Controls.Add(this.cboLoai);
            this.grpVe.Controls.Add(this.lblGia);
            this.grpVe.Controls.Add(this.txtGiave);
            this.grpVe.Location = new System.Drawing.Point(20, 180);
            this.grpVe.Name = "grpVe";
            this.grpVe.Size = new System.Drawing.Size(1094, 101);
            this.grpVe.TabIndex = 1;
            this.grpVe.TabStop = false;
            this.grpVe.Text = "Thông tin vé";
            // 
            // lblLoai
            // 
            this.lblLoai.Location = new System.Drawing.Point(10, 30);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(80, 20);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại vé:";
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(90, 27);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(253, 24);
            this.cboLoai.TabIndex = 1;
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(10, 65);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(80, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá vé (VNĐ):";
            // 
            // txtGiave
            // 
            this.txtGiave.Location = new System.Drawing.Point(90, 62);
            this.txtGiave.Name = "txtGiave";
            this.txtGiave.ReadOnly = true;
            this.txtGiave.Size = new System.Drawing.Size(668, 22);
            this.txtGiave.TabIndex = 3;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Location = new System.Drawing.Point(463, 307);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(100, 40);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Đặt vé";
            // 
            // frmDatVe
            // 
            this.ClientSize = new System.Drawing.Size(1146, 486);
            this.Controls.Add(this.grpChuyenDi);
            this.Controls.Add(this.grpVe);
            this.Controls.Add(this.btnDatVe);
            this.Name = "frmDatVe";
            this.Text = "Đặt vé Metro";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.grpChuyenDi.ResumeLayout(false);
            this.grpVe.ResumeLayout(false);
            this.grpVe.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private GroupBox grpChuyenDi;
        private Label lblTuyenDi;
        private ComboBox cboTuyenDi;
        private Label lblTuyenDen;
        private ComboBox cboTuyenDen;
        private Label lblGaDi;
        private ComboBox cboGaDi;
        private Label lblGaDen;
        private ComboBox cboGaDen;

        private GroupBox grpVe;
        private Label lblLoai;
        private ComboBox cboLoai;
        private Label lblGia;
        private TextBox txtGiave;

        private Button btnDatVe;
    }
}
