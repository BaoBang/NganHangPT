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
using NganHangPT.model;
using NganHangPT;

namespace NGANHANGPT.usercontrol
{
    public partial class UCGuiRut : UserControl
    {
        int soLuongGD;
        TaiKhoan tk = new TaiKhoan();
        private static AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        public UCGuiRut()
        {
            InitializeComponent();
        }

        private void UCGuiRut_Load(object sender, EventArgs e)
        {
            cmbLoaiGiaoDich.SelectedIndex = 0;
            LoadDanhSachTK();
            txtSoTK.AutoCompleteCustomSource = auto;
            soLuongGD = capNhapSoLuongGiaoDich();
        }

        private int capNhapSoLuongGiaoDich()
        {
            int soLuong = 0;

            try
            {
                String sql = "EXEC SP_LaySoGiaoDichGuiRut";
                SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        soLuong = Convert.ToInt32(reader["TONGGD"].ToString());
                    }
                    
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại sau!" + ex.Message, "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return soLuong + 1;
        }

        private void LoadDanhSachTK()
        {
            String sql = "select * from V_DS_TAIKHOAN";
 
            SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto.Add(reader["SOTK"].ToString());
                }
            }
            reader.Close();
        }

        private void txtSoTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void leave(object sender, EventArgs e)
        {
            //MessageBox.Show("", "ádasas", MessageBoxButtons.OK);
        }

        private void txtSoTK_TextChanged(object sender, EventArgs e)
        {

            String soTK = txtSoTK.Text.Trim();
            if(soTK.Length <= 9)
            {
                String sql = "EXEC SP_TIMTK_SS '" + soTK + "'";
                SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        String cmnd = reader["CMND"].ToString();
                        String soDu = reader["SODU"].ToString();
                        tk.CMND = cmnd;
                        tk.SOTK = soTK;
                        tk.SODU = Convert.ToDecimal(soDu);
                        sql = "EXEC SP_TIMKH_SS '" + cmnd + "'";
                        reader = Program.ExecSqlDataReader(sql, Program.connstr);
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                txtTenTK.Text = reader["HOTEN"].ToString();
                                txtCMND.Text = reader["CMND"].ToString();
                            }
                        }
                    }
                    else
                    {
                        txtTenTK.Text = "";
                        txtCMND.Text = "";
                    }
                }
                reader.Close();
            }
            else
            {
                txtTenTK.Text = "";
                txtCMND.Text = "";
            }
        }

        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            if(txtSoTK.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào số tài khoản.");
                txtSoTK.Focus();
                return;
            }
            if(txtCMND.Text.Trim() == ""  || txtTenTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không tồn tại");
                txtSoTK.Focus();
                return;
            }
            if(txtSoTien.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền vào số tiền.");
                txtSoTien.Focus();
                return;
            }
            else
            {
                int soTien;
                Int32.TryParse(txtSoTien.Text.Trim(), out soTien);
                if(soTien < 100000)
                {
                    MessageBox.Show("Số tiền không hợp lệ");
                    txtSoTien.Focus();
                    return;
                }else
                {
                    if(soTien > tk.SODU)
                    {
                        MessageBox.Show("Số tiền trong tài khoản không đủ");
                        txtSoTien.Focus();
                    }else
                    {
                        string loaigd = cmbLoaiGiaoDich.SelectedItem.ToString();
                        if (loaigd == "Rút Tiền") loaigd = "RT";
                        else loaigd = "GT";
                        try
                        {
                            String sql = "declare @kt int " + " EXEC @kt = SP_GUIRUT N'" + soLuongGD + "', N'"
                                    + txtSoTK.Text.ToString().Trim()
                                    + "', N'" + txtSoTien.Text.ToString().Trim() + "', N'"
                                    + loaigd + "', N'" + Program.username + "'";
                            sql += "  select @kt as res";
                            MessageBox.Show(sql);
                            SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    int res = Convert.ToInt32((reader["res"].ToString()));
                                    switch (res)
                                    {
                                        case 1:
                                            MessageBox.Show("Giao dịch thành công");
                                            txtSoTK.Text = "";
                                            txtSoTien.Text = "100000";
                                            break;
                                    }
                                }
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Đã có lỗi xảy ra! Vui lòng thử lại sau!" + ex.Message, "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            
        }
    }
}
