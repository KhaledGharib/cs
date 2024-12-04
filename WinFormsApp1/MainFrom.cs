using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MainFrom : Form
    {
        private int _userId;
        private string _userName;
        public MainFrom(int userId, string userName)
        {
            InitializeComponent();
            _userId = userId;
            _userName = userName;
        }
        private void MainFrom_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {_userName}!";
            LoadTasks();
        }
        private void LoadTasks()
        {
            dataGridViewTasks.Rows.Clear();

            try
            {
                using (var conn = new SQLiteConnection("Data Source=TaskOrganizer.db;Version=3;"))
                {
                    conn.Open();

                    string query = "SELECT TaskID, TaskDescription, IsCompleted FROM Tasks WHERE UserID = @UserID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int taskId = reader.GetInt32(0);
                                string taskDescription = reader.GetString(1);
                                bool isCompleted = reader.GetBoolean(2);

                                // Add rows to DataGridView
                                dataGridViewTasks.Rows.Add(taskId, taskDescription, isCompleted ? "Yes" : "No");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string newTaskDescription = Prompt.ShowDialog("Enter Task Description:", "Add Task");
            if (string.IsNullOrEmpty(newTaskDescription)) return;

            try
            {
                using (var conn = new SQLiteConnection("Data Source=TaskOrganizer.db;Version=3;"))
                {
                    conn.Open();

                    string query = "INSERT INTO Tasks (UserID, TaskDescription, IsCompleted) VALUES (@UserID, @TaskDescription, 0)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", _userId);
                        cmd.Parameters.AddWithValue("@TaskDescription", newTaskDescription);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0) return;

            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);
            string currentDescription = dataGridViewTasks.SelectedRows[0].Cells[1].Value.ToString();

            string newDescription = Prompt.ShowDialog("Edit Task Description:", "Edit Task", currentDescription);
            if (string.IsNullOrEmpty(newDescription)) return;

            try
            {
                using (var conn = new SQLiteConnection("Data Source=TaskOrganizer.db;Version=3;"))
                {
                    conn.Open();

                    string query = "UPDATE Tasks SET TaskDescription = @TaskDescription WHERE TaskID = @TaskID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskDescription", newDescription);
                        cmd.Parameters.AddWithValue("@TaskID", taskId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.SelectedRows.Count == 0) return;

            int taskId = Convert.ToInt32(dataGridViewTasks.SelectedRows[0].Cells[0].Value);

            try
            {
                using (var conn = new SQLiteConnection("Data Source=TaskOrganizer.db;Version=3;"))
                {
                    conn.Open();

                    string query = "DELETE FROM Tasks WHERE TaskID = @TaskID";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", taskId);
                        cmd.ExecuteNonQuery();
                    }
                }

                LoadTasks();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }



    }
}
