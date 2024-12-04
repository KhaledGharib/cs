namespace WinFormsApp1
{
    partial class PromptForm
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
            btnOk = new Button();
            lblMessage = new Label();
            lblError = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(263, 352);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(150, 46);
            btnOk.TabIndex = 0;
            btnOk.Text = "button1";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(147, 132);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(78, 32);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "label1";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(155, 186);
            lblError.Name = "lblError";
            lblError.Size = new Size(64, 32);
            lblError.TabIndex = 2;
            lblError.Text = "Error";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(239, 264);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(200, 39);
            txtInput.TabIndex = 3;
            // 
            // PromptForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(lblError);
            Controls.Add(lblMessage);
            Controls.Add(btnOk);
            Name = "PromptForm";
            Text = "PromptForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOk;
        private Label lblMessage;
        private Label lblError;
        private TextBox txtInput;
    }
}