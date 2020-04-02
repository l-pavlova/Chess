using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Board
{
    public class Board :IBoard
    {
        private readonly IFigure[,] board;

        public int TotalRows { get; private set; }
        public int TotalCols { get; private set; }

        public Board(int rows = Globals.DefaultRows, int cols = Globals.DefaultCols)
        {
            TotalRows = rows;
            TotalCols = cols;
            this.board = new IFigure[rows, cols];
        }
        private int GetArrayRow(int row)
        {
            return this.TotalRows - row;
        }
        private int GetArrayCol(char col)
        {
            return col - 'a';
        }
        private void ValidatePosition(Position position)
        {
            if (position.Row < Globals.DefaultMinRows || position.Row > Globals.DefaultMaxRows)
            {
                throw new IndexOutOfRangeException("Selected row is out of the board");
            }
            if (position.Col < Globals.DefaultMinCols || position.Col > Globals.DefaultMaxCols)
            {
                throw new IndexOutOfRangeException("Selected col is out of the board");
            }
        }
        public void AddFigure(IFigure figure, Position position)
        {
            ObjectValidator.CheckForNullObject(figure, ExceptionMessages.NullFigureErrorMesage);
            ValidatePosition(position);
            int arrayRow = GetArrayRow(position.Row);
            int arrayCol = GetArrayCol(position.Col);
            this.board[arrayRow, arrayCol] = figure;
        }
        public void RemoveFigure(Position position)
        {
            ValidatePosition(position);
            int arrayRow = GetArrayRow(position.Row);
            int arrayCol = GetArrayCol(position.Col);
            this.board[arrayRow, arrayCol] = null;
        }
    }
}
