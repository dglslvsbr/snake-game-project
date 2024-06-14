using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Controllers
{
    internal class GameDifficulty
    {
        private readonly Snake _snake;
        private readonly Label _score;
        private int score;
        private int Difficulty = 5;

        public GameDifficulty(Snake snake, Label score)
        {
            _snake = snake;
            _score = score;
        }

        public void VerifyScore()
        {
            if (int.TryParse(_score.Text, out score))
            {
                IncreaseDifficulty();
            }
        }

        private void IncreaseDifficulty()
        {
            if (score > Difficulty)
            {
                AdjustingSpeed();
                Difficulty += 5;
            }
        }

        private void AdjustingSpeed()
        {
            _snake.Speed += 0.1f;
        }
    }
}
