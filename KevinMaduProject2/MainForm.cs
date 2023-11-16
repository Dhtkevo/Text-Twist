using KevinMaduProject2.Driver;
using KevinMaduProject2.Utilities;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {

        private TextTwist _textTwist;

        public MainForm()
        {
            InitializeComponent();

            _textTwist = new TextTwist();

            // Set score label
            UpdateScore();

            // Make text of each button corresponding random letter
            PopulateLetterButtons();

            // Disable submit button when application is first launched
            submitWordBtn.Enabled = false;
        }

        private void UpdateScore()
        {
            scoreLbl.Text = $"Score: {_textTwist.Score}";
        }

        private void PopulateLetterButtons()
        {
            letterBtn1.Text = _textTwist.RandomLetters[0].ToString();
            letterBtn2.Text = _textTwist.RandomLetters[1].ToString();
            letterBtn3.Text = _textTwist.RandomLetters[2].ToString();
            letterBtn4.Text = _textTwist.RandomLetters[3].ToString();
            letterBtn5.Text = _textTwist.RandomLetters[4].ToString();
            letterBtn6.Text = _textTwist.RandomLetters[5].ToString();
            letterBtn7.Text = _textTwist.RandomLetters[6].ToString();
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

            var userWord = userWordTxtbox.Text;

            HandleWordFeedback(userWord);


            PopulateDisplayUserWords();

            userWordTxtbox.Text = "";
            submitWordBtn.Enabled = false;

            EnableRandomLetterButtons();
        }

        private void HandleWordFeedback(string userWord)
        {
            if (_textTwist.CheckDuplicatedWord(userWord))
            {
                duplicateWordLbl.Text = $"You already entered the word '{userWord}'";
                duplicateWordLbl.Visible = true;
                return;
            }

            if (_textTwist.CheckWordIsValid(userWord))
            {
                // Show valid label with word in it or invalid with word in it

                var points = _textTwist.DetermineWordScore(userWord);

                invalidWordLbl.Text = "";
                invalidWordLbl.Visible = false;

                validWordLbl.Text = $"{points} Points for word '{userWord}'";
                validWordLbl.Visible = true;

                duplicateWordLbl.Visible = false;

                _textTwist.UserWords.Add(userWord);

                UpdateScore();
            }
            else
            {
                validWordLbl.Text = "";
                validWordLbl.Visible = false;

                invalidWordLbl.Text = $"'{userWord}' is not a valid word!";
                invalidWordLbl.Visible = true;

                duplicateWordLbl.Visible = false;
            }
        }

        private void PopulateDisplayUserWords()
        {
            displayTxtbox.Text = "";
            foreach (string word in _textTwist.UserWords)
            {
                displayTxtbox.Text += $"{word}{Environment.NewLine}";
            }
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