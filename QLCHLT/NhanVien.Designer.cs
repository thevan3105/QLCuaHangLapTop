namespace QLCHLT
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cbGioiTinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Nam = new DevComponents.Editors.ComboItem();
            this.Nữ = new DevComponents.Editors.ComboItem();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cbQuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.admin = new DevComponents.Editors.ComboItem();
            this.user = new DevComponents.Editors.ComboItem();
            this.kho = new DevComponents.Editors.ComboItem();
            this.btnXoaTK = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaTK = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTK = new DevComponents.DotNetBar.ButtonX();
            this.labelX17 = new DevComponents.DotNetBar.LabelX();
            this.labelX16 = new DevComponents.DotNetBar.LabelX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.btnThoatNV = new DevComponents.DotNetBar.ButtonX();
            this.btnXuatNV = new DevComponents.DotNetBar.ButtonX();
            this.btnNhapLaiNV = new DevComponents.DotNetBar.ButtonX();
            this.btnXoaNV = new DevComponents.DotNetBar.ButtonX();
            this.btnSuaNV = new DevComponents.DotNetBar.ButtonX();
            this.labelX14 = new DevComponents.DotNetBar.LabelX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.btnThemNV = new DevComponents.DotNetBar.ButtonX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.txtDiaChiNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtSDTNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenNV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.groupPanel4.SuspendLayout();
            this.groupPanel5.SuspendLayout();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1265, 513);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.groupPanel3);
            this.ribbonPanel1.Controls.Add(this.groupPanel4);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel1.Size = new System.Drawing.Size(1265, 456);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.dgvNhanVien);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel3.Location = new System.Drawing.Point(3, 0);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1259, 157);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 2;
            this.groupPanel3.Text = "Danh sách nhân viên";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.DiaChi,
            this.SDT,
            this.Email,
            this.GioiTinh});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1253, 134);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvNhanVien_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 130;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.ReadOnly = true;
            this.TenNV.Width = 130;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.Width = 125;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.Width = 120;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 125;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.cbGioiTinh);
            this.groupPanel4.Controls.Add(this.groupPanel5);
            this.groupPanel4.Controls.Add(this.btnThoatNV);
            this.groupPanel4.Controls.Add(this.btnXuatNV);
            this.groupPanel4.Controls.Add(this.btnNhapLaiNV);
            this.groupPanel4.Controls.Add(this.btnXoaNV);
            this.groupPanel4.Controls.Add(this.btnSuaNV);
            this.groupPanel4.Controls.Add(this.labelX14);
            this.groupPanel4.Controls.Add(this.labelX13);
            this.groupPanel4.Controls.Add(this.labelX9);
            this.groupPanel4.Controls.Add(this.btnThemNV);
            this.groupPanel4.Controls.Add(this.labelX10);
            this.groupPanel4.Controls.Add(this.labelX11);
            this.groupPanel4.Controls.Add(this.labelX12);
            this.groupPanel4.Controls.Add(this.txtDiaChiNV);
            this.groupPanel4.Controls.Add(this.txtEmail);
            this.groupPanel4.Controls.Add(this.txtSDTNV);
            this.groupPanel4.Controls.Add(this.txtMaNV);
            this.groupPanel4.Controls.Add(this.txtTenNV);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupPanel4.Location = new System.Drawing.Point(3, 167);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(1259, 286);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel4.TabIndex = 3;
            this.groupPanel4.Text = "Chức năng nhân viên";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DisplayMember = "Text";
            this.cbGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.ItemHeight = 16;
            this.cbGioiTinh.Items.AddRange(new object[] {
            this.Nam,
            this.Nữ});
            this.cbGioiTinh.Location = new System.Drawing.Point(159, 188);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 22);
            this.cbGioiTinh.TabIndex = 19;
            // 
            // Nam
            // 
            this.Nam.Text = "Nam";
            // 
            // Nữ
            // 
            this.Nữ.Text = "Nữ";
            // 
            // groupPanel5
            // 
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.Controls.Add(this.txtMatKhau);
            this.groupPanel5.Controls.Add(this.txtTaiKhoan);
            this.groupPanel5.Controls.Add(this.cbQuyen);
            this.groupPanel5.Controls.Add(this.btnXoaTK);
            this.groupPanel5.Controls.Add(this.btnSuaTK);
            this.groupPanel5.Controls.Add(this.btnThemTK);
            this.groupPanel5.Controls.Add(this.labelX17);
            this.groupPanel5.Controls.Add(this.labelX16);
            this.groupPanel5.Controls.Add(this.labelX15);
            this.groupPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupPanel5.Location = new System.Drawing.Point(761, 0);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(492, 263);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel5.TabIndex = 18;
            this.groupPanel5.Text = "Quyền";
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Location = new System.Drawing.Point(157, 55);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(193, 22);
            this.txtMatKhau.TabIndex = 5;
            // 
            // txtTaiKhoan
            // 
            // 
            // 
            // 
            this.txtTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTaiKhoan.Location = new System.Drawing.Point(157, 17);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(193, 22);
            this.txtTaiKhoan.TabIndex = 5;
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTaiKhoan_KeyPress);
            // 
            // cbQuyen
            // 
            this.cbQuyen.DisplayMember = "Text";
            this.cbQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbQuyen.FormattingEnabled = true;
            this.cbQuyen.ItemHeight = 16;
            this.cbQuyen.Items.AddRange(new object[] {
            this.admin,
            this.user,
            this.kho});
            this.cbQuyen.Location = new System.Drawing.Point(157, 92);
            this.cbQuyen.Name = "cbQuyen";
            this.cbQuyen.Size = new System.Drawing.Size(121, 22);
            this.cbQuyen.TabIndex = 4;
            // 
            // admin
            // 
            this.admin.Text = "admin";
            // 
            // user
            // 
            this.user.Text = "user";
            // 
            // kho
            // 
            this.kho.Text = "kho";
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaTK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaTK.Location = new System.Drawing.Point(368, 150);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTK.TabIndex = 3;
            this.btnXoaTK.Text = "Xóa";
            this.btnXoaTK.Click += new System.EventHandler(this.BtnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaTK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaTK.Location = new System.Drawing.Point(225, 150);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTK.TabIndex = 3;
            this.btnSuaTK.Text = "Sửa";
            this.btnSuaTK.Click += new System.EventHandler(this.BtnSuaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTK.Location = new System.Drawing.Point(67, 151);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(75, 23);
            this.btnThemTK.TabIndex = 3;
            this.btnThemTK.Text = "Thêm";
            this.btnThemTK.Click += new System.EventHandler(this.BtnThemTK_Click);
            // 
            // labelX17
            // 
            this.labelX17.BackColor = System.Drawing.Color.Transparent;
            this.labelX17.Location = new System.Drawing.Point(43, 91);
            this.labelX17.Name = "labelX17";
            this.labelX17.Size = new System.Drawing.Size(75, 23);
            this.labelX17.TabIndex = 2;
            this.labelX17.Text = "Quyền";
            // 
            // labelX16
            // 
            this.labelX16.BackColor = System.Drawing.Color.Transparent;
            this.labelX16.Location = new System.Drawing.Point(43, 55);
            this.labelX16.Name = "labelX16";
            this.labelX16.Size = new System.Drawing.Size(75, 23);
            this.labelX16.TabIndex = 1;
            this.labelX16.Text = "Mật khẩu";
            // 
            // labelX15
            // 
            this.labelX15.BackColor = System.Drawing.Color.Transparent;
            this.labelX15.Location = new System.Drawing.Point(43, 17);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(75, 23);
            this.labelX15.TabIndex = 0;
            this.labelX15.Text = "Tài khoản";
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoatNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoatNV.Image = global::QLCHLT.Properties.Resources.exitapp;
            this.btnThoatNV.Location = new System.Drawing.Point(455, 188);
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.Size = new System.Drawing.Size(75, 23);
            this.btnThoatNV.TabIndex = 4;
            this.btnThoatNV.Text = "Thoát";
            this.btnThoatNV.Click += new System.EventHandler(this.BtnThoatNV_Click);
            // 
            // btnXuatNV
            // 
            this.btnXuatNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXuatNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXuatNV.Image = global::QLCHLT.Properties.Resources.excel;
            this.btnXuatNV.Location = new System.Drawing.Point(455, 154);
            this.btnXuatNV.Name = "btnXuatNV";
            this.btnXuatNV.Size = new System.Drawing.Size(141, 23);
            this.btnXuatNV.TabIndex = 5;
            this.btnXuatNV.Text = "Xuất danh sách";
            this.btnXuatNV.Click += new System.EventHandler(this.BtnXuatNV_Click);
            // 
            // btnNhapLaiNV
            // 
            this.btnNhapLaiNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhapLaiNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhapLaiNV.Image = global::QLCHLT.Properties.Resources._return;
            this.btnNhapLaiNV.Location = new System.Drawing.Point(455, 118);
            this.btnNhapLaiNV.Name = "btnNhapLaiNV";
            this.btnNhapLaiNV.Size = new System.Drawing.Size(96, 23);
            this.btnNhapLaiNV.TabIndex = 6;
            this.btnNhapLaiNV.Text = "Nhập lại";
            this.btnNhapLaiNV.Click += new System.EventHandler(this.BtnNhapLaiNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoaNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoaNV.Image = global::QLCHLT.Properties.Resources.delete;
            this.btnXoaNV.Location = new System.Drawing.Point(455, 82);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNV.TabIndex = 7;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.Click += new System.EventHandler(this.BtnXoaNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSuaNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSuaNV.Image = global::QLCHLT.Properties.Resources.edit;
            this.btnSuaNV.Location = new System.Drawing.Point(455, 46);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNV.TabIndex = 8;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.Click += new System.EventHandler(this.BtnSuaNV_Click);
            // 
            // labelX14
            // 
            this.labelX14.BackColor = System.Drawing.Color.Transparent;
            this.labelX14.Location = new System.Drawing.Point(32, 188);
            this.labelX14.Name = "labelX14";
            this.labelX14.Size = new System.Drawing.Size(102, 23);
            this.labelX14.TabIndex = 10;
            this.labelX14.Text = "Giới tính";
            // 
            // labelX13
            // 
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            this.labelX13.Location = new System.Drawing.Point(32, 147);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(102, 23);
            this.labelX13.TabIndex = 10;
            this.labelX13.Text = "Email";
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            this.labelX9.Location = new System.Drawing.Point(32, 111);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(102, 23);
            this.labelX9.TabIndex = 10;
            this.labelX9.Text = "Số điện thoại";
            // 
            // btnThemNV
            // 
            this.btnThemNV.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNV.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNV.Image = global::QLCHLT.Properties.Resources.plus;
            this.btnThemNV.Location = new System.Drawing.Point(455, 10);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(75, 23);
            this.btnThemNV.TabIndex = 9;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.Click += new System.EventHandler(this.BtnThemNV_Click);
            // 
            // labelX10
            // 
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            this.labelX10.Location = new System.Drawing.Point(32, 73);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(103, 23);
            this.labelX10.TabIndex = 11;
            this.labelX10.Text = "Địa chỉ";
            // 
            // labelX11
            // 
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            this.labelX11.Location = new System.Drawing.Point(32, 3);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(102, 23);
            this.labelX11.TabIndex = 12;
            this.labelX11.Text = "Mã nhân viên";
            // 
            // labelX12
            // 
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            this.labelX12.Location = new System.Drawing.Point(32, 37);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(102, 23);
            this.labelX12.TabIndex = 13;
            this.labelX12.Text = "Tên nhân viên";
            // 
            // txtDiaChiNV
            // 
            // 
            // 
            // 
            this.txtDiaChiNV.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtDiaChiNV.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtDiaChiNV.Border.Class = "ListViewBorder";
            this.txtDiaChiNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtDiaChiNV.Location = new System.Drawing.Point(152, 75);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(251, 25);
            this.txtDiaChiNV.TabIndex = 14;
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtEmail.Border.Class = "ListViewBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtEmail.Location = new System.Drawing.Point(152, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 25);
            this.txtEmail.TabIndex = 15;
            // 
            // txtSDTNV
            // 
            // 
            // 
            // 
            this.txtSDTNV.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtSDTNV.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtSDTNV.Border.Class = "ListViewBorder";
            this.txtSDTNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtSDTNV.Location = new System.Drawing.Point(152, 111);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(154, 25);
            this.txtSDTNV.TabIndex = 15;
            this.txtSDTNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSDTNV_KeyPress);
            // 
            // txtMaNV
            // 
            // 
            // 
            // 
            this.txtMaNV.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNV.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtMaNV.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtMaNV.Border.Class = "ListViewBorder";
            this.txtMaNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtMaNV.Location = new System.Drawing.Point(152, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 25);
            this.txtMaNV.TabIndex = 16;
            // 
            // txtTenNV
            // 
            // 
            // 
            // 
            this.txtTenNV.Border.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNV.Border.BackColor2 = System.Drawing.SystemColors.Control;
            this.txtTenNV.Border.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.Center;
            this.txtTenNV.Border.Class = "ListViewBorder";
            this.txtTenNV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtTenNV.Location = new System.Drawing.Point(152, 39);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(190, 25);
            this.txtTenNV.TabIndex = 17;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Nhân viên";
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
            // btnQuayLai
            // 
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.Click += new System.EventHandler(this.BtnQuayLai_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 513);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.groupPanel4.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbGioiTinh;
        private DevComponents.Editors.ComboItem Nam;
        private DevComponents.Editors.ComboItem Nữ;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoan;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbQuyen;
        private DevComponents.Editors.ComboItem admin;
        private DevComponents.Editors.ComboItem user;
        private DevComponents.Editors.ComboItem kho;
        private DevComponents.DotNetBar.ButtonX btnXoaTK;
        private DevComponents.DotNetBar.ButtonX btnSuaTK;
        private DevComponents.DotNetBar.ButtonX btnThemTK;
        private DevComponents.DotNetBar.LabelX labelX17;
        private DevComponents.DotNetBar.LabelX labelX16;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.ButtonX btnThoatNV;
        private DevComponents.DotNetBar.ButtonX btnXuatNV;
        private DevComponents.DotNetBar.ButtonX btnNhapLaiNV;
        private DevComponents.DotNetBar.ButtonX btnXoaNV;
        private DevComponents.DotNetBar.ButtonX btnSuaNV;
        private DevComponents.DotNetBar.LabelX labelX14;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.ButtonX btnThemNV;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChiNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSDTNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaNV;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenNV;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.Office2007StartButton office2007StartButton1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private DevComponents.DotNetBar.ButtonItem btnQuayLai;
    }
}