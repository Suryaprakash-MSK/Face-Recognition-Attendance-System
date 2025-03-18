using AForge.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FaceRecognitionApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Face Recognize Attendance System");
        }
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance form2 = new Attendance();
            form2.Show();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            AttendanceRecords form3 = new AttendanceRecords();
            form3.Show();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Profile form1 = new Profile();
            form1.Show();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
