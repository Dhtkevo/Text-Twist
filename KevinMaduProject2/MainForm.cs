using KevinMaduProject2.Driver;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var t = new TextTwist();
            for (var i = 0; i < t.RandomLetters.Count; i++)
            {
                displayTxtbox.Text += $"{i}.{t.RandomLetters[i]}{Environment.NewLine}";
            }
        }
    }
}