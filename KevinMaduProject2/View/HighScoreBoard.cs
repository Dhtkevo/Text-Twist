using KevinMaduProject2.Model;
using KevinMaduProject2.Utilities;

namespace KevinMaduProject2.View
{
    /// <summary>
    /// Round board class
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class HighScoreBoard : Form
    {
        private List<Round> _rounds;

        /// <summary>
        /// Initializes a new instance of the <see cref="HighScoreBoard"/> class.
        /// </summary>
        /// <param name="list">The list.</param>
        /// <exception cref="System.ArgumentException">Null Round</exception>
        public HighScoreBoard(List<Round> list)
        {
            if (list == null) throw new ArgumentException("Null Round");

            InitializeComponent();

            _rounds = list;

            PopulateBoard();

            DisableExportButton();
        }

        private void DisableExportButton()
        {
            if (_rounds.Count > 0)
            {
                exportStatsBtn.Enabled = true;
            } else
            {
                exportStatsBtn.Enabled = false;
            }
        }



        private void PopulateBoard()
        {
            var roundCounter = 1;

            foreach (Round round in _rounds)
            {
                highScoreTxtbox.Text += $"{roundCounter}. Anonymous Attempt - {round.ToString()}{Environment.NewLine}";
                roundCounter++;
            }
        }

        private void sortByOverallScoreBtn_Click(object sender, EventArgs e)
        {
            _rounds.Sort();
            highScoreTxtbox.Text = "";
            PopulateBoard();
        }

        private void sortTimeandScoreBtn_Click(object sender, EventArgs e)
        {
            _rounds.Sort(new ScoreTimeDescendingOrder());
            highScoreTxtbox.Text = "";
            PopulateBoard();
        }

        private void resetHighScoreBoardBtn_Click(object sender, EventArgs e)
        {
            _rounds.Clear();
            highScoreTxtbox.Text = "";
            PopulateBoard();
            DisableExportButton();
        }

        private void exportStatsBtn_Click(object sender, EventArgs e)
        {
            new DataExporter(_rounds).ExportCsv();
        }
    }
}
