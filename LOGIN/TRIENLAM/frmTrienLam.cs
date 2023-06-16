using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOGIN.TRIENLAM
{
    public partial class frmTrienLam : DevExpress.XtraEditors.XtraForm
    {
        public frmTrienLam()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = false;


        }

        private void frmTrienLam_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.VIEW_GETTPNT' table. You can move, or remove it, as needed.
            this.vIEW_GETTPNTTableAdapter.Fill(this.qL_BAOTANGDataSet.VIEW_GETTPNT);
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.qL_BAOTANGDataSet.TPNT);
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TRIENLAM' table. You can move, or remove it, as needed.
            this.tRIENLAMTableAdapter.Fill(this.qL_BAOTANGDataSet.TRIENLAM);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //NHẤN VÔ BẢNG NÓ SẼ HIỆN THỊ DỮ LIỆU
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy mã triển lãm
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string maTL = selectedRow.Cells["MATRIENLAM"].Value.ToString();

            if (Program.KetNoi() == 0) return;
            //lấy mã triển lãm bảng 2
            using (SqlCommand command = new SqlCommand("GetTPNTByMaTrienLam", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Truyền các tham số nếu có
                command.Parameters.AddWithValue("@MaTrienLam", maTL);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gắn DataTable vào DataGridView
                    dataGridView2.DataSource = dataTable;

                 
                }


            }

            //đẩy các thông tin vào field
            textTenTL.Text = selectedRow.Cells["TENTRIENLAM"].Value.ToString();
            textMATL.Text = selectedRow.Cells["MATRIENLAM"].Value.ToString();

            string ngayBD = selectedRow.Cells["NGAYBD"].Value.ToString();
            DateTime date;
            if (DateTime.TryParse(ngayBD, out date))
            {
                dateEditNgayBD.Text = date.ToString("dd/MM/yyyy");
            }

            string ngayKT = selectedRow.Cells["NGAYKT"].Value.ToString();
            if (DateTime.TryParse(ngayKT, out date))
            {
                dateEditNgayKT.Text = date.ToString("dd/MM/yyyy");
            }

            



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //NÚT UPDATE
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                if (string.IsNullOrWhiteSpace(textMATL.Text) || string.IsNullOrWhiteSpace(textTenTL.Text) || string.IsNullOrWhiteSpace(dateEditNgayBD.Text) || string.IsNullOrWhiteSpace(dateEditNgayKT.Text))
                {
                    MessageBox.Show("Không được để trống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    string query = "UPDATE TRIENLAM SET TENTRIENLAM = @TENTL, NGAYBD = @NgayBD, NGAYKT = @NgayKT WHERE MATRIENLAM = @MATL";
                    SqlCommand command = new SqlCommand(query, Program.conn);
                    command.Parameters.AddWithValue("@TENTL", textTenTL.Text);
                    command.Parameters.AddWithValue("@NgayBD", dateEditNgayBD.DateTime);
                    command.Parameters.AddWithValue("@NgayKT", dateEditNgayKT.DateTime);
                    command.Parameters.AddWithValue("@MATL", textMATL.Text);


                    command.ExecuteNonQuery();

                    //load lại dữ liệu
                    reload();
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        //NÚT XÓA
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                string query = "DELETE FROM TRIENLAM WHERE MATRIENLAM = @MaTL";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MaTL", textMATL.Text);

                command.ExecuteNonQuery();

                //load lại dữ liệu
                reload();

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //nút reload
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload();
        }

        //hàm reload
        public void reload()
        {

            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = false;

            // Đặt giá trị trắng cho các textbox
            textMATL.Text = string.Empty;
            textTenTL.Text = string.Empty;

            // Đặt giá trị trắng cho các dateEdit
            dateEditNgayBD.EditValue = null;
            dateEditNgayKT.EditValue = null;

            //load lại dữ liệu
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TPNT' table. You can move, or remove it, as needed.
            this.tPNTTableAdapter.Fill(this.qL_BAOTANGDataSet.TPNT);
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TRIENLAM' table. You can move, or remove it, as needed.
            this.tRIENLAMTableAdapter.Fill(this.qL_BAOTANGDataSet.TRIENLAM);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //lấy mã triển lãm
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string maTL = selectedRow.Cells["MATRIENLAM"].Value.ToString();

            if (Program.KetNoi() == 0) return;
            //lấy mã triển lãm bảng 2
            using (SqlCommand command = new SqlCommand("SP_GETTPNTBYMATRIENLAM", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                // Truyền các tham số nếu có
                command.Parameters.AddWithValue("@MaTrienLam", maTL);

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Gắn DataTable vào DataGridView
                    dataGridView2.DataSource = dataTable;


                }


            }

            //đẩy các thông tin vào field
            textTenTL.Text = selectedRow.Cells["TENTRIENLAM"].Value.ToString();
            textMATL.Text = selectedRow.Cells["MATRIENLAM"].Value.ToString();

            string ngayBD = selectedRow.Cells["NGAYBD"].Value.ToString();
            DateTime date;
            if (DateTime.TryParse(ngayBD, out date))
            {
                dateEditNgayBD.Text = date.ToString("dd/MM/yyyy");
            }

            string ngayKT = selectedRow.Cells["NGAYKT"].Value.ToString();
            if (DateTime.TryParse(ngayKT, out date))
            {
                dateEditNgayKT.Text = date.ToString("dd/MM/yyyy");
            }

            if (string.IsNullOrWhiteSpace(selectedRow.Cells["MATRIENLAM"].Value.ToString()))
            {
                barButtonItem1.Enabled = false;
                barButtonItem2.Enabled = false;
            }
            else
            {
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = true;
            }

        }
    }
}