namespace SnakeGame.Game.Entities
{
    internal class Snake
    {
        private readonly List<Snake> _segments = new();
        private readonly Image _image;
        private const int _size = 20;
        public int X { get; set; }
        public int Y { get; set; }

        public Snake(int x, int y)
        {
            _image = Image.FromFile(@"Utility/PNG/Snake.png");
            X = x;
            Y = y;
        }

        public List<Snake> List() => _segments;
        public int Size => _size;
        public Image Image => _image;
        public void MoveUp() => Y--;
        public void MoveDown() => Y++;
        public void MoveLeft() => X--;
        public void MoveRight() => X++;
    }
}
