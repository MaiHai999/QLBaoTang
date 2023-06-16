using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LOGIN
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static String connstr_publisher = "Data Source=LAPTOP-5MDDM7K6\\SQLEXPRESS;Initial Catalog=QL_BAOTANG;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String ussername = "";
        public static String mlogin = "";
        public static String password = "";


        public static String mloginDn = "";
        public static String passDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";
       /* public static int chiNhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();// giuwx ds phaan manhr*/


        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open) Program.conn.Close();

            try
            {
                Program.connstr = "Data Source=LAPTOP-5MDDM7K6\\SQLEXPRESS;Initial Catalog=QL_BAOTANG;User ID=" + Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                



                return 1;
            }
            catch (Exception e)
            {

                MessageBox.Show("xem lai user name và pass" + e.Message +   Program.mlogin + Program.password);
                return 0;
            }
        }

        //exec sql data reader
        public static SqlDataReader ExecSqldataReader(string cmd)
        {
            SqlDataReader myReader;
            using (SqlCommand myCommand = new SqlCommand(cmd, Program.conn))
            {
                myCommand.CommandType = CommandType.Text;
                if (Program.conn.State == System.Data.ConnectionState.Closed)
                {
                    Program.conn.Open();
                }
                try
                {
                    myReader = myCommand.ExecuteReader();
                    return myReader;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("DATA CÓ LẼ NULL " + ex.Message);
                    return null;
                }
            }
        }

        public static object ExecSqlScalar(string query)
        {
            using (SqlConnection connection = new SqlConnection(Program.connstr))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    return result;
                }
            }
        }

        //exec sql data table
        public static DataTable ExecSqldataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }
        // exec sql chir thuc thi nhung ko tra ve so lieu, neu err thif tra ve raiserror len messagebox
        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand myCommand = new SqlCommand(cmd, Program.conn);
            myCommand.CommandType = CommandType.Text;
            myCommand.CommandTimeout = 600; //10p ,defaut is 60s

            if (Program.conn.State == System.Data.ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                myCommand.ExecuteNonQuery();
                conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                {
                    MessageBox.Show("ban format lai cot /ngay thi qua kieu number  or open file excel !");
                }
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDN());
        }
    }
}
