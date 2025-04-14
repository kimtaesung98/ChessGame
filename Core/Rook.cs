using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Rook : Piece
    {
        public override List<Point> GetAvailableMoves(Piece[,] Board)
        {
            List<Point> moves = new();

            int[] dx = { 1, -1, 0, 0 };
            int[] dy = { 0, 0, 1, -1 };

            foreach(var dir in Enumerable.Range(0, 4))
            {
                int x = Position.X;
                int y = Position.Y;

                while (true)
                {
                    x += dx[dir];
                    y += dy[dir];
                    if (x < 0 || x >= 8 || y < 0 || y >= 8)
                        break;
                    if (Board[x,y] == null)
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
