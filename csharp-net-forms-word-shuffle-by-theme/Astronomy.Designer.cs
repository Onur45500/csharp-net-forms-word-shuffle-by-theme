namespace csharp_net_forms_word_shuffle_by_theme
{
    partial class Astronomy
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
            Title.Location = new Point(292, 9);
            Title.Name = "Title";
            Title.Size = new Size(184, 46);
            Title.TabIndex = 2;
            Title.Text = "Astronomy";
            // 
            // Astronomy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Title);
            Name = "Astronomy";
            Text = "Astronomy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
    }
}