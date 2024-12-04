﻿namespace WinFormsApp1
{
    partial class MainFrom
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
            dataGridViewTasks = new DataGridView();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnAddTask = new Button();
            btnEditTask = new Button();
            btnDeleteTask = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            dataGridViewTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTasks.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewTasks.Location = new Point(280, 188);
            dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewTasks.RowHeadersWidth = 82;
            dataGridViewTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTasks.Size = new Size(724, 462);
            dataGridViewTasks.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1926, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(359, 44);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(359, 44);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 72);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(65, 152);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(150, 46);
            btnAddTask.TabIndex = 3;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnEditTask
            // 
            btnEditTask.Location = new Point(69, 240);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(150, 46);
            btnEditTask.TabIndex = 4;
            btnEditTask.Text = "Edit";
            btnEditTask.UseVisualStyleBackColor = true;
            btnEditTask.Click += btnEditTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(75, 332);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(150, 46);
            btnDeleteTask.TabIndex = 5;
            btnDeleteTask.Text = "Delete";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // Column1
            // 
            Column1.HeaderText = "Task ID:";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Task Description";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.FalseValue = "No";
            Column3.HeaderText = "Status";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.TrueValue = "Yes";
            Column3.Width = 200;
            // 
            // MainFrom
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1926, 820);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnEditTask);
            Controls.Add(btnAddTask);
            Controls.Add(label1);
            Controls.Add(dataGridViewTasks);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainFrom";
            Text = "MainFrom";
            Load += MainFrom_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTasks).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTasks;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
        private Button btnAddTask;
        private Button btnEditTask;
        private Button btnDeleteTask;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
    }
}