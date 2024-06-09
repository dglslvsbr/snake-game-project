namespace SnakeGame.Game.Entities
{
    internal class Food
    {
        private readonly Image _image;
        private const int _size = 20;
        public int X { get; set; }
        public int Y { get; set; }

        public Food(int x, int y)
        {
            _image = Image.FromFile(@"Utility/Ico/32xApple.ico");
            X = x;
            Y = y;
        }

        public Image Image => _image;
        public static int Size => _size;
    }
}
