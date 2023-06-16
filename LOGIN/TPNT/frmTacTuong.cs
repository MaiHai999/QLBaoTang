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
    public partial class frmTacTuong : DevExpress.XtraEditors.XtraForm
    {
        public frmTacTuong()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textBoxMoTa.Select();
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem4.Enabled = false;
        }

        private void frmTacTuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.TACGIA' table. You can move, or remove it, as needed.
            this.tACGIATableAdapter.Fill(this.qL_BAOTANGDataSet.TACGIA);
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.VIEW_TACTUONG1' table. You can move, or remove it, as needed.
            this.vIEW_TACTUONG1TableAdapter.Fill(this.qL_BAOTANGDataSet.VIEW_TACTUONG1);

        }

        //NHẤN VÔ THÌ NÓ SẼ ĐẨY DỮ LIỆU LÊN
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            textBoxMoTa.Text = selectedRow.Cells["MOTA"].Value.ToString();
            textTacGia.Text = selectedRow.Cells["TACGIA"].Value.ToString();

            if (string.IsNullOrWhiteSpace(selectedRow.Cells["MATPNT"].Value.ToString()))
            {
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = false;
                barButtonItem3.Enabled = false;
                barButtonItem4.Enabled = false;
            }
            else
            {
                barButtonItem1.Enabled = true;
                barButtonItem2.Enabled = true;
                barButtonItem3.Enabled = true;
                barButtonItem4.Enabled = true;
            }
        }

        //khai báo các biến toàn cục
        private frmLoaiRieng loaiRieng;
        private frmMenu menu;
        private frmLoaiMuon loaiMuon;

        //NÚT ADD
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMenu frm = new frmMenu();
            menu = frm;
            frm.buttonLoaiRieng.Click += new EventHandler(addLoaiRieng);
            frm.buttonLoaiMuon.Click += new EventHandler(addLoaiMuon);
            frm.ShowDialog();
        }

        //NÚT READ MORE
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

            if (Program.KetNoi() == 0) return;
            // Tạo command để gọi stored procedure
            using (SqlCommand command = new SqlCommand("SP_CHECKLOAITS", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào
                command.Parameters.AddWithValue("@MATPNT", MATPNT);

                // Thêm tham số đầu ra
                SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit);
                existsParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(existsParam);

                // Thực thi stored procedure
                command.ExecuteNonQuery();

                // Lấy kết quả từ tham số đầu ra
                bool result = (bool)command.Parameters["@Exists"].Value;

                if (result == true)
                {
                    frmLoaiRieng frm = new frmLoaiRieng(MATPNT);
                    frm.buttonADD.Visible = false;
                    frm.buttonUPDATE.Visible = false;
                    frm.ShowDialog();
                }
                else
                {
                    frmLoaiMuon frm1 = new frmLoaiMuon(MATPNT);
                    frm1.buttonADD.Visible = false;
                    frm1.buttonUPDATE.Visible = false;
                    frm1.ShowDialog();
                }



            }
        }

        //hàm để lưu xuống
        public void addLoaiRieng(object sender, EventArgs e)
        {
            frmLoaiRieng frm = new frmLoaiRieng();
            frm.textEditMa.Text = textMATPNT.Text;
            loaiRieng = frm;
            frm.buttonADD.Click += new EventHandler(saveLoaiRieng);
            frm.buttonADD.Visible = true;
            frm.buttonUPDATE.Visible = false;
            frm.ShowDialog();

        }

        //hàm để lưu xuống
        public void addLoaiMuon(object sender, EventArgs e)
        {
            frmLoaiMuon frm = new frmLoaiMuon();
            loaiMuon = frm;
            frm.textEditMaTPNT.Text = textMATPNT.Text;
            frm.buttonADD.Click += new EventHandler(saveLoaiMuon);
            frm.buttonADD.Visible = true;
            frm.buttonUPDATE.Visible = false;
            frm.ShowDialog();
        }

        //hàm để lưu loại riêng
        public void saveLoaiRieng(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                // Tạo command để gọi stored procedure
                using (SqlCommand command = new SqlCommand("SP_GHITACTUONG_LOAIRIENG", Program.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.AddWithValue("@MATPNT", textMATPNT.Text);
                    command.Parameters.AddWithValue("@TENTPNT", textTENTPNT.Text);
                    command.Parameters.AddWithValue("@MATACGIA", textTacGia.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MOTA", textBoxMoTa.Text);

                    command.Parameters.AddWithValue("@CHIEUCAO", textChieuCao.Value);
                    command.Parameters.AddWithValue("@KHOILUONG", textKhoiLuong.Value);
                    command.Parameters.AddWithValue("@PHONGCACH", textPhongCach.Text);
                    command.Parameters.AddWithValue("@VATLIEU", textVatLieu.Text);
                    

                    command.Parameters.AddWithValue("@NGAYSOHUU", loaiRieng.textEditNgaySoHuu.DateTime);
                    command.Parameters.AddWithValue("@TINHTRANG", loaiRieng.textEditTinhTrang.Text);
                    command.Parameters.AddWithValue("@VITRI", loaiRieng.textEditViTri.Text);

                    // Chuyển đổi giá trị sang kiểu money
                    if (decimal.TryParse(loaiRieng.textEditTriGia.Text, out decimal triGia))
                    {
                        command.Parameters.AddWithValue("@TRIGIA", triGia);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị không hợp lệ!");
                        return;
                    }

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    loaiRieng.Close();
                    menu.Close();


                }
                Reload();
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //hàm lưu loại mượn
        public void saveLoaiMuon(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                // Tạo command để gọi stored procedure
                using (SqlCommand command = new SqlCommand("SP_GHITACTUONG_LOAIMUON", Program.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.AddWithValue("@MATPNT", textMATPNT.Text);
                    command.Parameters.AddWithValue("@TENTPNT", textTENTPNT.Text);
                    command.Parameters.AddWithValue("@MATACGIA", textTacGia.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MOTA", textBoxMoTa.Text);

                    command.Parameters.AddWithValue("@CHIEUCAO", textChieuCao.Value);
                    command.Parameters.AddWithValue("@KHOILUONG", textKhoiLuong.Value);
                    command.Parameters.AddWithValue("@PHONGCACH", textPhongCach.Text);
                    command.Parameters.AddWithValue("@VATLIEU", textVatLieu.Text);

                    command.Parameters.AddWithValue("@MABOSUUTAP", loaiMuon.textEditBST.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NGAYMUON", loaiMuon.textEditNgayMuon.DateTime);
                    command.Parameters.AddWithValue("@NGAYTRA", loaiMuon.textEditNgayTra.DateTime);

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    loaiMuon.Close();
                    menu.Close();


                }
                Reload();
                MessageBox.Show("Thêm dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //reload
        private void Reload()
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.VIEW_TACTUONG1' table. You can move, or remove it, as needed.
            this.vIEW_TACTUONG1TableAdapter.Fill(this.qL_BAOTANGDataSet.VIEW_TACTUONG1);


            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;
            barButtonItem3.Enabled = false;
            barButtonItem4.Enabled = false;

        }

        //NÚT XÓA
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

                string query = "DELETE FROM TPNT WHERE MATPNT = @MATPNT";
                SqlCommand command = new SqlCommand(query, Program.conn);
                command.Parameters.AddWithValue("@MATPNT", MATPNT);

                command.ExecuteNonQuery();

                // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.VIEW_TACTUONG1' table. You can move, or remove it, as needed.
                this.vIEW_TACTUONG1TableAdapter.Fill(this.qL_BAOTANGDataSet.VIEW_TACTUONG1);


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
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            String MATPNT = selectedRow.Cells["MATPNT"].Value.ToString();

            if (Program.KetNoi() == 0) return;
            // Tạo command để gọi stored procedure
            using (SqlCommand command = new SqlCommand("SP_CHECKLOAITS", Program.conn))
            {
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào
                command.Parameters.AddWithValue("@MATPNT", MATPNT);

                // Thêm tham số đầu ra
                SqlParameter existsParam = new SqlParameter("@Exists", SqlDbType.Bit);
                existsParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(existsParam);

                // Thực thi stored procedure
                command.ExecuteNonQuery();

                // Lấy kết quả từ tham số đầu ra
                bool result = (bool)command.Parameters["@Exists"].Value;

                if (result == true)
                {
                    frmLoaiRieng frm = new frmLoaiRieng(MATPNT);
                    loaiRieng = frm;
                    frm.buttonADD.Visible = false;
                    frm.buttonUPDATE.Visible = true;
                    frm.buttonUPDATE.Click += new EventHandler(updateLoaiRieng);
                    frm.ShowDialog();
                }
                else
                {
                    frmLoaiMuon frm1 = new frmLoaiMuon(MATPNT);
                    loaiMuon = frm1;
                    frm1.buttonADD.Visible = false;
                    frm1.buttonUPDATE.Visible = true;
                    frm1.buttonUPDATE.Click += new EventHandler(updateLoaiMuon);
                    frm1.ShowDialog();
                }



            }
        }

        //hàm để update loại riêng
        public void updateLoaiRieng(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                // Tạo command để gọi stored procedure
                using (SqlCommand command = new SqlCommand("[SP_UPDATETACTUONG_LOAIRIENG]", Program.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.AddWithValue("@MATPNT", textMATPNT.Text);
                    command.Parameters.AddWithValue("@TENTPNT", textTENTPNT.Text);
                    command.Parameters.AddWithValue("@MATACGIA", textTacGia.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MOTA", textBoxMoTa.Text);

                    command.Parameters.AddWithValue("@CHIEUCAO", textChieuCao.Value);
                    command.Parameters.AddWithValue("@KHOILUONG", textKhoiLuong.Value);
                    command.Parameters.AddWithValue("@PHONGCACH", textPhongCach.Text);
                    command.Parameters.AddWithValue("@VATLIEU", textVatLieu.Text);


                    command.Parameters.AddWithValue("@NGAYSOHUU", loaiRieng.textEditNgaySoHuu.DateTime);
                    command.Parameters.AddWithValue("@TINHTRANG", loaiRieng.textEditTinhTrang.Text);
                    command.Parameters.AddWithValue("@VITRI", loaiRieng.textEditViTri.Text);

                    // Chuyển đổi giá trị sang kiểu money
                    if (decimal.TryParse(loaiRieng.textEditTriGia.Text, out decimal triGia))
                    {
                        command.Parameters.AddWithValue("@TRIGIA", triGia);
                    }
                    else
                    {
                        MessageBox.Show("Giá trị không hợp lệ!");
                        return;
                    }

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    loaiRieng.Close();


                }

                Reload();

                MessageBox.Show("Update dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //hàm update loại mượn
        public void updateLoaiMuon(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
                // Tạo command để gọi stored procedure
                using (SqlCommand command = new SqlCommand("SP_UPDATETACTUONG_LOAIMUON", Program.conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số đầu vào
                    command.Parameters.AddWithValue("@MATPNT", textMATPNT.Text);
                    command.Parameters.AddWithValue("@TENTPNT", textTENTPNT.Text);
                    command.Parameters.AddWithValue("@MATACGIA", textTacGia.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@MOTA", textBoxMoTa.Text);

                    command.Parameters.AddWithValue("@CHIEUCAO", textChieuCao.Value);
                    command.Parameters.AddWithValue("@KHOILUONG", textKhoiLuong.Value);
                    command.Parameters.AddWithValue("@PHONGCACH", textPhongCach.Text);
                    command.Parameters.AddWithValue("@VATLIEU", textVatLieu.Text);

                    command.Parameters.AddWithValue("@MABOSUUTAP", loaiMuon.textEditBST.SelectedValue.ToString());
                    command.Parameters.AddWithValue("@NGAYMUON", loaiMuon.textEditNgayMuon.DateTime);
                    command.Parameters.AddWithValue("@NGAYTRA", loaiMuon.textEditNgayTra.DateTime);

                    // Thực thi stored procedure
                    command.ExecuteNonQuery();

                    loaiMuon.Close();



                }

                Reload();

                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}