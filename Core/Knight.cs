using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Knight : Piece
    {
        public override List<Point> GetAvailableMoves(Piece[,] Board)
        {
            List<Point> moves = new();
            int[] dx = { 2, 1, -1, -2, -2, -1, 1, 2 };
            int[] dy = { 1, 2, 2, 1, -1, -2, -2, -1 };

            for(int i = 0;i < 8; i++)
            {
                int x = Position.X + dx[i];
                int y = Position.Y + dy[i];
                if (x < 0 || x >= 8 || y < 0 || y >= 8)
                    if (Board[x, y] == null || Board[x, y].IsWhite != this.IsWhite)
                        moves.Add(new Point(x, y));
            }
            return moves;
        }
    }
}
