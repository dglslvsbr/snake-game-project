namespace SnakeGame.Game.Entities
{
    internal class AutomaticMovement
    {
        private readonly Snake _snake;
        private readonly Movement _movement;

        public AutomaticMovement(Snake snake, Movement movement)
        {
            _movement = movement;
            _snake = snake;
        }

        public void MoveAutomatically()
        {
            switch (_movement.Direction)
            {
                case 'W':
                    _snake.MoveUp();
                    break;
                case 'S':
                    _snake.MoveDown();
                    break;
                case 'A':
                    _snake.MoveLeft();
                    break;
                case 'D':
                    _snake.MoveRight();
                    break;
            }
        }
    }
}
