using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.common;
using Chess.Classes.squares;
using File = Chess.Classes.common.File;

namespace Chess.Classes.board
{
    public class Board
    {
        Square[,] boardSquares = new Square[8, 8];

        public Board()
        {
            for (int i = 0; i < boardSquares.GetLength(0); i++)
            {
                int column = 0;
                SquareColour currentColour = (i % 2 == 0) ? SquareColour.LIGHT : SquareColour.DARK;
                foreach (File file in Enum.GetValues(typeof(File)))
                {
                    Square newSquare = new Square(currentColour, new Location(file, boardSquares.GetLength(0)-i), false);
                    boardSquares[i, column] = newSquare;
                    currentColour = (currentColour == SquareColour.DARK) ? SquareColour.LIGHT : SquareColour.DARK;
                    column++;
                }
            }
        }

        public void PrintSquareDetails()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Location Currentlocation = boardSquares[i, j].GetLocation();
                    File Currentfile = Currentlocation.getfile();
                    int Currentrank = Currentlocation.getrank();
                    SquareColour printColour = boardSquares[i, j].getSquareColour();    
                    System.Diagnostics.Debug.WriteLine("Location:" + Currentfile.ToString() + Currentrank + " Colour:" + printColour.ToString());
                }
            }
        }

        
    }
}

