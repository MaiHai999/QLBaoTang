using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace LOGIN.VIEW_REPORT
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport2()
        {
           
        }
        public XtraReport2(string NGAYbd,string nGAYkt)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = NGAYbd;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nGAYkt;
            this.sqlDataSource1.Fill();
        }
    }
}
