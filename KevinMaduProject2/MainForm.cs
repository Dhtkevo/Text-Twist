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
            if (letterBtn1.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn1.Text;
            } 

            letterBtn1.Enabled = false;
        }

        private void letterBtn2_Click(object sender, EventArgs e)
        {
            if (letterBtn2.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn2.Text;
            }

            letterBtn2.Enabled = false;
        }

        private void letterBtn3_Click(object sender, EventArgs e)
        {
            if (letterBtn3.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn3.Text;
            }

            letterBtn3.Enabled = false;
        }

        private void letterBtn4_Click(object sender, EventArgs e)
        {
            if (letterBtn4.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn4.Text;
            }

            letterBtn4.Enabled = false;
        }

        private void letterBtn5_Click(object sender, EventArgs e)
        {
            if (letterBtn5.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn5.Text;
            }

            letterBtn5.Enabled = false;
        }

        private void letterBtn6_Click(object sender, EventArgs e)
        {
            if (letterBtn6.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn6.Text;
            }

            letterBtn6.Enabled = false;
        }

        private void letterBtn7_Click(object sender, EventArgs e)
        {
            if (letterBtn7.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn7.Text;
            }

            letterBtn7.Enabled = false;
        }
    }
}