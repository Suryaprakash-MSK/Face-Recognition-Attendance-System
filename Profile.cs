using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using SeetaFace6Sharp;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using Microsoft.VisualBasic.ApplicationServices;

namespace FaceRecognitionApp
{
    public partial class Profile : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap Cframe;
        private FaceDetector faceDetector;
        private FaceRecognizer faceRecognizer;

        public Profile()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            faceRecognizer = new FaceRecognizer();
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }
            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            GenderComboBox.Items.Add("Male");
            GenderComboBox.Items.Add("Female");
            GenderComboBox.Items.Add("Other ");
            LoadUserData();
            //GenderComboBox.SelectedIndex = 0;
            btnSave.Enabled = false;
            btnCapture.Enabled = false;
            btnStop.Enabled = false;
            UseridTXT.Enabled = false;
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            var frame = new Bitmap(eventArgs.Frame);
            if (pictureBox.Image != null)
            {
                pictureBox.Image.Dispose();
            }
            if (faceDetector == null)
            {
                faceDetector = new FaceDetector();
            }
            if (faceDetector != null)
            {
                var imageData = frame.ToFaceImage();
                FaceInfo[] infos = faceDetector.Detect(imageData);
                DrawDetectedFaces(frame, infos);

            }
        }
        private void DrawDetectedFaces(Bitmap frame, FaceInfo[] infos)
        {
            using (Graphics g = Graphics.FromImage(frame))
            {

                foreach (var info in infos)
                {
                    Rectangle faceRect = new Rectangle(info.Location.X, info.Location.Y, info.Location.Width, info.Location.Height);
                    Cframe = CropImage(frame, faceRect);
                    using (Pen pen = new Pen(Color.Red, 4))
                    {
                        g.DrawRectangle(pen, faceRect);
                    }
                }
                pictureBox.Image = (Bitmap)frame;
            }
        }
        private Bitmap CropImage(Bitmap source, Rectangle cropArea)
        {
            // Ensure the crop area is within the bounds of the source image
            cropArea.Intersect(new Rectangle(0, 0, source.Width, source.Height));
            if (cropArea.Width <= 0 || cropArea.Height <= 0)
                return null;
            return source.Clone(cropArea, source.PixelFormat);
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            videoSource.Start();
            btnCapture.Enabled = true;
            btnStop.Enabled = true;
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (Cframe != null)
            {
                UseridTXT.Enabled = false;
                pictureBoxImage.Image = (Bitmap)Cframe;
                MessageBox.Show("Image captured successfully!");
                btnSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("No frame captured to save.");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            string username = UserNameTXT.Text.Trim();
            string userGender = GenderComboBox.SelectedItem?.ToString();
            int userAge = GetInteger(AgeTXT);

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(userGender) || userAge == 0)
            {
                MessageBox.Show("Please enter all details");
                return;
            }
            else if (userAge < 1 || userAge > 110)
            {
                MessageBox.Show("Please enter an age between 1 - 110");
                return;
            }

            // Get existing user ID or create a new one if user does not exist
            int userid = GetUserId(username);
            UseridTXT.Text = userid.ToString(); // Ensure UI is updated
            
            SaveUserToDatabase(userid, username, userGender, userAge,(Bitmap)pictureBoxImage.Image);
           
            LoadUserData();
        }
        private int GetUserId(string username)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Check if the user already exists
                string query = "SELECT UserId FROM Users WHERE UserName = @UserName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result); // Return existing user ID
                    }
                }

                // If user does not exist, get the next available ID
                string maxIdQuery = "SELECT ISNULL(MAX(UserId), 0) + 1 FROM Users";
                using (SqlCommand cmd = new SqlCommand(maxIdQuery, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar()); // Return new user ID
                }
            }
        }

        private int GetInteger(TextBox textBox)
        {
            return int.TryParse(textBox.Text, out int result) ? result : 0;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            this.Close();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            pictureBoxImage.Image = null;
            pictureBox.Image = null; // Clear the PictureBox
            btnCapture.Enabled = false;
            btnSave.Enabled = false;
            btnStop.Enabled = false;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGrid.SelectedRows[0];
                int userId = Convert.ToInt32(selectedRow.Cells["UserId"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this user?",
                                                      "Confirm Deletion",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteUserFromDatabase(userId); // Delete the user from the database
                    LoadUserData(); // Refresh the DataGridView
                    MessageBox.Show("User deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
        private void SaveUserToDatabase(int userId, string username, string gender, int age, Bitmap image)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string userQuery = "IF NOT EXISTS (SELECT 1 FROM Users WHERE UserId = @UserId) " +
                                       "INSERT INTO Users (UserId, UserName, Gender, Age) VALUES (@UserId, @UserName, @Gender, @Age)";
                    using (SqlCommand cmd = new SqlCommand(userQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@UserName", username);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Age", age);
                        cmd.ExecuteNonQuery();
                    }

                    float[][] faceFeatures = ExtractMultipleFaceFeatures(image);
                    if (faceFeatures == null || faceFeatures.Length == 0)
                    {
                        MessageBox.Show("Face not detected. Cannot save user.");
                        return;
                    }

                    string featureQuery = "INSERT INTO UserFaceFeatures (UserId, FeatureData) VALUES (@UserId, @FeatureData)";
                    foreach (var feature in faceFeatures)
                    {
                        using (SqlCommand cmd = new SqlCommand(featureQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@UserId", userId);
                            cmd.Parameters.AddWithValue("@FeatureData", FloatArrayToByteArray(feature));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("User and multiple face features saved successfully!");
                    conn.Close();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }
        private float[][] ExtractMultipleFaceFeatures(Bitmap image)
        {
            if (faceRecognizer == null || faceDetector == null) return null;

            var imageData = image.ToFaceImage();
            FaceInfo[] faces = faceDetector.Detect(imageData);

            if (faces.Length == 0)
                return null;

            List<float[]> featuresList = new List<float[]>();

            using FaceLandmarker faceMark = new FaceLandmarker();
            foreach (var face in faces)
            {
                FaceMarkPoint[] landmarks = faceMark.Mark(imageData, face);
                if (landmarks != null && landmarks.Length > 0)
                {
                    float[] features = faceRecognizer.Extract(imageData, landmarks);
                    featuresList.Add(features);
                }
            }

            return featuresList.ToArray();
        }
        private byte[] FloatArrayToByteArray(float[] floatArray)
        {
            byte[] byteArray = new byte[floatArray.Length * sizeof(float)];
            Buffer.BlockCopy(floatArray, 0, byteArray, 0, byteArray.Length);
            return byteArray;
        }
        private void LoadUserData()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserId, UserName, Gender, Age FROM Users";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }
        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is selected
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];

                row.Selected = true;

                dataGrid.CurrentCell = row.Cells[0];

                MessageBox.Show($"Row {e.RowIndex + 1} selected.");
            }
        }
        private void DeleteUserFromDatabase(int userId)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Users WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

    }
}

   
