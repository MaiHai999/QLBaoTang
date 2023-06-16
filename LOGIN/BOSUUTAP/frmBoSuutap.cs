using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Export.Pdf;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOGIN.BOSUUTAP
{
    public partial class frmBoSuutap : DevExpress.XtraEditors.XtraForm
    {
        public frmBoSuutap()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Program.KetNoi() == 0) return;

            try
            {

                //thêm trực tiếp vào database
                string query = "INSERT INTO BOSUUTAP (MASUUTAP,TENSUUTAP,HINHTHUCSUUTAP,MANHANVIEN) " +
                "VALUES (@MABST, @TENBST,@MAHT, @MANV)";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MABST", txtMaSuuTap.Text);
                command.Parameters.AddWithValue("@TENBST", txtTenSuuTap.Text);
                command.Parameters.AddWithValue("@MAHT", txtMaHinhThuc.Text);
                command.Parameters.AddWithValue("@MANV", txtMaNhanVien.SelectedValue.ToString());
                

                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bOSUUTAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.bOSUUTAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qL_BAOTANGDataSet);

        }

        private void frmBoSuutap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.BOSUUTAP' table. You can move, or remove it, as needed.
            this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;

            try
            {

                string query = "DELETE FROM BoSuuTap WHERE MASUUTAP = @MaBST";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MaBST", txtMaSuuTap.Text);

                command.ExecuteNonQuery();




                //load lại dữ liệu
                this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);
                reload();

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi thông tin bộ sưu tập " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                string query = "UPDATE BoSuuTap SET TENSUUTAP=@TenBoSuuTap, HINHTHUCSUUTAP=@MaHinhThuc" +
                    ", MANHANVIEN=@MaNhanVien WHERE MASUUTAP= @MaBoSuuTap";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MahinhThuc", txtMaSuuTap.Text);
                command.Parameters.AddWithValue("@TenBoSuuTap", txtTenSuuTap.Text);
                command.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                command.Parameters.AddWithValue("@MaBoSuuTap", txtMaSuuTap.Text);


                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            //load lại dữ liệu
            this.bOSUUTAPTableAdapter.Fill(this.qL_BAOTANGDataSet.BOSUUTAP);
            reload();
        }

        //hàm reload
        public void reload()
        {
            if (Program.KetNoi() == 0) return;

            btnXoa.Enabled = false;
            btnGhi.Enabled = false;
            // Đặt giá trị trắng cho các textbox
            txtMaSuuTap.Text = " ";
            txtTenSuuTap.Text = " ";
            txtMaHinhThuc.Text = " ";
            txtMaNhanVien.Text = " ";
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Program.KetNoi() == 0) return;

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            txtMaNhanVien.Text = selectedRow.Cells["MANV"].Value.ToString();

            if (string.IsNullOrWhiteSpace(selectedRow.Cells["MASUUTAP"].Value.ToString()))
            {
                btnXoa.Enabled = false;
                btnGhi.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = true;
                btnGhi.Enabled = true;
            }


        }
    }
}