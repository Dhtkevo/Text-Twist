using KevinMaduProject2.Driver;
using KevinMaduProject2.Model;
using KevinMaduProject2.Model.Word;
using KevinMaduProject2.Utilities;
using KevinMaduProject2.View;
using Timer = System.Windows.Forms.Timer;

namespace KevinMaduProject2
{
    /// <summary>
    /// Main Form class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        private HighScoreBoard _highScoreBoard;

        private TextTwist _textTwist;

        private Timer Timer1;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _textTwist = new TextTwist();

            UpdateScore();

            PopulateLetterButtons();

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
            letterBtn1.Text = _textTwist.Round.RandomLetters[0].ToString();
            letterBtn2.Text = _textTwist.Round.RandomLetters[1].ToString();
            letterBtn3.Text = _textTwist.Round.RandomLetters[2].ToString();
            letterBtn4.Text = _textTwist.Round.RandomLetters[3].ToString();
            letterBtn5.Text = _textTwist.Round.RandomLetters[4].ToString();
            letterBtn6.Text = _textTwist.Round.RandomLetters[5].ToString();
            letterBtn7.Text = _textTwist.Round.RandomLetters[6].ToString();
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

                invalidWordLbl.Visible = false;
                validWordLbl.Visible = false;
                return;
            }

            if (_textTwist.CheckWordIsValid(userWord))
            {

                var points = _textTwist.Round.DetermineWordScore(userWord);
                _textTwist.Round.AddToScore(points);

                invalidWordLbl.Text = "";
                invalidWordLbl.Visible = false;

                validWordLbl.Text = $"{points} Points for word '{userWord}'";
                validWordLbl.Visible = true;

                duplicateWordLbl.Visible = false;

                _textTwist.Round.AddToValidWords(userWord, time);

                UpdateScore();
            }
            else
            {
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
                displayTxtbox.Text += $"{position}.{word.Text} - Entered at {word.GameTime} seconds - {word.PointsEarned} Points{Environment.NewLine}";
                position++;
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

        private void oneMinuteMenuItem_Click(object sender, EventArgs e)
        {
            _textTwist.Round.Clock = new Clock(60);
        }

        private void twoMinutesMenuItem_Click(object sender, EventArgs e)
        {
            _textTwist.Round.Clock = new Clock(120);

        }

        private void threeMinutesMenuItem_Click(object sender, EventArgs e)
        {
            _textTwist.Round.Clock = new Clock(180);
        }

        private void twistLettersMenuItem_Click(object sender, EventArgs e)
        {
            _textTwist.Round.Twist();
            PopulateLetterButtons();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_textTwist.Round.Score > 0 && _textTwist.Round.Clock.TimeInSeconds != 0) _textTwist.SaveRoundHistory();
            _textTwist.CreateNewRound();
            scoreLbl.Visible = false;
            Timer1.Enabled = true;
            displayTxtbox.Text = "";
            userWordTxtbox.Text = "";
            EnableRandomLetterButtons();
            PopulateLetterButtons();
            UpdateScore();
            HideAllFeedbackLabels();
        }

        private void HideAllFeedbackLabels()
        {
            duplicateWordLbl.Visible = false;
            invalidWordLbl.Visible = false;
            validWordLbl.Visible = false;
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void highScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _highScoreBoard = new HighScoreBoard(_textTwist.AllRounds);
            _highScoreBoard.ShowDialog();
        }
    }
}