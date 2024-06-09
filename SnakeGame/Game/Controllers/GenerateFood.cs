﻿using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Controllers
{
    internal class GenerateFood
    {
        private readonly Snake _snake;
        private readonly Food _food;
        private readonly Label _score;
        private const int MapWidth = 300;
        private const int MapHeight = 250;

        public GenerateFood(Snake snake, Food food, Label foods)
        {
            _snake = snake;
            _food = food;
            _score = foods;
        }

        public void Generate()
        {
            var list = _snake.List();
            Random random = new();
            int x;
            int y;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].X + 20 >= _food.X &&
                   list[0].X <= _food.X + 20 &&
                   list[0].Y + 20 >= _food.Y &&
                   list[0].Y <= _food.Y + 20)
                {
                    do
                    {
                        x = random.Next(MapWidth);
                        y = random.Next(MapHeight);
                    } while (IsPositionOnSnake(x, y));

                    IncreaseFood();
                    NewSegment();
                    _food.X = x;
                    _food.Y = y; 
                }
            }
        }

        private bool IsPositionOnSnake(int x, int y)
        {
            foreach (var seg in _snake.List())
            {
                if (seg.X == x && seg.Y == y)
                {
                    return true;
                }
            }
            return false;
        }

        private void IncreaseFood()
        {
            _snake.Placar++;
            _score.Text = _snake.Placar.ToString();
        }

        private void NewSegment()
        {
            var list = _snake.List();
            int quantity = 10;
            for (int i = 0; i < quantity; i++)
            {
                list.Add(new Snake(_snake.X, _snake.Y));
            }
            
        }
    }
}