namespace ChessGame.Core
{
    public struct Piece
    {
        public PieceType Type;
        public PieceColor Color;

        public Piece(PieceType type, PieceColor color)
        {
            Type = type;
            Color = color;
        }
    }
}
