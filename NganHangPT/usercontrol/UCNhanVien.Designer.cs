namespace NganHangPT.usercontrol
{
    partial class UCNhanVien
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nGANHANGDataSet1 = new NganHangPT.NGANHANGDataSet1();
            this.nhanVienTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.bar4 = new DevComponents.DotNetBar.Bar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnGhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhucHoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnDanhSach = new DevComponents.DotNetBar.ButtonItem();
            this.gD_ChuyenTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_ChuyenTienTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.GD_ChuyenTienTableAdapter();
            this.gD_GoiRutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GoiRutTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.GD_GoiRutTableAdapter();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNhanVien = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.txtMaNV = new DevExpress.XtraEditors.TextEdit();
            this.txtHoTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSDT = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new System.Windows.Forms.RichTextBox();
            this.cbPhai = new DevExpress.XtraEditors.ComboBoxEdit();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_ChuyenTienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GoiRutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 13);
            label1.TabIndex = 4;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(415, 44);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(28, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(54, 13);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(415, 85);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 13);
            label4.TabIndex = 2;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(28, 125);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(47, 13);
            label5.TabIndex = 6;
            label5.Text = "Giới tính";
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.nGANHANGDataSet1;
            // 
            // nGANHANGDataSet1
            // 
            this.nGANHANGDataSet1.DataSetName = "NGANHANGDataSet1";
            this.nGANHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_ChuyenTienTableAdapter = null;
            this.tableAdapterManager.GD_GoiRutTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "buttonItem1";
            // 
            // bar4
            // 
            this.bar4.AntiAlias = true;
            this.bar4.Dock = System.Windows.Forms.DockStyle.Top;
            this.bar4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnSua,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnLamMoi,
            this.btnDanhSach});
            this.bar4.Location = new System.Drawing.Point(0, 0);
            this.bar4.Name = "bar4";
            this.bar4.Size = new System.Drawing.Size(766, 53);
            this.bar4.Stretch = true;
            this.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar4.TabIndex = 8;
            this.bar4.TabStop = false;
            this.bar4.Text = "bar4";
            // 
            // btnThem
            // 
            this.btnThem.FixedSize = new System.Drawing.Size(100, 50);
            this.btnThem.Image = global::NganHangPT.Properties.Resources.Actions_list_add_user_icon_24;
            this.btnThem.ImagePaddingHorizontal = 0;
            this.btnThem.ImagePaddingVertical = 0;
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm";
            this.btnThem.Tooltip = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.FixedSize = new System.Drawing.Size(100, 50);
            this.btnSua.Image = global::NganHangPT.Properties.Resources.Text_Edit_icon_24;
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa";
            this.btnSua.Tooltip = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.FixedSize = new System.Drawing.Size(100, 50);
            this.btnGhi.Image = global::NganHangPT.Properties.Resources.Save_icon_24;
            this.btnGhi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Text = "Ghi";
            this.btnGhi.Tooltip = "Ghi";
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FixedSize = new System.Drawing.Size(100, 50);
            this.btnXoa.Image = global::NganHangPT.Properties.Resources.Delete_2_icon_24;
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Tooltip = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.FixedSize = new System.Drawing.Size(100, 50);
            this.btnPhucHoi.Image = global::NganHangPT.Properties.Resources.Undo_icon_24;
            this.btnPhucHoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.Text = "Phục hồi";
            this.btnPhucHoi.Tooltip = "Phục hồi";
            this.btnPhucHoi.Click += new System.EventHandler(this.btnPhucHoi_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.FixedSize = new System.Drawing.Size(100, 50);
            this.btnLamMoi.Image = global::NganHangPT.Properties.Resources.Button_Refresh_icon_24;
            this.btnLamMoi.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Tooltip = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.FixedSize = new System.Drawing.Size(120, 50);
            this.btnDanhSach.Image = global::NganHangPT.Properties.Resources.print_icon;
            this.btnDanhSach.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Text = "Danh sách nhân viên";
            this.btnDanhSach.Tooltip = "Danh sách nhân viên";
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // gD_ChuyenTienBindingSource
            // 
            this.gD_ChuyenTienBindingSource.DataMember = "FK_GD_ChuyenTien_NhanVien";
            this.gD_ChuyenTienBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // gD_ChuyenTienTableAdapter
            // 
            this.gD_ChuyenTienTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GoiRutBindingSource
            // 
            this.gD_GoiRutBindingSource.DataMember = "FK_GD_GoiRut_NhanVien";
            this.gD_GoiRutBindingSource.DataSource = this.nhanVienBindingSource;
            // 
            // gD_GoiRutTableAdapter
            // 
            this.gD_GoiRutTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.cbChiNhanh);
            this.panel2.Controls.Add(this.lbChiNhanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 43);
            this.panel2.TabIndex = 9;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(105, 9);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(211, 21);
            this.cbChiNhanh.TabIndex = 2;
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(18, 12);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(55, 13);
            this.lbChiNhanh.TabIndex = 1;
            this.lbChiNhanh.Text = "Chi nhánh";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(766, 553);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbNhanVien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 215);
            this.panel1.TabIndex = 16;
            // 
            // tbNhanVien
            // 
            this.tbNhanVien.DataSource = this.nhanVienBindingSource;
            this.tbNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNhanVien.Location = new System.Drawing.Point(0, 0);
            this.tbNhanVien.MainView = this.gridView1;
            this.tbNhanVien.Name = "tbNhanVien";
            this.tbNhanVien.Size = new System.Drawing.Size(760, 215);
            this.tbNhanVien.TabIndex = 17;
            this.tbNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.tbNhanVien.Click += new System.EventHandler(this.tbNhanVien_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHOTEN,
            this.colDIACHI,
            this.colMANV,
            this.colPHAI,
            this.colSODT});
            this.gridView1.GridControl = this.tbNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ và tên";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Giới tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 2;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 224);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 326);
            this.panel3.TabIndex = 17;
            // 
            // pnInfo
            // 
            this.pnInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnInfo.Controls.Add(this.txtMaNV);
            this.pnInfo.Controls.Add(label1);
            this.pnInfo.Controls.Add(label2);
            this.pnInfo.Controls.Add(this.txtHoTen);
            this.pnInfo.Controls.Add(this.txtSDT);
            this.pnInfo.Controls.Add(label3);
            this.pnInfo.Controls.Add(label4);
            this.pnInfo.Controls.Add(label5);
            this.pnInfo.Controls.Add(this.txtDiaChi);
            this.pnInfo.Controls.Add(this.cbPhai);
            this.pnInfo.Location = new System.Drawing.Point(0, 47);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(760, 233);
            this.pnInfo.TabIndex = 19;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(106, 41);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(200, 20);
            this.txtMaNV.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "HOTEN", true));
            this.txtHoTen.Location = new System.Drawing.Point(106, 82);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "SODT", true));
            this.txtSDT.Location = new System.Drawing.Point(502, 41);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 9;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nhanVienBindingSource, "DIACHI", true));
            this.txtDiaChi.Location = new System.Drawing.Point(502, 85);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 57);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.Text = "";
            // 
            // cbPhai
            // 
            this.cbPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nhanVienBindingSource, "PHAI", true));
            this.cbPhai.Location = new System.Drawing.Point(106, 122);
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPhai.Properties.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhai.Size = new System.Drawing.Size(200, 20);
            this.cbPhai.TabIndex = 7;
            // 
            // UCNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bar4);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(766, 649);
            this.Load += new System.EventHandler(this.UCNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_ChuyenTienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GoiRutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaNV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPhai.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private NGANHANGDataSet1 nGANHANGDataSet1;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private NGANHANGDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private NGANHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Bar bar4;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnGhi;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnPhucHoi;
        private DevComponents.DotNetBar.ButtonItem btnLamMoi;
        private DevComponents.DotNetBar.ButtonItem btnDanhSach;
        private System.Windows.Forms.BindingSource gD_ChuyenTienBindingSource;
        private NGANHANGDataSet1TableAdapters.GD_ChuyenTienTableAdapter gD_ChuyenTienTableAdapter;
        private System.Windows.Forms.BindingSource gD_GoiRutBindingSource;
        private NGANHANGDataSet1TableAdapters.GD_GoiRutTableAdapter gD_GoiRutTableAdapter;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl tbNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnInfo;
        private DevExpress.XtraEditors.TextEdit txtMaNV;
        private DevExpress.XtraEditors.TextEdit txtHoTen;
        private DevExpress.XtraEditors.TextEdit txtSDT;
        private System.Windows.Forms.RichTextBox txtDiaChi;
        private DevExpress.XtraEditors.ComboBoxEdit cbPhai;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
    }
}
