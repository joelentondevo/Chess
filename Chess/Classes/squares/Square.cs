using Chess.Classes.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Classes.squares
{
    public class Square
    {
        private readonly SquareColour squareColour;
        private readonly Location location;
        private bool isOccupied;

        public Square(SquareColour squareColour, Location location, bool isOccupied)
        {
            this.squareColour = squareColour;
            this.location = location;
            this.isOccupied = false ;
        }

        public void resetOccupied()
        {
            this.isOccupied=false ;
        }

        public bool getIsOccupied()
        {
            return isOccupied;
        }

        public void setOccupied(bool occupied)
        {
            isOccupied = occupied ;
        }

        public SquareColour getSquareColour()
        {
            return squareColour;
        }

        public Location GetLocation()
        {
            return location;
        }


    }
}
