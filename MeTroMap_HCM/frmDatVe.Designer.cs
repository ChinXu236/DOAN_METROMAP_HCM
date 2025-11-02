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
            this.cboGG = new System.Windows.Forms.ComboBox();
            this.lblGG = new System.Windows.Forms.Label();
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
            this.grpChuyenDi.Location = new System.Drawing.Point(180, 70);
            this.grpChuyenDi.Name = "grpChuyenDi";
            this.grpChuyenDi.Size = new System.Drawing.Size(1209, 178);
            this.grpChuyenDi.TabIndex = 0;
            this.grpChuyenDi.TabStop = false;
            this.grpChuyenDi.Text = "Thông tin chuyến đi";
            // 
            // lblTuyenDi
            // 
            this.lblTuyenDi.AutoSize = true;
            this.lblTuyenDi.Location = new System.Drawing.Point(20, 54);
            this.lblTuyenDi.Name = "lblTuyenDi";
            this.lblTuyenDi.Size = new System.Drawing.Size(101, 26);
            this.lblTuyenDi.TabIndex = 0;
            this.lblTuyenDi.Text = "Tuyến đi:";
            // 
            // cboTuyenDi
            // 
            this.cboTuyenDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTuyenDi.Location = new System.Drawing.Point(130, 50);
            this.cboTuyenDi.Name = "cboTuyenDi";
            this.cboTuyenDi.Size = new System.Drawing.Size(420, 34);
            this.cboTuyenDi.TabIndex = 1;
            // 
            // lblTuyenDen
            // 
            this.lblTuyenDen.AutoSize = true;
            this.lblTuyenDen.Location = new System.Drawing.Point(630, 54);
            this.lblTuyenDen.Name = "lblTuyenDen";
            this.lblTuyenDen.Size = new System.Drawing.Size(117, 26);
            this.lblTuyenDen.TabIndex = 2;
            this.lblTuyenDen.Text = "Tuyến đến:";
            // 
            // cboTuyenDen
            // 
            this.cboTuyenDen.Location = new System.Drawing.Point(760, 50);
            this.cboTuyenDen.Name = "cboTuyenDen";
            this.cboTuyenDen.Size = new System.Drawing.Size(394, 34);
            this.cboTuyenDen.TabIndex = 3;
            // 
            // lblGaDi
            // 
            this.lblGaDi.AutoSize = true;
            this.lblGaDi.Location = new System.Drawing.Point(20, 114);
            this.lblGaDi.Name = "lblGaDi";
            this.lblGaDi.Size = new System.Drawing.Size(68, 26);
            this.lblGaDi.TabIndex = 4;
            this.lblGaDi.Text = "Ga đi:";
            // 
            // cboGaDi
            // 
            this.cboGaDi.Location = new System.Drawing.Point(130, 110);
            this.cboGaDi.Name = "cboGaDi";
            this.cboGaDi.Size = new System.Drawing.Size(420, 34);
            this.cboGaDi.TabIndex = 5;
            // 
            // lblGaDen
            // 
            this.lblGaDen.AutoSize = true;
            this.lblGaDen.Location = new System.Drawing.Point(630, 114);
            this.lblGaDen.Name = "lblGaDen";
            this.lblGaDen.Size = new System.Drawing.Size(84, 26);
            this.lblGaDen.TabIndex = 6;
            this.lblGaDen.Text = "Ga đến:";
            // 
            // cboGaDen
            // 
            this.cboGaDen.Location = new System.Drawing.Point(760, 110);
            this.cboGaDen.Name = "cboGaDen";
            this.cboGaDen.Size = new System.Drawing.Size(394, 34);
            this.cboGaDen.TabIndex = 7;
            // 
            // grpVe
            // 
            this.grpVe.Controls.Add(this.cboGG);
            this.grpVe.Controls.Add(this.lblGG);
            this.grpVe.Controls.Add(this.lblLoai);
            this.grpVe.Controls.Add(this.cboLoai);
            this.grpVe.Controls.Add(this.lblGia);
            this.grpVe.Controls.Add(this.txtGiave);
            this.grpVe.Location = new System.Drawing.Point(180, 323);
            this.grpVe.Name = "grpVe";
            this.grpVe.Size = new System.Drawing.Size(1209, 164);
            this.grpVe.TabIndex = 1;
            this.grpVe.TabStop = false;
            this.grpVe.Text = "Thông tin vé";
            // 
            // cboGG
            // 
            this.cboGG.Location = new System.Drawing.Point(760, 32);
            this.cboGG.Name = "cboGG";
            this.cboGG.Size = new System.Drawing.Size(394, 34);
            this.cboGG.TabIndex = 5;
            // 
            // lblGG
            // 
            this.lblGG.Location = new System.Drawing.Point(630, 35);
            this.lblGG.Name = "lblGG";
            this.lblGG.Size = new System.Drawing.Size(109, 20);
            this.lblGG.TabIndex = 4;
            this.lblGG.Text = "Giảm Giá:";
            // 
            // lblLoai
            // 
            this.lblLoai.Location = new System.Drawing.Point(20, 36);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(80, 20);
            this.lblLoai.TabIndex = 0;
            this.lblLoai.Text = "Loại vé:";
            // 
            // cboLoai
            // 
            this.cboLoai.Location = new System.Drawing.Point(130, 32);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(420, 34);
            this.cboLoai.TabIndex = 1;
            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(20, 96);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(80, 20);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá vé (VNĐ):";
            // 
            // txtGiave
            // 
            this.txtGiave.BackColor = System.Drawing.Color.White;
            this.txtGiave.Location = new System.Drawing.Point(130, 92);
            this.txtGiave.Name = "txtGiave";
            this.txtGiave.ReadOnly = true;
            this.txtGiave.Size = new System.Drawing.Size(1035, 34);
            this.txtGiave.TabIndex = 3;
            // 
            // btnDatVe
            // 
            this.btnDatVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDatVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnDatVe.FlatAppearance.BorderSize = 0;
            this.btnDatVe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatVe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.ForeColor = System.Drawing.Color.White;
            this.btnDatVe.Location = new System.Drawing.Point(744, 546);
            this.btnDatVe.Margin = new System.Windows.Forms.Padding(4);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(150, 55);
            this.btnDatVe.TabIndex = 11;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            // 
            // frmDatVe
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1558, 698);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.grpChuyenDi);
            this.Controls.Add(this.grpVe);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDatVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt vé Metro";
            this.Load += new System.EventHandler(this.frmDatVe_Load);
            this.grpChuyenDi.ResumeLayout(false);
            this.grpChuyenDi.PerformLayout();
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
        private ComboBox cboGG;
        private Label lblGG;
        private Button btnDatVe;
    }
}
