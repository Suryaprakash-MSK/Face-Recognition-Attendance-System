namespace AttendanceAPP
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            printDialog1 = new PrintDialog();
            About = new Button();
            Records = new Button();
            Save = new Button();
            Exit = new Button();
            Entry = new Button();
            Attendance = new Button();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // About
            // 
            About.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            About.Cursor = Cursors.Hand;
            About.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            About.Location = new Point(970, 445);
            About.Name = "About";
            About.Size = new Size(150, 50);
            About.TabIndex = 24;
            About.Text = "About";
            About.UseVisualStyleBackColor = true;
            // 
            // Records
            // 
            Records.Anchor = AnchorStyles.Bottom;
            Records.Cursor = Cursors.Hand;
            Records.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Records.Location = new Point(690, 445);
            Records.Name = "Records";
            Records.Size = new Size(150, 50);
            Records.TabIndex = 23;
            Records.Text = "View Records";
            Records.UseVisualStyleBackColor = true;
            // 
            // Save
            // 
            Save.Anchor = AnchorStyles.Bottom;
            Save.Cursor = Cursors.Hand;
            Save.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Save.Location = new Point(410, 445);
            Save.Name = "Save";
            Save.Size = new Size(150, 50);
            Save.TabIndex = 22;
            Save.Text = "Save Profile";
            Save.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Exit.Location = new Point(217, 505);
            Exit.Name = "Exit";
            Exit.Size = new Size(125, 30);
            Exit.TabIndex = 21;
            Exit.Text = "Exit Time";
            Exit.UseVisualStyleBackColor = true;
            Exit.Visible = false;
            // 
            // Entry
            // 
            Entry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Entry.Cursor = Cursors.Hand;
            Entry.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Entry.Location = new Point(65, 505);
            Entry.Name = "Entry";
            Entry.Size = new Size(125, 30);
            Entry.TabIndex = 20;
            Entry.Text = "Entry Time";
            Entry.UseVisualStyleBackColor = true;
            Entry.Visible = false;
            // 
            // Attendance
            // 
            Attendance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Attendance.Cursor = Cursors.Hand;
            Attendance.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Attendance.Location = new Point(130, 445);
            Attendance.Name = "Attendance";
            Attendance.Size = new Size(150, 50);
            Attendance.TabIndex = 19;
            Attendance.Text = "Mark Attendance";
            Attendance.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(About);
            Controls.Add(Records);
            Controls.Add(Save);
            Controls.Add(Exit);
            Controls.Add(Entry);
            Controls.Add(Attendance);
            Name = "Home";
            Size = new Size(1250, 567);
            ResumeLayout(false);
        }

        #endregion

        private PrintDialog printDialog1;
        private Button About;
        private Button Records;
        private Button Save;
        private Button Exit;
        private Button Entry;
        private Button Attendance;
    }
}
