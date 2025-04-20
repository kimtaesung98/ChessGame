using System;
using System.Drawing;
//using System.Windows.Forms;
using ChessGame.Core; // 네임스페이스는 네가 정의한 곳에 맞게 설정

namespace ChessGame
{
    public partial class MainForm : Form
    {
        private const int TileSize = 80;
        private Board board = new Board();

        private int selectedX = -1;
        private int selectedY = -1;
        private bool isWhiteTurn = true;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(TileSize * 8, TileSize * 8);
            this.Paint += ChessPanel_Paint;
            this.MouseClick += ChessPanel_MouseClick;
        }

        private void ChessPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    bool isWhite = (x + y) % 2 == 0;
                    Brush brush = isWhite ? Brushes.Beige : Brushes.Brown;
                    g.FillRectangle(brush, x * TileSize, y * TileSize, TileSize, TileSize);

                    var piece = board.GetPiece(x, y);
                    if (piece != null)
                    {
                        string text = piece.GetSymbol();
                        Font font = new Font("Arial", 24);
                        Brush textBrush = piece.IsWhite ? Brushes.White : Brushes.Black;

                        g.DrawString(text, font, textBrush, x * TileSize + 20, y * TileSize + 20);
                    }
                }
            }
        }

        private void ChessPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X / TileSize;
            int y = e.Y / TileSize;

            if (selectedX == -1)
            {
                if (board.SelectPiece(x, y, isWhiteTurn))
                {
                    selectedX = x;
                    selectedY = y;
                }
            }
            else
            {
                bool moved = board.MovePiece(selectedX, selectedY, x, y, isWhiteTurn);
                if (moved)
                {
                    isWhiteTurn = !isWhiteTurn;
                }

                selectedX = -1;
                selectedY = -1;
            }

            this.Invalidate(); // 화면 다시 그리기
        }
    }
}
