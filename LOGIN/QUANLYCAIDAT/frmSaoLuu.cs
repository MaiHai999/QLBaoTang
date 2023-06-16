using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DevExpress.CodeParser;
//using static DevExpress.Xpo.Helpers.AssociatedCollectionCriteriaHelper;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraExport.Helpers;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace LOGIN.QUANLYCAIDAT
{
    public partial class frmSaoLuu : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frmSaoLuu()
        {
            InitializeComponent();
            progressBar1.Hide();
            txtName.Enabled = false;
            String cmd = "EXEC SP_STT_BACKUP '"+ txtName.Text + "'";
            dt = Program.ExecSqldataTable(cmd);
            gridControl1.DataSource = dt;
             int rowCount = gridControl1.DefaultView.RowCount;
 
            txtCount.Text = rowCount.ToString();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            string x= txtName.Text.Trim() + "_device";
            txtDevice.Text = x;
            try
            {
                string cmd = "EXEC sp_addumpdevice 'disk', 'MyBackupDisk', 'C:\\backup\\" + x + "'";
                int result = Program.ExecSqlNonQuery(cmd);
                if (result == 0)
                {
                    MessageBox.Show("tạo tên device");
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            try
            {
              
                    string cmd = "BACKUP DATABASE QL_BAOTANG TO DISK = 'C:\\backup\\" + txtDevice.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_full.bak" + "' WITH INIT, NAME = 'Full Database Backup', STATS = 10;";
                    int result = Program.ExecSqlNonQuery(cmd);
                    if (result == 0)
                    {
                        progressBar1.Show();
                        progressBar1.Minimum = 0;
                        progressBar1.Maximum = 100;
                        progressBar1.Value = 0;

                        for (int i = 0; i < 100; i++)
                        {
                            if (progressBar1.Value < progressBar1.Maximum)
                            {
                                progressBar1.Value += 10;


                                System.Threading.Thread.Sleep(100);
                            }

                        }
                        MessageBox.Show("tạo backup thanh cong");
                    String cmd2 = "EXEC SP_STT_BACKUP '" + txtName.Text + "'";
                    dt = Program.ExecSqldataTable(cmd2);
                    gridControl1.DataSource = dt;
                    int rowCount = gridControl1.DefaultView.RowCount;

                    txtCount.Text = rowCount.ToString();
                }


               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Hide();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //progressBar1.Value = 0;
            progressBar1.Visible = true;



            // Khởi tạo một luồng riêng để thực hiện quá trình khôi phục và cấu hình cơ sở dữ liệu
            Thread restoreThread = new Thread(restore);
            restoreThread.Start();

            while (restoreThread.IsAlive)
            {
                // Tăng giá trị của ProgressBar một lượng cố định
                progressBar1.Value += 10;

                // Kiểm tra nếu giá trị của ProgressBar đã đạt đến đầu kia
                if (progressBar1.Value >= progressBar1.Maximum)
                {
                    // Thiết lập lại giá trị của ProgressBar về đầu để bắt đầu lại quá trình di chuyển
                    progressBar1.Value = progressBar1.Minimum;
                }

                // Tạm dừng một khoảng thời gian trước khi tiếp tục vòng lặp
                System.Threading.Thread.Sleep(100);
            }

            progressBar1.Visible = false;






        }

        //hàm này dùng để restore
        private void restore()
        {
            if (Program.KetNoi() == 0) return;

            string backupPath = "";
            string loai = "";
            int selectedRowIndex = 0; // lấy số dòng được chọn
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                backupPath = selectedRow["TÊN TỆP"].ToString();
                loai = selectedRow["LOẠI"].ToString();
                selectedRowIndex = gridView1.FocusedRowHandle;

            }

            if (loai.Trim() == "FULL")
            {
                try
                {
                    // Check if the database is in the Restoring state
                    string checkCmd = "SELECT state_desc FROM sys.databases WHERE name = 'QL_BAOTANG'";
                    string databaseState = Program.ExecSqlScalar(checkCmd).ToString();

                    if (databaseState.Equals("RESTORING", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("The database is currently being restored. Please wait for the restore operation to complete.");
                        return;
                    }

                    // Set the database to single-user mode and rollback any active transactions
                    string cmd1 = "ALTER DATABASE QL_BAOTANG SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    int result1 = Program.ExecSqlNonQuery(cmd1);

                    if (result1 == 0)
                    {




                        // Restore the database from the specified backup file
                        string cmd2 = "USE master;" + "RESTORE DATABASE QL_BAOTANG FROM DISK = '" + backupPath + "' WITH REPLACE, RECOVERY;" + "ALTER DATABASE QL_BAOTANG SET MULTI_USER";

                        int result2 = Program.ExecSqlNonQuery(cmd2);

                        if (result2 == 0)
                        {
                            MessageBox.Show("Phục hồi thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể khôi phục cơ sở dữ liệu từ tập tin sao lưu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thiết lập chế độ single-user cho cơ sở dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //progressBar1.Hide();
                }
            }
            else
            {
                // Khai báo và khởi tạo danh sách chuỗi
                List<string> listPath = new List<string>();
                int dem = 0;

                // Duyệt qua từng hàng trong GridControl1
                for (int i = selectedRowIndex; i >= 0; i--)
                {
                    // Lấy dữ liệu từ từng hàng
                    object data = gridView1.GetRow(i);

                    // Sử dụng dữ liệu trong hàng
                    // Ví dụ: Lấy giá trị từ một cột cụ thể
                    string columnName = "TÊN TỆP";
                    string stringValuePath = gridView1.GetRowCellValue(i, columnName).ToString();



                    listPath.Add(stringValuePath);

                    string stringValueLoai = gridView1.GetRowCellValue(i, "LOẠI").ToString();
                    if (stringValueLoai == "FULL")
                    {
                        dem = 1;
                        break;
                    }

                }
                if(dem == 0)
                {
                    MessageBox.Show("Bản diff này không thể phục hồi vì không có bạn gốc của nó , bạn phải tạo bản full trước khi tạo bản diff để có thể restore");
                    return;
                }


                // Check if the database is in the Restoring state
                string checkCmd = "SELECT state_desc FROM sys.databases WHERE name = 'QL_BAOTANG'";
                string databaseState = Program.ExecSqlScalar(checkCmd).ToString();
                if (databaseState.Equals("RESTORING", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("The database is currently being restored. Please wait for the restore operation to complete.");
                    return;
                }

                //KHAI BÁO BIẾN ĐỂ CÓ THỂ lưu được câu lệnh restore
                String cmd = "";

                //VÒNG LẬP ĐỂ DUYỆT NGƯỢC LẠI VÀ TRONG VÒNG LẬP NÀY SẼ BÁT ĐẦU TẠO CHUỖI ĐỂ BACKUP
                for (int i = listPath.Count - 1; i >= 0; i--)
                {
                    string path = listPath[i];

                    // Sử dụng giá trị path trong vòng lặp ĐỂ TẠO STRING TRUY VẤN 
                    if(i != 0)
                    {
                        cmd = cmd + "RESTORE DATABASE QL_BAOTANG " +
                         "FROM DISK = '" + path + "'" +
                         "WITH NORECOVERY;";
                    }
                    else
                    {
                        cmd = cmd + "RESTORE DATABASE QL_BAOTANG " +
                       "FROM DISK = '" + path + "'" +
                       "WITH RECOVERY;";
                    }

                }

                try
                {
                    // Set the database to single-user mode and rollback any active transactions
                    string cmd1 = "ALTER DATABASE QL_BAOTANG SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    int result1 = Program.ExecSqlNonQuery(cmd1);

                    if (result1 == 0)
                    {
                        // Restore the database from the specified backup file
                        string cmd2 = "USE master;" + cmd + "ALTER DATABASE QL_BAOTANG SET MULTI_USER";

                        int result2 = Program.ExecSqlNonQuery(cmd2);
                        if (result2 == 0)
                        {
                            MessageBox.Show("Phục hồi thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể khôi phục cơ sở dữ liệu từ tập tin sao lưu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể thiết lập chế độ single-user cho cơ sở dữ liệu");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
       
                if (Program.KetNoi() == 0) return;

            try
            {
                string cmd = "EXEC xp_cmdshell 'DEL C:\\backup\\*.bak'";
                int result = Program.ExecSqlNonQuery(cmd);
                if (result == 0)
                {
                    progressBar1.Show();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = 0;

                    for (int i = 0; i < 100; i++)
                    {
                        if (progressBar1.Value < progressBar1.Maximum)
                        {
                            progressBar1.Value += 10;


                            System.Threading.Thread.Sleep(100);
                        }

                    }
                    MessageBox.Show("xóa tât cả backup thành công");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Hide();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0) return;
            string backupPath = "";
            DataRowView selectedRow = (DataRowView)gridView1.GetRow(gridView1.FocusedRowHandle);
            if (selectedRow != null)
            {
                  backupPath = selectedRow["TÊN TỆP"].ToString();
                MessageBox.Show(backupPath);
            }
            try
            {
                string cmd = "EXEC sp_dropdevice 'MyBackupDisk', 'delfile'";
                int result = Program.ExecSqlNonQuery(cmd);
                if (result == 0)
                {
                    progressBar1.Show();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = 0;

                    for (int i = 0; i < 100; i++)
                    {
                        if (progressBar1.Value < progressBar1.Maximum)
                        {
                            progressBar1.Value += 10;


                            System.Threading.Thread.Sleep(100);
                        }

                    }
                    MessageBox.Show("Xóa divice thành công");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            progressBar1.Hide();
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string checkCmd = "SELECT backup_set_id FROM msdb.dbo.backupset WHERE database_name = 'QL_BAOTANG' AND type = 'D'";
            object kq = Program.ExecSqlScalar(checkCmd);

            if (kq != null && kq != DBNull.Value)
            {
                string backupPath = "C:\\backup\\" + txtDevice.Text + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";
                string backupCmd = "BACKUP DATABASE QL_BAOTANG TO DISK = '" + backupPath + "' WITH DIFFERENTIAL;";

                int kq1 = Program.ExecSqlNonQuery(backupCmd);
                if (kq1 == 0)
                {

                    progressBar1.Show();
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;
                    progressBar1.Value = 0;

                    for (int i = 0; i < 100; i++)
                    {
                        if (progressBar1.Value < progressBar1.Maximum)
                        {
                            progressBar1.Value += 10;


                            System.Threading.Thread.Sleep(100);
                        }

                    }
                    MessageBox.Show("tạo backup khác thanh cong");
                    progressBar1.Hide();

                    String cmd2 = "EXEC SP_STT_BACKUP '" + txtName.Text + "'";
                    dt = Program.ExecSqldataTable(cmd2);
                    gridControl1.DataSource = dt;
                    int rowCount = gridControl1.DefaultView.RowCount;

                    txtCount.Text = rowCount.ToString();
                }

            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void gridControl1_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {
            
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}