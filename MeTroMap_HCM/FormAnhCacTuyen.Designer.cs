using System;
using System.Drawing;
using System.Windows.Forms;

namespace MeTroMap_HCM
{
    partial class FormAnhCacTuyen
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnhCacTuyen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::MeTroMap_HCM.Properties.Resources._3_ban_do_metro_tphcm_cap_nhat_moi_nhat;
            this.pictureBox1.Location = new System.Drawing.Point(66, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 565);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.label1.Location = new System.Drawing.Point(169, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ảnh Các Tuyến Metro HCM Tương Lai";
            // 
            // FormAnhCacTuyen
            // 
            this.ClientSize = new System.Drawing.Size(913, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAnhCacTuyen";
            this.Text = "FormAnhCacTuyen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }
    }
}
