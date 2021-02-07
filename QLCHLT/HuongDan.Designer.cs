namespace QLCHLT
{
    partial class HuongDan
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCaiDat = new System.Windows.Forms.Button();
            this.btnHuongDan = new System.Windows.Forms.Button();
            this.btnLuuY = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 545);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1231, 20);
            this.panel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(583, 502);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(102, 37);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.Location = new System.Drawing.Point(35, 36);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(112, 30);
            this.btnCaiDat.TabIndex = 2;
            this.btnCaiDat.Text = "Cài đặt";
            this.btnCaiDat.UseVisualStyleBackColor = true;
            this.btnCaiDat.Click += new System.EventHandler(this.BtnCaiDat_Click);
            // 
            // btnHuongDan
            // 
            this.btnHuongDan.Location = new System.Drawing.Point(35, 79);
            this.btnHuongDan.Name = "btnHuongDan";
            this.btnHuongDan.Size = new System.Drawing.Size(112, 30);
            this.btnHuongDan.TabIndex = 2;
            this.btnHuongDan.Text = "Hướng dẫn";
            this.btnHuongDan.UseVisualStyleBackColor = true;
            this.btnHuongDan.Click += new System.EventHandler(this.BtnHuongDan_Click);
            // 
            // btnLuuY
            // 
            this.btnLuuY.Location = new System.Drawing.Point(35, 124);
            this.btnLuuY.Name = "btnLuuY";
            this.btnLuuY.Size = new System.Drawing.Size(112, 30);
            this.btnLuuY.TabIndex = 2;
            this.btnLuuY.Text = "Lưu ý";
            this.btnLuuY.UseVisualStyleBackColor = true;
            this.btnLuuY.Click += new System.EventHandler(this.BtnLuuY_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(186, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 483);
            this.panel2.TabIndex = 3;
            // 
            // HuongDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1231, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnLuuY);
            this.Controls.Add(this.btnHuongDan);
            this.Controls.Add(this.btnCaiDat);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HuongDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HuongDan";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCaiDat;
        private System.Windows.Forms.Button btnHuongDan;
        private System.Windows.Forms.Button btnLuuY;
        private System.Windows.Forms.Panel panel2;
    }
}