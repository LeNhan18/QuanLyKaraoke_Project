﻿namespace QUANLY_KARAOKE_PROJECT
{
    partial class ChiTietSanPham
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
            this.lblChitietsanpham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMota = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChitietsanpham
            // 
            this.lblChitietsanpham.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblChitietsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChitietsanpham.Location = new System.Drawing.Point(0, 9);
            this.lblChitietsanpham.Name = "lblChitietsanpham";
            this.lblChitietsanpham.Size = new System.Drawing.Size(800, 54);
            this.lblChitietsanpham.TabIndex = 22;
            this.lblChitietsanpham.Text = "Chi Tiết Sản Phẩm";
            this.lblChitietsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên sản phẩm";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDongia.Location = new System.Drawing.Point(29, 202);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(112, 32);
            this.lblDongia.TabIndex = 24;
            this.lblDongia.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mô tả";
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.Location = new System.Drawing.Point(252, 129);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.Size = new System.Drawing.Size(536, 33);
            this.lblTensanpham.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(252, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 33);
            this.label2.TabIndex = 27;
            // 
            // lblMota
            // 
            this.lblMota.Location = new System.Drawing.Point(252, 284);
            this.lblMota.Name = "lblMota";
            this.lblMota.Size = new System.Drawing.Size(536, 100);
            this.lblMota.TabIndex = 28;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(273, 379);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(218, 59);
            this.btnOK.TabIndex = 29;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChiTietSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTensanpham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChitietsanpham);
            this.Name = "ChiTietSanPham";
            this.Text = "ChiTietSanPham";
            this.Load += new System.EventHandler(this.ChiTietSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChitietsanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMota;
        private System.Windows.Forms.Button btnOK;
    }
}