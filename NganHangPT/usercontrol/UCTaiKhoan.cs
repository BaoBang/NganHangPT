using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevComponents.DotNetBar;
using NganHangPT.model;
using NganHangPT.ulti;
using NganHangPT.report;

namespace NganHangPT.usercontrol
{
    public partial class UCTaiKhoan : UserControl
    {
        private int viTri = 0;
        private Stack<UndoData<TaiKhoan>> stack = new Stack<UndoData<TaiKhoan>>();
        public UCTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            viTri = nhanVienBindingSource.Position;
            taiKhoanBindingSource.AddNew();
            stack.Push(new UndoData<TaiKhoan>(Constants.ADD, Constants.NONE, viTri, null));
            setDefaultInputValue();
            txtCMND.Focus();
            tuyBienNutLenh(btnThem);
            tuyBienInputForm(false);
        }
        private void setDefaultInputValue()
        {
            txtCMND.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            cbPhai.Text = "Nam";
            txtSoTK.Text = "";
            txtSoDu.Text = "0";
        }
        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {
            nGANHANGDataSet1.EnforceConstraints = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);

            cbChiNhanh.DataSource = Program.bds_dspm;
            cbChiNhanh.DisplayMember = "TENCN";
            cbChiNhanh.ValueMember = "TENSERVER";

            if (Program.mGroup.CompareTo("NGANHANG") != 0)
            {
                lbChiNhanh.Visible = false;
                cbChiNhanh.Visible = false;
            }
            else
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

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            UndoData<TaiKhoan> ud = stack.Peek();
            if (ud.getHanhDong() == Constants.ADD || ud.getHanhDong() == Constants.EDIT)
            {

                taiKhoanBindingSource.CancelEdit();
                taiKhoanTableAdapter.Fill(nGANHANGDataSet1.TaiKhoan);
                taiKhoanBindingSource.Position = ud.getViTri();
                stack.Pop();

            }
            else if (ud.getHanhDong() == Constants.GHI)
            {
                if (ud.getHanhDongTruoc() == Constants.ADD)
                {
                    if (MessageBox.Show(this, "Bạn có muốn khôi phục dữ liệu cũ không?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        String sql = "EXEC SP_XOATAIKHOAN '" + ud.getData().SOTK + "'";

                        try
                        {
                            Program.ExecSqlNonQuery(sql, Program.connstr);
                            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
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

                        String sql = "EXEC SP_SUATAIKHOAN N'" + ud.getData().SOTK + "', " + ud.getData().SODU;

                        try
                        {
                            Program.ExecSqlNonQuery(sql, Program.connstr);
                            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
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

                    String sql = "EXEC SP_THEMTAIKHOAN N'" + ud.getData().SOTK + "',N'" + ud.getData().CMND + "', " + ud.getData().SODU;

                    try
                    {
                        Program.ExecSqlNonQuery(sql, Program.connstr);
                        this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
                        stack.Pop();
                        MessageBox.Show("Them thanh cong");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể phục hồi" + ex.Message);
                    }

                }
            }
            tuyBienNutLenh(btnPhucHoi);
        }
        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            String cmnd = txtCMND.Text.Trim();
            if (cmnd.Length <= 9)
            {
                String sql = "EXEC SP_TIMKH_SS '" + cmnd + "'";
                SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        txtHoTen.Text = reader["HOTEN"].ToString();
                        txtSDT.Text = reader["SODT"].ToString();
                        if (reader["PHAI"].ToString().Equals("Nam"))
                        {
                            cbPhai.SelectedIndex = 0;
                        }
                        else
                        {
                            cbPhai.SelectedIndex = 1;
                        }
                        return;
                    }
                } 
            }
            txtHoTen.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            cbPhai.SelectedIndex = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            viTri = taiKhoanBindingSource.Position;
            TaiKhoan tk = new TaiKhoan();
            tk.CMND = txtCMND.Text.Trim();
            tk.SOTK = txtSoTK.Text.Trim();
            tk.SODU = Decimal.Parse(txtSoDu.Text.Trim());
            stack.Push(new UndoData<TaiKhoan>(Constants.EDIT, Constants.NONE, viTri, tk));
            tuyBienNutLenh(btnSua);
            tuyBienInputForm(false);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtCMND.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào chứng minh nhân dân của chủ tài khoản.");
                txtCMND.Focus();
                return;
            }
            if (txtSoTK.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào số tài khoản.");
                txtSoTK.Focus();
                return;
            }
            if (txtSoDu.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Vui lòng điền vào số dư.");
                txtSoDu.Focus();
                return;
            }
            if (txtSDT.Text.Trim().CompareTo("") == 0)
            {
                MessageBox.Show("Khách hàng không tồn tại");
                txtCMND.Focus();
                return;
            }

