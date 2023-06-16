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

namespace LOGIN.TRIENLAM
{
    public partial class frmTPNT : DevExpress.XtraEditors.XtraForm
    {
        public frmTPNT()
        {
            InitializeComponent();
            //thay đổi chế độ chọn dòng
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //bất hoạt cho cả 2 nút thêm và xóa
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = false;
        }

        private void frmTPNT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet1.VIEW_GETTPNT' table. You can move, or remove it, as needed.
            this.vIEW_GETTPNTTableAdapter.Fill(this.qL_BAOTANGDataSet1.VIEW_GETTPNT);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //khi nhấn vào bảng thứ nhất nó sẽ bất hoạt một số nút
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;

        }

        //nút thêm tác phẩm nghệ thuật
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            // Tạo một bảng tạm thời để lưu trữ kết quả từ stored procedure
            DataTable tempTable = new DataTable();

            // Lấy hàng đã chọn trong DataGridView 1
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Lấy dữ liệu từ các ô trong hàng đã chọn
            string column1Value = selectedRow.Cells["MATPNT"].Value.ToString();

            //tạo một table để lưu các data đã có
            DataTable existingData = (DataTable)dataGridView2.DataSource;

            //tạo một table để tạo mới table
            DataTable newData = new DataTable();

            //kết nối và gọi sp
            SqlCommand command = new SqlCommand("SP_GETTPNT", Program.conn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm tham số và gán giá trị từ column1Value
            command.Parameters.AddWithValue("@MATPNT", column1Value);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(newData);


            // Kết hợp dữ liệu hiện có và dữ liệu mới
            DataTable combinedData = new DataTable();

            if(existingData == null)
            {
                combinedData.Merge(newData);
            }
            else
            {
                // Kiểm tra sự tồn tại của mã TPNT
                DataRow[] rows = existingData.Select("MATPNT = '" + column1Value + "'");

                if (rows.Length > 0)
                {
                    combinedData.Merge(existingData);
                    string errorMessage = "Tác phẩm nghệ thuật đã được chọn";
                    MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    combinedData.Merge(existingData);
                    combinedData.Merge(newData);
                }

               
            }
           


            // Cập nhật dữ liệu trong dataGridView2
            dataGridView2.DataSource = combinedData;




        }

        //nút xóa tác phẩm nghệ thuật
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Kiểm tra xem có dòng được chọn không
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dataGridView2.SelectedRows[0];

                // Xóa dòng khỏi dataGridView2
                dataGridView2.Rows.Remove(selectedRow);
            }

        }

        //khi nhấn vào bảng thứ 2 thì nó sẽ bất hoạt một số nút
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            barButtonItem1.Enabled = false;
            barButtonItem2.Enabled = true;
        }

        //nút tạo triển lãm
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                if(dataGridView2 == null || dataGridView2.RowCount == 0)
                {
                    MessageBox.Show("Phải chọn TPNT cho cuộc triển lãm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(textMaTrienLam.Text) || string.IsNullOrWhiteSpace(textTenTL.Text) || string.IsNullOrWhiteSpace(dateEditNgayBD.Text) || string.IsNullOrWhiteSpace(dateEditNgayKT.Text))
                    {
                        MessageBox.Show("Không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        //thêm các thông tin về triển lãm
                        string query = "INSERT INTO TRIENLAM (MATRIENLAM, TENTRIENLAM, NGAYBD, NGAYKT) " +
                        "VALUES (@MATL, @TENTL, @NGAYBD, @NGAYKT)";
                        SqlCommand command = new SqlCommand(query, Program.conn);
                        command.Parameters.AddWithValue("@MATL", textMaTrienLam.Text);
                        command.Parameters.AddWithValue("@TENTL", textTenTL.Text);
                        command.Parameters.AddWithValue("@NGAYBD", dateEditNgayBD.DateTime);
                        command.Parameters.AddWithValue("@NGAYKT", dateEditNgayKT.DateTime);

                        command.ExecuteNonQuery();

                        //thêm các thông tin về ct_triển lãm
                        string matl = textMaTrienLam.Text;

                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            string matpnt = dataGridView2.Rows[i].Cells["MATPNT1"].Value.ToString();

                            // Thực hiện câu lệnh INSERT vào bảng CT_TRIENLAM
                            string query1 = "INSERT INTO CT_TRIENLAM (MATRIENLAM, MATPNT) VALUES (@MATL, @MATPNT)";
                            SqlCommand command1 = new SqlCommand(query1, Program.conn);
                            command1.Parameters.AddWithValue("@MATL", matl);
                            command1.Parameters.AddWithValue("@MATPNT", matpnt);
                            command1.ExecuteNonQuery();
                        }

                        reload();

                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }




                }




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
            textMaTrienLam.Text = string.Empty;
            textTenTL.Text = string.Empty;

            // Đặt giá trị trắng cho các dateEdit
            dateEditNgayBD.EditValue = null;
            dateEditNgayKT.EditValue = null;
        }

        //khi nhấn vào bảng thứ nhất nó sẽ bất hoạt một số nút
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            barButtonItem1.Enabled = true;
            barButtonItem2.Enabled = false;
        }
    }
}