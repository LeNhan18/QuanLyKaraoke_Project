namespace QUANLY_KARAOKE_PROJECT
{
    partial class ChinhSuaSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblDongia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChinhsua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(494, 409);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(335, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(335, 230);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(255, 133);
            this.txtMota.TabIndex = 24;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(335, 164);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(138, 22);
            this.txtDongia.TabIndex = 23;
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(335, 91);
            this.txtTensanpham.Multiline = true;
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(255, 39);
            this.txtTensanpham.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Mô tả";
            // 
            // lblDongia
            // 
            this.lblDongia.AutoSize = true;
            this.lblDongia.Location = new System.Drawing.Point(211, 167);
            this.lblDongia.Name = "lblDongia";
            this.lblDongia.Size = new System.Drawing.Size(53, 16);
            this.lblDongia.TabIndex = 20;
            this.lblDongia.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tên sản phẩm";
            // 
            // lblChinhsua
            // 
            this.lblChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChinhsua.Location = new System.Drawing.Point(269, 19);
            this.lblChinhsua.Name = "lblChinhsua";
            this.lblChinhsua.Size = new System.Drawing.Size(321, 50);
            this.lblChinhsua.TabIndex = 18;
            this.lblChinhsua.Text = "Chỉnh sửa sản phẩm";
            this.lblChinhsua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChinhSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.txtDongia);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDongia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChinhsua);
            this.Name = "ChinhSuaSanPham";
            this.Text = "ChinhSuaSanPham";
            this.Load += new System.EventHandler(this.ChinhSuaSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDongia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChinhsua;
    }
}