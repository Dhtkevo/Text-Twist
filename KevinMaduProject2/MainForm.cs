using KevinMaduProject2.Driver;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {

        private TextTwist _textTwist;
        private List<char> _randomLetters;
        public MainForm()
        {
            InitializeComponent();

            _textTwist = new TextTwist();
            _randomLetters = _textTwist.RandomLetters;

            // Make text of each button corresponding random letter
            PopulateLetterButtons();
        }

        private void PopulateLetterButtons()
        {
            letterBtn1.Text = _randomLetters[0].ToString();
            letterBtn2.Text = _randomLetters[1].ToString();
            letterBtn3.Text = _randomLetters[2].ToString();
            letterBtn4.Text = _randomLetters[3].ToString();
            letterBtn5.Text = _randomLetters[4].ToString();
            letterBtn6.Text = _randomLetters[5].ToString();
            letterBtn7.Text = _randomLetters[6].ToString();
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