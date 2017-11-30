using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevComponents.DotNetBar;
using NganHangPT.usercontrol;
using NGANHANGPT.usercontrol;

namespace NganHangPT
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void ribbonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            closeThisTab();
        }
        public void closeThisTab()
        {
            tabControl.Tabs.Remove(tabControl.SelectedTab);
        }

        public void closeCurrentTab_Click(object sender, EventArgs e)
        {
            closeThisTab();
        }

        public void closeOthersTab()
        {
            for(int i = tabControl.Tabs.Count - 1 ; i >= 0; i--)
            {
                if(tabControl.SelectedTabIndex != i)
                {
                    tabControl.Tabs.RemoveAt(i);
                }
            }
            tabControl.Refresh();
        }
        private void closeAllTabs()
        {
            for (int i = tabControl.Tabs.Count - 1; i >= 0; i--)
            {
               
                    tabControl.Tabs.RemoveAt(i);
                
            }
            tabControl.Refresh();
        }
        private void closeOtherTab_Click(object sender, EventArgs e)
        {
            closeOthersTab();
        }
        private void closeAllTab_Click(object sender, EventArgs e)
        {
            closeAllTabs();
        }
        private void addtab(string tabname, UserControl control)
        {
            foreach (TabItem tabPage in tabControl.Tabs)
                if (tabPage.Text == tabname)
                {
                    tabControl.SelectedTab = tabPage;
                    return;
                }
            TabControlPanel newtabpannel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newtab = new TabItem();
            newtabpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            newtabpannel.Location = new System.Drawing.Point(0, 26);
            newtabpannel.Name = tabname;
            newtabpannel.Padding = new System.Windows.Forms.Padding(1);
            newtabpannel.Size = new System.Drawing.Size(1230, 384);
            newtabpannel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newtabpannel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newtabpannel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newtabpannel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newtabpannel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newtabpannel.Style.GradientAngle = 90;
            newtabpannel.TabIndex = 2;
            newtabpannel.TabItem = newtab;
            Random ran = new Random();
            newtab.Name = tabname + ran.Next(100000) + ran.Next(22342);

            newtab.AttachedControl = newtabpannel;
            newtab.Text = tabname;
            newtab.CloseButtonVisible = true;
            control.Dock = DockStyle.Fill;
            newtabpannel.Controls.Add(control);
            tabControl.Controls.Add(newtabpannel);
            tabControl.Tabs.Add(newtab);
            tabControl.SelectedTab = newtab;

        }
        public void loadInfoUser()
        {
            barStaticItemThongTinDangNhap.Caption = "Mã nhân viên: " + Program.username +
                "\t Họ và tên: " + Program.mHoten + "\t Nhóm quyền: " + Program.mGroup; 
                 

        }
        public void checkLogin(string username, string password)
        {
            if (username.CompareTo("") == 0 && password.CompareTo("") == 0)
            {

                ribbonPageGroupDangNhap.Visible = true;
                ribbonPageGroupDangXuat.Visible = false;
                ribbonBarTaoLogin.Visible = false;
                ribbonPageDanhMuc.Visible = false;
                ribbonPageBaoCao.Visible = false;
            }
            else
            {

                ribbonPageGroupDangNhap.Visible = false;
                ribbonPageGroupDangXuat.Visible = true;
                ribbonPageDanhMuc.Visible = true;
                ribbonPageBaoCao.Visible = true;
            }
            this.Refresh();
        }
        public DevComponents.DotNetBar.TabControl getTabControl()
        {
            return tabControl;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ribbonControl.SelectedPage = ribbonPageHeThong;
            checkLogin(Program.username, Program.password);
            addtab("Đăng nhập", new UCDangNhap(this));
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Đăng nhập", new UCDangNhap(this));
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.username = "";
            Program.password = "";
            Program.mlogin = "";
            Program.mHoten = "";
            Program.mGroup = "";
            closeAllTabs();
            checkLogin(Program.username, Program.password);
            loadInfoUser();
            addtab("Đăng nhập", new UCDangNhap(this));
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Nhân viên", new UCNhanVien());
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Khách hàng", new UCKhachHang());
        }

        private void btnTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Tài khoản", new UCTaiKhoan());
        }

        private void btnGiaoDichGuiRut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Giao dịch gửi/rút", new UCGuiRut());
        }

        private void btnGiaoDichChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            addtab("Giao dịch chuyển tiền", new UCGiaoDichChuyenTien());
        }

        private void btnTaoLogin_Click(object sender, EventArgs e)
        {
            addtab("Tạo Login", new UCTaoLogin());
        }
    }
}