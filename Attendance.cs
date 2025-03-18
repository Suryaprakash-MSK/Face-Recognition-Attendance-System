using AForge.Video;
using AForge.Video.DirectShow;
using SeetaFace6Sharp;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Text;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FaceRecognitionApp
{
    public partial class Attendance : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private FaceDetector faceDetector;
        private FaceRecognizer faceRecognizer;
        private FaceLandmarker faceMark;
        private FaceAntiSpoofing faceAntiSpoofing;
        private Dictionary<string, List<float[]>> storedFaceFeatures;

        public Attendance()
        {
            InitializeComponent();
            storedFaceFeatures = LoadFaceDataFromDatabase();
            faceDetector = new FaceDetector();
            faceRecognizer = new FaceRecognizer();
            faceMark = new FaceLandmarker();
            faceAntiSpoofing = new FaceAntiSpoofing();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += videoSource_NewFrame;
            btnStop.Enabled = false;
        }
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (eventArgs.Frame == null) return;

            using (var frame = (Bitmap)eventArgs.Frame.Clone())
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                var imageData = frame.ToFaceImage();
                FaceInfo[] faces = faceDetector.Detect(imageData);

                if (faces.Length > 0)
                {
                    DrawRecognizedFaces(frame, faces, imageData);
                }
                else
                {
                    pictureBox.Image = (Bitmap)frame.Clone();
                }
            }
        }
        private void DrawRecognizedFaces(Bitmap frame, FaceInfo[] faces, FaceImage imageData)
        {
            String display;
            using (var cloneFrame = (Bitmap)frame.Clone())
            using (Graphics g = Graphics.FromImage(cloneFrame))
            {
                bool userFound = false;
                int matchedUsersCount = 0;

                foreach (var face in faces)
                {
                    Rectangle faceRect = new Rectangle(face.Location.X, face.Location.Y, face.Location.Width, face.Location.Height);
                    FaceMarkPoint[] points = faceMark.Mark(imageData, face);

                    var result = faceAntiSpoofing.Predict(imageData, face, points);
                    if(result.Status ==AntiSpoofingStatus.Real)
                    {
                         display = "Real";
                    }
                    else
                    {
                        display = "Fake";
                    }

                    float[] faceFeature = faceRecognizer.Extract(imageData, points);
                    string matchedUser = CompareWithDatabase(faceFeature);
                    
                    using (Pen pen = new Pen(Color.Red, 4))
                    {
                        g.DrawRectangle(pen, faceRect);
                    }
                    using (Font font = new Font("Arial", 12, FontStyle.Bold))
                    using (SolidBrush brush = new SolidBrush(Color.Yellow))
                    {
                        string displayText = string.IsNullOrEmpty(matchedUser) ? "Unknown" : matchedUser;
                        displayText += $" - {display}";

                        if (!string.IsNullOrEmpty(matchedUser))
                        {

                            g.DrawString(displayText, font, brush, face.Location.X, face.Location.Y - 20);
                            userFound = true;
                            matchedUsersCount++;
                            if(result.Status == AntiSpoofingStatus.Real)
                            {
                                MarkAttendance(matchedUser);
                                UpdateExitTime(matchedUser);

                            }
                        }
                        else
                        {
                            g.DrawString("Unknown", font, brush, face.Location.X, face.Location.Y - 20);
                        }
                    }
                }
                using (Font font = new Font("Arial", 16, FontStyle.Bold))
                using (SolidBrush brush = new SolidBrush(Color.Red))
                {
                    g.DrawString($"Matched Users: {matchedUsersCount}", font, brush, new Point(10, 10));
                }
                pictureBox.Image = (Bitmap)cloneFrame.Clone();
            }
        }
        private string CompareWithDatabase(float[] faceFeature)
        {
            if (faceFeature == null) return null;

            string bestMatch = null;
            float highestSimilarity = 0.0f;

            foreach (var entry in storedFaceFeatures)
            {
                if (entry.Value == null || entry.Value.Count == 0) continue;

                foreach (var storedFeature in entry.Value)
                {
                    float similarity = faceRecognizer.Compare(storedFeature, faceFeature);
                    if (similarity > 0.7f && similarity > highestSimilarity)
                    {
                        highestSimilarity = similarity;
                        bestMatch = entry.Key;
                    }
                }
            }
            return bestMatch;
        }
        private Dictionary<string, List<float[]>> LoadFaceDataFromDatabase()
        {
            Dictionary<string, List<float[]>> faceData = new Dictionary<string, List<float[]>>();

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Users.UserName, UserFaceFeatures.FeatureData FROM Users INNER JOIN UserFaceFeatures ON Users.UserId = UserFaceFeatures.UserId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string username = reader.GetString(0);
                        byte[] faceBytes = reader["FeatureData"] as byte[];

                        if (faceBytes != null && faceBytes.Length % sizeof(float) == 0)
                        {
                            float[] faceFeature = ConvertBytesToFloatArray(faceBytes);
                            if (faceFeature != null)
                            {
                                if (!faceData.ContainsKey(username))
                                {
                                    faceData[username] = new List<float[]>();
                                }
                                faceData[username].Add(faceFeature);
                            }
                        }
                    }
                }
            }
            return faceData;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (videoSource != null && !videoSource.IsRunning)
            {
                videoSource.Start();
                btnStop.Enabled = true;
            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            pictureBox.Image = null;
            btnStop.Enabled = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
            this.Close();
        }
        private float[] ConvertBytesToFloatArray(byte[] byteArray)
        {
            if (byteArray == null || byteArray.Length == 0) return null;

            if (byteArray.Length % sizeof(float) != 0)
            {
                Debug.WriteLine("Error: Face feature byte array is not a valid size.");
                return null;
            }

            float[] floatArray = new float[byteArray.Length / sizeof(float)];
            Buffer.BlockCopy(byteArray, 0, floatArray, 0, byteArray.Length);
            return floatArray;
        }
        private void MarkAttendance(string userName)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get user details from the Users table
                string getUserQuery = "SELECT UserId, Gender, Age FROM Users WHERE UserName = @UserName";
                int userIdFromUsers = 0;
                string gender = "";
                int age = 0;

                using (SqlCommand cmd = new SqlCommand(getUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userIdFromUsers = reader.GetInt32(0);
                            gender = reader.GetString(1);
                            age = reader.GetInt32(2);
                        }
                    }
                }
                if (userIdFromUsers == 0) return; // User not found

                // Check if the user has already recorded attendance today
                string checkAttendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(checkAttendanceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userIdFromUsers);
                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0) return; // If the user has already recorded attendance today, do nothing
                }
                // Insert new attendance record if the user hasn't recorded attendance today
                string insertQuery = "INSERT INTO Attendance (UserId, Username, Gender, Age, EnterTime) " +
                              "VALUES (@UserId, @UserName, @Gender, @Age, CONVERT(VARCHAR(5), GETDATE(), 108))";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userIdFromUsers);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void UpdateExitTime(string userName)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raji\\source\\repos\\FaceRecognitionApp\\FaceRecognitionApp\\Database.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Get userId from Users table
                string getUserQuery = "SELECT UserId FROM Users WHERE UserName = @UserName";
                int userId = 0;

                using (SqlCommand cmd = new SqlCommand(getUserQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                        }
                    }
                }

                if (userId == 0) return; // User not found

                // Check if there is an existing attendance record for today
                string checkAttendanceQuery = "SELECT COUNT(*) FROM Attendance WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(checkAttendanceQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    int count = (int)cmd.ExecuteScalar();

                    if (count == 0) return; // No attendance record for today, so exit
                }

                // Update only the ExitTime for today
                string updateQuery = "UPDATE Attendance SET ExitTime = CONVERT(VARCHAR(5), GETDATE(), 108) WHERE UserId = @UserId AND Date = CAST(GETDATE() AS DATE)";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
