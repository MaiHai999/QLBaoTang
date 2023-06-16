using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class frmDN : DevExpress.XtraEditors.XtraForm
    {
        public frmDN()
        {
            InitializeComponent();
        }
        private SqlConnection conn_publisher = new SqlConnection();
        private int KETNOI_CSDL()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            { conn_publisher.Close(); }

            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Loi ket noi vao co so du lieu go .Xem lai publisher va ten database name 5555");
                return 0;
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (KETNOI_CSDL() == 0) return;

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("lõi user or pass");
                return;
            }
            Program.mlogin = txtUser.Text.ToString();
            Program.password = txtPass.Text.ToString();
            // admin03 12 ; nv01 12

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("ket noi ko thanh cong   " );
                return;
            }
             
            try
            {
                String cmd = "EXEC SP_DANGNHAP  '" + Program.mlogin + "'";
               
                Program.myReader = Program.ExecSqldataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read();
                MessageBox.Show("dang nhap  thanh cong", Program.myReader.GetString(0));

                //
                Program.ussername = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.ussername))
                {
                    MessageBox.Show("tai khoan cua ban ko co quyen truy cap !");
                    return;
                }
                Program.mHoTen = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                
                new frmMain().Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("dang nhap  that bai", ex.Message);
            }
             
           
        }
    }
}
