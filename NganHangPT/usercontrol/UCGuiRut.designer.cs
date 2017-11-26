namespace NGANHANGPT.usercontrol
{
    partial class UCGuiRut
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.txtSoTK = new System.Windows.Forms.TextBox();
            this.v_DS_TAIKHOANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.v_TK = new NGANHANGPT.V_TK();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_TAIKHOANBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.v_TK)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giao dịch Gửi / Rút";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 137);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 360);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiaoDich);
            this.groupBox1.Controls.Add(this.txtSoTK);
            this.groupBox1.Controls.Add(this.txtSoTien);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtTenTK);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbLoaiGiaoDich);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(194, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 258);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Giao Dịch";
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.Location = new System.Drawing.Point(376, 115);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(89, 53);
            this.btnGiaoDich.TabIndex = 10;
            this.btnGiaoDich.Text = "Giao Dịch";
            this.btnGiaoDich.UseVisualStyleBackColor = true;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // txtSoTK
            // 
            this.txtSoTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSoTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.v_DS_TAIKHOANBindingSource, "SOTK", true));
            this.txtSoTK.Location = new System.Drawing.Point(175, 90);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(168, 20);
            this.txtSoTK.TabIndex = 9;
            this.txtSoTK.TextChanged += new System.EventHandler(this.txtSoTK_TextChanged);
            // 
            // v_DS_TAIKHOANBindingSource
            // 
            //this.v_DS_TAIKHOANBindingSource.DataMember = "V_DS_TAIKHOAN";
            //this.v_DS_TAIKHOANBindingSource.DataSource = this.v_TK;
            // 
            // v_TK
            //// 
            //this.v_TK.DataSetName = "V_TK";
            //this.v_TK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(175, 222);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(168, 20);
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.Text = "100000";
            this.txtSoTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTien_KeyPress);
            // 
            // txtCMND
            // 
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(175, 178);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(168, 20);
            this.txtCMND.TabIndex = 3;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Enabled = false;
            this.txtTenTK.Location = new System.Drawing.Point(175, 132);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(168, 20);
            this.txtTenTK.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Số tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số CMND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tài khoản";
            // 
            // cmbLoaiGiaoDich
            // 
            this.cmbLoaiGiaoDich.FormattingEnabled = true;
            this.cmbLoaiGiaoDich.Items.AddRange(new object[] {
            "Gửi Tiền",
            "Rút Tiền"});
            this.cmbLoaiGiaoDich.Location = new System.Drawing.Point(175, 40);
            this.cmbLoaiGiaoDich.Name = "cmbLoaiGiaoDich";
            this.cmbLoaiGiaoDich.Size = new System.Drawing.Size(168, 21);
            this.cmbLoaiGiaoDich.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại giao dịch";
            // 
            // v_DS_TAIKHOANTableAdapter
            // 
            //this.v_DS_TAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            //this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            //this.tableAdapterManager.Connection = null;
            //this.tableAdapterManager.UpdateOrder = NGANHANGPT.V_TKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dS
            //// 
            //this.dS.DataSetName = "DS";
            //this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UCGuiRut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCGuiRut";
            this.Size = new System.Drawing.Size(756, 497);
            this.Load += new System.EventHandler(this.UCGuiRut_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_TAIKHOANBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.v_TK)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbLoaiGiaoDich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource v_DS_TAIKHOANBindingSource;
        //private V_TK v_TK;
        //private V_TKTableAdapters.V_DS_TAIKHOANTableAdapter v_DS_TAIKHOANTableAdapter;
        //private V_TKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtSoTK;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiaoDich;
        //private DS dS;
    }
}
