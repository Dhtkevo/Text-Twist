using KevinMaduProject2.Model;
using System.Text;

namespace KevinMaduProject2.Utilities
{
    /// <summary>
    /// Class responsible for exporting files
    /// </summary>
    public class DataExporter
    {
        private List<Round> _rounds;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataExporter"/> class.
        /// </summary>
        /// <param name="rounds">The rounds.</param>
        /// <exception cref="System.ArgumentException">Invalid list of rounds</exception>
        public DataExporter(List<Round> rounds) {
            if (rounds == null)
            {
                throw new ArgumentException("Invalid list of rounds");
            }

            _rounds = rounds;        
        }

        /// <summary>
        /// Exports the stats as a CSV.
        /// </summary>
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
