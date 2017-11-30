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

namespace NganHangPT.usercontrol
{
    public partial class UCTaoLogin : UserControl
    {
        public UCTaoLogin()
        {
            InitializeComponent();
            cmbQuyen.SelectedIndex = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông báo", MessageBoxButtons.OK);
                this.txtTenDangNhap.Focus();
                return;
            }

            if (txtTenDangNhap.Text.Trim().Contains(" "))
            {
                MessageBox.Show("Tên tài khoản không có khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                this.txtTenDangNhap.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập user.\nUser là mã nhân viên muốn tạo tài khoản.", "Thông báo", MessageBoxButtons.OK);
                this.txtMaNhanVien.Focus();
                return;
            }

            if (String.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập password.", "Thông báo", MessageBoxButtons.OK);
                this.txtMatKhau.Focus();
                return;
            }

            if (txtMatKhau.Text.Trim() != txtReMatKhau.Text.Trim())
            {
                MessageBox.Show("Xác thực mật khẩu không đúng.", "Thông báo", MessageBoxButtons.OK);
                this.txtReMatKhau.Focus();
                return;
            }

            string cmbValue = ((String)cmbQuyen.SelectedItem);
            string phanQuyen = "";
            if (cmbValue == "NGÂN HÀNG")
            {
                phanQuyen = "NGANHANG";
            }
            else if (cmbValue == "CHI NHÁNH")
            {
                phanQuyen = "CHINHANH";
            }


            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            String strLenh = "";
            strLenh = "dbo.sp_TaoLogin";
            Program.sqlcmd = Program.conn.CreateCommand();
            Program.sqlcmd.CommandType = CommandType.StoredProcedure;
            Program.sqlcmd.CommandText = strLenh;
            Program.sqlcmd.Parameters.Add("@LGNAME", SqlDbType.Text).Value = txtTenDangNhap.Text;
            Program.sqlcmd.Parameters.Add("@PASS", SqlDbType.Text).Value = txtMatKhau.Text;
            Program.sqlcmd.Parameters.Add("@USERNAME", SqlDbType.Text).Value = txtMaNhanVien.Text;
            Program.sqlcmd.Parameters.Add("@ROLE", SqlDbType.Text).Value = phanQuyen;
            Program.sqlcmd.Parameters.Add("@RET", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;


            try
            {
                Program.sqlcmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Có lỗi xảy ra : " + ex.Message);
            }
            Program.conn.Close();
            String Ret = Program.sqlcmd.Parameters["@RET"].Value.ToString();
            if (Ret.Equals("2"))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại", "Thất bại", MessageBoxButtons.OK);
                return;
            }
            if (Ret.Equals("1"))
            {
                MessageBox.Show("Mã nhân viên này đã tạo tài khoản", "Thất bại", MessageBoxButtons.OK);
                return;
            }
            if (Ret == "0") //Cho phép tạo tài khoản
            {
                MessageBox.Show("Tạo tài khoản thành công!", "", MessageBoxButtons.OK);
                Program.frmChinh.closeThisTab();
            }
        }
    }
}
