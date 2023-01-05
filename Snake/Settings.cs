using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                                HeadColor = new SolidBrush(Color.FromArgb(192, 255, 192));
                                BodyColor = new SolidBrush(Color.FromArgb(192, 255, 192));
                                FoodColor = new SolidBrush(Color.FromArgb(255, 128, 128));
                                ObstacleColor = new SolidBrush(Color.FromArgb(128, 128, 128));
                                BackgroundColor = Color.FromArgb(128, 128, 255);
                            }
                            else if (styl == "Styl 2")
                            {
                                HeadColor = new SolidBrush(Color.FromArgb(153, 153, 0));
                                BodyColor = new SolidBrush(Color.FromArgb(110, 77, 34));
                                FoodColor = new SolidBrush(Color.FromArgb(153, 255, 51));
                                ObstacleColor = new SolidBrush(Color.FromArgb(160, 160, 160));
                                BackgroundColor = Color.FromArgb(255,255,153);
                            }
                            else
                            {
                                HeadColor = new SolidBrush(Color.FromArgb(192, 255, 192));
                                BodyColor = new SolidBrush(Color.FromArgb(192, 255, 192));
                                FoodColor = new SolidBrush(Color.FromArgb(255, 128, 128));
                                ObstacleColor = new SolidBrush(Color.FromArgb(128, 128, 128));
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
