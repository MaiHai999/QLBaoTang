using DevExpress.Xpo.DB.Helpers;
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
    public partial class frmLoaiRieng : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiRieng(String matpnt)
        {
            InitializeComponent();
            loadData(matpnt);
        }

        public frmLoaiRieng()
        {
            InitializeComponent();
        }

        private void frmLoaiRieng_Load(object sender, EventArgs e)
        {
        }

        private void loadData(String matpnt)
        {
            if (Program.KetNoi() == 0) return;
            string query = "SELECT NgaySoHuu, TinhTrang, ViTri, TriGia FROM LOAIRIENG WHERE MATPNT = @MATPNT";

            SqlCommand command = new SqlCommand(query, Program.conn);
            command.Parameters.AddWithValue("@MATPNT", matpnt);

            try
            {
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    DateTime ngaySoHuu = reader.GetDateTime(0);
                    string tinhTrang = reader.GetString(1);
                    string viTri = reader.GetString(2);
                    decimal triGia = reader.GetDecimal(3);

                    textEditNgaySoHuu.Text = ngaySoHuu.ToString("dd/MM/yyyy");
                    textEditTinhTrang.Text = tinhTrang;
                    textEditViTri.Text = viTri;
                    textEditTriGia.Text = triGia.ToString();
                    textEditMa.Text = matpnt;
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

        private void buttonADD_Click(object sender, EventArgs e)
        {

        }
    }
}