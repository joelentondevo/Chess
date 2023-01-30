using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess.Classes.board;

namespace Chess.Classes.runner
{
    public class runner
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            board.PrintSquareDetails();
        }
    }
}
