namespace QUANLY_KARAOKE_PROJECT
{
    partial class ThemSanPham
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.lblThemsanpham = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(523, 401);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(343, 401);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(343, 237);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(255, 133);
            this.txtMota.TabIndex = 24;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(343, 179);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(138, 22);
            this.txtDongia.TabIndex = 23;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(343, 102);
            this.txtTensanpham.Multiline = true;
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(255, 39);
            this.txtTensanpham.TabIndex = 22;
            // 
            // lblThemsanpham
            // 
            this.lblThemsanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemsanpham.Location = new System.Drawing.Point(305, 26);
            this.lblThemsanpham.Name = "lblThemsanpham";
            this.lblThemsanpham.Size = new System.Drawing.Size(316, 61);
            this.lblThemsanpham.TabIndex = 21;
            this.lblThemsanpham.Text = "Thêm sản phẩm";
            this.lblThemsanpham.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mô tả";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(180, 185);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(53, 16);
            this.lblDongia.TabIndex = 19;
            this.lblDongia.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên sản phẩm";
            // 
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.lblThemsanpham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.label1);
            this.Name = "ThemSanPham";
            this.Text = "ThemSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label lblThemsanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label label1;
    }
}