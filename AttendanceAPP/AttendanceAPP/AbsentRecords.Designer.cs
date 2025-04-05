﻿namespace AttendanceAPP
{
    partial class AbsentRecords
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
            dataGrid = new DataGridView();
            datePicker = new DateTimePicker();
            btnAbsentDays = new Button();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Exportbtn = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(24, 50);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 51;
            dataGrid.Size = new Size(1133, 386);
            dataGrid.TabIndex = 27;
            // 
            // datePicker
            // 
            datePicker.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            datePicker.Location = new Point(573, 16);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(250, 28);
            datePicker.TabIndex = 32;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // btnAbsentDays
            // 
            btnAbsentDays.Anchor = AnchorStyles.Bottom;
            btnAbsentDays.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            btnAbsentDays.Location = new Point(669, 582);
            btnAbsentDays.Name = "btnAbsentDays";
            btnAbsentDays.Size = new Size(610, 30);
            btnAbsentDays.TabIndex = 33;
            btnAbsentDays.Text = "Get";
            btnAbsentDays.UseVisualStyleBackColor = true;
            btnAbsentDays.Click += btnAbsentDays_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Bottom;
            usernameTextBox.Location = new Point(239, 582);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(257, 27);
            usernameTextBox.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 15);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 35;
            label2.Text = "Absent Records ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label1.Location = new Point(435, 19);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 36;
            label1.Text = "Select Date :";
            // 
            // Exportbtn
            // 
            Exportbtn.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            Exportbtn.Location = new Point(1163, 15);
            Exportbtn.Name = "Exportbtn";
            Exportbtn.Size = new Size(218, 29);
            Exportbtn.TabIndex = 37;
            Exportbtn.Text = "Export";
            Exportbtn.UseVisualStyleBackColor = true;
            Exportbtn.Click += Exportbtn_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label6.Location = new Point(23, 582);
            label6.Name = "label6";
            label6.Size = new Size(210, 22);
            label6.TabIndex = 38;
            label6.Text = "Enter Username      :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label5.Location = new Point(24, 501);
            label5.Name = "label5";
            label5.Size = new Size(120, 22);
            label5.TabIndex = 42;
            label5.Text = "Start Date :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Fax", 11F, FontStyle.Bold);
            label4.Location = new Point(280, 501);
            label4.Name = "label4";
            label4.Size = new Size(111, 22);
            label4.TabIndex = 41;
            label4.Text = "End Date :";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtpEndDate.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            dtpEndDate.Location = new Point(280, 526);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 28);
            dtpEndDate.TabIndex = 40;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dtpStartDate.Font = new Font("Lucida Fax", 10.2F, FontStyle.Bold);
            dtpStartDate.Location = new Point(24, 526);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 28);
            dtpStartDate.TabIndex = 39;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(1163, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(218, 386);
            dataGridView.TabIndex = 43;
            // 
            // AbsentRecords
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label6);
            Controls.Add(Exportbtn);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(usernameTextBox);
            Controls.Add(btnAbsentDays);
            Controls.Add(datePicker);
            Controls.Add(dataGrid);
            Name = "AbsentRecords";
            Size = new Size(1400, 700);
            Load += AbsentRecords_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid;
        private DateTimePicker datePicker;
        private Button btnAbsentDays;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
        private Button Exportbtn;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private DataGridView dataGridView;
    }
}
