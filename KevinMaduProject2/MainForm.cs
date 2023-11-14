using KevinMaduProject2.Driver;

namespace KevinMaduProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var t = new TextTwist();
            for (var i = 0; i < t.letters.Count; i++)
            {
                displayTxtbox.Text += $"{i}.{t.letters[i]}{Environment.NewLine}";
            }
        }
    }
}