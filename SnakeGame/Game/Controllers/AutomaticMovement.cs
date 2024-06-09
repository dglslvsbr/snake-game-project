using SnakeGame.Game.Controllers;

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

        private void SegmentsFollowingTheHead()
        {
            var list = _snake.List();
            for (int i = list.Count - 1; i > 0; i--)
            {
                list[i].X = list[i - 1].X;
                list[i].Y = list[i - 1].Y;
            }
        }

        public void MoveAutomatically()
        {
            SegmentsFollowingTheHead();
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
