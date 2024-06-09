using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Controllers
{
    internal class GameDifficulty
    {
        private readonly Snake _snake;
        private readonly Label _score;
        
        public GameDifficulty(Snake snake, Label score)
        {
            _snake = snake;
            _score = score;
        }

        public void IncreasingDifficulty()
        {
            if (int.TryParse(_score.Text, out int score))
            {
                if (score >= 30)
                {
                    _snake.Speed = 3;
                }
                else if (score >= 15)
                {
                    _snake.Speed = 2;
                }
            }
        }
    }
}
