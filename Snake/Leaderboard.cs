using System.Text;

namespace Snake
{
    public static class Leaderboard
    {
        public static int Temp;
        public static string Player;
        public static string[] PlayerName;
        public static int[] PlayerScore;

        public static void LoadingScores()
        {
            if (!File.Exists("SnakeGameLeaderboard.txt"))
                CreateLeaderboardFile();

            string[] lines = File.ReadAllLines("SnakeGameLeaderboard.txt");

            int index = 1;
            int empty = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                {
                    empty++;
                    continue;
                }
                var keyValue = line.Split('=');
                if (keyValue.Length != 2)
                {
                    empty++;
                    continue;
                }
            }
            PlayerName = new string[lines.Length - empty + 1];
            PlayerScore = new int[lines.Length - empty + 1];
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                {
                    continue;
                }

                var keyValue = line.Split('=');
                if (keyValue.Length != 2)
                    continue;

                PlayerName[index] = keyValue[0];
                PlayerScore[index] = int.Parse(keyValue[1]);
                index++;
            }

            Array.Sort(PlayerScore, PlayerName);
            Array.Reverse(PlayerScore);
            Array.Reverse(PlayerName);



        }




        public static void CreateLeaderboardFile()
        {
            string fullPath = Path.GetFullPath(@"SnakeGameLeaderboard.txt");

            using (FileStream fs = File.Create(fullPath))
            {
                string x;
                if (Player != null && Temp != 0)
                    x = $"{Player}={Temp}\n";
                else
                    x = "#\n";

                byte[] info = new UTF8Encoding(true).GetBytes(
                    x);
                fs.Write(info, 0, info.Length);
            }

        }

        public static void SaveScore()
        {
            if (Player != null && Temp != 0)
            {
                File.AppendAllText("SnakeGameLeaderboard.txt",
                   $"{Player}={Temp}\n");
            }
        }
    }
}
