using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN.TPNT
{
    public partial class frmLoaiMuon : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiMuon(String matpnt)
        {
            InitializeComponent();
            loadData(matpnt);
            textEditMaTPNT.Select();

        }

        public frmLoaiMuon()
        {
            InitializeComponent();

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void loadData(String matpnt)
        {
            if (Program.KetNoi() == 0) return;
            string query = "SELECT * FROM LOAIMUON WHERE MATPNT = @MATPNT";

            SqlCommand command = new SqlCommand(query, Program.conn);
            command.Parameters.AddWithValue("@MATPNT", matpnt);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime ngayMuon = reader.GetDateTime(2);
                    string mabst = reader.GetString(1);
                    DateTime ngayTra = reader.GetDateTime(3);


                    textEditNgayMuon.Text = ngayMuon.ToString("dd/MM/yyyy");
                    textEditNgayTra.Text = ngayTra.ToString("dd/MM/yyyy"); 
                   
                    textEditBST.Text = mabst;
                    textEditMaTPNT.Text = matpnt;
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho MATPNT: " + matpnt, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmLoaiMuon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.BOSUUTAP' table. You can move, or remove it, as needed.
            this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);

        }

        private void textEditNgayTra_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonADD_Click(object sender, EventArgs e)
        {

        }

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {

        }
    }
}