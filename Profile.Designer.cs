namespace FaceRecognitionApp
{
    partial class Profile
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
            btnStart = new Button();
            btnSave = new Button();
            btnClose = new Button();
            btnStop = new Button();
            btnCapture = new Button();
            pictureBox = new PictureBox();
            Camera = new Label();
            pictureBoxImage = new PictureBox();
            DetectedImage = new Label();
            Useridlb = new Label();
            Usernamelb = new Label();
            UseridTXT = new TextBox();
            UserNameTXT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            AgeTXT = new TextBox();
            GenderComboBox = new ComboBox();
            dataGrid = new DataGridView();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnStart.Location = new Point(878, 269);
            btnStart.Margin = new Padding(4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(202, 29);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnSave.Location = new Point(878, 374);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(202, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnClose.Location = new Point(878, 409);
            btnClose.Margin = new Padding(4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(202, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnStop.Location = new Point(878, 304);
            btnStop.Margin = new Padding(4);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(202, 29);
            btnStop.TabIndex = 17;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnCapture
            // 
            btnCapture.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnCapture.Location = new Point(878, 339);
            btnCapture.Margin = new Padding(4);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(202, 29);
            btnCapture.TabIndex = 12;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = true;
            btnCapture.Click += btnCapture_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Desktop;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(17, 38);
            pictureBox.Margin = new Padding(4);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(550, 400);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // Camera
            // 
            Camera.AutoSize = true;
            Camera.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Camera.Location = new Point(17, 15);
            Camera.Margin = new Padding(4, 0, 4, 0);
            Camera.Name = "Camera";
            Camera.Size = new Size(76, 20);
            Camera.TabIndex = 5;
            Camera.Text = "Camera";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackColor = SystemColors.Desktop;
            pictureBoxImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxImage.Location = new Point(574, 261);
            pictureBoxImage.Margin = new Padding(4);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(248, 177);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 6;
            pictureBoxImage.TabStop = false;
            // 
            // DetectedImage
            // 
            DetectedImage.AutoSize = true;
            DetectedImage.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            DetectedImage.Location = new Point(574, 234);
            DetectedImage.Margin = new Padding(4, 0, 4, 0);
            DetectedImage.Name = "DetectedImage";
            DetectedImage.Size = new Size(152, 20);
            DetectedImage.TabIndex = 7;
            DetectedImage.Text = "Captured Image";
            // 
            // Useridlb
            // 
            Useridlb.AutoSize = true;
            Useridlb.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Useridlb.Location = new Point(617, 44);
            Useridlb.Margin = new Padding(4, 0, 4, 0);
            Useridlb.Name = "Useridlb";
            Useridlb.Size = new Size(99, 17);
            Useridlb.TabIndex = 8;
            Useridlb.Text = "UserID       :";
            Useridlb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Usernamelb
            // 
            Usernamelb.AutoSize = true;
            Usernamelb.Font = new Font("Lucida Fax", 9F);
            Usernamelb.Location = new Point(617, 93);
            Usernamelb.Margin = new Padding(4, 0, 4, 0);
            Usernamelb.Name = "Usernamelb";
            Usernamelb.Size = new Size(94, 17);
            Usernamelb.TabIndex = 9;
            Usernamelb.Text = "UserName :";
            Usernamelb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UseridTXT
            // 
            UseridTXT.Location = new Point(737, 44);
            UseridTXT.Margin = new Padding(4);
            UseridTXT.Name = "UseridTXT";
            UseridTXT.PlaceholderText = "Updated Automatically";
            UseridTXT.Size = new Size(345, 28);
            UseridTXT.TabIndex = 10;
            // 
            // UserNameTXT
            // 
            UserNameTXT.Location = new Point(737, 93);
            UserNameTXT.Margin = new Padding(4);
            UserNameTXT.Name = "UserNameTXT";
            UserNameTXT.PlaceholderText = "Enter Username";
            UserNameTXT.Size = new Size(345, 28);
            UserNameTXT.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 9F);
            label1.Location = new Point(617, 193);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 13;
            label1.Text = "Age           :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 9F);
            label2.Location = new Point(617, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 17);
            label2.TabIndex = 14;
            label2.Text = "Gender      :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AgeTXT
            // 
            AgeTXT.Location = new Point(737, 193);
            AgeTXT.Margin = new Padding(4);
            AgeTXT.Name = "AgeTXT";
            AgeTXT.PlaceholderText = "Enter Age";
            AgeTXT.Size = new Size(345, 28);
            AgeTXT.TabIndex = 15;
            // 
            // GenderComboBox
            // 
            GenderComboBox.FormattingEnabled = true;
            GenderComboBox.Location = new Point(737, 144);
            GenderComboBox.Margin = new Padding(4);
            GenderComboBox.Name = "GenderComboBox";
            GenderComboBox.Size = new Size(341, 28);
            GenderComboBox.TabIndex = 18;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(17, 456);
            dataGrid.Margin = new Padding(4);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1104, 306);
            dataGrid.TabIndex = 20;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnDelete.Location = new Point(878, 234);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(202, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1134, 775);
            Controls.Add(btnDelete);
            Controls.Add(dataGrid);
            Controls.Add(GenderComboBox);
            Controls.Add(btnStop);
            Controls.Add(AgeTXT);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(UserNameTXT);
            Controls.Add(UseridTXT);
            Controls.Add(Usernamelb);
            Controls.Add(Useridlb);
            Controls.Add(DetectedImage);
            Controls.Add(pictureBoxImage);
            Controls.Add(Camera);
            Controls.Add(pictureBox);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(btnStart);
            Controls.Add(btnCapture);
            Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Profile";
            Text = "Save User Information";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnSave;
        private Button btnClose;
        private Button btnCapture;
        private Button btnStop;
        private PictureBox pictureBox;
        private Label Camera;
        private PictureBox pictureBoxImage;
        private Label DetectedImage;
        private Label Useridlb;
        private Label Usernamelb;
        private TextBox UseridTXT;
        private TextBox UserNameTXT;
        private Label label1;
        private Label label2;
        private TextBox AgeTXT;
        private ComboBox GenderComboBox;
        private DataGridView dataGrid;
        private Button btnDelete;
    }
}
