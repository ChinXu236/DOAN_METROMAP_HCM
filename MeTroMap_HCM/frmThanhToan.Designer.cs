namespace MeTroMap_HCM
{
    partial class frmThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMaVe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.lblGaDen = new System.Windows.Forms.Label();
            this.lblGaDi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDemNguoc = new System.Windows.Forms.Label();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaVe
            // 
            this.lblMaVe.AutoSize = true;
            this.lblMaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaVe.Location = new System.Drawing.Point(6, 26);
            this.lblMaVe.Name = "lblMaVe";
            this.lblMaVe.Size = new System.Drawing.Size(57, 20);
            this.lblMaVe.TabIndex = 0;
            this.lblMaVe.Text = "Mã Vé";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.btnHoanTat);
            this.groupBox1.Controls.Add(this.lblGiaVe);
            this.groupBox1.Controls.Add(this.lblGaDen);
            this.groupBox1.Controls.Add(this.lblGaDi);
            this.groupBox1.Controls.Add(this.lblMaVe);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 309);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Vé";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSoLuong.Location = new System.Drawing.Point(6, 153);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(101, 20);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số lượng vé:";
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(92, 255);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(82, 34);
            this.btnHoanTat.TabIndex = 4;
            this.btnHoanTat.Text = "Hoàn tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGiaVe.Location = new System.Drawing.Point(6, 195);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(57, 20);
            this.lblGiaVe.TabIndex = 3;
            this.lblGiaVe.Text = "Giá vé";
            // 
            // lblGaDen
            // 
            this.lblGaDen.AutoSize = true;
            this.lblGaDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGaDen.Location = new System.Drawing.Point(6, 112);
            this.lblGaDen.Name = "lblGaDen";
            this.lblGaDen.Size = new System.Drawing.Size(63, 20);
            this.lblGaDen.TabIndex = 2;
            this.lblGaDen.Text = "Ga đến";
            // 
            // lblGaDi
            // 
            this.lblGaDi.AutoSize = true;
            this.lblGaDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGaDi.Location = new System.Drawing.Point(6, 67);
            this.lblGaDi.Name = "lblGaDi";
            this.lblGaDi.Size = new System.Drawing.Size(52, 20);
            this.lblGaDi.TabIndex = 1;
            this.lblGaDi.Text = "Ga Đi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(398, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thanh Toán";
            // 
            // lblDemNguoc
            // 
            this.lblDemNguoc.AutoSize = true;
            this.lblDemNguoc.Location = new System.Drawing.Point(443, 60);
            this.lblDemNguoc.Name = "lblDemNguoc";
            this.lblDemNguoc.Size = new System.Drawing.Size(155, 16);
            this.lblDemNguoc.TabIndex = 4;
            this.lblDemNguoc.Text = "Hiển thị đếm ngược 05:00";
            // 
            // picQR
            // 
            this.picQR.Location = new System.Drawing.Point(355, 91);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(270, 242);
            this.picQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQR.TabIndex = 5;
            this.picQR.TabStop = false;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Location = new System.Drawing.Point(352, 60);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(85, 16);
            this.lblThoiGian.TabIndex = 6;
            this.lblThoiGian.Text = "Thời gian đặt";
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 378);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.picQR);
            this.Controls.Add(this.lblDemNguoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThanhToan";
            this.Text = "frmThanhToan";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaVe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGaDen;
        private System.Windows.Forms.Label lblGaDi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDemNguoc;
        private System.Windows.Forms.PictureBox picQR;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Label lblGiaVe;
        private System.Windows.Forms.Label lblSoLuong;
    }
}