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

namespace LOGIN.NHANVIEN
{
    public partial class frmDSNV : DevExpress.XtraEditors.XtraForm
    {
        public frmDSNV()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;

        }

        private void frmDSNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //hàm này dùng để nhấn vô thì đẩy dữ liệu lên
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string manv = selectedRow.Cells["MANV"].Value.ToString();
            textMANV.Text = manv;
            textHO.Text = selectedRow.Cells["HO"].Value.ToString();
            textTen.Text = selectedRow.Cells["TEN"].Value.ToString();
            textDiaChi.Text = selectedRow.Cells["DIACHI"].Value.ToString();
            textCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
            textSDT.Text = selectedRow.Cells["SDT"].Value.ToString();
            textChucDanh.Text = selectedRow.Cells["CHUCDANH"].Value.ToString();

            if (string.IsNullOrWhiteSpace(selectedRow.Cells["MANV"].Value.ToString()))
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

        //nút thêm
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                //thêm trực tiếp vào database
                string query = "INSERT INTO NhanVien (MANV, HO, Ten, DiaChi, SDT, CMND, ChucDanh) " +
                "VALUES (@MANV, @HO, @Ten, @DiaChi, @SDT, @CMND, @ChucDanh)";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MANV", textMANV.Text);
                command.Parameters.AddWithValue("@HO", textHO.Text);
                command.Parameters.AddWithValue("@Ten", textTen.Text);
                command.Parameters.AddWithValue("@DiaChi", textDiaChi.Text);
                command.Parameters.AddWithValue("@SDT", textSDT.Text);
                command.Parameters.AddWithValue("@CMND", textCMND.Text);
                command.Parameters.AddWithValue("@ChucDanh", textChucDanh.Text);

                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);

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

                string query = "DELETE FROM NhanVien WHERE MANV = @MaNV";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MaNV", textMANV.Text);

                command.ExecuteNonQuery();


            

                //load lại dữ liệu
                this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);
                reload();

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //nút cập nhật
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                string query = "UPDATE NhanVien SET HO = @Ho, Ten = @Ten, DiaChi = @DiaChi, SDT = @SDT, CMND = @CMND, ChucDanh = @ChucDanh WHERE MANV = @MaNV";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@Ho", textHO.Text);
                command.Parameters.AddWithValue("@Ten", textTen.Text);
                command.Parameters.AddWithValue("@DiaChi", textDiaChi.Text);
                command.Parameters.AddWithValue("@SDT", textSDT.Text);
                command.Parameters.AddWithValue("@CMND", textCMND.Text);
                command.Parameters.AddWithValue("@ChucDanh", textChucDanh.Text);
                command.Parameters.AddWithValue("@MaNV", textMANV.Text);

                command.ExecuteNonQuery();

                //load lại dữ liệu
                this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //nút reload
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //load lại dữ liệu
            this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);
            reload();
        }

        //hàm reload
        public void reload()
        {


            // Đặt giá trị trắng cho các textbox
            textMANV.Text = string.Empty;
            textHO.Text = string.Empty;
            textTen.Text = string.Empty;
            textCMND.Text = string.Empty;
            textDiaChi.Text = string.Empty;
            textSDT.Text = string.Empty;

            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;

        }


    }
}