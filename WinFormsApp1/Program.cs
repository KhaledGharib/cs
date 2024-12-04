using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the database
            DatabaseSetup.InitializeDatabase();

            // Start the application
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
