using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceAPP
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Attendance_Click(object sender, EventArgs e)
        {
            if (Entry.Visible == false)
            {
                Entry.Visible = true;
                Exit.Visible = true;
            }
            else
            {
                Entry.Visible = false;
                Exit.Visible = false;
            }


        }

        private void Records_Click(object sender, EventArgs e)
        {

        }
    }
}
