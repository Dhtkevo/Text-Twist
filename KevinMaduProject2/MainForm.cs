using KevinMaduProject2.Driver;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var t = new TextTwist();
            for (var i = 0; i < t.RandomLetters.Count; i++)
            {
                displayTxtbox.Text += $"{i}.{t.RandomLetters[i]}{Environment.NewLine}";
            }
        }

        private void letterBtn1_Click(object sender, EventArgs e)
        {
            letterBtn1.Enabled = false;
        }

        private void letterBtn2_Click(object sender, EventArgs e)
        {
            letterBtn2.Enabled = false;
        }

        private void letterBtn3_Click(object sender, EventArgs e)
        {
            letterBtn3.Enabled = false;
        }

        private void letterBtn4_Click(object sender, EventArgs e)
        {
            letterBtn4.Enabled = false;
        }

        private void letterBtn5_Click(object sender, EventArgs e)
        {
            letterBtn5.Enabled = false;
        }

        private void letterBtn6_Click(object sender, EventArgs e)
        {
            letterBtn6.Enabled = false;
        }

        private void letterBtn7_Click(object sender, EventArgs e)
        {
            letterBtn7.Enabled = false;
        }
    }
}