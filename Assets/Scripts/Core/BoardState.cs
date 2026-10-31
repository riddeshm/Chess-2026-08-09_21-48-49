namespace ChessGame.Core
{
    public class BoardState
    {
        public readonly Piece[,] Grid = new Piece[8, 8];

        public BoardState()
        {
            SetupInitialBoard();
        }

        private void SetupInitialBoard()
        {
            // White Back Rank (y = 0)
            Grid[0, 0] = new Piece(PieceType.Rook, PieceColor.White);
            Grid[1, 0] = new Piece(PieceType.Knight, PieceColor.White);
            Grid[2, 0] = new Piece(PieceType.Bishop, PieceColor.White);
            Grid[3, 0] = new Piece(PieceType.Queen, PieceColor.White);
            Grid[4, 0] = new Piece(PieceType.King, PieceColor.White);
            Grid[5, 0] = new Piece(PieceType.Bishop, PieceColor.White);
            Grid[6, 0] = new Piece(PieceType.Knight, PieceColor.White);
            Grid[7, 0] = new Piece(PieceType.Rook, PieceColor.White);

            // White Pawns (y = 1)
            for (int x = 0; x < 8; x++)
            {
                Grid[x, 1] = new Piece(PieceType.Pawn, PieceColor.White);
            }

            // Black Pawns (y = 6)
            for (int x = 0; x < 8; x++)
            {
                Grid[x, 6] = new Piece(PieceType.Pawn, PieceColor.Black);
            }

            // Black Back Rank (y = 7)
            Grid[0, 7] = new Piece(PieceType.Rook, PieceColor.Black);
            Grid[1, 7] = new Piece(PieceType.Knight, PieceColor.Black);
            Grid[2, 7] = new Piece(PieceType.Bishop, PieceColor.Black);
            Grid[3, 7] = new Piece(PieceType.Queen, PieceColor.Black);
            Grid[4, 7] = new Piece(PieceType.King, PieceColor.Black);
            Grid[5, 7] = new Piece(PieceType.Bishop, PieceColor.Black);
            Grid[6, 7] = new Piece(PieceType.Knight, PieceColor.Black);
            Grid[7, 7] = new Piece(PieceType.Rook, PieceColor.Black);
        }
    }
}