using SnakeGame.Game.Entities;

namespace SnakeGame.Game.Views
{
    public partial class GameScreen : Form
    { 
        private readonly Snake _snake;
        public GameScreen()
        {
            InitializeComponent();
            Eventos();
            _snake = new(10, 10);
            _snake.List().Add(_snake);

        }
        private void Eventos()
        {
            Map.Paint += DrawOnScreen;
        }

        private void DrawOnScreen(object sender, PaintEventArgs e)
        {
            foreach (var seg in _snake.List())
            {
                e.Graphics.DrawImage(seg.Image, seg.X, seg.Y, seg.Size, seg.Size);
            }
        
        }
    }
}
