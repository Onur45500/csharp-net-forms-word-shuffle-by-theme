using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csharp_net_forms_word_shuffle_by_theme
{
    public partial class Astronomy : Form
    {
        int i = 0;
        int guessed = 0;
        string newText;
        List<string> words = new List<string>();

        public Astronomy()
        {
            InitializeComponent();
            KeyPreview = true;
            Setup();

        }

        public void Setup()
        {
            words = File.ReadLines("Cars.txt").ToList();
            newText = Scramble(words[i]);
            lblWord.Text = newText;
            lblCounter.Text = "Words : " + (i + 1) + "of " + words.Count();
            guessed = 0;
            lblGuessed.Text = "Guessed times : " + guessed;
        }

        public string Scramble(string word)
        {
            return new string(word.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray());
        }

        private void KeyIsPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (words[i].ToLower() == textBox1.Text.ToLower())
                {
                    if (i < words.Count - 1)
                    {
                        MessageBox.Show("Correct !", "Message:");
                        textBox1.Text = "";
                        i += 1;
                        newText = Scramble(words[i]);
                        lblWord.Text = newText;
                        lblCounter.Text = "Words :" + (i + 1) + " of " + words.Count;
                        guessed = 0;
                        lblGuessed.Text = "Guessed times : " + guessed;
                    }
                }
                else
                {
                    guessed += 1;
                    lblGuessed.Text = "Guessed times : " + guessed;
                }
            }
        }
    }
}
