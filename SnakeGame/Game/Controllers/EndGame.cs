using SnakeGame.Game.Entities;
using SnakeGame.Game.Views;

namespace SnakeGame.Game.Controllers
{
    internal class EndGame
    {
        private readonly Snake _snake;
        private readonly GameScreen _gameScreen;

        public EndGame(Snake snake, GameScreen gameScreen)
        {
            _snake = snake;
            _gameScreen = gameScreen;
        }

        public void End()
        {
            if (CheckingCollisionWithTheSnakeBody() || CheckingCollisionWithTheMap())
            {
                _gameScreen.Close();
            }

        }

        private bool CheckingCollisionWithTheSnakeBody()
        {
            var list = _snake.List();
            for (int i = 1; i < list.Count; i++)
            {
                if (list[0].X == list[i].X && list[0].Y == list[i].Y)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckingCollisionWithTheMap()
        {
            var list = _snake.List();
            if (list[0].X < 0 || list[0].X > GameScreen.MapWidth ||
                list[0].Y < 0 || list[0].Y > GameScreen.MapHeight)
            {
                return true;
            }
            return false;
        }
    }
}
