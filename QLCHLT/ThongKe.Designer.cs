namespace QLCHLT
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chThongKe = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnThongKe = new DevComponents.DotNetBar.ButtonX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbTongBan = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.lbTongNhap = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.lbDoanhThu = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvHB = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHN = new System.Windows.Forms.DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.btnQuayLai = new DevComponents.DotNetBar.ButtonItem();
            this.office2007StartButton1 = new DevComponents.DotNetBar.Office2007StartButton();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHN)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(1306, 489);
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
            this.ribbonPanel1.Size = new System.Drawing.Size(1306, 432);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.chThongKe);
            this.groupPanel1.Controls.Add(this.btnThongKe);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.lbTongBan);
            this.groupPanel1.Controls.Add(this.labelX10);
            this.groupPanel1.Controls.Add(this.labelX9);
            this.groupPanel1.Controls.Add(this.lbTongNhap);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Controls.Add(this.lbDoanhThu);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.dgvHB);
            this.groupPanel1.Controls.Add(this.dgvHN);
            this.groupPanel1.Controls.Add(this.dtpEnd);
            this.groupPanel1.Controls.Add(this.dtpStart);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(3, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1300, 429);
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
            this.groupPanel1.Text = "Chức năng thống kê";
            // 
            // chThongKe
            // 
            this.chThongKe.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chThongKe.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chThongKe.Legends.Add(legend1);
            this.chThongKe.Location = new System.Drawing.Point(911, 36);
            this.chThongKe.Name = "chThongKe";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng nhập";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Tổng bán";
            this.chThongKe.Series.Add(series1);
            this.chThongKe.Series.Add(series2);
            this.chThongKe.Size = new System.Drawing.Size(300, 300);
            this.chThongKe.TabIndex = 4;
            this.chThongKe.Text = "chart1";
            // 
            // btnThongKe
            // 
            this.btnThongKe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThongKe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThongKe.Image = global::QLCHLT.Properties.Resources.graph_report;
            this.btnThongKe.Location = new System.Drawing.Point(752, 38);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(101, 23);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // labelX4
            // 
            this.labelX4.Location = new System.Drawing.Point(3, 199);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 2;
            this.labelX4.Text = "Bán hàng";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(350, 36);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Kết thúc";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(3, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Hàng nhập";
            // 
            // lbTongBan
            // 
            this.lbTongBan.Location = new System.Drawing.Point(165, 367);
            this.lbTongBan.Name = "lbTongBan";
            this.lbTongBan.Size = new System.Drawing.Size(75, 23);
            this.lbTongBan.TabIndex = 2;
            this.lbTongBan.Text = ": &null";
            // 
            // labelX10
            // 
            this.labelX10.Location = new System.Drawing.Point(246, 367);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(48, 23);
            this.labelX10.TabIndex = 2;
            this.labelX10.Text = "phiếu";
            // 
            // labelX9
            // 
            this.labelX9.Location = new System.Drawing.Point(246, 328);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(48, 23);
            this.labelX9.TabIndex = 2;
            this.labelX9.Text = "phiếu";
            // 
            // lbTongNhap
            // 
            this.lbTongNhap.Location = new System.Drawing.Point(165, 328);
            this.lbTongNhap.Name = "lbTongNhap";
            this.lbTongNhap.Size = new System.Drawing.Size(75, 23);
            this.lbTongNhap.TabIndex = 2;
            this.lbTongNhap.Text = ": &null";
            // 
            // labelX8
            // 
            this.labelX8.Location = new System.Drawing.Point(699, 347);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(17, 23);
            this.labelX8.TabIndex = 2;
            this.labelX8.Text = "&đ";
            // 
            // lbDoanhThu
            // 
            this.lbDoanhThu.Location = new System.Drawing.Point(594, 347);
            this.lbDoanhThu.Name = "lbDoanhThu";
            this.lbDoanhThu.Size = new System.Drawing.Size(99, 23);
            this.lbDoanhThu.TabIndex = 2;
            this.lbDoanhThu.Text = ": &null";
            // 
            // labelX6
            // 
            this.labelX6.Location = new System.Drawing.Point(513, 347);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Doanh thu";
            // 
            // labelX7
            // 
            this.labelX7.Location = new System.Drawing.Point(66, 367);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 2;
            this.labelX7.Text = "Tổng bán";
            // 
            // labelX5
            // 
            this.labelX5.Location = new System.Drawing.Point(66, 328);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 2;
            this.labelX5.Text = "Tổng nhập";
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(84, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Bắt đầu";
            // 
            // dgvHB
            // 
            this.dgvHB.AllowUserToAddRows = false;
            this.dgvHB.AllowUserToDeleteRows = false;
            this.dgvHB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.NgayBan,
            this.MaKH,
            this.MaNV,
            this.TongTien});
            this.dgvHB.Location = new System.Drawing.Point(3, 228);
            this.dgvHB.Name = "dgvHB";
            this.dgvHB.ReadOnly = true;
            this.dgvHB.RowHeadersWidth = 51;
            this.dgvHB.RowTemplate.Height = 24;
            this.dgvHB.Size = new System.Drawing.Size(794, 82);
            this.dgvHB.TabIndex = 1;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hóa đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.ReadOnly = true;
            // 
            // NgayBan
            // 
            this.NgayBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày bán";
            this.NgayBan.MinimumWidth = 6;
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // dgvHN
            // 
            this.dgvHN.AllowUserToAddRows = false;
            this.dgvHN.AllowUserToDeleteRows = false;
            this.dgvHN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.NgayNhap,
            this.MaNCC});
            this.dgvHN.Location = new System.Drawing.Point(3, 106);
            this.dgvHN.Name = "dgvHN";
            this.dgvHN.ReadOnly = true;
            this.dgvHN.RowHeadersWidth = 51;
            this.dgvHN.RowTemplate.Height = 24;
            this.dgvHN.Size = new System.Drawing.Size(677, 82);
            this.dgvHN.TabIndex = 1;
            // 
            // MaPN
            // 
            this.MaPN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.MinimumWidth = 6;
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            // 
            // NgayNhap
            // 
            this.NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            // 
            // MaNCC
            // 
            this.MaNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy/MM/dd";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(431, 37);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(114, 22);
            this.dtpEnd.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy/MM/dd";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(165, 37);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(119, 22);
            this.dtpStart.TabIndex = 0;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Thống kê";
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
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 489);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHN)).EndInit();
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
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dgvHB;
        private System.Windows.Forms.DataGridView dgvHN;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnThongKe;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private DevComponents.DotNetBar.LabelX lbTongBan;
        private DevComponents.DotNetBar.LabelX lbTongNhap;
        private DevComponents.DotNetBar.LabelX lbDoanhThu;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX10;
    }
}