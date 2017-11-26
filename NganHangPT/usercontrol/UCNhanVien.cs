using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using NganHangPT.model;
using NganHangPT.ulti;
using DevComponents.DotNetBar;

namespace NganHangPT.usercontrol
{
    public partial class UCNhanVien : UserControl
    {
        private int viTri = 0;
        private Stack<UndoData<NhanVien>> stack = new Stack<UndoData<NhanVien>>();
        public UCNhanVien()
        {
            InitializeComponent();
        }
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nhanVienBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet1);

        }

        private void UCNhanVien_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet1.EnforceConstraints = false;
            
            nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet1.NhanVien);

            gD_ChuyenTienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_ChuyenTienTableAdapter.Fill(this.nGANHANGDataSet1.GD_ChuyenTien);

            gD_GoiRutTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GoiRutTableAdapter.Fill(this.nGANHANGDataSet1.GD_GoiRut);
            
            

            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember ="TENSERVER";
            
            if(Program.mGroup.CompareTo("NGANHANG") != 0)
            {
                lbChiNhanh.Visible = false;
                cbChiNhanh.Visible = false;
            }else
            {
               lbChiNhanh.Visible = true;
               cbChiNhanh.Visible = true;
            }

            btnGhi.Enabled = false;
            btnPhucHoi.Enabled = false;
            pnInfo.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnDanhSach.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            nhanVienBindingSource.AddNew();
            stack.Push(new UndoData<NhanVien>(Constants.ADD, Constants.NONE, viTri, null));
            setDefaultInputValue();
            txtMaNV.Focus();
            tuyBienNutLenh(btnThem);
        }

        private void setDefaultInputValue()
        {
            txtMaNV.Text = "";
            txtDiaChi.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            cbPhai.Text = "Nam";
        }
        private void tuyBienNutLenh(ButtonItem btn)
        {
            if(btn == btnThem)
            {
                //endable txtMaNV
                txtMaNV.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnDanhSach.Enabled = false;
                pnInfo.Enabled = true;

                tbNhanVien.Enabled = false;
                btnGhi.Enabled = true;
              
            }

            if(btn == btnSua)
            {
                //disable txtMaNV
                txtMaNV.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnDanhSach.Enabled = false;
                tbNhanVien.Enabled = false;

                pnInfo.Enabled = true;
                btnGhi.Enabled = true;
                
              
            }

            if(btn == btnGhi)
            {
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                pnInfo.Enabled = false;

                btnDanhSach.Enabled = true;
                tbNhanVien.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
              
            }

            if(btn == btnLamMoi)
            {
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;
                pnInfo.Enabled = false;

                tbNhanVien.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDanhSach.Enabled = true;
            }

            if(btn == btnPhucHoi)
            {
                tbNhanVien.Enabled = true;
                pnInfo.Enabled = false;

                tbNhanVien.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDanhSach.Enabled = true;
            }

            if (btn == btnXoa)
            {
                tbNhanVien.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDanhSach.Enabled = true;
                if (nhanVienBindingSource.Count == 0) btnXoa.Enabled = false;
            }

            btnLamMoi.Enabled = true;
            if (stack.Count > 0) btnPhucHoi.Enabled = true;
            else btnPhucHoi.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            NhanVien nv = new NhanVien();
            nv.MANV = txtMaNV.Text.Trim();
            nv.HOTEN = txtHoTen.Text.Trim();
            nv.PHAI = ((string)cbPhai.SelectedItem).Trim();
            nv.SODT = txtSDT.Text.Trim();
            nv.DIACHI = txtDiaChi.Text.Trim();
            nv.MACN = txtMaNV.Text.Trim();
            stack.Push(new UndoData<NhanVien>(Constants.EDIT, Constants.NONE, viTri, nv));
            tuyBienNutLenh(btnSua);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {

            if(txtMaNV.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào mã nhân viên.");
                txtMaNV.Focus();
                return;
            }
            if(txtHoTen.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào họ tên nhân viên.");
                txtHoTen.Focus();
                return;
            }
            if (txtSDT.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào số điện thoại nhân viên.");
                txtSDT.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào địa chỉ nhân viên.");
                txtDiaChi.Focus();
                return;
            }
            NhanVien nv = new NhanVien();
            try
            {
                
                nhanVienBindingSource.EndEdit();
                nhanVienBindingSource.ResetCurrentItem();
                if (nGANHANGDataSet1.HasChanges())
                {
                    nv.MANV = txtMaNV.Text.Trim();
                    nv.HOTEN = txtHoTen.Text.Trim();
                    nv.PHAI = ((string)cbPhai.SelectedItem).Trim();
                    nv.SODT = txtSDT.Text.Trim();
                    nv.DIACHI = txtDiaChi.Text.Trim();
                    nv.MACN = txtMaNV.Text.Trim();

                    this.nhanVienTableAdapter.Update(nGANHANGDataSet1.NhanVien);
                    int hanhDongTruoc = stack.Peek().getHanhDong();

                    // column MACN == NULL => cập nhật lại
                    String sql = "EXEC SP_SUANHANVIEN N'" + nv.MANV + "',N'" + nv.HOTEN + "',N'" + nv.DIACHI + "',N'" + nv.PHAI + "',N'" + nv.SODT + "'";
                    try
                    {
                        Program.ExecSqlNonQuery(sql, Program.connstr);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi qury");  
                    }
                    if (stack.Count > 0)
                    {
                        if(stack.Peek().getHanhDong() == Constants.EDIT)
                        {
                            nv = stack.Peek().getData();
                        }
                    }
                    stack.Push(new UndoData<NhanVien>(Constants.GHI, hanhDongTruoc, viTri, nv));
                    tuyBienNutLenh(btnGhi);
                   
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }

           

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        private void lamMoi()
        {
            nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet1.NhanVien);

            gD_ChuyenTienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_ChuyenTienTableAdapter.Fill(this.nGANHANGDataSet1.GD_ChuyenTien);

            gD_GoiRutTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GoiRutTableAdapter.Fill(this.nGANHANGDataSet1.GD_GoiRut);
            stack.Clear();
            tuyBienNutLenh(btnLamMoi);
        }
        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            UndoData<NhanVien> ud = stack.Peek();
            if(ud.getHanhDong() == Constants.ADD || ud.getHanhDong() == Constants.EDIT)
            {
                
                nhanVienBindingSource.CancelEdit();
                nhanVienTableAdapter.Fill(nGANHANGDataSet1.NhanVien);
                nhanVienBindingSource.Position = ud.getViTri();
                stack.Pop();

            }
            else if(ud.getHanhDong() == Constants.GHI)
            {
                if (ud.getHanhDongTruoc() == Constants.ADD)
                {
                    if (MessageBox.Show(this, "Bạn có muốn khôi phục dữ liệu cũ không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        String sql = "EXEC SP_XOANHANVIEN '" + ud.getData().MANV + "'";

                        try
                        {
                            Program.ExecSqlNonQuery(sql, Program.connstr);
                            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet1.NhanVien);
                            stack.Pop();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể phục hồi");
                        }

                    }

                }
                else
                {
                    if (MessageBox.Show(this, "Bạn có muốn khôi phục dữ liệu cũ không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        String sql = "EXEC SP_SUANHANVIEN N'" + ud.getData().MANV + "',N'" + ud.getData().HOTEN + "',N'" + ud.getData().DIACHI + "',N'" + ud.getData().PHAI + "',N'" + ud.getData().SODT + "'";

                        try
                        {
                            Program.ExecSqlNonQuery(sql, Program.connstr);
                            this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet1.NhanVien);
                            stack.Pop();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể phục hồi" + ex.Message);
                        }

                    }
                }

            }
            else
            {
                if (MessageBox.Show(this, "Bạn có muốn khôi phục dữ liệu cũ không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    String sql = "EXEC SP_THEMNHANVIEN N'" + ud.getData().MANV + "',N'" + ud.getData().HOTEN + "',N'" + ud.getData().DIACHI + "',N'" + ud.getData().PHAI + "',N'" + ud.getData().SODT + "'";

                    try
                    {
                        Program.ExecSqlNonQuery(sql, Program.connstr);
                        this.nhanVienTableAdapter.Fill(this.nGANHANGDataSet1.NhanVien);
                        stack.Pop();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể phục hồi" + ex.Message);
                    }

                }
            }
            tuyBienNutLenh(btnPhucHoi);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gD_GoiRutBindingSource.Count > 0  || gD_GoiRutBindingSource.Count > 0)
            {
                MessageBox.Show(this, "Nhân viên đã lập giao dịch, không thể xóa.", "Message");
            }
            else
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa nhân viên này?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    try
                    {

                        NhanVien nv = new NhanVien();
                        nv.MANV = txtMaNV.Text.Trim();
                        nv.HOTEN = txtHoTen.Text.Trim();
                        nv.PHAI = (string)cbPhai.SelectedItem;
                        nv.SODT = txtSDT.Text.Trim();
                        nv.DIACHI = txtDiaChi.Text.Trim();
                        nv.MACN = txtMaNV.Text.Trim();
                        nhanVienBindingSource.RemoveCurrent();
                        this.nhanVienTableAdapter.Update(this.nGANHANGDataSet1.NhanVien);
                        stack.Push(new UndoData<NhanVien>(Constants.DELETE, Constants.NONE, viTri, nv));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa nhân viên" + ex.Message);
                        return;
                    }
                }
                tuyBienNutLenh(btnXoa);
            }
        }

        private void v_DS_PHANMANHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            //if(cbChiNhanh.SelectedIndex != Program.mChinhanh)
            //{
            //    Program.mlogin = Program.remotelogin;
            //    Program.password = Program.remotepassword;
            //}else
            //{
            //    Program.mlogin = Program.mloginDN;
            //    Program.password = Program.passwordDN;
            //}
            //Program.servername = cbChiNhanh.SelectedValue.ToString();
            //int kq = Program.KetNoi();
            //MessageBox.Show(Program.connstr);
            //if(kq == 1) MessageBox.Show("Thành công");
            //else MessageBox.Show("Tin người vkl");
            //lamMoi();
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            if (cbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            Program.servername = cbChiNhanh.SelectedValue.ToString();
            int kq = Program.KetNoi();
            MessageBox.Show(Program.connstr);
            if (kq == 1) MessageBox.Show("Thành công");
            else MessageBox.Show("Tin người vkl");
            lamMoi();
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
        

        }

        private void tbNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
