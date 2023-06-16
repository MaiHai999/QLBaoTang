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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOGIN.TACGIA
{
    public partial class frmTacGia : DevExpress.XtraEditors.XtraForm
    {
        public frmTacGia()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);

        }

        //NÚT THÊM
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                //thêm trực tiếp vào database
                string query = "INSERT INTO TACGIA (MATACGIA, TEN, NGAYMAT, QUOCTICH, NGAYSINH ,PHONGCACHCHINH , DIENGIAI , THOIDAI) " +
                "VALUES (@MATG, @Ten, @NGAYMAT, @QUOCTICH, @NGAYSINH, @PHONGCACHCHINH , @DIENGIAI , @THOIDAI )";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MATG", textMaTacGia.Text);
                command.Parameters.AddWithValue("@Ten", textTen.Text);
                command.Parameters.AddWithValue("@NGAYMAT", textNgayMat.Text);
                command.Parameters.AddWithValue("@QUOCTICH", textQuocTich.Text);
                command.Parameters.AddWithValue("@NGAYSINH", textNgaySinh.Text);
                command.Parameters.AddWithValue("@PHONGCACHCHINH", textPhongCach.Text);
                command.Parameters.AddWithValue("@DIENGIAI", textDenDai.Text);
                command.Parameters.AddWithValue("@THOIDAI", textThoiDai.Text);

                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);


            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //nút xóa 
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                string query = "DELETE FROM TACGIA WHERE MATACGIA = @MaTG";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MaTG", textMaTacGia.Text);

                command.ExecuteNonQuery();




                //load lại dữ liệu
                this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);


            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //NÚT UPDATE
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                string query = "UPDATE TACGIA SET  TEN = @Ten, NGAYMAT = @NGAYMAT , QUOCTICH = @QUOCTICH, NGAYSINH = @NGAYSINH,PHONGCACHCHINH = @PHONGCACHCHINH, DIENGIAI = @DIENGIAI, THOIDAI = @THOIDAI WHERE MATACGIA = @MATG";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MATG", textMaTacGia.Text);
                command.Parameters.AddWithValue("@Ten", textTen.Text);
                command.Parameters.AddWithValue("@NGAYMAT", textNgayMat.Text);
                command.Parameters.AddWithValue("@QUOCTICH", textQuocTich.Text);
                command.Parameters.AddWithValue("@NGAYSINH", textNgaySinh.Text);
                command.Parameters.AddWithValue("@PHONGCACHCHINH", textPhongCach.Text);
                command.Parameters.AddWithValue("@DIENGIAI", textDenDai.Text);
                command.Parameters.AddWithValue("@THOIDAI", textThoiDai.Text);

                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //hàm reload
        public void reload()
        {
            // Đặt giá trị trắng cho các textbox
            textMaTacGia.Text = string.Empty;
            textTen.Text = string.Empty;
            textNgayMat.Text = string.Empty;
            textQuocTich.Text = string.Empty;
            textNgaySinh.Text = string.Empty;
            textPhongCach.Text = string.Empty;
            textDenDai.Text = string.Empty;
            textThoiDai.Text = string.Empty;

            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //load lại dữ liệu
            this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);

            reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            if (string.IsNullOrWhiteSpace(selectedRow.Cells["MATACGIA"].Value.ToString()))
            {
                barButtonItem2.Enabled = false;
                barButtonItem3.Enabled = false;
            }
            else
            {
                barButtonItem2.Enabled = true;
                barButtonItem3.Enabled = true;
            }
        }
    }
}