namespace csharp_net_forms_word_shuffle_by_theme
{
    partial class Themes
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
            Animals = new Button();
            Cars = new Button();
            Trees = new Button();
            Plants = new Button();
            Astronomy = new Button();
            Body = new Button();
            SuspendLayout();
            // 
            // Animals
            // 
            Animals.Location = new Point(138, 139);
            Animals.Name = "Animals";
            Animals.Size = new Size(145, 62);
            Animals.TabIndex = 0;
            Animals.Text = "Animals";
            Animals.UseVisualStyleBackColor = true;
            Animals.Click += Animals_Click;
            // 
            // Cars
            // 
            Cars.Location = new Point(313, 139);
            Cars.Name = "Cars";
            Cars.Size = new Size(145, 62);
            Cars.TabIndex = 1;
            Cars.Text = "Cars";
            Cars.UseVisualStyleBackColor = true;
            Cars.Click += Cars_Click;
            // 
            // Trees
            // 
            Trees.Location = new Point(487, 139);
            Trees.Name = "Trees";
            Trees.Size = new Size(145, 62);
            Trees.TabIndex = 2;
            Trees.Text = "Trees";
            Trees.UseVisualStyleBackColor = true;
            Trees.Click += Trees_Click;
            // 
            // Plants
            // 
            Plants.Location = new Point(138, 233);
            Plants.Name = "Plants";
            Plants.Size = new Size(145, 62);
            Plants.TabIndex = 3;
            Plants.Text = "Plants";
            Plants.UseVisualStyleBackColor = true;
            Plants.Click += Plants_Click;
            // 
            // Astronomy
            // 
            Astronomy.Location = new Point(313, 233);
            Astronomy.Name = "Astronomy";
            Astronomy.Size = new Size(145, 62);
            Astronomy.TabIndex = 4;
            Astronomy.Text = "Astronomy";
            Astronomy.UseVisualStyleBackColor = true;
            Astronomy.Click += Astronomy_Click;
            // 
            // Body
            // 
            Body.Location = new Point(487, 233);
            Body.Name = "Body";
            Body.Size = new Size(145, 62);
            Body.TabIndex = 5;
            Body.Text = "Body";
            Body.UseVisualStyleBackColor = true;
            Body.Click += Body_Click;
            // 
            // Themes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Body);
            Controls.Add(Astronomy);
            Controls.Add(Plants);
            Controls.Add(Trees);
            Controls.Add(Cars);
            Controls.Add(Animals);
            Name = "Themes";
            Text = "c";
            ResumeLayout(false);
        }

        #endregion

        private Button Animals;
        private Button Cars;
        private Button Trees;
        private Button Plants;
        private Button Astronomy;
        private Button Body;
    }
}
