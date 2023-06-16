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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace LOGIN.QUANLYCAIDAT
{
    public partial class frmtaoTtaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmtaoTtaiKhoan()
        {
            InitializeComponent();
            //thay đổi chế độ chọn dòng
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textPassWord.Properties.UseSystemPasswordChar = true;
        }

        private void frmtaoTtaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_BAOTANGDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qL_BAOTANGDataSet.NHANVIEN);

        }

        //nhấn vô bảng thì nó sẽ hiện tên đăng nhập cảu nhân viên
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            // Lấy hàng đã chọn trong DataGridView 1
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Lấy dữ liệu từ các ô trong hàng đã chọn
            string manv = selectedRow.Cells["MANV"].Value.ToString();

            //kết nối và gọi sp
            SqlCommand command = new SqlCommand("SP_LAYLOGINNAME", Program.conn);
            command.CommandType = CommandType.StoredProcedure;

            // Thêm tham số và gán giá trị từ column1Value
            command.Parameters.AddWithValue("@USERNAME", manv);

            // Thực thi Stored Procedure và lưu giá trị trả về vào biến tenLogin
            object result = command.ExecuteScalar();
            string tenLogin = result != null ? result.ToString() : string.Empty;

            textLoginName.Text = tenLogin;

            //bất hoạt một số nút
            if (result != null)
            {
                textPassWord.Text = "ffffff";
                buttonTaoTK.Enabled = false;
                buttonXoaTK.Enabled = true;
            }
            else
            {
                textPassWord.Text = "";
                buttonTaoTK.Enabled = true;
                buttonXoaTK.Enabled = false;
            }

            

            



        }

        //nút tạo tài khoản 
        private void buttonTaoTK_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                if (string.IsNullOrWhiteSpace(textLoginName.Text) || string.IsNullOrWhiteSpace(textPassWord.Text))
                {
                    MessageBox.Show("Không được để trống ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    // Lấy hàng đã chọn trong DataGridView 1
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Lấy dữ liệu từ các ô trong hàng đã chọn
                    string manv = selectedRow.Cells["MANV"].Value.ToString();
                    string chucdanh = selectedRow.Cells["CHUCDANH"].Value.ToString();


                    //kết nối và gọi sp
                    SqlCommand command = new SqlCommand("SP_TAOLOGIN", Program.conn);
                    command.CommandType = CommandType.StoredProcedure;

                    // Thêm tham số và gán giá trị từ column1Value
                    command.Parameters.AddWithValue("@LGNAME", textLoginName.Text);
                    command.Parameters.AddWithValue("@PASS", textPassWord.Text);
                    command.Parameters.AddWithValue("@USERNAME", manv);
                    if (chucdanh.Trim().Equals("NHÂN VIÊN"))
                    {
                        command.Parameters.AddWithValue("@ROLE", "EMPLOYEE");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@ROLE", "ADMIN");
                    }

                    // Thực thi stored procedure mà không quan tâm đến giá trị trả về
                    command.ExecuteNonQuery();

                    // thiết lập lại giao diện 
                    buttonTaoTK.Enabled = false;
                    buttonXoaTK.Enabled = true;



                    

                    MessageBox.Show("Tạo tài khoản thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        //nút xóa tài khoản 
        private void buttonXoaTK_Click(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {

                // Lấy hàng đã chọn trong DataGridView 1
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy dữ liệu từ các ô trong hàng đã chọn
                string manv = selectedRow.Cells["MANV"].Value.ToString();

                //kết nối và gọi sp
                SqlCommand command = new SqlCommand("SP_LAYLOGINNAME", Program.conn);
                command.CommandType = CommandType.StoredProcedure;

                // Thêm tham số và gán giá trị từ column1Value
                command.Parameters.AddWithValue("@USERNAME", manv);

                // Thực thi Stored Procedure và lưu giá trị trả về vào biến tenLogin
                object result = command.ExecuteScalar();
                string tenLogin = result != null ? result.ToString() : string.Empty;


                ////////////////////////thực thi xóa tài khoản
                SqlCommand command1 = new SqlCommand("SP_XOALOGIN", Program.conn);
                command1.CommandType = CommandType.StoredProcedure;


                // Thêm tham số và gán giá trị từ column1Value
                command1.Parameters.AddWithValue("@LGNAME", tenLogin);
                command1.Parameters.AddWithValue("@USRNAME", manv);

                // Thực thi stored procedure mà không quan tâm đến giá trị trả về
                command1.ExecuteNonQuery();

                //thiết lập giao diện
                buttonTaoTK.Enabled = true;
                buttonXoaTK.Enabled = false;

                textLoginName.Text = "";
                textPassWord.Text = string.Empty;

                MessageBox.Show("Xóa tài khoản thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi trong một hộp thoại
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        


    }
}