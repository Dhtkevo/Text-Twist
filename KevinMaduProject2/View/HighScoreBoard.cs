using KevinMaduProject2.Model;
using KevinMaduProject2.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KevinMaduProject2.View
{
    public partial class HighScoreBoard : Form
    {
        private List<Round> _rounds;
        public HighScoreBoard(List<Round> list)
        {
            InitializeComponent();

            _rounds = list;

            PopulateBoard();
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
    }
}
