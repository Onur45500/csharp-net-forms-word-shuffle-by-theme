namespace csharp_net_forms_word_shuffle_by_theme
{
    public partial class Themes : Form
    {
        public Themes()
        {
            InitializeComponent();
        }

        private void Animals_Click(object sender, EventArgs e)
        {
            Animals form = new Animals();
            form.Show();
        }

        private void Cars_Click(object sender, EventArgs e)
        {
            Cars form = new Cars();
            form.Show();
        }

        private void Trees_Click(object sender, EventArgs e)
        {
            Trees form = new Trees();
            form.Show();
        }

        private void Plants_Click(object sender, EventArgs e)
        {
            Plants form = new Plants();
            form.Show();
        }

        private void Astronomy_Click(object sender, EventArgs e)
        {
            Astronomy form = new Astronomy();
            form.Show();
        }

        private void Body_Click(object sender, EventArgs e)
        {
            Body form = new Body();
            form.Show();
        }
    }
}
