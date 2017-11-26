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

namespace NganHangPT.usercontrol
{
    public partial class UCGiaoDichChuyenTien : UserControl
    {
        private static AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private TaiKhoan taiKhoan;
        public UCGiaoDichChuyenTien()
        {
            InitializeComponent();
        }

        private void UCGiaoDichChuyenTien_Load(object sender, EventArgs e)
        {
            loadDanhTaiKhoan();
            txtSoTKGui.AutoCompleteCustomSource = auto;
            txtSoTKNhan.AutoCompleteCustomSource = auto;
            cbPhaiNhan.SelectedIndex = 0;
            cbPhaiGui.SelectedIndex = 0;
        }

        private void loadDanhTaiKhoan()
        {
            String sql = "Select * from V_TAIKHOAN";
            SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
            if (reader != null)
            {
                while (reader.Read())
                {
                    auto.Add(reader["SOTK"].ToString());
                }
            }
        }

        private void txtSoTKNhan_TextChanged(object sender, EventArgs e)
        {
            String soTK = txtSoTKNhan.Text.Trim();
            if (soTK.Length <= 9)
            {
                String sql = "EXEC SP_TIMTK_SS '" + soTK + "'";
                SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        String cmnd = reader["CMND"].ToString();
                        sql = "EXEC SP_TIMKH_SS '" + cmnd + "'";
                        reader = Program.ExecSqlDataReader(sql, Program.connstr);
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                txtHoTenNhan.Text = reader["HOTEN"].ToString();
                                txtCMNDNhan.Text = reader["CMND"].ToString();
                                txtSDTNhan.Text = reader["SODT"].ToString();
                                if (reader["PHAI"].ToString().Equals("Nam"))
                                {
                                    cbPhaiNhan.SelectedIndex = 0;
                                }
                                else
                                {
                                    cbPhaiNhan.SelectedIndex = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        txtHoTenNhan.Text = "";
                        txtCMNDNhan.Text = "";
                        txtSDTNhan.Text = "";
                        cbPhaiNhan.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                txtHoTenNhan.Text = "";
                txtCMNDNhan.Text = "";
                txtSDTNhan.Text = "";
                cbPhaiNhan.SelectedIndex = 0;
            }
        }

        private void txtSoTKGui_TextChanged(object sender, EventArgs e)
        {
            String soTK = txtSoTKGui.Text.Trim();
            if(soTK.Length <= 9)
            {
                String sql = "EXEC SP_TIMTK_SS '" + soTK + "'";
                SqlDataReader reader = Program.ExecSqlDataReader(sql, Program.connstr);
                if (reader != null)
                {
                    if (reader.Read())
                    {
                        String cmnd = reader["CMND"].ToString();
                        String soTKG = reader["SOTK"].ToString();
                        String soDu = reader["SODU"].ToString();
                        taiKhoan = new TaiKhoan();
                        taiKhoan.CMND = cmnd;
                        taiKhoan.SOTK = soTK;
                        taiKhoan.SODU = Decimal.Parse(soDu);

                        sql = "EXEC SP_TIMKH_SS '" + cmnd + "'";
                        reader = Program.ExecSqlDataReader(sql, Program.connstr);
                        if (reader != null)
                        {
                            if (reader.Read())
                            {
                                txtHoTenGui.Text = reader["HOTEN"].ToString();
                                txtCMNDGui.Text = reader["CMND"].ToString();
                                txtSDTGui.Text = reader["SODT"].ToString();
                                if (reader["PHAI"].ToString().Equals("Nam"))
                                {
                                    cbPhaiGui.SelectedIndex = 0;
                                }
                                else
                                {
                                    cbPhaiGui.SelectedIndex = 1;
                                }
                            }
                        }
                    }
                    else
                    {
                        txtHoTenGui.Text = "";
                        txtCMNDGui.Text = "";
                        txtSDTGui.Text = "";
                        cbPhaiGui.SelectedIndex = 0;
                    }
                }
            }
            else
            {
                txtHoTenGui.Text = "";
                txtCMNDGui.Text = "";
                txtSDTGui.Text = "";
                cbPhaiGui.SelectedIndex = 0;
            }
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            String soTKGui = txtSoTKGui.Text.Trim();
            String soTKNhan = txtSoTKNhan.Text.Trim();
            String cmndGui = txtCMNDGui.Text.Trim();
            String cmndNhan = txtCMNDNhan.Text.Trim();
            String soTien = txtSoTien.Text.Trim();
            if (soTKGui.Equals(""))
            {
                MessageBox.Show("Nhập vào số tài khoản gửi.");
                return;
            }
            if (soTKNhan.Equals(""))
            {
                MessageBox.Show("Nhập vào số tài khoản nhận.");
                return;
            }
            if (soTKNhan.Equals(soTKGui))
            {
                MessageBox.Show("Số tài khoản gửi trùng số tài khoản nhận.");
                return;
            }
            if (cmndGui.Equals(""))
            {
                MessageBox.Show("Số tài khoản gửi không đúng.");
                return;
            }

            if (cmndNhan.Equals(""))
            {
                MessageBox.Show("Số tài khoản nhận không đúng.");
                return;
            }

            if (soTien.Equals("0"))
            {
                MessageBox.Show("Vui lòng nhập vào số tiền");
                return;
            }
            if(taiKhoan.SODU < Decimal.Parse(soTien))
            {
                MessageBox.Show("Số dư tài khoản"+ taiKhoan.SODU +" không đủ để thực hiện giao dịch");
                return;
            }
            String sql = "EXEC SP_CHUYENTIEN N'" + soTKGui + "',N'" + soTKNhan + "'," + soTien + ",N'" + Program.username + "'";
            try
             {
                int ketQua = Program.ExecSqlNonQuery(sql, Program.connstr);
                if(ketQua == 1)
                {
                    MessageBox.Show("Chuyển tiền thành công!");
                    lamMoi();
                }
             }
             catch (Exception ex)
             {
                
                MessageBox.Show("Chuyển tiền thất bại!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
        private void lamMoi()
        {
            txtSoTKGui.Text = "";
            txtSoTKNhan.Text = "";
            txtSoTien.Text = "";
        }
    }
}
