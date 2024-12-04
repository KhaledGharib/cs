namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlAuth = new TabControl();
            tabPageSignIn = new TabPage();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnSignIn = new Button();
            tabPageSignUp = new TabPage();
            btnSignUp = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabControlAuth.SuspendLayout();
            tabPageSignIn.SuspendLayout();
            tabPageSignUp.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAuth
            // 
            tabControlAuth.Controls.Add(tabPageSignIn);
            tabControlAuth.Controls.Add(tabPageSignUp);
            tabControlAuth.Location = new Point(3, 2);
            tabControlAuth.Name = "tabControlAuth";
            tabControlAuth.SelectedIndex = 0;
            tabControlAuth.Size = new Size(773, 436);
            tabControlAuth.TabIndex = 0;
            // 
            // tabPageSignIn
            // 
            tabPageSignIn.Controls.Add(label2);
            tabPageSignIn.Controls.Add(label1);
            tabPageSignIn.Controls.Add(textBox2);
            tabPageSignIn.Controls.Add(textBox1);
            tabPageSignIn.Controls.Add(btnSignIn);
            tabPageSignIn.Location = new Point(8, 46);
            tabPageSignIn.Name = "tabPageSignIn";
            tabPageSignIn.Padding = new Padding(3);
            tabPageSignIn.Size = new Size(757, 382);
            tabPageSignIn.TabIndex = 0;
            tabPageSignIn.Text = "Sign in";
            tabPageSignIn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 145);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 60);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(246, 138);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(238, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 1;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(258, 256);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(150, 46);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign in";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // tabPageSignUp
            // 
            tabPageSignUp.Controls.Add(btnSignUp);
            tabPageSignUp.Controls.Add(textBox4);
            tabPageSignUp.Controls.Add(textBox3);
            tabPageSignUp.Controls.Add(label4);
            tabPageSignUp.Controls.Add(label3);
            tabPageSignUp.Location = new Point(8, 46);
            tabPageSignUp.Name = "tabPageSignUp";
            tabPageSignUp.Padding = new Padding(3);
            tabPageSignUp.Size = new Size(757, 382);
            tabPageSignUp.TabIndex = 1;
            tabPageSignUp.Text = "Sign up";
            tabPageSignUp.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(294, 258);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(150, 46);
            btnSignUp.TabIndex = 4;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(270, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(270, 80);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 163);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 76);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 0;
            label3.Text = "Username";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlAuth);
            MaximumSize = new Size(826, 521);
            MinimumSize = new Size(826, 521);
            Name = "Form1";
            Text = "Form1";
            tabControlAuth.ResumeLayout(false);
            tabPageSignIn.ResumeLayout(false);
            tabPageSignIn.PerformLayout();
            tabPageSignUp.ResumeLayout(false);
            tabPageSignUp.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAuth;
        private TabPage tabPageSignIn;
        private TabPage tabPageSignUp;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSignIn;
        private Button btnSignUp;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
    }
}
