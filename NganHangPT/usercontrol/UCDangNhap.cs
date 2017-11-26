using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHangPT.usercontrol
{
    public partial class UCDangNhap : UserControl
    {
        private FormMain formMain = null;
        public UCDangNhap(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UCDangNhap_Load(object sender, EventArgs e)
        {
            this.v_DS_PHANMANHTableAdapter.Fill(this.nGANHANGDataSet.V_DS_PHANMANH);
            txtTenDangNhap.Text = "chinhanh1";
            txtMatKhau.Text = "123456";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Program.servername = (string)cbChiNhanh.SelectedValue;
            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtMatKhau.Text;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.mChinhanh = cbChiNhanh.SelectedIndex;
            int kq = Program.KetNoi();
            if (kq == 1)
            {
                Program.bds_dspm = this.vDSPHANMANHBindingSource;
                string cmd = "EXEC sp_DANGNHAP '" + Program.username + "'";
                System.Data.SqlClient.SqlDataReader dataReader = Program.ExecSqlDataReader(cmd, Program.connstr);
               if(dataReader != null)
                {
                    if (dataReader.Read())
                    {

                        Program.username = (string)dataReader["MANV"];
                        Program.mHoten = (string)dataReader["HOTEN"];
                        Program.mGroup = (string)dataReader["TENNHOM"];
                        formMain.loadInfoUser();
                        formMain.checkLogin(Program.username, Program.password);
                        formMain.getTabControl().Tabs.Remove(formMain.getTabControl().SelectedTab);

                    }
                }

            }

        }
    }
}
