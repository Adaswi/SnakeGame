namespace Snake
{
    internal class NotSnake : Object
    {
        public NotSnake()
        {
            X = 0;
            Y = 0;
        }
        public void ObstPrevent(int maxWidth, int maxHeight, Random rand)
        {
            while (this.X == maxWidth / 2 && this.Y == maxHeight / 2)
            {
                X = rand.Next(1, maxWidth);
                Y = rand.Next(1, maxHeight);
            }
        }
    }
}
