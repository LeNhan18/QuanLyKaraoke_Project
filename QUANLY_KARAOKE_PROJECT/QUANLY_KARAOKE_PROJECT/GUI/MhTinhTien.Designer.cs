namespace QUANLY_KARAOKE_PROJECT
{
    partial class MhTinhTien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnTaoHoaDon = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.ThanhToan = new System.Windows.Forms.Button();
            this.rtb_TienPhong = new System.Windows.Forms.RichTextBox();
            this.rtb_TienSanpham = new System.Windows.Forms.RichTextBox();
            this.rtb_PhuThu = new System.Windows.Forms.RichTextBox();
            this.rtb_Tong = new System.Windows.Forms.RichTextBox();
            this.rtb_KhuyenMai = new System.Windows.Forms.RichTextBox();
            this.rtb_TongThanhToan = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.rtb_HoaDon = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 61);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(656, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giờ Vào";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(6, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 57);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Location = new System.Drawing.Point(338, 438);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(102, 46);
            this.btnTaoHoaDon.TabIndex = 3;
            this.btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this.btnTaoHoaDon.UseVisualStyleBackColor = true;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(486, 438);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(102, 46);
            this.btnInHoaDon.TabIndex = 4;
            this.btnInHoaDon.Text = "In Hóa Đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.button2_Click);
            // 
            // ThanhToan
            // 
            this.ThanhToan.Location = new System.Drawing.Point(632, 438);
            this.ThanhToan.Name = "ThanhToan";
            this.ThanhToan.Size = new System.Drawing.Size(102, 46);
            this.ThanhToan.TabIndex = 5;
            this.ThanhToan.Text = "Thanh Toán";
            this.ThanhToan.UseVisualStyleBackColor = true;
            this.ThanhToan.Click += new System.EventHandler(this.ThanhToan_Click);
            // 
            // rtb_TienPhong
            // 
            this.rtb_TienPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_TienPhong.Location = new System.Drawing.Point(157, 70);
            this.rtb_TienPhong.Name = "rtb_TienPhong";
            this.rtb_TienPhong.Size = new System.Drawing.Size(618, 45);
            this.rtb_TienPhong.TabIndex = 6;
            this.rtb_TienPhong.Text = "";
            // 
            // rtb_TienSanpham
            // 
            this.rtb_TienSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_TienSanpham.Location = new System.Drawing.Point(157, 136);
            this.rtb_TienSanpham.Name = "rtb_TienSanpham";
            this.rtb_TienSanpham.Size = new System.Drawing.Size(618, 45);
            this.rtb_TienSanpham.TabIndex = 7;
            this.rtb_TienSanpham.Text = "";
            // 
            // rtb_PhuThu
            // 
            this.rtb_PhuThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_PhuThu.Location = new System.Drawing.Point(142, 197);
            this.rtb_PhuThu.Name = "rtb_PhuThu";
            this.rtb_PhuThu.Size = new System.Drawing.Size(633, 45);
            this.rtb_PhuThu.TabIndex = 8;
            this.rtb_PhuThu.Text = "";
            // 
            // rtb_Tong
            // 
            this.rtb_Tong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_Tong.Location = new System.Drawing.Point(142, 257);
            this.rtb_Tong.Name = "rtb_Tong";
            this.rtb_Tong.Size = new System.Drawing.Size(633, 45);
            this.rtb_Tong.TabIndex = 9;
            this.rtb_Tong.Text = "";
            // 
            // rtb_KhuyenMai
            // 
            this.rtb_KhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_KhuyenMai.Location = new System.Drawing.Point(142, 317);
            this.rtb_KhuyenMai.Name = "rtb_KhuyenMai";
            this.rtb_KhuyenMai.Size = new System.Drawing.Size(633, 45);
            this.rtb_KhuyenMai.TabIndex = 10;
            this.rtb_KhuyenMai.Text = "";
            // 
            // rtb_TongThanhToan
            // 
            this.rtb_TongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtb_TongThanhToan.Location = new System.Drawing.Point(186, 377);
            this.rtb_TongThanhToan.Name = "rtb_TongThanhToan";
            this.rtb_TongThanhToan.Size = new System.Drawing.Size(589, 45);
            this.rtb_TongThanhToan.TabIndex = 11;
            this.rtb_TongThanhToan.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tiêu Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tiền Sản Phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Phụ thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tổng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Khuyến Mãi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tổng thanh toán";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // rtb_HoaDon
            // 
            this.rtb_HoaDon.Location = new System.Drawing.Point(12, 438);
            this.rtb_HoaDon.Name = "rtb_HoaDon";
            this.rtb_HoaDon.Size = new System.Drawing.Size(308, 324);
            this.rtb_HoaDon.TabIndex = 18;
            this.rtb_HoaDon.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(377, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 248);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MhTinhTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtb_HoaDon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_TongThanhToan);
            this.Controls.Add(this.rtb_KhuyenMai);
            this.Controls.Add(this.rtb_Tong);
            this.Controls.Add(this.rtb_PhuThu);
            this.Controls.Add(this.rtb_TienSanpham);
            this.Controls.Add(this.rtb_TienPhong);
            this.Controls.Add(this.ThanhToan);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnTaoHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "MhTinhTien";
            this.Text = "MhTinhTien";
            this.Load += new System.EventHandler(this.MhTinhTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnTaoHoaDon;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button ThanhToan;
        private System.Windows.Forms.RichTextBox rtb_TienPhong;
        private System.Windows.Forms.RichTextBox rtb_TienSanpham;
        private System.Windows.Forms.RichTextBox rtb_PhuThu;
        private System.Windows.Forms.RichTextBox rtb_Tong;
        private System.Windows.Forms.RichTextBox rtb_KhuyenMai;
        private System.Windows.Forms.RichTextBox rtb_TongThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.RichTextBox rtb_HoaDon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}