            TaiKhoan tk = new TaiKhoan();
            try
            {

                taiKhoanBindingSource.EndEdit();
                taiKhoanBindingSource.ResetCurrentItem();
                if (nGANHANGDataSet1.HasChanges())
                {
                    tk.CMND = txtCMND.Text.Trim();
                    tk.SOTK = txtSoTK.Text.Trim();
                    tk.SODU = Decimal.Parse(txtSoDu.Text.Trim());

                    this.taiKhoanTableAdapter.Update(nGANHANGDataSet1.TaiKhoan);
                    int hanhDongTruoc = stack.Peek().getHanhDong();

                    // column MACN == NULL => cập nhật lại
                    String sql = "EXEC SP_SUATAIKHOAN N'" + tk.SOTK + "'," + tk.SODU ;
                    try
                    {
                        Program.ExecSqlNonQuery(sql, Program.connstr);
                    }
                    catch (Exception ex)
                    {

                    }
                    if (stack.Count > 0)
                    {
                        if (stack.Peek().getHanhDong() == Constants.EDIT)
                        {
                            tk = stack.Peek().getData();
                        }
                    }
                    stack.Push(new UndoData<TaiKhoan>(Constants.GHI, hanhDongTruoc, viTri, tk));
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            tuyBienNutLenh(btnGhi);

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Decimal soDu = Decimal.Parse(txtSoDu.Text.ToString());
            if (soDu > 0)
            {
                MessageBox.Show(this, "Tài khoản còn " + soDu + " , không thể xóa.", "Message");
            }
            else
            {
                if (MessageBox.Show(this, "Bạn có muốn xóa tài khoản này?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    try
                    {

                        TaiKhoan tk = new TaiKhoan();
                        tk.CMND = txtCMND.Text.Trim();
                        tk.SOTK = txtSoTK.Text.Trim();
                        tk.SODU = Decimal.Parse(txtSoDu.Text.Trim());

                        taiKhoanBindingSource.RemoveCurrent();
                        this.taiKhoanTableAdapter.Update(this.nGANHANGDataSet1.TaiKhoan);
                        stack.Push(new UndoData<TaiKhoan>(Constants.DELETE, Constants.NONE, viTri, tk));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa tài khoản: " + ex.Message);
                        return;
                    }
                }
                tuyBienNutLenh(btnXoa);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        private void lamMoi()
        {
            taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.nGANHANGDataSet1.TaiKhoan);
            stack.Clear();
            tuyBienNutLenh(btnLamMoi);
        }
        private void tuyBienInputForm(Boolean b)
        {
                txtHoTen.Enabled = b;
                txtSDT.Enabled = b;
                cbPhai.Enabled = b;
            
        }

        private void tuyBienNutLenh(ButtonItem btn)
        {
            if (btn == btnThem)
            {
                pnInfo.Enabled = true;
                txtCMND.Enabled = true;
                btnGhi.Enabled = true;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnDanhSach.Enabled = false;
                tbTaiKhoan.Enabled = false;
            }

            if (btn == btnSua)
            {
                txtCMND.Enabled = false;
                txtSoTK.Enabled = false;

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnDanhSach.Enabled = false;
                tbTaiKhoan.Enabled = false;

                pnInfo.Enabled = true;
                btnGhi.Enabled = true;


            }

            if (btn == btnGhi)
            {
                btnGhi.Enabled = false;
                pnInfo.Enabled = false;

                btnDanhSach.Enabled = true;
                tbTaiKhoan.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtSoTK.Enabled = true;

            }

            if (btn == btnLamMoi)
            {
                btnGhi.Enabled = false;
                pnInfo.Enabled = false;

                tbTaiKhoan.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDanhSach.Enabled = true;
            }

            if (btn == btnPhucHoi)
            {
                tbTaiKhoan.Enabled = true;
                pnInfo.Enabled = false;
                
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnDanhSach.Enabled = true;
            }

            if (btn == btnXoa)
            {
                tbTaiKhoan.Enabled = true;
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
            UCTaiKhoanReport uc = new UCTaiKhoanReport();
            uc.Show();
        }
    }
}
