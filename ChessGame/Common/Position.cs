using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Common
{
    public struct Position
    {
        public Position(int row, char col)
            :this()
        {
            this.Row = row;
            this.Col = col;
        }
        public int Row { get; private set; }
        public char Col { get; private set; }
        public static Position FromArrayCoordinates(int arrRow, int arrCol, int totalRows)
        {
            return new Position(totalRows - arrRow, (char)(arrCol + 'a'));
        }

        public static Position FromChessCoordinates(int chessRow, char chessCol)
        {
            var newPosition = new Position(chessRow, chessCol);
            CheckIfValid(newPosition);
            return newPosition;
        }

        public static void CheckIfValid(Position position)
        {
            if (position.Row < Globals.DefaultMinRows
                || position.Row > Globals.DefaultMaxRows)
            {
                throw new IndexOutOfRangeException("Selected row position on the board is not valid!");
            }

            if (position.Col < Globals.DefaultMinCols
                || position.Col > Globals.DefaultMaxCols)
            {
                throw new IndexOutOfRangeException("Selected column position on the board is not valid!");
            }
        }
    }
}
