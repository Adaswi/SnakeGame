using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class GameOver : Form
    {
        string input;

        public GameOver()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            Leaderboard.Player = input;
            Leaderboard.SaveScore();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            if (Gameplay.ActiveForm != null)
            {
                Gameplay.ActiveForm.DialogResult = DialogResult.Cancel;
                Gameplay.ActiveForm.Close();
            }
            else
            {
                GameOver gameover = new GameOver();
                gameover.Show();
            }
        }

        private void GameOverInput_TextChanged(object sender, EventArgs e)
        {
            input = GameOverInput.Text.ToString();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.Cancel)
            {
                Leaderboard.Temp = 0;
                Leaderboard.Player = null;
                Application.Exit();
            }
        }
    }
}
