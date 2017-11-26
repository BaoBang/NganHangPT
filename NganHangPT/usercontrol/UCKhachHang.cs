using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Globalization;
using NganHangPT.ulti;
using NganHangPT.model;
using NganHangPT;

namespace NGANHANGPT.usercontrol
{
    public partial class UCKhachHang : UserControl
    {
        private int viTri = 0;
        private string maCN = "";
        private Stack<UndoData<KhachHang>> stack = new Stack<UndoData<KhachHang>>();
        
        public UCKhachHang()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nGANHANGDataSet1);
        }

        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            this.nGANHANGDataSet1.EnforceConstraints = false;

            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);

            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);

            maCN = ((DataRowView)bdsKH[0])["MACN"].ToString();

            this.cmbChiNhanh.DataSource = Program.bds_dspm;
            this.cmbChiNhanh.DisplayMember = "TENCN";
            this.cmbChiNhanh.ValueMember = "TENSERVER";
            this.cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            if (Program.mGroup != "NGANHANG")
            {
                this.cmbChiNhanh.Enabled = false;
                groupBox1.Enabled = false;
                btnGhi.Enabled = false;
            }
            else
            {
                this.cmbChiNhanh.Enabled = true;

                this.gcKH.Enabled = false;
                this.groupBox1.Enabled = false;

                this.btnThem.Enabled = false;
                this.btnSua.Enabled = false;
                this.btnGhi.Enabled = false;
                this.btnXoa.Enabled = false;
                this.btnLamMoi.Enabled = false;
                this.btnPhucHoi.Enabled = false;

            }
            btnThem.Enabled = true;
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue != null)
            {
                if (cmbChiNhanh.SelectedValue.ToString() != "System.Data.DataRowView")
                    Program.servername = cmbChiNhanh.SelectedValue.ToString();

                if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }

                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "Lỗi", MessageBoxButtons.OK);
                }
                else
                {
                    //this.DS.EnforceConstraints = false;

                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);

                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
                    maCN = ((DataRowView)bdsKH[0])["MACN"].ToString();
                }
            }
        }

        private void tuyBienNutLenh(BarButtonItem btn)
        {
            if (btn == btnThem)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnPhucHoi.Enabled = false;
                btnPhucHoi.Enabled = true;

                btnGhi.Enabled = true;

                gcKH.Enabled = false;
            }
            if (btn == btnSua)
            {
                groupBox1.Enabled = true;
                

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;

                btnGhi.Enabled = true;
                btnPhucHoi.Enabled = false;
                btnLamMoi.Enabled = false;

                gcKH.Enabled = false;
            }

            if (btn == btnGhi)
            {
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = true;
                groupBox1.Enabled = false;
                gcKH.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;

            }

            if (btn == btnPhucHoi)
            {
                btnGhi.Enabled = false;
                btnPhucHoi.Enabled = false;

                gcKH.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

            if (btn == btnLamMoi)
            {
                gcKH.Enabled = true;
                groupBox1.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }

            if (btn == btnXoa)
            {
                gcKH.Enabled = true;
                groupBox1.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnPhucHoi.Enabled = true;
                if (bdsKH.Count == 0) btnXoa.Enabled = false;
            }

            btnPhucHoi.Enabled = true;
            //if (stack.Count > 0) btnPhucHoi.Enabled = true;
            //else btnPhucHoi.Enabled = false;
            //MessageBox.Show(stack.Count + "");
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKH.Position;
            groupBox1.Enabled = true;
            bdsKH.AddNew();
            stack.Push(new UndoData<KhachHang>(Constants.ADD, Constants.NONE, viTri, null));
            txtHoTen.Focus();

            txtMaCN.Text = maCN;
            txtMaCN.Enabled = false;
            datetime.EditValue = "";
            cmbPhai.SelectedIndex = 1;
            cmbPhai.SelectedIndex = 0;

            tuyBienNutLenh(btnThem);
        }

        private void btnSua_ItemClick(object sender, ItemClickEventArgs e)
        {
            viTri = bdsKH.Position;
            groupBox1.Enabled = true;
            txtMaCN.Enabled = false;
            txtCMND.Enabled = false;
            KhachHang kh = new KhachHang();
            kh.CMND = txtCMND.Text.Trim();
            kh.HOTEN = txtHoTen.Text.Trim();
            kh.MACN = maCN;
            kh.NGAYCAP = DateTime.ParseExact(datetime.Text.Trim(), "MM/dd/yyyy", null);
            kh.PHAI = (cmbPhai.SelectedIndex).ToString();
            kh.SODT = txtSoDT.Text.Trim();
            kh.DIACHI = txtDiaChi.Text.Trim();

            stack.Push(new UndoData<KhachHang>(Constants.EDIT, Constants.NONE, viTri, kh));
            tuyBienNutLenh(btnSua);
            gcKH.Enabled = false;
        }

        private void btnGhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào tên khách hàng.");
                txtHoTen.Focus();
                return;
            }
            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào CMND.");
                txtHoTen.Focus();
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào địa chỉ.");
                txtHoTen.Focus();
                return;
            }
            if (datetime.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào ngày cấp CMND.");
                txtHoTen.Focus();
                return;
            }

            try
            {
                bdsKH.EndEdit();
                bdsKH.ResetCurrentItem();
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Update(this.nGANHANGDataSet1.KhachHang);

                int hanhDongTruoc = stack.Peek().getHanhDongTruoc();

                KhachHang kh = new KhachHang();
                kh.CMND = txtCMND.Text.Trim();
                kh.NGAYCAP = Convert.ToDateTime(datetime);
                kh.HOTEN = txtHoTen.Text.Trim();
                kh.PHAI = (string)cmbPhai.SelectedItem.ToString();
                kh.DIACHI = txtDiaChi.Text.Trim();
                kh.SODT = txtSoDT.Text.Trim();
                kh.MACN = maCN;

                if(stack.Count > 0)
                {
                    if(stack.Peek().getHanhDong() == Constants.EDIT)
                    {
                        kh = stack.Peek().getData();
                    }
                }
                stack.Push(new UndoData<KhachHang>(Constants.GHI, hanhDongTruoc, viTri, kh));
                tuyBienNutLenh(btnGhi);
            }
            catch (Exception ex)
            {
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);
                if (ex.Message.Contains("CMND"))
                {
                    MessageBox.Show("CMND bị trùng");
                }
                else
                {
                    MessageBox.Show("Lỗi ghi khách hàng" + ex.Message);
                }
            }
            
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            Int32 cmnd = 0;
            if (bdsTK.Count > 0)
            {
                MessageBox.Show("Không thể xóa Khách Hàng vì đã có tài khoản",
                    "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa Khách Hàng này?",
                "Xác nhận xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    cmnd = int.Parse(((DataRowView)bdsKH[0])["CMND"].ToString());
                    bdsKH.RemoveCurrent();
                    this.khachHangTableAdapter.Update(this.nGANHANGDataSet1.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa Khách Hàng : " + ex.Message);
                    return;
                }

            }
            tuyBienNutLenh(btnXoa);
        }

        private void btnLamMoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload " + ex.Message);
                return;
            }
            tuyBienNutLenh(btnLamMoi);
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Program.frmChinh.closeThisTab();
        }

        private void btnPhucHoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            UndoData<KhachHang> ud = stack.Peek();
            if(ud.getHanhDong() == Constants.ADD || ud.getHanhDong() == Constants.EDIT)
            {
                bdsKH.CancelEdit();
                bdsKH.Position = ud.getViTri();
                stack.Pop();
            }else
                if (ud.getHanhDong() == Constants.GHI)
                {
                    if(ud.getHanhDongTruoc() == Constants.ADD)
                    {
                        if (MessageBox.Show(this, 
                            "Bạn có muốn khôi phục dữ liệu cũ không?", 
                            "Message", 
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            String sql = "EXEC SP_XoaKhachHang '" + ud.getData().CMND + "'";
                            try
                            {
                                Program.ExecSqlNonQuery(sql, Program.connstr);
                                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);
                                stack.Pop();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không thể hồi phục ! " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(this,
                            "Bạn có muốn khôi phục dữ liệu cũ không?",
                            "Message",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //@HOTEN nvarchar(50),
                            //@DIACHI nvarchar(100),
                            //@CMND nchar(9),
                            //@NGAYCAP DATE,
                            //@SODT nchar(12),
                            //@PHAI nchar(3)
                            
                            String sql = "EXEC SP_UpdateKHACHHANG N'" 
                                + ud.getData().HOTEN 
                                + "',N'" + ud.getData().DIACHI 
                                + "',N'" + ud.getData().CMND 
                                + "',N'" + ud.getData().NGAYCAP 
                                + "',N'" + ud.getData().SODT
                                + "',N'" + ud.getData().PHAI + "'";
                            try
                            {
                                Program.ExecSqlNonQuery(sql, Program.connstr);
                                this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);
                                stack.Pop();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Không thể hồi phục ! " + ex.Message);
                            }
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show(this,
                            "Bạn có muốn khôi phục dữ liệu cũ không?",
                            "Message",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String sql = "EXEC SP_ThemKhachHang N'"
                                + ud.getData().HOTEN
                                + "',N'" + ud.getData().DIACHI
                                + "',N'" + ud.getData().CMND
                                + "',N'" + ud.getData().NGAYCAP
                                + "',N'" + ud.getData().SODT
                                + "',N'" + ud.getData().PHAI  
                                + "',N'" + maCN +"'";
                        try
                        {
                            Program.ExecSqlNonQuery(sql, Program.connstr);
                            this.khachHangTableAdapter.Fill(this.nGANHANGDataSet1.KhachHang);
                            stack.Pop();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Không thể hồi phục ! " + ex.Message);
                        }
                    }
                }
                
            tuyBienNutLenh(btnLamMoi);
        }
    }
}
