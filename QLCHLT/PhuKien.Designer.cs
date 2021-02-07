namespace QLCHLT
{
    partial class PhuKien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuKien));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtSoLuong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtBaoHanh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGia = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMauSac = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNamSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtHangSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenPK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaPK = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvPhuKien = new System.Windows.Forms.DataGridView();
            this.MaPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imgPK = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnLuuAnh = new DevComponents.DotNetBar.ButtonX();
            this.ptbAnhPK = new System.Windows.Forms.PictureBox();
            this.btnThemAnh = new DevComponents.DotNetBar.ButtonX();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatExcel = new DevComponents.DotNetBar.ButtonX();
            this.btnNhapLai = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtImagePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhPK)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1,
            this.btnQuayLai});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.office2007StartButton1,
            this.buttonItem1,
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(1253, 687);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.groupPanel1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1253, 630);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.txtSoLuong);
            this.groupPanel1.Controls.Add(this.txtBaoHanh);
            this.groupPanel1.Controls.Add(this.txtGia);
            this.groupPanel1.Controls.Add(this.txtMauSac);
            this.groupPanel1.Controls.Add(this.txtNamSX);
            this.groupPanel1.Controls.Add(this.txtHangSX);
            this.groupPanel1.Controls.Add(this.txtTenPK);
            this.groupPanel1.Controls.Add(this.txtMaPK);
            this.groupPanel1.Controls.Add(this.dgvPhuKien);
            this.groupPanel1.Controls.Add(this.btnLuuAnh);
            this.groupPanel1.Controls.Add(this.ptbAnhPK);
            this.groupPanel1.Controls.Add(this.btnThemAnh);
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.btnXuatExcel);
            this.groupPanel1.Controls.Add(this.btnNhapLai);
            this.groupPanel1.Controls.Add(this.btnXoa);
            this.groupPanel1.Controls.Add(this.btnSua);
            this.groupPanel1.Controls.Add(this.btnTimKiem);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.labelX14);
            this.groupPanel1.Controls.Add(this.labelX15);
            this.groupPanel1.Controls.Add(this.labelX12);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX13);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.txtImagePath);
            this.groupPanel1.Controls.Add(this.txtTimKiem);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1247, 627);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "Danh sách phụ kiện";
            // 
            // txtSoLuong
            // 
            // 
            // 
            // 
            this.txtSoLuong.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtSoLuong.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtSoLuong.Border.Class = "ListViewBorder";
            this.txtSoLuong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSoLuong.Location = new System.Drawing.Point(529, 318);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(75, 25);
            this.txtSoLuong.TabIndex = 50;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoLuong_KeyPress);
            // 
            // txtBaoHanh
            // 
            // 
            // 
            // 
            this.txtBaoHanh.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtBaoHanh.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtBaoHanh.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtBaoHanh.Border.Class = "ListViewBorder";
            this.txtBaoHanh.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtBaoHanh.Location = new System.Drawing.Point(529, 277);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(112, 25);
            this.txtBaoHanh.TabIndex = 50;
            // 
            // txtGia
            // 
            // 
            // 
            // 
            this.txtGia.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtGia.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtGia.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtGia.Border.Class = "ListViewBorder";
            this.txtGia.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtGia.Location = new System.Drawing.Point(529, 237);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(130, 25);
            this.txtGia.TabIndex = 50;
            this.txtGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGia_KeyPress);
            // 
            // txtMauSac
            // 
            // 
            // 
            // 
            this.txtMauSac.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtMauSac.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtMauSac.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtMauSac.Border.Class = "ListViewBorder";
            this.txtMauSac.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMauSac.Location = new System.Drawing.Point(182, 397);
            this.txtMauSac.Name = "txtMauSac";
            this.txtMauSac.Size = new System.Drawing.Size(145, 25);
            this.txtMauSac.TabIndex = 50;
            // 
            // txtNamSX
            // 
            // 
            // 
            // 
            this.txtNamSX.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtNamSX.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtNamSX.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtNamSX.Border.Class = "ListViewBorder";
            this.txtNamSX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtNamSX.Location = new System.Drawing.Point(182, 356);
            this.txtNamSX.Name = "txtNamSX";
            this.txtNamSX.Size = new System.Drawing.Size(100, 25);
            this.txtNamSX.TabIndex = 50;
            this.txtNamSX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNamSX_KeyPress);
            // 
            // txtHangSX
            // 
            // 
            // 
            // 
            this.txtHangSX.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtHangSX.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtHangSX.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtHangSX.Border.Class = "ListViewBorder";
            this.txtHangSX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtHangSX.Location = new System.Drawing.Point(182, 318);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Size = new System.Drawing.Size(117, 25);
            this.txtHangSX.TabIndex = 50;
            // 
            // txtTenPK
            // 
            // 
            // 
            // 
            this.txtTenPK.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtTenPK.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtTenPK.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtTenPK.Border.Class = "ListViewBorder";
            this.txtTenPK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTenPK.Location = new System.Drawing.Point(182, 277);
            this.txtTenPK.Name = "txtTenPK";
            this.txtTenPK.Size = new System.Drawing.Size(175, 25);
            this.txtTenPK.TabIndex = 50;
            // 
            // txtMaPK
            // 
            // 
            // 
            // 
            this.txtMaPK.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtMaPK.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtMaPK.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtMaPK.Border.Class = "ListViewBorder";
            this.txtMaPK.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMaPK.Location = new System.Drawing.Point(182, 237);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(100, 25);
            this.txtMaPK.TabIndex = 50;
            // 
            // dgvPhuKien
            // 
            this.dgvPhuKien.AllowUserToAddRows = false;
            this.dgvPhuKien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPK,
            this.TenPK,
            this.HangSX,
            this.NamSX,
            this.MauSac,
            this.Gia,
            this.BaoHanh,
            this.SoLuong,
            this.imgPK});
            this.dgvPhuKien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhuKien.Location = new System.Drawing.Point(0, 0);
            this.dgvPhuKien.Name = "dgvPhuKien";
            this.dgvPhuKien.RowHeadersWidth = 51;
            this.dgvPhuKien.RowTemplate.Height = 24;
            this.dgvPhuKien.Size = new System.Drawing.Size(1241, 213);
            this.dgvPhuKien.TabIndex = 49;
            this.dgvPhuKien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPhuKien_CellClick);
            // 
            // MaPK
            // 
            this.MaPK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPK.DataPropertyName = "MaPK";
            this.MaPK.HeaderText = "Mã PK";
            this.MaPK.MinimumWidth = 6;
            this.MaPK.Name = "MaPK";
            this.MaPK.Width = 80;
            // 
            // TenPK
            // 
            this.TenPK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPK.DataPropertyName = "TenPK";
            this.TenPK.HeaderText = "Tên PK";
            this.TenPK.MinimumWidth = 6;
            this.TenPK.Name = "TenPK";
            // 
            // HangSX
            // 
            this.HangSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HangSX.DataPropertyName = "HangSX";
            this.HangSX.HeaderText = "Hãng sx";
            this.HangSX.MinimumWidth = 6;
            this.HangSX.Name = "HangSX";
            this.HangSX.Width = 125;
            // 
            // NamSX
            // 
            this.NamSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NamSX.DataPropertyName = "NamSX";
            this.NamSX.HeaderText = "Năm sx";
            this.NamSX.MinimumWidth = 6;
            this.NamSX.Name = "NamSX";
            this.NamSX.Width = 125;
            // 
            // MauSac
            // 
            this.MauSac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MauSac.DataPropertyName = "MauSac";
            this.MauSac.HeaderText = "Màu sắc";
            this.MauSac.MinimumWidth = 6;
            this.MauSac.Name = "MauSac";
            this.MauSac.Width = 125;
            // 
            // Gia
            // 
            this.Gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.Width = 125;
            // 
            // BaoHanh
            // 
            this.BaoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BaoHanh.DataPropertyName = "BaoHanh";
            this.BaoHanh.HeaderText = "Bảo hành";
            this.BaoHanh.MinimumWidth = 6;
            this.BaoHanh.Name = "BaoHanh";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // imgPK
            // 
            this.imgPK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imgPK.DataPropertyName = "imgPK";
            this.imgPK.HeaderText = "ảnh";
            this.imgPK.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.imgPK.MinimumWidth = 6;
            this.imgPK.Name = "imgPK";
            this.imgPK.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.imgPK.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.imgPK.Width = 40;
            // 
            // btnLuuAnh
            // 
            this.btnLuuAnh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuAnh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuAnh.Image = global::QLCHLT.Properties.Resources.save;
            this.btnLuuAnh.Location = new System.Drawing.Point(1040, 470);
            this.btnLuuAnh.Name = "btnLuuAnh";
            this.btnLuuAnh.Size = new System.Drawing.Size(75, 33);
            this.btnLuuAnh.TabIndex = 48;
            this.btnLuuAnh.Text = "Lưu";
            this.btnLuuAnh.Click += new System.EventHandler(this.BtnLuuAnh_Click);
            // 
            // ptbAnhPK
            // 
            this.ptbAnhPK.BackColor = System.Drawing.Color.Transparent;
            this.ptbAnhPK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbAnhPK.Location = new System.Drawing.Point(905, 256);
            this.ptbAnhPK.Name = "ptbAnhPK";
            this.ptbAnhPK.Size = new System.Drawing.Size(202, 165);
            this.ptbAnhPK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnhPK.TabIndex = 47;
            this.ptbAnhPK.TabStop = false;
            this.ptbAnhPK.Click += new System.EventHandler(this.PtbAnhPK_Click);
            // 
            // btnThemAnh
            // 
            this.btnThemAnh.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemAnh.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemAnh.Location = new System.Drawing.Point(1040, 441);
            this.btnThemAnh.Name = "btnThemAnh";
            this.btnThemAnh.Size = new System.Drawing.Size(75, 23);
            this.btnThemAnh.TabIndex = 38;
            this.btnThemAnh.Text = "Thêm ảnh";
            this.btnThemAnh.Click += new System.EventHandler(this.BtnThemAnh_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QLCHLT.Properties.Resources.exitapp;
            this.btnThoat.Location = new System.Drawing.Point(995, 535);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 39);
            this.btnThoat.TabIndex = 39;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatExcel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatExcel.Image = global::QLCHLT.Properties.Resources.excel;
            this.btnXuatExcel.Location = new System.Drawing.Point(779, 535);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(143, 39);
            this.btnXuatExcel.TabIndex = 40;
            this.btnXuatExcel.Text = "Xuất danh sách";
            this.btnXuatExcel.Click += new System.EventHandler(this.BtnXuatExcel_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapLai.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapLai.Image = global::QLCHLT.Properties.Resources._return;
            this.btnNhapLai.Location = new System.Drawing.Point(616, 535);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(102, 39);
            this.btnNhapLai.TabIndex = 41;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.Click += new System.EventHandler(this.BtnNhapLai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QLCHLT.Properties.Resources.delete;
            this.btnXoa.Location = new System.Drawing.Point(448, 535);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(88, 39);
            this.btnXoa.TabIndex = 42;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Image = global::QLCHLT.Properties.Resources.edit;
            this.btnSua.Location = new System.Drawing.Point(280, 535);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(88, 35);
            this.btnSua.TabIndex = 43;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimKiem.Location = new System.Drawing.Point(503, 465);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 44;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.BtnTimKiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Image = global::QLCHLT.Properties.Resources.plus;
            this.btnThem.Location = new System.Drawing.Point(108, 535);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 35);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            this.labelX14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(938, 219);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(122, 31);
            this.labelX14.TabIndex = 25;
            this.labelX14.Text = "Ảnh sản phẩm";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            this.labelX15.Location = new System.Drawing.Point(821, 441);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 26;
            this.labelX15.Text = "Đường dẫn";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(665, 239);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(33, 23);
            this.labelX12.TabIndex = 22;
            this.labelX12.Text = "&đ";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(66, 399);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(110, 23);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "Màu sắc";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Location = new System.Drawing.Point(78, 465);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(98, 23);
            this.labelX13.TabIndex = 19;
            this.labelX13.Text = "Tìm Theo tên";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(66, 358);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(110, 23);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "Năm sản xuất";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            this.labelX8.Location = new System.Drawing.Point(448, 320);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(75, 23);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "Số lượng";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(66, 320);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(110, 23);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "Hãng sản xuất";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            this.labelX7.Location = new System.Drawing.Point(448, 279);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 15;
            this.labelX7.Text = "Bảo hành";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(66, 279);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(110, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Tên phụ kiện";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(448, 239);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "Giá bán";
            // 
            // txtImagePath
            // 
            // 
            // 
            // 
            this.txtImagePath.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtImagePath.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor;
            this.txtImagePath.Border.Class = "TextBoxBorder";
            this.txtImagePath.Location = new System.Drawing.Point(918, 441);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(116, 22);
            this.txtImagePath.TabIndex = 34;
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.Border.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.DockSiteBackColor;
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(182, 465);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(297, 22);
            this.txtTimKiem.TabIndex = 32;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(66, 239);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.TabIndex = 24;
            this.labelX1.Text = "Mã phụ kiện";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Phụ kiện";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // office2007StartButton1
            // 
            this.office2007StartButton1.AutoExpandOnClick = true;
            this.office2007StartButton1.CanCustomize = false;
            this.office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.office2007StartButton1.Icon = ((System.Drawing.Icon)(resources.GetObject("office2007StartButton1.Icon")));
            this.office2007StartButton1.ImagePaddingHorizontal = 2;
            this.office2007StartButton1.ImagePaddingVertical = 2;
            this.office2007StartButton1.Name = "office2007StartButton1";
            this.office2007StartButton1.ShowSubItems = false;
            this.office2007StartButton1.Text = "&File";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Cấu hình";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // PhuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 687);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhuKien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhuKien";
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuKien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhPK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonItem btnQuayLai;
        private DevComponents.DotNetBar.ButtonX btnLuuAnh;
        private System.Windows.Forms.PictureBox ptbAnhPK;
        private DevComponents.DotNetBar.ButtonX btnThemAnh;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnXuatExcel;
        private DevComponents.DotNetBar.ButtonX btnNhapLai;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtImagePath;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dgvPhuKien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPK;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoLuong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBaoHanh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGia;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMauSac;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNamSX;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHangSX;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewImageColumn imgPK;
    }
}