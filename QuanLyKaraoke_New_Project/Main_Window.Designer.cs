namespace QuanLyKaraoke_New_Project
{
    partial class Frm_MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView_SanPhamDaChon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.col_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýLoạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_TenPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_GioVao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPhamDaChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_SanPhamDaChon
            // 
            this.dataGridView_SanPhamDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPhamDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_SanPhamDaChon.Location = new System.Drawing.Point(12, 412);
            this.dataGridView_SanPhamDaChon.Name = "dataGridView_SanPhamDaChon";
            this.dataGridView_SanPhamDaChon.RowHeadersWidth = 51;
            this.dataGridView_SanPhamDaChon.RowTemplate.Height = 24;
            this.dataGridView_SanPhamDaChon.Size = new System.Drawing.Size(525, 185);
            this.dataGridView_SanPhamDaChon.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Thành Tiền";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_TenSanPham,
            this.col_DonGia});
            this.dataGridView_SanPham.Location = new System.Drawing.Point(860, 46);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 51;
            this.dataGridView_SanPham.RowTemplate.Height = 24;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(419, 551);
            this.dataGridView_SanPham.TabIndex = 1;
            // 
            // col_STT
            // 
            this.col_STT.HeaderText = "STT";
            this.col_STT.MinimumWidth = 6;
            this.col_STT.Name = "col_STT";
            this.col_STT.Width = 50;
            // 
            // col_TenSanPham
            // 
            this.col_TenSanPham.HeaderText = "Tên Sản Phẩm";
            this.col_TenSanPham.MinimumWidth = 6;
            this.col_TenSanPham.Name = "col_TenSanPham";
            this.col_TenSanPham.Width = 125;
            // 
            // col_DonGia
            // 
            this.col_DonGia.HeaderText = "Đơn Giá";
            this.col_DonGia.MinimumWidth = 6;
            this.col_DonGia.Name = "col_DonGia";
            this.col_DonGia.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửDụngToolStripMenuItem,
            this.tínhTiềnToolStripMenuItem,
            this.tảiLạiToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 76);
            // 
            // sửDụngToolStripMenuItem
            // 
            this.sửDụngToolStripMenuItem.Name = "sửDụngToolStripMenuItem";
            this.sửDụngToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.sửDụngToolStripMenuItem.Text = "Sử dụng";
            // 
            // tínhTiềnToolStripMenuItem
            // 
            this.tínhTiềnToolStripMenuItem.Name = "tínhTiềnToolStripMenuItem";
            this.tínhTiềnToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.tínhTiềnToolStripMenuItem.Text = "Tính tiền";
            // 
            // tảiLạiToolStripMenuItem
            // 
            this.tảiLạiToolStripMenuItem.Name = "tảiLạiToolStripMenuItem";
            this.tảiLạiToolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.tảiLạiToolStripMenuItem.Text = "Tải lại";
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Phong});
            this.dataGridView_Phong.Location = new System.Drawing.Point(15, 46);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.RowHeadersWidth = 51;
            this.dataGridView_Phong.RowTemplate.Height = 24;
            this.dataGridView_Phong.Size = new System.Drawing.Size(814, 317);
            this.dataGridView_Phong.TabIndex = 14;
            this.dataGridView_Phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Phong_CellContentClick);
            // 
            // col_Phong
            // 
            this.col_Phong.HeaderText = "Phòng";
            this.col_Phong.MinimumWidth = 6;
            this.col_Phong.Name = "col_Phong";
            this.col_Phong.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLoạiPhòngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýLoạiPhòngToolStripMenuItem
            // 
            this.quảnLýLoạiPhòngToolStripMenuItem.Name = "quảnLýLoạiPhòngToolStripMenuItem";
            this.quảnLýLoạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.quảnLýLoạiPhòngToolStripMenuItem.Text = "Quản Lý Loại Phòng";
            this.quảnLýLoạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiPhòngToolStripMenuItem_Click);
            // 
            // label_TenPhong
            // 
            this.label_TenPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_TenPhong.Location = new System.Drawing.Point(12, 373);
            this.label_TenPhong.Name = "label_TenPhong";
            this.label_TenPhong.Size = new System.Drawing.Size(136, 36);
            this.label_TenPhong.TabIndex = 16;
            this.label_TenPhong.Text = "    ";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(154, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giờ vào";
            // 
            // txt_GioVao
            // 
            this.txt_GioVao.Location = new System.Drawing.Point(259, 369);
            this.txt_GioVao.MaximumSize = new System.Drawing.Size(100, 200);
            this.txt_GioVao.Multiline = true;
            this.txt_GioVao.Name = "txt_GioVao";
            this.txt_GioVao.Size = new System.Drawing.Size(100, 37);
            this.txt_GioVao.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tổng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Khuyển mại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Phụ Thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tiền sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tiền Phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(571, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 214);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tổng Hợp Tiền Dịch Vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Frm_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 780);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_GioVao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TenPhong);
            this.Controls.Add(this.dataGridView_Phong);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_SanPham);
            this.Controls.Add(this.dataGridView_SanPhamDaChon);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_MainWindow";
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPhamDaChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_SanPhamDaChon;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiPhòngToolStripMenuItem;
        private System.Windows.Forms.Label label_TenPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_GioVao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

