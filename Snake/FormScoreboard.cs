namespace Snake
{
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();

            Leaderboard.LoadingScores();
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 0:
                        if (Leaderboard.PlayerScore.Length > 1)
                            LeaderboardFirst.Text = "1. " + Leaderboard.PlayerName[0] + " - " + Leaderboard.PlayerScore[0].ToString();
                        else
                            LeaderboardFirst.Text = " ";
                        break;

                    case 1:
                        if (Leaderboard.PlayerScore.Length > 2)
                            LeaderboardSecond.Text = "2. " + Leaderboard.PlayerName[1] + " - " + Leaderboard.PlayerScore[1].ToString();
                        else
                            LeaderboardSecond.Text = " ";
                        break;

                    case 2:
                        if (Leaderboard.PlayerScore.Length > 3)
                            LeaderboardThird.Text = "3. " + Leaderboard.PlayerName[2] + " - " + Leaderboard.PlayerScore[2].ToString();
                        else
                            LeaderboardThird.Text = " ";
                        break;

                    case 3:
                        if (Leaderboard.PlayerScore.Length > 4)
                            LeaderboardFourth.Text = "4. " + Leaderboard.PlayerName[3] + " - " + Leaderboard.PlayerScore[3].ToString();
                        else
                            LeaderboardFourth.Text = " ";
                        break;

                    case 4:
                        if (Leaderboard.PlayerScore.Length > 5)
                            LeaderboardFifth.Text = "5. " + Leaderboard.PlayerName[4] + " - " + Leaderboard.PlayerScore[4].ToString();
                        else
                            LeaderboardFifth.Text = " ";
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Scoreboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Leaderboard.Temp = 0;
            Leaderboard.Player = null;
            if (this.DialogResult == DialogResult.OK)
            {
                Gameplay gameplayForm = new Gameplay();
                gameplayForm.Show();
            }
            else if (this.DialogResult == DialogResult.Cancel)
            {
                FormProvider.mainmenuForm.Show();
            }
            else
                Application.Exit();
        }

    }
}
