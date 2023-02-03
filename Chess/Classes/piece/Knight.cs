using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.common;
using Chess.Classes.squares;
using Chess.Classes.board;
using Chess.Classes.piece;
using File = Chess.Classes.common.File;

namespace Chess.Classes.piece
{
    public class Knight : Piece.Piece, Movement
    {
        public Knight(PieceColour pieceColour, Square square, bool isAlive)
        {
            this.pieceColour = pieceColour;
            this.pieceType = PieceType.KNIGHT;
            this.square = square;
            this.isAlive = false;
        }
        public List<Location> GetValidMoves(Board board, Square square)
        {
            System.Diagnostics.Debug.WriteLine(this.getPieceType() + "GetValidMoves");
            return null;
        }

        public void MakeMove(Square square)
        {
            System.Diagnostics.Debug.WriteLine(this.getPieceType() + "MakeMove");
        }
    }
}
