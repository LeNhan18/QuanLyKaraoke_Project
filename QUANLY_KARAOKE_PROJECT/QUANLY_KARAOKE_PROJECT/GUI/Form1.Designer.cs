namespace QUANLY_KARAOKE_PROJECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HienDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýLoạiPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.col_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_SanPhamDaChon = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.menuStripSanPham = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.thêmVàoPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPhongChuaSuDung = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.sửDụngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉnhSửaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripPhongDaSuDung = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyểnPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTiềnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_BCTK = new System.Windows.Forms.Button();
            this.label_TenPhong = new System.Windows.Forms.Label();
            this.txt_GioVao = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.lvPlaylist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.BaoCaoThongKeStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPhamDaChon)).BeginInit();
            this.menuStripSanPham.SuspendLayout();
            this.menuStripPhongChuaSuDung.SuspendLayout();
            this.menuStripPhongDaSuDung.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 471);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 37);
            this.label2.TabIndex = 32;
            this.label2.Text = "Giờ vào";
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.col_Phong,
            this.col_HienDung});
            this.dataGridView_Phong.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView_Phong.Location = new System.Drawing.Point(950, 471);
            this.dataGridView_Phong.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.RowHeadersWidth = 51;
            this.dataGridView_Phong.RowTemplate.Height = 24;
            this.dataGridView_Phong.Size = new System.Drawing.Size(381, 278);
            this.dataGridView_Phong.TabIndex = 29;
            this.dataGridView_Phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Phong_CellContentClick);
            this.dataGridView_Phong.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Phong_CellMouseUp);
            // 
            // Col_ID
            // 
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.MinimumWidth = 6;
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.Width = 125;
            // 
            // col_Phong
            // 
            this.col_Phong.HeaderText = "Phòng";
            this.col_Phong.MinimumWidth = 6;
            this.col_Phong.Name = "col_Phong";
            this.col_Phong.Width = 125;
            // 
            // col_HienDung
            // 
            this.col_HienDung.HeaderText = "Hiện Dùng";
            this.col_HienDung.MinimumWidth = 6;
            this.col_HienDung.Name = "col_HienDung";
            this.col_HienDung.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLoạiPhòngToolStripMenuItem,
            this.quảnLýKháchHàngToolStripMenuItem,
            this.BaoCaoThongKeStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(9, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quảnLýLoạiPhòngToolStripMenuItem
            // 
            this.quảnLýLoạiPhòngToolStripMenuItem.Name = "quảnLýLoạiPhòngToolStripMenuItem";
            this.quảnLýLoạiPhòngToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.quảnLýLoạiPhòngToolStripMenuItem.Text = "Quản Lý Loại Phòng";
            this.quảnLýLoạiPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiPhòngToolStripMenuItem_Click);
            // 
            // quảnLýKháchHàngToolStripMenuItem
            // 
            this.quảnLýKháchHàngToolStripMenuItem.Name = "quảnLýKháchHàngToolStripMenuItem";
            this.quảnLýKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.quảnLýKháchHàngToolStripMenuItem.Text = "Quản Lý Khách Hàng";
            this.quảnLýKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_STT,
            this.col_TenSanPham,
            this.col_DonGia});
            this.dataGridView_SanPham.Location = new System.Drawing.Point(1335, 0);
            this.dataGridView_SanPham.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 51;
            this.dataGridView_SanPham.RowTemplate.Height = 24;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(313, 722);
            this.dataGridView_SanPham.TabIndex = 28;
            this.dataGridView_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_SanPham_CellContentClick);
            this.dataGridView_SanPham.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_SanPham_CellMouseUp);
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
            // dataGridView_SanPhamDaChon
            // 
            this.dataGridView_SanPhamDaChon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SanPhamDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPhamDaChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_SanPhamDaChon.Location = new System.Drawing.Point(12, 508);
            this.dataGridView_SanPhamDaChon.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_SanPhamDaChon.Name = "dataGridView_SanPhamDaChon";
            this.dataGridView_SanPhamDaChon.RowHeadersWidth = 51;
            this.dataGridView_SanPhamDaChon.RowTemplate.Height = 24;
            this.dataGridView_SanPhamDaChon.Size = new System.Drawing.Size(496, 257);
            this.dataGridView_SanPhamDaChon.TabIndex = 27;
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
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(1525, 726);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(68, 29);
            this.btn_Thoat.TabIndex = 35;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // menuStripSanPham
            // 
            this.menuStripSanPham.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripSanPham.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmVàoPhòngToolStripMenuItem,
            this.chiTiếtToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem,
            this.sảnPhẩmMớiToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.menuStripSanPham.Name = "menuStripSanPham";
            this.menuStripSanPham.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripSanPham.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripSanPham.RenderStyle.ColorTable = null;
            this.menuStripSanPham.RenderStyle.RoundedEdges = true;
            this.menuStripSanPham.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripSanPham.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuStripSanPham.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripSanPham.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripSanPham.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripSanPham.Size = new System.Drawing.Size(166, 114);
            this.menuStripSanPham.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripSanPham_Opening);
            // 
            // thêmVàoPhòngToolStripMenuItem
            // 
            this.thêmVàoPhòngToolStripMenuItem.Name = "thêmVàoPhòngToolStripMenuItem";
            this.thêmVàoPhòngToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.thêmVàoPhòngToolStripMenuItem.Text = "Thêm Vào Phòng";
            this.thêmVàoPhòngToolStripMenuItem.Click += new System.EventHandler(this.thêmVàoPhòngToolStripMenuItem_Click);
            // 
            // chiTiếtToolStripMenuItem
            // 
            this.chiTiếtToolStripMenuItem.Name = "chiTiếtToolStripMenuItem";
            this.chiTiếtToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chiTiếtToolStripMenuItem.Text = "Chi Tiết";
            this.chiTiếtToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtToolStripMenuItem_Click);
            // 
            // chỉnhSửaToolStripMenuItem
            // 
            this.chỉnhSửaToolStripMenuItem.Name = "chỉnhSửaToolStripMenuItem";
            this.chỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.chỉnhSửaToolStripMenuItem.Text = "Chỉnh Sửa";
            this.chỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.chỉnhSửaToolStripMenuItem_Click);
            // 
            // sảnPhẩmMớiToolStripMenuItem
            // 
            this.sảnPhẩmMớiToolStripMenuItem.Name = "sảnPhẩmMớiToolStripMenuItem";
            this.sảnPhẩmMớiToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.sảnPhẩmMớiToolStripMenuItem.Text = "Sản Phẩm Mới";
            this.sảnPhẩmMớiToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmMớiToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // menuStripPhongChuaSuDung
            // 
            this.menuStripPhongChuaSuDung.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPhongChuaSuDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửDụngToolStripMenuItem,
            this.xóaPhòngToolStripMenuItem,
            this.chỉnhSửaToolStripMenuItem1,
            this.đặtPhòngToolStripMenuItem,
            this.thêmPhòngToolStripMenuItem});
            this.menuStripPhongChuaSuDung.Name = "menuStripPhongChuaSuDung";
            this.menuStripPhongChuaSuDung.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripPhongChuaSuDung.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripPhongChuaSuDung.RenderStyle.ColorTable = null;
            this.menuStripPhongChuaSuDung.RenderStyle.RoundedEdges = true;
            this.menuStripPhongChuaSuDung.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripPhongChuaSuDung.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuStripPhongChuaSuDung.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripPhongChuaSuDung.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripPhongChuaSuDung.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripPhongChuaSuDung.Size = new System.Drawing.Size(144, 114);
            this.menuStripPhongChuaSuDung.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripPhongChuaSuDung_Opening);
            // 
            // sửDụngToolStripMenuItem
            // 
            this.sửDụngToolStripMenuItem.Name = "sửDụngToolStripMenuItem";
            this.sửDụngToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sửDụngToolStripMenuItem.Text = "Sử Dụng";
            this.sửDụngToolStripMenuItem.Click += new System.EventHandler(this.sửDụngToolStripMenuItem_Click);
            // 
            // xóaPhòngToolStripMenuItem
            // 
            this.xóaPhòngToolStripMenuItem.Name = "xóaPhòngToolStripMenuItem";
            this.xóaPhòngToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.xóaPhòngToolStripMenuItem.Text = "Xóa Phòng ";
            // 
            // chỉnhSửaToolStripMenuItem1
            // 
            this.chỉnhSửaToolStripMenuItem1.Name = "chỉnhSửaToolStripMenuItem1";
            this.chỉnhSửaToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.chỉnhSửaToolStripMenuItem1.Text = "Chỉnh Sửa";
            // 
            // đặtPhòngToolStripMenuItem
            // 
            this.đặtPhòngToolStripMenuItem.Name = "đặtPhòngToolStripMenuItem";
            this.đặtPhòngToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.đặtPhòngToolStripMenuItem.Text = "Đặt Phòng";
            this.đặtPhòngToolStripMenuItem.Click += new System.EventHandler(this.đặtPhòngToolStripMenuItem_Click);
            // 
            // thêmPhòngToolStripMenuItem
            // 
            this.thêmPhòngToolStripMenuItem.Name = "thêmPhòngToolStripMenuItem";
            this.thêmPhòngToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.thêmPhòngToolStripMenuItem.Text = "Thêm Phòng";
            this.thêmPhòngToolStripMenuItem.Click += new System.EventHandler(this.thêmPhòngToolStripMenuItem_Click);
            // 
            // menuStripPhongDaSuDung
            // 
            this.menuStripPhongDaSuDung.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripPhongDaSuDung.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trảPhòngToolStripMenuItem,
            this.chuyểnPhòngToolStripMenuItem,
            this.tínhTiềnToolStripMenuItem1});
            this.menuStripPhongDaSuDung.Name = "menuStripPhongDaSuDung";
            this.menuStripPhongDaSuDung.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.menuStripPhongDaSuDung.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.menuStripPhongDaSuDung.RenderStyle.ColorTable = null;
            this.menuStripPhongDaSuDung.RenderStyle.RoundedEdges = true;
            this.menuStripPhongDaSuDung.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.menuStripPhongDaSuDung.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.menuStripPhongDaSuDung.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.menuStripPhongDaSuDung.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.menuStripPhongDaSuDung.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.menuStripPhongDaSuDung.Size = new System.Drawing.Size(154, 70);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.trảPhòngToolStripMenuItem.Text = "Trả Phòng";
            this.trảPhòngToolStripMenuItem.Click += new System.EventHandler(this.trảPhòngToolStripMenuItem_Click);
            // 
            // chuyểnPhòngToolStripMenuItem
            // 
            this.chuyểnPhòngToolStripMenuItem.Name = "chuyểnPhòngToolStripMenuItem";
            this.chuyểnPhòngToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.chuyểnPhòngToolStripMenuItem.Text = "Chuyển Phòng";
            this.chuyểnPhòngToolStripMenuItem.Click += new System.EventHandler(this.chuyểnPhòngToolStripMenuItem_Click);
            // 
            // tínhTiềnToolStripMenuItem1
            // 
            this.tínhTiềnToolStripMenuItem1.Name = "tínhTiềnToolStripMenuItem1";
            this.tínhTiềnToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.tínhTiềnToolStripMenuItem1.Text = "Tính Tiền";
            this.tínhTiềnToolStripMenuItem1.Click += new System.EventHandler(this.tínhTiềnToolStripMenuItem1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.flowLayoutPanel1.ContextMenuStrip = this.menuStripPhongChuaSuDung;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1309, 442);
            this.flowLayoutPanel1.TabIndex = 36;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Colorful Gradient International Podcast Day Instagram Post (2).png");
            this.imageList1.Images.SetKeyName(1, "Colorful Gradient International Podcast Day Instagram Post (3).png");
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(12, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "label7";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_BCTK
            // 
            this.btn_BCTK.Location = new System.Drawing.Point(289, 0);
            this.btn_BCTK.Name = "btn_BCTK";
            this.btn_BCTK.Size = new System.Drawing.Size(144, 24);
            this.btn_BCTK.TabIndex = 38;
            this.btn_BCTK.Text = "Báo cáo thống kê";
            this.btn_BCTK.UseVisualStyleBackColor = true;
            this.btn_BCTK.Click += new System.EventHandler(this.btn_BCTK_Click);
            // 
            // label_TenPhong
            // 
            this.label_TenPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TenPhong.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_TenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenPhong.Location = new System.Drawing.Point(373, 472);
            this.label_TenPhong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TenPhong.Name = "label_TenPhong";
            this.label_TenPhong.Size = new System.Drawing.Size(118, 36);
            this.label_TenPhong.TabIndex = 31;
            this.label_TenPhong.Text = "    ";
            this.label_TenPhong.Click += new System.EventHandler(this.label_TenPhong_Click);
            // 
            // txt_GioVao
            // 
            this.txt_GioVao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GioVao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioVao.Location = new System.Drawing.Point(210, 472);
            this.txt_GioVao.Name = "txt_GioVao";
            this.txt_GioVao.Size = new System.Drawing.Size(168, 36);
            this.txt_GioVao.TabIndex = 39;
            this.txt_GioVao.Text = "";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(525, 650);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Phát nhạc";
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(606, 650);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Dừng nhạc";
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(687, 650);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.Text = "Thêm bài hát";
            this.btnAddSong.Click += new System.EventHandler(this.BtnAddSong_Click);
            // 
            // lvPlaylist
            // 
            this.lvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvPlaylist.HideSelection = false;
            this.lvPlaylist.Location = new System.Drawing.Point(525, 522);
            this.lvPlaylist.Name = "lvPlaylist";
            this.lvPlaylist.Size = new System.Drawing.Size(183, 106);
            this.lvPlaylist.TabIndex = 3;
            this.lvPlaylist.UseCompatibleStateImageBehavior = false;
            this.lvPlaylist.View = System.Windows.Forms.View.Details;
            this.lvPlaylist.SelectedIndexChanged += new System.EventHandler(this.lvPlaylist_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Bài Hát";
            this.columnHeader1.Width = 270;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đường dẫn";
            this.columnHeader2.Width = 150;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("VNI-Souvir", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Bai Hat Duoc Yeu Thich\r\n";
            // 
            // BaoCaoThongKeStripMenuItem1
            // 
            this.BaoCaoThongKeStripMenuItem1.Name = "BaoCaoThongKeStripMenuItem1";
            this.BaoCaoThongKeStripMenuItem1.Size = new System.Drawing.Size(119, 20);
            this.BaoCaoThongKeStripMenuItem1.Text = "Báo Cáo Thống Kê";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1648, 766);
            this.Controls.Add(this.btn_BCTK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvPlaylist);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.txt_GioVao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView_Phong);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TenPhong);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_SanPham);
            this.Controls.Add(this.dataGridView_SanPhamDaChon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Màn Hình Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPhamDaChon)).EndInit();
            this.menuStripSanPham.ResumeLayout(false);
            this.menuStripPhongChuaSuDung.ResumeLayout(false);
            this.menuStripPhongDaSuDung.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView_Phong;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiPhòngToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_SanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DonGia;
        private System.Windows.Forms.DataGridView dataGridView_SanPhamDaChon;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKháchHàngToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripSanPham;
        private System.Windows.Forms.ToolStripMenuItem thêmVàoPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripPhongChuaSuDung;
        private System.Windows.Forms.ToolStripMenuItem sửDụngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉnhSửaToolStripMenuItem1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip menuStripPhongDaSuDung;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chuyểnPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đặtPhòngToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HienDung;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_BCTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label_TenPhong;
        private System.Windows.Forms.RichTextBox txt_GioVao;
        private System.Windows.Forms.ListView lvPlaylist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem thêmPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoThongKeStripMenuItem1;
    }
}

