namespace SnakeGame.Game.Entities
{
    internal class Snake
    {
        private readonly List<Snake> _segments = new();
        private const int _size = 10;
        private int _score;
        public int X { get; set; }
        public int Y { get; set; }

        public Snake(int x, int y)
        {
            X = x;
            Y = y;
        }

        public List<Snake> List() => _segments;
        public static int Size => _size;
        public int Placar
        {
            get => _score;
            set => _score = value;
        }
        public void MoveUp() => Y--;
        public void MoveDown() => Y++;
        public void MoveLeft() => X--;
        public void MoveRight() => X++;
    }
}
