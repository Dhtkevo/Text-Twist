using KevinMaduProject2.Model;
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

            var roundCounter = 1;

            foreach( Round round in _rounds )
            {
                highScoreTxtbox.Text += $"Round: {roundCounter} - {round.ToString()}{Environment.NewLine}";
                roundCounter++;
            }
        }


    }
}
