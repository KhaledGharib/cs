using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class PromptForm : Form
    {
        public string InputText { get; private set; }
        public bool IsNumeric { get; set; }

        public PromptForm(string message, string title, string defaultValue = "", bool isNumeric = false)
        {
            InitializeComponent();

            // Set dynamic properties
            this.Text = title;
            lblMessage.Text = message;
            txtInput.Text = defaultValue;
            IsNumeric = isNumeric;
            lblError.Text = "";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(input))
            {
                lblError.Text = "Input cannot be empty.";
                return;
            }

            if (IsNumeric && !decimal.TryParse(input, out _))
            {
                lblError.Text = "Please enter a valid number.";
                return;
            }

            InputText = input;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
