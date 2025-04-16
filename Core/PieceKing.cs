using System.Drawing;
using System.Runtime.CompilerServices;

public class PieceKing : Piece
{
    public override List<Point> GetAvailableMoves(Piece[,] board)
    {
        List<Point> moves = new();
        int[] dx = { -1, 0, 1 };
        int[] dy = { -1, 0, 1 };

        foreach (int x in dx)
        {
            foreach (int y in dy)
            {
                if (x == 0 && y == 0) continue;

                int newX = Position.X + x;
                int newY = Position.Y + y;

                if (IsInBounds(newX, newY) && (board[newX, newY] == null || board[newX, newY].IsWhite != IsWhite))
                    moves.Add(new Point(newX, newY));
            }
        }
        return moves;
    }
}
