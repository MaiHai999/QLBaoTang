using DevExpress.XtraBars;
using LOGIN.BOSUUTAP;
using LOGIN.NHANVIEN;
using LOGIN.QUANLYCAIDAT;
using LOGIN.QUANLYTHONGKE;
using LOGIN.TACGIA;
using LOGIN.TINHCHATKHAC;
using LOGIN.TPNT;
using LOGIN.TRIENLAM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            txtUser.Text = "MÃ NHÂN VIÊN :"+Program.ussername;
            txtHoTen.Text ="HỌ TÊN NHÂN VIÊN :"+ Program.mHoTen;
            txtGroup.Text ="CHỨC DANH :"+ Program.mGroup;
            if (Program.mGroup.Trim() == "EMPLOYEE")
            {
                barButtonItem6.Enabled = false;
                ribbonPage2.Visible = false;
                barButtonItem11.Enabled = false;
                barButtonItem18.Enabled = false;
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmHoiHoa));
            if (frm != null) frm.Activate();
            else
            {
                frmHoiHoa f = new frmHoiHoa();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTacTuong));
            if (frm != null) frm.Activate();
            else
            {
                frmTacTuong f = new frmTacTuong();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLoaiKhac));
            if (frm != null) frm.Activate();
            else
            {
                frmLoaiKhac f = new frmLoaiKhac();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTrienLam));
            if (frm != null) frm.Activate();
            else
            {
                frmTrienLam f = new frmTrienLam();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Console.WriteLine("                   ưefwefwefwefwefedfrÍANDIJFN");
            Form frm = this.CheckExists(typeof(frmTPNT));
            Console.WriteLine("                   ưefwefwefwefwefedfrÍANDIJFN");
            if (frm != null) frm.Activate();
            else
            {
                frmTPNT f = new frmTPNT();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBoSuutap));
            if (frm != null) frm.Activate();
            else
            {
                frmBoSuutap f = new frmBoSuutap();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDSNV ));
            if (frm != null) frm.Activate();
            else
            {
                frmDSNV f = new frmDSNV();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTacGia ));
            if (frm != null) frm.Activate();
            else
            {
                frmTacGia f = new frmTacGia();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmChatLieuKhac));
            if (frm != null) frm.Activate();
            else
            {
                frmChatLieuKhac f = new frmChatLieuKhac();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSoLuongTPNT));
            if (frm != null) frm.Activate();
            else
            {
                frmSoLuongTPNT f = new frmSoLuongTPNT();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmtaoTtaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmtaoTtaiKhoan f = new frmtaoTtaiKhoan();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
             
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTacTuong));
            if (frm != null) frm.Activate();
            else
            {
                frmTacTuong f = new frmTacTuong();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmSaoLuu));
            if (frm != null) frm.Activate();
            else
            {
                frmSaoLuu f = new frmSaoLuu();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTpntOfTrienLam));
            if (frm != null) frm.Activate();
            else
            {
                frmTpntOfTrienLam f = new frmTpntOfTrienLam();
                f.MdiParent = this;
                f.Dock = DockStyle.Fill;
                f.Show();
            }
        }
    }
}