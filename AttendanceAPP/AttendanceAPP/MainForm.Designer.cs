namespace AttendanceAPP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelTop = new Panel();
            Maximize = new PictureBox();
            Close = new PictureBox();
            Restore = new PictureBox();
            Minimize = new PictureBox();
            BtnSlide = new PictureBox();
            pictureTitle = new PictureBox();
            panelLeft = new Panel();
            Menu = new Panel();
            panelRecords = new Panel();
            panelPresent = new Panel();
            panelAbsent = new Panel();
            btnAbsent = new Button();
            btnPresent = new Button();
            panelEntry = new Panel();
            btnAbout = new Button();
            panelAttendnace = new Panel();
            panelExit = new Panel();
            btnExit = new Button();
            btnEntry = new Button();
            btnHome = new Button();
            btnRecords = new Button();
            btnSave = new Button();
            btnAttendance = new Button();
            SlideTimer = new System.Windows.Forms.Timer(components);
            MenuTimer = new System.Windows.Forms.Timer(components);
            RecordsTimer = new System.Windows.Forms.Timer(components);
            panelView = new Panel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Maximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Restore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BtnSlide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureTitle).BeginInit();
            Menu.SuspendLayout();
            panelRecords.SuspendLayout();
            panelAttendnace.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.White;
            panelTop.Controls.Add(Maximize);
            panelTop.Controls.Add(Close);
            panelTop.Controls.Add(Restore);
            panelTop.Controls.Add(Minimize);
            panelTop.Controls.Add(BtnSlide);
            panelTop.Controls.Add(pictureTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1747, 55);
            panelTop.TabIndex = 3;
            panelTop.MouseDown += panelTop_MouseDown;
            // 
            // Maximize
            // 
            Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Maximize.BackColor = Color.FromArgb(0, 122, 204);
            Maximize.BackgroundImageLayout = ImageLayout.Stretch;
            Maximize.Cursor = Cursors.Hand;
            Maximize.Image = (Image)resources.GetObject("Maximize.Image");
            Maximize.Location = new Point(1664, 12);
            Maximize.Name = "Maximize";
            Maximize.Size = new Size(35, 35);
            Maximize.SizeMode = PictureBoxSizeMode.StretchImage;
            Maximize.TabIndex = 7;
            Maximize.TabStop = false;
            Maximize.Visible = false;
            Maximize.Click += Maximize_Click;
            // 
            // Close
            // 
            Close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Close.BackColor = Color.FromArgb(0, 122, 204);
            Close.BackgroundImageLayout = ImageLayout.Stretch;
            Close.Cursor = Cursors.Hand;
            Close.Image = (Image)resources.GetObject("Close.Image");
            Close.Location = new Point(1705, 12);
            Close.Name = "Close";
            Close.Size = new Size(35, 35);
            Close.SizeMode = PictureBoxSizeMode.StretchImage;
            Close.TabIndex = 8;
            Close.TabStop = false;
            Close.Click += Close_Click;
            // 
            // Restore
            // 
            Restore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Restore.BackColor = Color.FromArgb(0, 122, 204);
            Restore.BackgroundImageLayout = ImageLayout.Stretch;
            Restore.Cursor = Cursors.Hand;
            Restore.Image = (Image)resources.GetObject("Restore.Image");
            Restore.Location = new Point(1664, 12);
            Restore.Name = "Restore";
            Restore.Size = new Size(35, 35);
            Restore.SizeMode = PictureBoxSizeMode.StretchImage;
            Restore.TabIndex = 6;
            Restore.TabStop = false;
            Restore.Click += Restore_Click;
            // 
            // Minimize
            // 
            Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Minimize.BackColor = Color.FromArgb(0, 122, 204);
            Minimize.BackgroundImageLayout = ImageLayout.Stretch;
            Minimize.Cursor = Cursors.Hand;
            Minimize.Image = (Image)resources.GetObject("Minimize.Image");
            Minimize.Location = new Point(1623, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(35, 35);
            Minimize.SizeMode = PictureBoxSizeMode.StretchImage;
            Minimize.TabIndex = 5;
            Minimize.TabStop = false;
            Minimize.Click += Minimize_Click;
            // 
            // BtnSlide
            // 
            BtnSlide.BackColor = Color.Transparent;
            BtnSlide.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSlide.Cursor = Cursors.Hand;
            BtnSlide.Image = (Image)resources.GetObject("BtnSlide.Image");
            BtnSlide.Location = new Point(6, 7);
            BtnSlide.Name = "BtnSlide";
            BtnSlide.Size = new Size(45, 45);
            BtnSlide.SizeMode = PictureBoxSizeMode.StretchImage;
            BtnSlide.TabIndex = 4;
            BtnSlide.TabStop = false;
            BtnSlide.Click += BtnSlide_Click;
            // 
            // pictureTitle
            // 
            pictureTitle.BackColor = Color.FromArgb(0, 122, 204);
            pictureTitle.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTitle.BorderStyle = BorderStyle.Fixed3D;
            pictureTitle.Image = (Image)resources.GetObject("pictureTitle.Image");
            pictureTitle.Location = new Point(57, 0);
            pictureTitle.Name = "pictureTitle";
            pictureTitle.Size = new Size(829, 55);
            pictureTitle.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureTitle.TabIndex = 0;
            pictureTitle.TabStop = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(41, 50, 65);
            panelLeft.Location = new Point(240, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(10, 94);
            panelLeft.TabIndex = 4;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(0, 122, 204);
            Menu.Controls.Add(panelRecords);
            Menu.Controls.Add(panelLeft);
            Menu.Controls.Add(panelEntry);
            Menu.Controls.Add(btnAbout);
            Menu.Controls.Add(panelAttendnace);
            Menu.Controls.Add(btnHome);
            Menu.Controls.Add(btnRecords);
            Menu.Controls.Add(btnSave);
            Menu.Controls.Add(btnAttendance);
            Menu.Dock = DockStyle.Left;
            Menu.Location = new Point(0, 55);
            Menu.Name = "Menu";
            Menu.Size = new Size(250, 878);
            Menu.TabIndex = 5;
            // 
            // panelRecords
            // 
            panelRecords.BackColor = Color.FromArgb(0, 122, 180);
            panelRecords.Controls.Add(panelPresent);
            panelRecords.Controls.Add(panelAbsent);
            panelRecords.Controls.Add(btnAbsent);
            panelRecords.Controls.Add(btnPresent);
            panelRecords.Location = new Point(0, 579);
            panelRecords.Margin = new Padding(0);
            panelRecords.MaximumSize = new Size(250, 200);
            panelRecords.MinimumSize = new Size(250, 0);
            panelRecords.Name = "panelRecords";
            panelRecords.Size = new Size(250, 200);
            panelRecords.TabIndex = 7;
            // 
            // panelPresent
            // 
            panelPresent.BackColor = Color.FromArgb(41, 50, 65);
            panelPresent.Location = new Point(240, 0);
            panelPresent.Name = "panelPresent";
            panelPresent.Size = new Size(10, 94);
            panelPresent.TabIndex = 7;
            // 
            // panelAbsent
            // 
            panelAbsent.BackColor = Color.FromArgb(41, 50, 65);
            panelAbsent.Location = new Point(240, 106);
            panelAbsent.Name = "panelAbsent";
            panelAbsent.Size = new Size(10, 94);
            panelAbsent.TabIndex = 6;
            // 
            // btnAbsent
            // 
            btnAbsent.BackColor = Color.Transparent;
            btnAbsent.FlatAppearance.BorderColor = Color.White;
            btnAbsent.FlatAppearance.BorderSize = 0;
            btnAbsent.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnAbsent.FlatStyle = FlatStyle.Flat;
            btnAbsent.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnAbsent.ForeColor = Color.WhiteSmoke;
            btnAbsent.Image = (Image)resources.GetObject("btnAbsent.Image");
            btnAbsent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbsent.Location = new Point(0, 106);
            btnAbsent.Margin = new Padding(3, 0, 3, 3);
            btnAbsent.Name = "btnAbsent";
            btnAbsent.Size = new Size(250, 94);
            btnAbsent.TabIndex = 3;
            btnAbsent.Text = "          Absent Records";
            btnAbsent.UseVisualStyleBackColor = false;
            btnAbsent.Click += btnAbsent_Click;
            // 
            // btnPresent
            // 
            btnPresent.BackColor = Color.Transparent;
            btnPresent.FlatAppearance.BorderColor = Color.White;
            btnPresent.FlatAppearance.BorderSize = 0;
            btnPresent.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnPresent.FlatStyle = FlatStyle.Flat;
            btnPresent.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnPresent.ForeColor = Color.WhiteSmoke;
            btnPresent.Image = (Image)resources.GetObject("btnPresent.Image");
            btnPresent.ImageAlign = ContentAlignment.MiddleLeft;
            btnPresent.Location = new Point(0, 0);
            btnPresent.Name = "btnPresent";
            btnPresent.Size = new Size(250, 94);
            btnPresent.TabIndex = 2;
            btnPresent.Text = "           Present Records";
            btnPresent.UseVisualStyleBackColor = false;
            btnPresent.Click += btnPresent_Click;
            // 
            // panelEntry
            // 
            panelEntry.BackColor = Color.FromArgb(41, 50, 65);
            panelEntry.Location = new Point(240, 188);
            panelEntry.Name = "panelEntry";
            panelEntry.Size = new Size(10, 94);
            panelEntry.TabIndex = 6;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.Transparent;
            btnAbout.FlatAppearance.BorderColor = Color.White;
            btnAbout.FlatAppearance.BorderSize = 0;
            btnAbout.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            btnAbout.ForeColor = Color.WhiteSmoke;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(0, 782);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(250, 94);
            btnAbout.TabIndex = 10;
            btnAbout.Text = "                About";
            btnAbout.TextAlign = ContentAlignment.MiddleLeft;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // panelAttendnace
            // 
            panelAttendnace.BackColor = Color.FromArgb(0, 122, 180);
            panelAttendnace.Controls.Add(panelExit);
            panelAttendnace.Controls.Add(btnExit);
            panelAttendnace.Controls.Add(btnEntry);
            panelAttendnace.Location = new Point(0, 188);
            panelAttendnace.Margin = new Padding(0);
            panelAttendnace.MaximumSize = new Size(250, 200);
            panelAttendnace.MinimumSize = new Size(250, 0);
            panelAttendnace.Name = "panelAttendnace";
            panelAttendnace.Size = new Size(250, 200);
            panelAttendnace.TabIndex = 5;
            // 
            // panelExit
            // 
            panelExit.BackColor = Color.FromArgb(41, 50, 65);
            panelExit.Location = new Point(240, 106);
            panelExit.Name = "panelExit";
            panelExit.Size = new Size(10, 94);
            panelExit.TabIndex = 6;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.White;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnExit.ForeColor = Color.WhiteSmoke;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 106);
            btnExit.Margin = new Padding(3, 0, 3, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(250, 94);
            btnExit.TabIndex = 3;
            btnExit.Text = " Exit Time";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnEntry
            // 
            btnEntry.BackColor = Color.Transparent;
            btnEntry.FlatAppearance.BorderColor = Color.White;
            btnEntry.FlatAppearance.BorderSize = 0;
            btnEntry.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnEntry.FlatStyle = FlatStyle.Flat;
            btnEntry.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnEntry.ForeColor = Color.WhiteSmoke;
            btnEntry.Image = (Image)resources.GetObject("btnEntry.Image");
            btnEntry.ImageAlign = ContentAlignment.MiddleLeft;
            btnEntry.Location = new Point(0, 0);
            btnEntry.Name = "btnEntry";
            btnEntry.Size = new Size(250, 94);
            btnEntry.TabIndex = 2;
            btnEntry.Text = "  Entry Time";
            btnEntry.UseVisualStyleBackColor = false;
            btnEntry.Click += btnEntry_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderColor = Color.White;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnHome.ForeColor = Color.WhiteSmoke;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(250, 94);
            btnHome.TabIndex = 8;
            btnHome.Text = "            Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.Transparent;
            btnRecords.FlatAppearance.BorderColor = Color.White;
            btnRecords.FlatAppearance.BorderSize = 0;
            btnRecords.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnRecords.ForeColor = Color.WhiteSmoke;
            btnRecords.Image = (Image)resources.GetObject("btnRecords.Image");
            btnRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecords.Location = new Point(0, 482);
            btnRecords.Name = "btnRecords";
            btnRecords.Size = new Size(250, 94);
            btnRecords.TabIndex = 5;
            btnRecords.Text = "       View Records";
            btnRecords.UseVisualStyleBackColor = false;
            btnRecords.Click += btnRecords_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.FlatAppearance.BorderColor = Color.White;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnSave.ForeColor = Color.WhiteSmoke;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(0, 388);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(250, 94);
            btnSave.TabIndex = 4;
            btnSave.Text = "    Save Profile";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.BackColor = Color.Transparent;
            btnAttendance.BackgroundImageLayout = ImageLayout.Zoom;
            btnAttendance.FlatAppearance.BorderColor = Color.White;
            btnAttendance.FlatAppearance.BorderSize = 0;
            btnAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(45, 45, 48);
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnAttendance.ForeColor = Color.WhiteSmoke;
            btnAttendance.Image = (Image)resources.GetObject("btnAttendance.Image");
            btnAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            btnAttendance.Location = new Point(0, 94);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(250, 94);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "           Mark Attendance";
            btnAttendance.UseVisualStyleBackColor = false;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // SlideTimer
            // 
            SlideTimer.Interval = 1;
            SlideTimer.Tick += SlideTimer_Tick;
            // 
            // MenuTimer
            // 
            MenuTimer.Interval = 10;
            MenuTimer.Tick += MenuTimer_Tick;
            // 
            // RecordsTimer
            // 
            RecordsTimer.Interval = 1;
            RecordsTimer.Tick += RecordsTimer_Tick;
            // 
            // panelView
            // 
            panelView.BackgroundImageLayout = ImageLayout.Stretch;
            panelView.Dock = DockStyle.Fill;
            panelView.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            panelView.Location = new Point(250, 55);
            panelView.Name = "panelView";
            panelView.Size = new Size(1497, 878);
            panelView.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1747, 933);
            Controls.Add(panelView);
            Controls.Add(Menu);
            Controls.Add(panelTop);
            Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Form1";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Maximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)Restore).EndInit();
            ((System.ComponentModel.ISupportInitialize)Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)BtnSlide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureTitle).EndInit();
            Menu.ResumeLayout(false);
            panelRecords.ResumeLayout(false);
            panelAttendnace.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private PictureBox BtnSlide;
        private Panel panelLeft;
        private Panel Menu;
        private Panel panelAttendnace;
        private Button btnEntry;
        private Button btnExit;
        private Button btnRecords;
        private Button btnSave;
        private Button btnAttendance;
        private PictureBox pictureTitle;
        private PictureBox Close;
        private PictureBox Maximize;
        private PictureBox Restore;
        private PictureBox Minimize;
        private Panel panelExit;
        private Panel panelEntry;
        private Button btnAbout;
        private Button btnHome;
        private System.Windows.Forms.Timer SlideTimer;
        private System.Windows.Forms.Timer MenuTimer;
        private Panel panelRecords;
        private Panel panelAbsent;
        private Button btnP;
        private System.Windows.Forms.Timer RSliderTimer;
        private System.Windows.Forms.Timer RecordsTimer;
        private Button btnA;
        private Button btnAbsent;
        private Button btnPresent;
        private Panel panelPresent;
        private Panel panelView;
    }
}
