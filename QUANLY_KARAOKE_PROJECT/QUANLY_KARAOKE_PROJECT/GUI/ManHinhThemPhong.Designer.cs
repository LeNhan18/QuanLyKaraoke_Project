namespace QUANLY_KARAOKE_PROJECT
{
    partial class ManHinhThemPhong
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
            this.ư = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HienDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.comboBox_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ư.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ư
            // 
            this.ư.BackColor = System.Drawing.Color.Transparent;
            this.ư.Controls.Add(this.guna2HtmlLabel1);
            this.ư.FillColor = System.Drawing.Color.ForestGreen;
            this.ư.Location = new System.Drawing.Point(205, 24);
            this.ư.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ư.Name = "ư";
            this.ư.ShadowColor = System.Drawing.Color.Black;
            this.ư.Size = new System.Drawing.Size(820, 70);
            this.ư.TabIndex = 25;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(325, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(186, 53);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Thêm Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_IDPhong,
            this.col_TenPhong,
            this.col_LoaiPhong,
            this.col_TrangThai,
            this.col_HienDung,
            this.col_Gia});
            this.dataGridView1.Location = new System.Drawing.Point(96, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(990, 214);
            this.dataGridView1.TabIndex = 26;
            // 
            // col_IDPhong
            // 
            this.col_IDPhong.HeaderText = "IDPhong";
            this.col_IDPhong.MinimumWidth = 6;
            this.col_IDPhong.Name = "col_IDPhong";
            this.col_IDPhong.Width = 125;
            // 
            // col_TenPhong
            // 
            this.col_TenPhong.HeaderText = "Tên Phòng";
            this.col_TenPhong.MinimumWidth = 6;
            this.col_TenPhong.Name = "col_TenPhong";
            this.col_TenPhong.Width = 125;
            // 
            // col_LoaiPhong
            // 
            this.col_LoaiPhong.HeaderText = "Loại Phòng";
            this.col_LoaiPhong.MinimumWidth = 6;
            this.col_LoaiPhong.Name = "col_LoaiPhong";
            this.col_LoaiPhong.Width = 125;
            // 
            // col_TrangThai
            // 
            this.col_TrangThai.HeaderText = "Trạng Thái";
            this.col_TrangThai.MinimumWidth = 6;
            this.col_TrangThai.Name = "col_TrangThai";
            this.col_TrangThai.Width = 125;
            // 
            // col_HienDung
            // 
            this.col_HienDung.HeaderText = "Hiện Dùng";
            this.col_HienDung.MinimumWidth = 6;
            this.col_HienDung.Name = "col_HienDung";
            this.col_HienDung.Width = 125;
            // 
            // col_Gia
            // 
            this.col_Gia.HeaderText = "Giá";
            this.col_Gia.MinimumWidth = 6;
            this.col_Gia.Name = "col_Gia";
            this.col_Gia.Width = 125;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(549, 412);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(114, 35);
            this.btn_Them.TabIndex = 27;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(720, 411);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(109, 35);
            this.btn_Thoat.TabIndex = 28;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Tên Phòng";
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(205, 380);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_TenPhong.TabIndex = 30;
            // 
            // comboBox_LoaiPhong
            // 
            this.comboBox_LoaiPhong.FormattingEnabled = true;
            this.comboBox_LoaiPhong.Items.AddRange(new object[] {
            "",
            "VIP",
            "Thường"});
            this.comboBox_LoaiPhong.Location = new System.Drawing.Point(205, 423);
            this.comboBox_LoaiPhong.Name = "comboBox_LoaiPhong";
            this.comboBox_LoaiPhong.Size = new System.Drawing.Size(147, 24);
            this.comboBox_LoaiPhong.TabIndex = 31;
            this.comboBox_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox_LoaiPhong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 34;
            // 
            // ManHinhThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_LoaiPhong);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ư);
            this.Name = "ManHinhThemPhong";
            this.Text = "ManHinhThemPhong";
            this.Load += new System.EventHandler(this.ManHinhThemPhong_Load);
            this.ư.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ư;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.ComboBox comboBox_LoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HienDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Gia;
    }
}