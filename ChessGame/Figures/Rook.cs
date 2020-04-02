using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Rook: BaseFigure, IFigure
    {
        public Rook(ChessColor color) : base(color)
        {

        }
    }
}
