namespace SnakeGame.Game.Controllers
{
    internal class Movement
    {
        private char _direction = 'D';
        public char Direction => _direction;

        public void Move(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    _direction = 'W';
                    break;
                case Keys.S:
                    _direction = 'S';
                    break;
                case Keys.A:
                    _direction = 'A';
                    break;
                case Keys.D:
                    _direction = 'D';
                    break;
            }
        }
    }
}
