namespace FaceRecognitionApp
{
    partial class AttendanceRecords
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
            Submitbtn = new Button();
            Closebtn = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // Submitbtn
            // 
            Submitbtn.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Submitbtn.Location = new Point(785, 13);
            Submitbtn.Name = "Submitbtn";
            Submitbtn.Size = new Size(218, 29);
            Submitbtn.TabIndex = 1;
            Submitbtn.Text = "Submit";
            Submitbtn.UseVisualStyleBackColor = true;
            Submitbtn.Click += Submitbtn_Click;
            // 
            // Closebtn
            // 
            Closebtn.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Closebtn.Location = new Point(384, 662);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(606, 29);
            Closebtn.TabIndex = 2;
            Closebtn.Text = "Close";
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            label1.Location = new Point(414, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Select Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(529, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 28);
            dateTimePicker1.TabIndex = 4;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(231, 23);
            label2.TabIndex = 5;
            label2.Text = "Attendance Records ";
            // 
            // dataGrid
            // 
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 45);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1358, 611);
            dataGrid.TabIndex = 6;
            // 
            // AttendanceRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1382, 703);
            Controls.Add(dataGrid);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(Closebtn);
            Controls.Add(Submitbtn);
            Name = "AttendanceRecords";
            Text = "AttendanceRecords";
            Load += AttendanceRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Submitbtn;
        private Button Closebtn;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DataGridView dataGrid;
    }
}