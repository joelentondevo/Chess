using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.common;
using Chess.Classes.squares;
using Chess.Classes.piece;
using File = Chess.Classes.common.File;

namespace Chess.Piece
{
    public class Piece
    {
        protected PieceColour pieceColour;
        protected PieceType pieceType;
        protected Location location;
        protected bool isAlive;


        public PieceColour getPieceColour()
        {
            return pieceColour;
        }

        public PieceType getPieceType()
        {
            return pieceType;
        }

        public Location getLocation()
        {
            return location;
        }

        public bool getisAlive()
        {
            return isAlive;
        }

        public void setLocation(Location location)
        {
            this.location = location;
        }

        public void setAlive(bool isAlive)
        {
            this.isAlive = isAlive;
        }


    }
}
