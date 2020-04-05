using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Board
{
    public interface IBoard
    {
        int TotalRows { get; }
        int TotalCols { get; }
        void AddFigure(IFigure figure, Position position);
        void RemoveFigure(Position position);
        IFigure GetFigureAtPosition(Position position);

        void MoveFigureAtPosition(IFigure figure, Position from, Position to);
    }
}
