namespace csharp_net_forms_word_shuffle_by_theme
{
    partial class Trees
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
            lblGuessed = new Label();
            lblCounter = new Label();
            lblWord = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F);
            Title.Location = new Point(343, 9);
            Title.Name = "Title";
            Title.Size = new Size(97, 46);
            Title.TabIndex = 0;
            Title.Text = "Trees";
            // 
            // lblGuessed
            // 
            lblGuessed.AutoSize = true;
            lblGuessed.Font = new Font("Segoe UI", 12F);
            lblGuessed.Location = new Point(495, 208);
            lblGuessed.Name = "lblGuessed";
            lblGuessed.Size = new Size(65, 28);
            lblGuessed.TabIndex = 10;
            lblGuessed.Text = "label1";
            // 
            // lblCounter
            // 
            lblCounter.AutoSize = true;
            lblCounter.CausesValidation = false;
            lblCounter.Font = new Font("Segoe UI", 12F);
            lblCounter.Location = new Point(315, 288);
            lblCounter.Name = "lblCounter";
            lblCounter.Size = new Size(65, 28);
            lblCounter.TabIndex = 9;
            lblCounter.Text = "label1";
            // 
            // lblWord
            // 
            lblWord.AutoSize = true;
            lblWord.Font = new Font("Segoe UI", 12F);
            lblWord.Location = new Point(315, 135);
            lblWord.Name = "lblWord";
            lblWord.Size = new Size(65, 28);
            lblWord.TabIndex = 8;
            lblWord.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(241, 198);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(215, 43);
            textBox1.TabIndex = 7;
            // 
            // Trees
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGuessed);
            Controls.Add(lblCounter);
            Controls.Add(lblWord);
            Controls.Add(textBox1);
            Controls.Add(Title);
            Name = "Trees";
            Text = "Trees";
            KeyPress += KeyIsPressed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblGuessed;
        private Label lblCounter;
        private Label lblWord;
        private TextBox textBox1;
    }
}