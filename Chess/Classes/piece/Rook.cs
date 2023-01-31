using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.common;
using Chess.Classes.squares;
using Chess.Classes.piece;
using File = Chess.Classes.common.File;

namespace Chess.Classes.piece
{
    public class Rook : Piece.Piece
    {
        public Rook(PieceColour pieceColour, Location location, bool isAlive)
        {
            this.pieceColour = pieceColour;
            this.pieceType = PieceType.ROOK;
            this.location = location;
            this.isAlive = false;
        }
    }
}
