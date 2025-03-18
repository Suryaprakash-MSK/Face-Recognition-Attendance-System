namespace FaceRecognitionApp
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pictureBoxImage = new PictureBox();
            btnAttendance = new Button();
            btnView = new Button();
            btnClose = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackgroundImage = (Image)resources.GetObject("pictureBoxImage.BackgroundImage");
            pictureBoxImage.Location = new Point(52, 57);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(470, 415);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            pictureBoxImage.Click += pictureBoxImage_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(611, 57);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(166, 46);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "Mark Attendance";
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(611, 305);
            btnView.Name = "btnView";
            btnView.Size = new Size(166, 46);
            btnView.TabIndex = 2;
            btnView.Text = "View Data";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.Location = new Point(611, 426);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(166, 46);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(611, 180);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save Profile";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(854, 529);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(btnView);
            Controls.Add(btnAttendance);
            Controls.Add(pictureBoxImage);
            Name = "Form2";
            Text = "Face Recognize Attendance System";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxImage;
        private Button btnAttendance;
        private Button btnView;
        private Button btnClose;
        private Button btnSave;
    }
}