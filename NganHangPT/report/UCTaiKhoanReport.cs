using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHangPT.report
{
    public partial class UCTaiKhoanReport : Form
    {
        public UCTaiKhoanReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            CRTaiKhoan obj = new CRTaiKhoan();

            string strLenh = "EXEC SP_THONGKETAIKHOAN '2017-1-1', '2017-12-1'";
            DataTable MyTable = Program.ExecSqlQuery(strLenh, Program.connstr);

            obj.SetDataSource(MyTable);
            obj.SetParameterValue("DATE1","1/1/2017");
            obj.SetParameterValue("DATE2", "1/12/2017");
            crystalReportViewer1.ReportSource = obj;

        }
    }
}
