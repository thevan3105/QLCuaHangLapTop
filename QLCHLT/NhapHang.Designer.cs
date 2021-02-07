namespace QLCHLT
{
    partial class NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnInPN = new DevComponents.DotNetBar.ButtonX();
            this.btnHuyPN = new DevComponents.DotNetBar.ButtonX();
            this.btnLuuPN = new DevComponents.DotNetBar.ButtonX();
            this.btnTaoPN = new DevComponents.DotNetBar.ButtonX();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGiaNhap = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX22 = new DevComponents.DotNetBar.LabelX();
            this.labelX23 = new DevComponents.DotNetBar.LabelX();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSLMay = new System.Windows.Forms.NumericUpDown();
            this.cbMaMay = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtTenMay = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMaNCC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtTenNCC = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaPN = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLMay)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1070, 553);
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
            this.ribbonPanel1.Size = new System.Drawing.Size(1070, 496);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnThoat);
            this.groupPanel1.Controls.Add(this.btnInPN);
            this.groupPanel1.Controls.Add(this.btnHuyPN);
            this.groupPanel1.Controls.Add(this.btnLuuPN);
            this.groupPanel1.Controls.Add(this.btnTaoPN);
            this.groupPanel1.Controls.Add(this.groupBox2);
            this.groupPanel1.Controls.Add(this.groupBox1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1064, 493);
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
            this.groupPanel1.Text = "Danh sách nhập hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QLCHLT.Properties.Resources.exitapp;
            this.btnThoat.Location = new System.Drawing.Point(900, 414);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(121, 37);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnInPN
            // 
            this.btnInPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnInPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnInPN.Image = global::QLCHLT.Properties.Resources.print;
            this.btnInPN.Location = new System.Drawing.Point(690, 414);
            this.btnInPN.Name = "btnInPN";
            this.btnInPN.Size = new System.Drawing.Size(146, 37);
            this.btnInPN.TabIndex = 4;
            this.btnInPN.Text = "In phiếu nhập";
            this.btnInPN.Click += new System.EventHandler(this.BtnInPN_Click);
            // 
            // btnHuyPN
            // 
            this.btnHuyPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuyPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuyPN.Image = global::QLCHLT.Properties.Resources.delete;
            this.btnHuyPN.Location = new System.Drawing.Point(465, 414);
            this.btnHuyPN.Name = "btnHuyPN";
            this.btnHuyPN.Size = new System.Drawing.Size(154, 37);
            this.btnHuyPN.TabIndex = 5;
            this.btnHuyPN.Text = "Hủy phiếu nhập";
            this.btnHuyPN.Click += new System.EventHandler(this.BtnHuyPN_Click);
            // 
            // btnLuuPN
            // 
            this.btnLuuPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuuPN.Image = global::QLCHLT.Properties.Resources.save;
            this.btnLuuPN.Location = new System.Drawing.Point(239, 414);
            this.btnLuuPN.Name = "btnLuuPN";
            this.btnLuuPN.Size = new System.Drawing.Size(153, 37);
            this.btnLuuPN.TabIndex = 6;
            this.btnLuuPN.Text = "Thêm sản phẩm";
            this.btnLuuPN.Click += new System.EventHandler(this.BtnLuuPN_Click);
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTaoPN.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTaoPN.Image = global::QLCHLT.Properties.Resources.plus;
            this.btnTaoPN.Location = new System.Drawing.Point(36, 414);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(146, 37);
            this.btnTaoPN.TabIndex = 7;
            this.btnTaoPN.Text = "Tạo phiếu nhập";
            this.btnTaoPN.Click += new System.EventHandler(this.BtnTaoPN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtGiaNhap);
            this.groupBox2.Controls.Add(this.labelX22);
            this.groupBox2.Controls.Add(this.labelX23);
            this.groupBox2.Controls.Add(this.dgvNhapHang);
            this.groupBox2.Controls.Add(this.txtSLMay);
            this.groupBox2.Controls.Add(this.cbMaMay);
            this.groupBox2.Controls.Add(this.labelX10);
            this.groupBox2.Controls.Add(this.txtTenMay);
            this.groupBox2.Controls.Add(this.labelX17);
            this.groupBox2.Controls.Add(this.labelX14);
            this.groupBox2.Controls.Add(this.labelX16);
            this.groupBox2.Location = new System.Drawing.Point(0, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1058, 241);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhập hàng";
            // 
            // txtGiaNhap
            // 
            // 
            // 
            // 
            this.txtGiaNhap.Border.BackColor = System.Drawing.Color.Honeydew;
            this.txtGiaNhap.Border.BackColor2 = System.Drawing.Color.Aqua;
            this.txtGiaNhap.Border.Class = "CrumbBarBackgroundKey";
            this.txtGiaNhap.Border.CornerDiameter = 3;
            this.txtGiaNhap.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtGiaNhap.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtGiaNhap.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtGiaNhap.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtGiaNhap.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtGiaNhap.Enabled = false;
            this.txtGiaNhap.Location = new System.Drawing.Point(853, 30);
            this.txtGiaNhap.Multiline = true;
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(151, 23);
            this.txtGiaNhap.TabIndex = 20;
            this.txtGiaNhap.Text = "0";
            // 
            // labelX22
            // 
            this.labelX22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX22.Location = new System.Drawing.Point(778, 32);
            this.labelX22.Name = "labelX22";
            this.labelX22.Size = new System.Drawing.Size(69, 23);
            this.labelX22.TabIndex = 19;
            this.labelX22.Text = "Giá nhập";
            // 
            // labelX23
            // 
            this.labelX23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX23.Location = new System.Drawing.Point(1010, 29);
            this.labelX23.Name = "labelX23";
            this.labelX23.Size = new System.Drawing.Size(32, 23);
            this.labelX23.TabIndex = 18;
            this.labelX23.Text = "&đ";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaMay,
            this.TenMay,
            this.SoLuong});
            this.dgvNhapHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhapHang.Location = new System.Drawing.Point(3, 81);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.RowHeadersWidth = 51;
            this.dgvNhapHang.RowTemplate.Height = 24;
            this.dgvNhapHang.Size = new System.Drawing.Size(1052, 157);
            this.dgvNhapHang.TabIndex = 17;
            // 
            // MaPN
            // 
            this.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.MinimumWidth = 6;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            this.MaPN.Width = 135;
            // 
            // MaMay
            // 
            this.MaMay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "Mã máy";
            this.MaMay.MinimumWidth = 6;
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            this.MaMay.Width = 125;
            // 
            // TenMay
            // 
            this.TenMay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMay.DataPropertyName = "TenMay";
            this.TenMay.HeaderText = "Tên máy";
            this.TenMay.MinimumWidth = 6;
            this.TenMay.Name = "TenMay";
            this.TenMay.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // txtSLMay
            // 
            this.txtSLMay.Enabled = false;
            this.txtSLMay.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLMay.Location = new System.Drawing.Point(661, 32);
            this.txtSLMay.Name = "txtSLMay";
            this.txtSLMay.Size = new System.Drawing.Size(50, 25);
            this.txtSLMay.TabIndex = 16;
            // 
            // cbMaMay
            // 
            this.cbMaMay.DisplayMember = "Text";
            this.cbMaMay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaMay.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMay.FormattingEnabled = true;
            this.cbMaMay.ItemHeight = 16;
            this.cbMaMay.Location = new System.Drawing.Point(144, 33);
            this.cbMaMay.Name = "cbMaMay";
            this.cbMaMay.Size = new System.Drawing.Size(102, 22);
            this.cbMaMay.TabIndex = 15;
            this.cbMaMay.SelectedIndexChanged += new System.EventHandler(this.CbMaMay_SelectedIndexChanged);
            // 
            // labelX10
            // 
            this.labelX10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(717, 32);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(55, 23);
            this.labelX10.TabIndex = 10;
            this.labelX10.Text = "Chiếc";
            // 
            // txtTenMay
            // 
            // 
            // 
            // 
            this.txtTenMay.Border.BackColor = System.Drawing.Color.Honeydew;
            this.txtTenMay.Border.BackColor2 = System.Drawing.Color.Aqua;
            this.txtTenMay.Border.Class = "CrumbBarBackgroundKey";
            this.txtTenMay.Border.CornerDiameter = 3;
            this.txtTenMay.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTenMay.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenMay.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenMay.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenMay.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenMay.Enabled = false;
            this.txtTenMay.Location = new System.Drawing.Point(369, 32);
            this.txtTenMay.Multiline = true;
            this.txtTenMay.Name = "txtTenMay";
            this.txtTenMay.Size = new System.Drawing.Size(203, 23);
            this.txtTenMay.TabIndex = 14;
            this.txtTenMay.TextChanged += new System.EventHandler(this.TxtTenMay_TextChanged);
            // 
            // labelX17
            // 
            this.labelX17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX17.Location = new System.Drawing.Point(597, 34);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(58, 23);
            this.labelX17.TabIndex = 11;
            this.labelX17.Text = "SL máy";
            // 
            // labelX14
            // 
            this.labelX14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX14.Location = new System.Drawing.Point(281, 32);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(82, 23);
            this.labelX14.TabIndex = 12;
            this.labelX14.Text = "Tên máy";
            // 
            // labelX16
            // 
            this.labelX16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX16.Location = new System.Drawing.Point(41, 33);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(97, 23);
            this.labelX16.TabIndex = 13;
            this.labelX16.Text = "Mã máy";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbMaNCC);
            this.groupBox1.Controls.Add(this.txtTenNCC);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.dtpNgayNhap);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Controls.Add(this.labelX2);
            this.groupBox1.Controls.Add(this.labelX1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1058, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cbMaNCC
            // 
            this.cbMaNCC.DisplayMember = "Text";
            this.cbMaNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNCC.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNCC.FormattingEnabled = true;
            this.cbMaNCC.ItemHeight = 16;
            this.cbMaNCC.Location = new System.Drawing.Point(631, 34);
            this.cbMaNCC.Name = "cbMaNCC";
            this.cbMaNCC.Size = new System.Drawing.Size(102, 22);
            this.cbMaNCC.TabIndex = 5;
            this.cbMaNCC.SelectedIndexChanged += new System.EventHandler(this.CbMaNCC_SelectedIndexChanged);
            // 
            // txtTenNCC
            // 
            // 
            // 
            // 
            this.txtTenNCC.Border.BackColor = System.Drawing.Color.Honeydew;
            this.txtTenNCC.Border.BackColor2 = System.Drawing.Color.Aqua;
            this.txtTenNCC.Border.Class = "CrumbBarBackgroundKey";
            this.txtTenNCC.Border.CornerDiameter = 3;
            this.txtTenNCC.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTenNCC.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenNCC.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenNCC.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenNCC.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtTenNCC.Enabled = false;
            this.txtTenNCC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(631, 81);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(273, 22);
            this.txtTenNCC.TabIndex = 4;
            // 
            // txtMaPN
            // 
            // 
            // 
            // 
            this.txtMaPN.Border.BackColor = System.Drawing.Color.Honeydew;
            this.txtMaPN.Border.BackColor2 = System.Drawing.Color.Aqua;
            this.txtMaPN.Border.Class = "CrumbBarBackgroundKey";
            this.txtMaPN.Border.CornerDiameter = 3;
            this.txtMaPN.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMaPN.Border.CornerTypeBottomLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtMaPN.Border.CornerTypeBottomRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtMaPN.Border.CornerTypeTopLeft = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtMaPN.Border.CornerTypeTopRight = DevComponents.DotNetBar.eCornerType.Diagonal;
            this.txtMaPN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(195, 34);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(112, 22);
            this.txtMaPN.TabIndex = 4;
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Checked = false;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(195, 81);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(131, 22);
            this.dtpNgayNhap.TabIndex = 2;
            // 
            // labelX4
            // 
            this.labelX4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(504, 81);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(121, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Tên nhà cung cấp";
            // 
            // labelX3
            // 
            this.labelX3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(504, 34);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(121, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Mã nhà cung cấp";
            // 
            // labelX2
            // 
            this.labelX2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(81, 81);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Ngày nhập";
            // 
            // labelX1
            // 
            this.labelX1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(81, 34);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã phiếu nhập";
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Nhập hàng";
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
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.NhapHang_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLMay)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaPN;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNCC;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaNCC;
        private System.Windows.Forms.NumericUpDown txtSLMay;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaMay;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenMay;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private DevComponents.DotNetBar.ButtonX btnInPN;
        private DevComponents.DotNetBar.ButtonX btnHuyPN;
        private DevComponents.DotNetBar.ButtonX btnLuuPN;
        private DevComponents.DotNetBar.ButtonX btnTaoPN;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaNhap;
        private DevComponents.DotNetBar.LabelX labelX22;
        private DevComponents.DotNetBar.LabelX labelX23;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}