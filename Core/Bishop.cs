using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Bishop : Piece
    {
        public override List<Point> GetAvailableMoves(Piece[,] Board)
        {
            List<Point> moves = new();

            int[] dx = { 1, -1, -1, 1 };
            int[] dy = { 1, 1, -1, -1 };
            for (int dir = 0; dir < 4; dir++)
            {
                int x = Position.X;
                int y = Position.Y;
                while (true)
                {
                    x += dx[dir];
                    y += dy[dir];
                    if (x < 0 || x >= 8 || y < 0 || y >= 8)
                        break;
                    if (Board[x, y] == null)
                        moves.Add(new Point(x, y));
                    else
                    {
                        if (Board[x, y].IsWhite != this.IsWhite)
                            moves.Add(new Point(x, y));
                        break;
                    }
                }
            }
            return moves;
         }
     }
}
