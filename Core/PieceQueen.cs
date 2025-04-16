using System.Drawing;

public class PieceQueen : Piece
{
    public override List<Point> GetAvailableMoves(Piece[,] board)
    {
        List<Point> moves = new();

        int[] dx = { -1, -1, -1, 0, 1, 1, 1, 0 };
        int[] dy = { -1, 0, 1, 1, 1, 0, -1, -1 };

        for (int dir = 0; dir < 8; dir++)
        {
            int x = Position.X;
            int y = Position.Y;

            while (true)
            {
                x += dx[dir];
                y += dy[dir];

                if (!IsInBounds(x, y)) break;

                if (board[x, y] == null)
                    moves.Add(new Point(x, y));
                else
                {
                    if (board[x, y].IsWhite != IsWhite)
                        moves.Add(new Point(x, y));
                    break;
                }
            }
        }

        return moves;
    }
}
