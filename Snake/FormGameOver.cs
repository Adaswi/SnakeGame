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
            FormProvider._gameplayForm.DialogResult = DialogResult.Cancel;
            FormProvider._gameplayForm.Close();
        }

        private void GameOverInput_TextChanged(object sender, EventArgs e)
        {
            input = GameOverInput.Text.ToString();
        }

        private void GameOver_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {

            }
            else
            {
                Leaderboard.Temp = 0;
                Leaderboard.Player = null;
                Application.Exit();
            }
        }
    }
}
