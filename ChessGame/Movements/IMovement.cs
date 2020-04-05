using ChessGame.Board;
using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Movements
{
    public interface IMovement
    {
        void ValidateMove(IFigure figure, IBoard board, Move move);
    }
}
