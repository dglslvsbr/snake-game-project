using SnakeGame.Game.Controllers;
using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Views
{
    public partial class GameScreen : Form
    { 
        private readonly Snake _snake;
        private readonly Movement _movement;
        private readonly AutomaticMovement _automaticMovement;
        private readonly Food _food;
        private readonly GenerateFood _generateFood;
        private readonly System.Windows.Forms.Timer _timer;

        public GameScreen()
        {
            InitializeComponent();
            _snake = new(10, 10);
            _snake.List().Add(_snake);
            _movement = new();
            _automaticMovement = new(_snake, _movement);
            _food = new(200, 200);
            _generateFood = new(_snake, _food, CountFood);
            _timer = new()
            {
                Interval = 10
            };
            _timer.Tick += Time;
            _timer.Start();

            Eventos();
        }
        private void Eventos()
        {
            Map.Paint += DrawOnScreen;
            Map.KeyDown += _movement.Move;
        }

        private void DrawOnScreen(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(_food.Image, _food.X, _food.Y, Food.Size, Food.Size);
            foreach (var seg in _snake.List())
            {
                e.Graphics.FillRectangle(Brushes.Green, seg.X, seg.Y, Snake.Size, Snake.Size);
            }
        
        }

        private void Time(object sender, EventArgs e)
        {
            Map.Invalidate();
            Map.Focus();
            _automaticMovement.MoveAutomatically();
            _generateFood.Generate();
        }
    }
}
