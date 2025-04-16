using Core;
using System.Net.NetworkInformation;

Board board = new Board();

for (int y = 7; y >= 0; y--)
{
    for (int x = 0; x < 8; x++)
    {
        var piece = board.GetPiece(x, y);
        if (piece == null)
            Console.Write(". ");
        else
        {
            char symbol = piece switch
            {
                Pawn => 'P',
                Rook => 'R',
                Knight => 'N',
                Bishop => 'B',
                PieceQueen => 'Q',
                PieceKing => 'K',
                _ => '?'
            };

            Console.Write(piece.IsWhite ? char.ToUpper(symbol) : char.ToLower(symbol));
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
