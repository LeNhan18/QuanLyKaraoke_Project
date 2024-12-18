namespace QuanLyKaraoke_New_Project
{
    partial class frm_QuanLyLoaiPhong
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column_IDPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IDPhong = new System.Windows.Forms.TextBox();
            this.txt_TenPhong = new System.Windows.Forms.TextBox();
            this.txt_Gia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_IDPhong,
            this.Column_TenPhong,
            this.Column_Gia});
            this.dataGridView1.Location = new System.Drawing.Point(69, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 133);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column_IDPhong
            // 
            this.Column_IDPhong.HeaderText = "ID";
            this.Column_IDPhong.MinimumWidth = 6;
            this.Column_IDPhong.Name = "Column_IDPhong";
            this.Column_IDPhong.Width = 125;
            // 
            // Column_TenPhong
            // 
            this.Column_TenPhong.HeaderText = "Tên Phòng";
            this.Column_TenPhong.MinimumWidth = 6;
            this.Column_TenPhong.Name = "Column_TenPhong";
            this.Column_TenPhong.Width = 125;
            // 
            // Column_Gia
            // 
            this.Column_Gia.HeaderText = "Giá";
            this.Column_Gia.MinimumWidth = 6;
            this.Column_Gia.Name = "Column_Gia";
            this.Column_Gia.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giá";
            // 
            // txt_IDPhong
            // 
            this.txt_IDPhong.Location = new System.Drawing.Point(174, 192);
            this.txt_IDPhong.Name = "txt_IDPhong";
            this.txt_IDPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_IDPhong.TabIndex = 4;
            // 
            // txt_TenPhong
            // 
            this.txt_TenPhong.Location = new System.Drawing.Point(174, 237);
            this.txt_TenPhong.Name = "txt_TenPhong";
            this.txt_TenPhong.Size = new System.Drawing.Size(100, 22);
            this.txt_TenPhong.TabIndex = 5;
            // 
            // txt_Gia
            // 
            this.txt_Gia.Location = new System.Drawing.Point(174, 283);
            this.txt_Gia.Name = "txt_Gia";
            this.txt_Gia.Size = new System.Drawing.Size(100, 22);
            this.txt_Gia.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(380, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(380, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 26);
            this.button3.TabIndex = 9;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frm_QuanLyLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 314);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Gia);
            this.Controls.Add(this.txt_TenPhong);
            this.Controls.Add(this.txt_IDPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_QuanLyLoaiPhong";
            this.Text = "Quản Lý Loại Phòng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IDPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IDPhong;
        private System.Windows.Forms.TextBox txt_TenPhong;
        private System.Windows.Forms.TextBox txt_Gia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}