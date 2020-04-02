using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Bishop:BaseFigure, IFigure
    {
        public Bishop(ChessColor color) : base(color)
        {

        }
    }
}
