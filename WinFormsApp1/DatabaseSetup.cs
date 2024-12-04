using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public static class DatabaseSetup
    {
        public static void InitializeDatabase()
        {
            string dbPath = "TaskOrganizer.db";

            // Check if the database file exists, if not create it
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                MessageBox.Show("Database created successfully.");
            }
            else
            {
                MessageBox.Show("Database already exists.");
            }

            // Create tables in the database
            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // Create Users table
                string createUsersTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Username TEXT NOT NULL UNIQUE,
                        Password TEXT NOT NULL
                    );";

                // Create Tasks table
                string createTasksTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Tasks (
                        TaskID INTEGER PRIMARY KEY AUTOINCREMENT,
                        UserID INTEGER NOT NULL,
                        TaskDescription TEXT NOT NULL,
                        IsCompleted INTEGER DEFAULT 0,
                        FOREIGN KEY (UserID) REFERENCES Users (UserID)
                    );";

                using (var cmd = new SQLiteCommand(createUsersTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = new SQLiteCommand(createTasksTableQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tables created successfully.");
            }
        }
    }
}
