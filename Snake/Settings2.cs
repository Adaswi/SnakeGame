using System.Text;

namespace Snake
{
    internal class Settings2
    {

        public static int Width, Height, Velocity;

        public static string Directions, styl, rozmiary, predkosc, typ;

        public static bool Obstacles, GameplayType;

        public static Brush HeadColor, FoodColor, BodyColor, ObstacleColor;

        public static Color BackgroundColor;



        public static void LoadSettings2()
        {
            if (!File.Exists("SnakeGameSettings.cfg"))
                LoadDefaultSettings();


            string[] lines = File.ReadAllLines("SnakeGameSettings.cfg");

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var keyValue = line.Split('=');
                if (keyValue.Length != 2)
                    continue;
                switch (keyValue[0])
                {
                    case "Wyglad":
                        {
                            styl = keyValue[1];
                            if (styl == "Styl 1")
                            {
                                HeadColor = new SolidBrush(Color.FromArgb(113, 255, 113));
                                BodyColor = new SolidBrush(Color.FromArgb(113, 255, 113));
                                FoodColor = new SolidBrush(Color.FromArgb(255, 78, 78));
                                ObstacleColor = new SolidBrush(Color.FromArgb(65, 105, 225));
                                BackgroundColor = Color.FromArgb(128, 128, 255);
                            }
                            else if (styl == "Styl 2")
                            {
                                HeadColor = new SolidBrush(Color.FromArgb(188, 201, 102));
                                BodyColor = new SolidBrush(Color.FromArgb(149, 119, 81));
                                FoodColor = new SolidBrush(Color.FromArgb(135, 164, 106));
                                ObstacleColor = new SolidBrush(Color.FromArgb(184, 184, 184));
                                BackgroundColor = Color.FromArgb(254, 254, 184);
                            }
                            else
                            {
                                HeadColor = new SolidBrush(Color.FromArgb(113, 255, 113));
                                BodyColor = new SolidBrush(Color.FromArgb(113, 255, 113));
                                FoodColor = new SolidBrush(Color.FromArgb(255, 78, 78));
                                ObstacleColor = new SolidBrush(Color.FromArgb(65, 105, 225));
                                BackgroundColor = Color.FromArgb(128, 128, 255);
                            }
                        }
                        break;

                    case "RozmiarMapy":
                        {
                            rozmiary = keyValue[1];
                            if (rozmiary == "20x20")
                            {
                                Width = 35;
                                Height = 35;
                            }
                            else if (rozmiary == "50x50")
                            {
                                Width = 14;
                                Height = 14;
                            }
                            else if (rozmiary == "100x100")
                            {
                                Width = 7;
                                Height = 7;
                            }
                            else
                            {
                                Width = 35;
                                Height = 35;
                            }
                        }
                        break;

                    case "Przeszkody":
                        {
                            var przeszkody = keyValue[1];
                            if (przeszkody == "True" || przeszkody == "False")
                                Obstacles = bool.Parse(przeszkody);
                            else
                                Obstacles = false;
                        }
                        break;

                    case "PredkoscWeza":
                        {
                            predkosc = keyValue[1];
                            if (predkosc == "1")
                                Velocity = 100;
                            else if
                                (predkosc == "2")
                                Velocity = 80;
                            else if (predkosc == "3")
                                Velocity = 60;
                            else
                                Velocity = 100;

                        }
                        break;

                    case "TypGry":
                        {
                            typ = keyValue[1];
                            if (typ == "Glob")
                                GameplayType = true;
                            else if (typ == "Pokój")
                                GameplayType = false;
                            else
                                GameplayType = true;
                        }
                        break;
                }
            }
        }

        public static void LoadDefaultSettings()
        {
            string fullPath = Path.GetFullPath(@"SnakeGameSettings.cfg");

            using (FileStream fs = File.Create(fullPath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes(
                    "Wyglad=Styl 1\n" +
                    "RozmiarMapy=20x20\n" +
                    "Przeszkody=false\n" +
                    "PredkoscWeza=1\n" +
                    "TypGry=Glob\n");
                fs.Write(info, 0, info.Length);
            }

        }

        public static void SaveSettings()
        {
            File.WriteAllLines("SnakeGameSettings.cfg", new string[]
            {
                $"Wyglad={styl}\n" +
                $"RozmiarMapy={rozmiary}\n" +
                $"Przeszkody={Obstacles}\n" +
                $"PredkoscWeza={predkosc}\n" +
                $"TypGry={typ}\n"
            });
        }


    }
}
