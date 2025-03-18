namespace FaceRecognitionApp
{
    partial class Attendance
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
            pictureBox = new PictureBox();
            label1 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.Desktop;
            pictureBox.Location = new Point(12, 44);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(1500, 653);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 2);
            label1.Name = "label1";
            label1.Size = new Size(153, 40);
            label1.TabIndex = 1;
            label1.Text = "Camera";
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnStart.Location = new Point(12, 703);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(450, 40);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnStop.Location = new Point(540, 703);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(450, 40);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnClose.Location = new Point(1062, 703);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(450, 40);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1532, 753);
            Controls.Add(btnClose);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label1);
            Controls.Add(pictureBox);
            Font = new Font("Lucida Fax", 9F);
            Name = "Attendance";
            Text = "Attendance";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private Label label1;
        private Button btnStart;
        private Button btnStop;
        private Button btnClose;
    }
}