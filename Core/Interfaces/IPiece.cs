// Core/Interfaces/IPiece.cs
namespace ChessGame.Core.Interfaces
{
    public interface IPiece
    {
        bool IsWhite { get; }
        string AssetName { get; } // UI용 기물 이미지 식별자
        List<(int x, int y)> GetAvailableMoves(Board board, int x, int y);
    }
}
