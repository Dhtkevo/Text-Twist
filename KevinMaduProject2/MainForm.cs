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

            // Disable submit button when application is first launched
            submitWordBtn.Enabled = false;
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

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn2_Click(object sender, EventArgs e)
        {
            if (letterBtn2.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn2.Text;
            }

            letterBtn2.Enabled = false;

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn3_Click(object sender, EventArgs e)
        {
            if (letterBtn3.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn3.Text;
            }

            letterBtn3.Enabled = false;

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn4_Click(object sender, EventArgs e)
        {
            if (letterBtn4.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn4.Text;
            }

            letterBtn4.Enabled = false;

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn5_Click(object sender, EventArgs e)
        {
            if (letterBtn5.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn5.Text;
            }

            letterBtn5.Enabled = false;

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn6_Click(object sender, EventArgs e)
        {
            if (letterBtn6.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn6.Text;
            }

            letterBtn6.Enabled = false;

            CheckWordAtleastThreeCharacters();

        }

        private void letterBtn7_Click(object sender, EventArgs e)
        {
            if (letterBtn7.Enabled == true)
            {
                userWordTxtbox.Text += letterBtn7.Text;
            }

            letterBtn7.Enabled = false;

            CheckWordAtleastThreeCharacters();
        }

        private void CheckWordAtleastThreeCharacters()
        {
            if (userWordTxtbox.Text.Length >= 3)
            {
                submitWordBtn.Enabled = true;
            }
        }

        private void submitWordBtn_Click(object sender, EventArgs e)
        {
            // If textbox not empty, add word to display
            // enable all random letter buttons
            // disable submit button after submitting word
            
            displayTxtbox.Text += $"{userWordTxtbox.Text} {Environment.NewLine}";
            userWordTxtbox.Text = "";
            submitWordBtn.Enabled = false;

            EnableRandomLetterButtons();
        }

        private void EnableRandomLetterButtons()
        {
            letterBtn1.Enabled = true;
            letterBtn2.Enabled = true;
            letterBtn3.Enabled = true;
            letterBtn4.Enabled = true;
            letterBtn5.Enabled = true;
            letterBtn6.Enabled = true;
            letterBtn7.Enabled = true;
        }
    }
}