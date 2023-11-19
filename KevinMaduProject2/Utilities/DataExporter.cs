using KevinMaduProject2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KevinMaduProject2.Utilities
{
    public class DataExporter
    {
        private List<Round> _rounds;
        public DataExporter(List<Round> rounds) {
            if (rounds == null)
            {
                throw new ArgumentException("Invalid list of rounds");
            }

            _rounds = rounds;        
        }

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
                        writer.WriteLine("Text,GameTime (Seconds),Points");
                        foreach (var round in _rounds)
                        {
                            foreach (var word in round.ValidWords)
                            {
                                writer.WriteLine($"{word.Text},{word.GameTime},{word.PointsEarned}");
                            }

                        }

                        writer.WriteLine("Text,GameTime (Seconds),Reason");
                        foreach (var round in _rounds)
                        {
                            foreach (var word in round.InvalidWords)
                            {
                                writer.WriteLine($"{word.Text},{word.GameTime},{word.Reason}");
                            }

                        }
                    }

                    myStream.Close();
                }
            }
        }
    }
}
