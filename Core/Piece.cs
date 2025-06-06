﻿using System.Drawing;

public abstract class Piece
{
    public bool IsWhite { get; set; }
    public Point Position { get; set; } // The position of the piece on the board
    public string Name { get; set; } // The name of the piece (e.g., "Pawn", "Knight", etc.)
    public abstract List<Point> GetAvailableMoves(Piece[,] board);
}