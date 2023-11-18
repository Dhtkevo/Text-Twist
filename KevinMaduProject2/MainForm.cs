using KevinMaduProject2.Driver;
using KevinMaduProject2.Model;
using KevinMaduProject2.Model.Word;
using KevinMaduProject2.Utilities;
using System.Reflection.Emit;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {

        private TextTwist _textTwist;


        private Timer Timer1;


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


            Timer1 = new System.Windows.Forms.Timer();

            SetUpTimer();
        }

        private void UpdateScore()
        {
            scoreLbl.Text = $"Score: {_textTwist.Round.Score}";
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

            userWordTxtbox.Text = "";
            submitWordBtn.Enabled = false;

            EnableRandomLetterButtons();
        }

        private void HandleWordFeedback(string userWord)
        {
            var time = _textTwist.Round.Clock.TimeInSeconds;

            if (_textTwist.Round.CheckDuplicatedWord(userWord))
            {
                _textTwist.Round.AddToInvalidWords(userWord, time, InvalidWordReasons.WordAlreadyEntered);

                duplicateWordLbl.Text = $"You already entered the word '{userWord}'";
                duplicateWordLbl.Visible = true;
                return;
            }

            if (_textTwist.CheckWordIsValid(userWord))
            {
                // Show valid label with word in it or invalid with word in it

                var points = _textTwist.Round.DetermineWordScore(userWord);
                _textTwist.Round.AddToScore(points);

                invalidWordLbl.Text = "";
                invalidWordLbl.Visible = false;

                validWordLbl.Text = $"{points} Points for word '{userWord}'";
                validWordLbl.Visible = true;

                duplicateWordLbl.Visible = false;

                // _textTwist.UserWords.Add(userWord);
                _textTwist.Round.AddToValidWords(userWord, time);

                UpdateScore();
            }
            else
            {
                // Come back and update this method. Need to get clock time
                _textTwist.Round.AddToInvalidWords(userWord, time, InvalidWordReasons.NotInDictionary);

                validWordLbl.Text = "";
                validWordLbl.Visible = false;

                invalidWordLbl.Text = $"'{userWord}' is not a valid word!";
                invalidWordLbl.Visible = true;

                duplicateWordLbl.Visible = false;
            }
        }

        private void PopulateDisplayUserWords()
        {
            var position = 1;

            displayTxtbox.Text = "";
            foreach (ValidWord word in _textTwist.Round.ValidWords)
            {
                displayTxtbox.Text += $"{position}.{word.Text} - {word.GameTime}seconds - {word.PointsEarned}Points{Environment.NewLine}";
                position++;
            }

            //foreach (InvalidWord word in _textTwist.Round.InvalidWords)
            //{
            //    displayTxtbox.Text += $"{position}.{word.Text} - {word.GameTime}seconds - {word.Reason}{Environment.NewLine}";
            //    position++;
            //}
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

        private void DisableRandomLetterButtons()
        {
            letterBtn1.Enabled = false;
            letterBtn2.Enabled = false;
            letterBtn3.Enabled = false;
            letterBtn4.Enabled = false;
            letterBtn5.Enabled = false;
            letterBtn6.Enabled = false;
            letterBtn7.Enabled = false;
        }

        private void SetUpTimer()
        {
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler(Timer1_Tick);

            Timer1.Enabled = true;
        }
        private void Timer1_Tick(object Sender, EventArgs e)
        {
            if (_textTwist.Round.Clock.CheckOutOfTime())
            {
                HandleClockAtZero();
                return;
            }

            _textTwist.Round.Clock.DecrementClock();
            timerLbl.Text = $"Time Remaining: {_textTwist.Round.Clock.TimeInSeconds.ToString()} seconds";
        }

        private void HandleClockAtZero()
        {
            Timer1.Enabled = false;
            DisableRandomLetterButtons();
            PopulateDisplayUserWords();
            scoreLbl.Visible = true;
            _textTwist.SaveRoundHistory();
            MessageBox.Show("Round Over!");
        }

    }
}