using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Queen: BaseFigure, IFigure
    {
        public Queen(ChessColor color) : base(color)
        {

        }
    }
}
