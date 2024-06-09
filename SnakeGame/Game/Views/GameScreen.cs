using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Views
{
    public partial class GameScreen : Form
    { 
        private readonly Snake _snake;
        private readonly Movement _movement;
        private readonly AutomaticMovement _automaticMovement;
        private readonly System.Windows.Forms.Timer _timer;

        public GameScreen()
        {
            InitializeComponent();
            _snake = new(10, 10);
            _snake.List().Add(_snake);
            _movement = new();
            _automaticMovement = new(_snake, _movement);

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
            foreach (var seg in _snake.List())
            {
                e.Graphics.DrawImage(seg.Image, seg.X, seg.Y, Snake.Size, Snake.Size);
            }
        
        }

        private void Time(object sender, EventArgs e)
        {
            Map.Invalidate();
            Map.Focus();
            _automaticMovement.MoveAutomatically();
        }
    }
}
