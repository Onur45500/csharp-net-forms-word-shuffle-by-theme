﻿namespace csharp_net_forms_word_shuffle_by_theme
{
    partial class Animals
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
            Title = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F);
            Title.Location = new Point(333, 9);
            Title.Name = "Title";
            Title.Size = new Size(137, 46);
            Title.TabIndex = 1;
            Title.Text = "Animals";
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Name = "Animals";
            Text = "Animals";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
    }
}