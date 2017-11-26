namespace NganHangPT.usercontrol
{
    partial class UCGiaoDichChuyenTien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbPhaiGui = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoTKGui = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTGui = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMNDGui = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoTenGui = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPhaiNhan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDTNhan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCMNDNhan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHoTenNhan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.txtSoTien = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản gửi";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.txtSoTien);
            this.panel3.Controls.Add(this.cbPhaiGui);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtSoTKGui);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSDTGui);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCMNDGui);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtHoTenGui);
            this.panel3.Location = new System.Drawing.Point(20, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 196);
            this.panel3.TabIndex = 0;
            // 
            // cbPhaiGui
            // 
            this.cbPhaiGui.Enabled = false;
            this.cbPhaiGui.FormattingEnabled = true;
            this.cbPhaiGui.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhaiGui.Location = new System.Drawing.Point(124, 83);
            this.cbPhaiGui.Name = "cbPhaiGui";
            this.cbPhaiGui.Size = new System.Drawing.Size(200, 21);
            this.cbPhaiGui.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số tiển chuyển";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Số tài khoản";
            // 
            // txtSoTKGui
            // 
            this.txtSoTKGui.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSoTKGui.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSoTKGui.Location = new System.Drawing.Point(124, 139);
            this.txtSoTKGui.Name = "txtSoTKGui";
            this.txtSoTKGui.Size = new System.Drawing.Size(200, 20);
            this.txtSoTKGui.TabIndex = 20;
            this.txtSoTKGui.TextChanged += new System.EventHandler(this.txtSoTKGui_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Số điện thoại";
            // 
            // txtSDTGui
            // 
            this.txtSDTGui.Enabled = false;
            this.txtSDTGui.Location = new System.Drawing.Point(516, 88);
            this.txtSDTGui.Name = "txtSDTGui";
            this.txtSDTGui.Size = new System.Drawing.Size(200, 20);
            this.txtSDTGui.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CMND";
            // 
            // txtCMNDGui
            // 
            this.txtCMNDGui.Enabled = false;
            this.txtCMNDGui.Location = new System.Drawing.Point(516, 37);
            this.txtCMNDGui.Name = "txtCMNDGui";
            this.txtCMNDGui.Size = new System.Drawing.Size(200, 20);
            this.txtCMNDGui.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Họ tên";
            // 
            // txtHoTenGui
            // 
            this.txtHoTenGui.Enabled = false;
            this.txtHoTenGui.Location = new System.Drawing.Point(124, 34);
            this.txtHoTenGui.Name = "txtHoTenGui";
            this.txtHoTenGui.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenGui.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản nhận";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Controls.Add(this.cbPhaiNhan);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtSoTKNhan);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtSDTNhan);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtCMNDNhan);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtHoTenNhan);
            this.panel4.Location = new System.Drawing.Point(20, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(759, 159);
            this.panel4.TabIndex = 0;
            // 
            // cbPhaiNhan
            // 
            this.cbPhaiNhan.Enabled = false;
            this.cbPhaiNhan.FormattingEnabled = true;
            this.cbPhaiNhan.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhaiNhan.Location = new System.Drawing.Point(124, 74);
            this.cbPhaiNhan.Name = "cbPhaiNhan";
            this.cbPhaiNhan.Size = new System.Drawing.Size(200, 21);
            this.cbPhaiNhan.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Số tài khoản";
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSoTKNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSoTKNhan.Location = new System.Drawing.Point(124, 122);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.Size = new System.Drawing.Size(200, 20);
            this.txtSoTKNhan.TabIndex = 30;
            this.txtSoTKNhan.TextChanged += new System.EventHandler(this.txtSoTKNhan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Số điện thoại";
            // 
            // txtSDTNhan
            // 
            this.txtSDTNhan.Enabled = false;
            this.txtSDTNhan.Location = new System.Drawing.Point(516, 71);
            this.txtSDTNhan.Name = "txtSDTNhan";
            this.txtSDTNhan.Size = new System.Drawing.Size(200, 20);
            this.txtSDTNhan.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "CMND";
            // 
            // txtCMNDNhan
            // 
            this.txtCMNDNhan.Enabled = false;
            this.txtCMNDNhan.Location = new System.Drawing.Point(516, 20);
            this.txtCMNDNhan.Name = "txtCMNDNhan";
            this.txtCMNDNhan.Size = new System.Drawing.Size(200, 20);
            this.txtCMNDNhan.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Giới tính";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Họ tên";
            // 
            // txtHoTenNhan
            // 
            this.txtHoTenNhan.Enabled = false;
            this.txtHoTenNhan.Location = new System.Drawing.Point(124, 17);
            this.txtHoTenNhan.Name = "txtHoTenNhan";
            this.txtHoTenNhan.Size = new System.Drawing.Size(200, 20);
            this.txtHoTenNhan.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 91);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btnLamMoi);
            this.panel2.Controls.Add(this.btnChuyenTien);
            this.panel2.Location = new System.Drawing.Point(282, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 88);
            this.panel2.TabIndex = 0;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(157, 31);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 23);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Location = new System.Drawing.Point(37, 31);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenTien.TabIndex = 0;
            this.btnChuyenTien.Text = "Chuyển tiền";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSoTien.Location = new System.Drawing.Point(516, 140);
            this.txtSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(200, 20);
            this.txtSoTien.TabIndex = 25;
            // 
            // UCGiaoDichChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCGiaoDichChuyenTien";
            this.Size = new System.Drawing.Size(785, 496);
            this.Load += new System.EventHandler(this.UCGiaoDichChuyenTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbPhaiGui;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoTKGui;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTGui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCMNDGui;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTenGui;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPhaiNhan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoTKNhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDTNhan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCMNDNhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHoTenNhan;
        private System.Windows.Forms.NumericUpDown txtSoTien;
    }
}
