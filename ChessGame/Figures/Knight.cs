using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Knight: BaseFigure, IFigure
    {
        public Knight(ChessColor color) : base(color)
        {

        }
    }
}
