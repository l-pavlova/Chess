using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class King: BaseFigure, IFigure
    {
        public King(ChessColor color) : base(color)
        {

        }
    }
}
