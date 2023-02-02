using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.board;
using Chess.Classes.common;
using Chess.Classes.squares;
using Chess.Classes.piece;
using File = Chess.Classes.common.File;

namespace Chess.Classes.runner
{
    public class runner
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            board.PrintSquareDetails();
            System.Diagnostics.Debug.WriteLine(board);
        }
    }
}
