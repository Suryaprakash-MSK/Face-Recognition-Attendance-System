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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FaceRecognitionApp
{
    public partial class AttendanceRecords : Form
    {
        public AttendanceRecords()
        {
            InitializeComponent();
        }
        private void AttendanceRecords_Load(object sender, EventArgs e)
        {
            LoadUserData();
            dateTimePicker1.MinDate = new DateTime(2025, 3, 17); 
            dateTimePicker1.MaxDate = DateTime.Today;
            Submitbtn.Enabled = false;
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Lucida", 10, FontStyle.Bold);
            dataGrid.DefaultCellStyle.Font = new Font("Lucida", 14);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Brown;
            dataGrid.EnableHeadersVisualStyles = false;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            Submitbtn.Enabled = true;
        }
        private void Submitbtn_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }
        private void LoadUserData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Format for SQL
                   // string query = "SELECT Date, UserId, Username, Gender, Age, EnterTime, ExitTime, FORMAT(WorkedHours, '00') + ':' + FORMAT((WorkedHours * 60) % 60, '00') AS WorkedHours  FROM Attendance WHERE CONVERT(date, Date) = @SelectedDate";

                    string query = "SELECT UserId, Username, Gender, Age, EnterTime, ExitTime, FORMAT(WorkedHours, '00') + ':' + FORMAT((WorkedHours * 60) % 60, '00') AS WorkedHours  FROM Attendance WHERE CONVERT(date, Date) = @SelectedDate";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance records: " + ex.Message);
            }
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
