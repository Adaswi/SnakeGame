using System.Reflection.Metadata.Ecma335;

namespace Snake
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gameplay gameplayForm = new Gameplay();
            gameplayForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
            this.Hide();
        }
    }
}