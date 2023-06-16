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
using DevExpress.XtraReports.UI;
namespace LOGIN.QUANLYTHONGKE
{
    public partial class frmSoLuongTPNT : DevExpress.XtraEditors.XtraForm
    { string name="";
       
        public frmSoLuongTPNT()
        {
            InitializeComponent();
        }

        private void tACGIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsTacGia.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_BAOTANGDataSet);

        }

        private void frmSoLuongTPNT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              string matg = cbMatg.Text;
           
            XtraReport1 xtr = new XtraReport1(matg);
            xtr.txtTentg.Text = name;
            ReportPrintTool print = new ReportPrintTool(xtr);
            print.ShowPreviewDialog();
        }

        

        private void cbMatg_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cbMatg.SelectedIndex != -1)
            {
                string tenmh = cbMatg.Text;
                DataView dvMonHoc = (bdsTacGia.DataSource as DataSet).Tables["TACGIA"].DefaultView;
                dvMonHoc.RowFilter = $"MATACGIA = '{tenmh}'";
                if (dvMonHoc.Count > 0)
                {
                    name = dvMonHoc[0]["TEN"].ToString();

                }

            }
        }
    }
}