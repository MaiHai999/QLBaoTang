using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using LOGIN.VIEW_REPORT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN.QUANLYTHONGKE
{
    public partial class frmTpntOfTrienLam : DevExpress.XtraEditors.XtraForm
    {
        public frmTpntOfTrienLam()
        {
            InitializeComponent();
        }

        private void tRIENLAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tRIENLAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_BAOTANGDataSet);

        }

        private void frmTpntOfTrienLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TRIENLAM' table. You can move, or remove it, as needed.
            this.tRIENLAMTableAdapter.Fill(this.qL_BAOTANGDataSet.TRIENLAM);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ngbd =  txtNgayBd.Text;
            string ngkt = txtNgayKt.Text;
            XtraReport2 xtr = new XtraReport2(ngbd, ngkt);
         
            ReportPrintTool print = new ReportPrintTool(xtr);
            print.ShowPreviewDialog();
        }
    }
}