using Core;
using System.Drawing;

public class Board
{
    public Piece[,] Grid { get; private set; }

    public Board()
    {
        Grid = new Piece[8, 8];
        SetupInitialPosition();
    }
    private void SetupInitialPosition()
    {
        Grid[0, 0] = new Rook { IsWhite = true, Position = new Point(0, 0) };
        Grid[1, 0] = new Knight { IsWhite = true, Position = new Point(1, 0) };
        Grid[2, 0] = new Bishop { IsWhite = true, Position = new Point(2, 0) };
        //Grid[3, 0] = new PieceQueen { IsWhite = true, Position = new Point(3, 0) };
        Grid[4, 0] = new PieceKing { IsWhite = true, Position = new Point(4, 0) };
        Grid[5, 0] = new Bishop { IsWhite = true, Position = new Point(5, 0) };
        Grid[6, 0] = new Knight { IsWhite = true, Position = new Point(6, 0) };
        Grid[7, 0] = new Rook { IsWhite = true, Position = new Point(7, 0) };

        for (int i = 0; i < 8; i++)
            Grid[i, 1] = new Pawn { IsWhite = true, Position = new Point(i, 1) };
    }
    public Piece GetPiece(int x, int y) => Grid[x, y];
}