using KevinMaduProject2.Model;
using KevinMaduProject2.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.Design.AxImporter;

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

        private void resetHighScoreBoardBtn_Click(object sender, EventArgs e)
        {
            _rounds.Clear();
            highScoreTxtbox.Text = "";
            PopulateBoard();
        }

        private void exportStatsBtn_Click(object sender, EventArgs e)
        {
            public void ExportCsv()
            {
                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.Title = "Export as CSV";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        using (StreamWriter writer = new StreamWriter(myStream, Encoding.UTF8))
                        {
                            writer.WriteLine("Text,Time Entered, Points");
                            foreach (var round in _rounds)
                            {
                                foreach (var word in round.ValidWords)
                                {
                                    writer.WriteLine("Anonymous Attempt - " + word.ToString());
                                }
                                
                            }
                        }

                        myStream.Close();
                    }
                }
            }
        }
    }
}
