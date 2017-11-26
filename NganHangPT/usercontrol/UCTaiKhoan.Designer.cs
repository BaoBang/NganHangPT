namespace NganHangPT.usercontrol
{
    partial class UCTaiKhoan
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label sOTKLabel;
            this.nGANHANGDataSet1 = new NganHangPT.NGANHANGDataSet1();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.TaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager();
            this.gD_GoiRutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gD_GoiRutTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.GD_GoiRutTableAdapter();
            this.gD_ChuyenTienTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.GD_ChuyenTienTableAdapter();
            this.nhanVienTableAdapter = new NganHangPT.NGANHANGDataSet1TableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager1 = new NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.bar4 = new DevComponents.DotNetBar.Bar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnGhi = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.btnPhucHoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonItem();
            this.btnDanhSach = new DevComponents.DotNetBar.ButtonItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoDu = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoTK = new DevExpress.XtraEditors.TextEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.cbPhai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.tbTaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            cMNDLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GoiRutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(29, 43);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(39, 13);
            cMNDLabel.TabIndex = 8;
            cMNDLabel.Text = "CMND";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(25, 100);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(35, 13);
            sODULabel.TabIndex = 12;
            sODULabel.Text = "Số dư";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(18, 43);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(67, 13);
            sOTKLabel.TabIndex = 10;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // nGANHANGDataSet1
            // 
            this.nGANHANGDataSet1.DataSetName = "NGANHANGDataSet1";
            this.nGANHANGDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.nGANHANGDataSet1;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.GD_ChuyenTienTableAdapter = null;
            this.tableAdapterManager.GD_GoiRutTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // gD_ChuyenTienTableAdapter
            // 
            this.gD_ChuyenTienTableAdapter.ClearBeforeFill = true;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ChiNhanhTableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.GD_ChuyenTienTableAdapter = null;
            this.tableAdapterManager1.GD_GoiRutTableAdapter = null;
            this.tableAdapterManager1.KhachHangTableAdapter = null;
            this.tableAdapterManager1.NhanVienTableAdapter = null;
            this.tableAdapterManager1.TaiKhoanTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = NganHangPT.NGANHANGDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.bar4.Size = new System.Drawing.Size(797, 53);
            this.bar4.Stretch = true;
            this.bar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bar4.TabIndex = 11;
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.cbChiNhanh);
            this.panel2.Controls.Add(this.lbChiNhanh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 43);
            this.panel2.TabIndex = 12;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(105, 9);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(220, 21);
            this.cbChiNhanh.TabIndex = 2;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
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
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.groupBox1);
            this.pnInfo.Controls.Add(this.groupBox2);
            this.pnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnInfo.Location = new System.Drawing.Point(0, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(797, 173);
            this.pnInfo.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(sODULabel);
            this.groupBox1.Controls.Add(this.txtSoDu);
            this.groupBox1.Controls.Add(sOTKLabel);
            this.groupBox1.Controls.Add(this.txtSoTK);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(646, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 173);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "SODU", true));
            this.txtSoDu.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtSoDu.Location = new System.Drawing.Point(91, 97);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoDu.Size = new System.Drawing.Size(200, 20);
            this.txtSoDu.TabIndex = 13;
            // 
            // txtSoTK
            // 
            this.txtSoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "SOTK", true));
            this.txtSoTK.Location = new System.Drawing.Point(91, 40);
            this.txtSoTK.Name = "txtSoTK";
            this.txtSoTK.Size = new System.Drawing.Size(200, 20);
            this.txtSoTK.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCMND);
            this.groupBox2.Controls.Add(this.cbPhai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(cMNDLabel);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtSDT);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 173);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chủ tài khoản";
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.taiKhoanBindingSource, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(108, 36);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(200, 20);
            this.txtCMND.TabIndex = 11;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // cbPhai
            // 
            this.cbPhai.FormattingEnabled = true;
            this.cbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbPhai.Location = new System.Drawing.Point(426, 88);
            this.cbPhai.Name = "cbPhai";
            this.cbPhai.Size = new System.Drawing.Size(200, 21);
            this.cbPhai.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giới tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(426, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(108, 84);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(200, 20);
            this.txtHoTen.TabIndex = 0;
            // 
            // tbTaiKhoan
            // 
            this.tbTaiKhoan.DataSource = this.taiKhoanBindingSource;
            this.tbTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.tbTaiKhoan.MainView = this.gridView1;
            this.tbTaiKhoan.Name = "tbTaiKhoan";
            this.tbTaiKhoan.Size = new System.Drawing.Size(797, 178);
            this.tbTaiKhoan.TabIndex = 14;
            this.tbTaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU});
            this.gridView1.GridControl = this.tbTaiKhoan;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 1;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số dư";
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbTaiKhoan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 178);
            this.panel1.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pnInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 173);
            this.panel3.TabIndex = 16;
            // 
            // UCTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.bar4);
            this.Name = "UCTaiKhoan";
            this.Size = new System.Drawing.Size(797, 447);
            this.Load += new System.EventHandler(this.UCTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GoiRutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTK.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private NGANHANGDataSet1 nGANHANGDataSet1;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private NGANHANGDataSet1TableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private NGANHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource gD_GoiRutBindingSource;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private NGANHANGDataSet1TableAdapters.GD_GoiRutTableAdapter gD_GoiRutTableAdapter;
        private NGANHANGDataSet1TableAdapters.GD_ChuyenTienTableAdapter gD_ChuyenTienTableAdapter;
        private NGANHANGDataSet1TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private NGANHANGDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.Bar bar4;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnGhi;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnPhucHoi;
        private DevComponents.DotNetBar.ButtonItem btnLamMoi;
        private DevComponents.DotNetBar.ButtonItem btnDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label lbChiNhanh;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbPhai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SpinEdit txtSoDu;
        private DevExpress.XtraEditors.TextEdit txtSoTK;
        private DevExpress.XtraGrid.GridControl tbTaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txtCMND;
    }
}
