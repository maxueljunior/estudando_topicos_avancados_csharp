﻿namespace Grapichs_Interface
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
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(22, 24);
            button1.Name = "button1";
            button1.Size = new Size(205, 102);
            button1.TabIndex = 0;
            button1.Text = "OpenFileDialog";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.InitialDirectory = "C:";
            // 
            // button2
            // 
            button2.Location = new Point(22, 132);
            button2.Name = "button2";
            button2.Size = new Size(205, 92);
            button2.TabIndex = 1;
            button2.Text = "FolderBrowserDialog";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 555);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button2;
    }
}