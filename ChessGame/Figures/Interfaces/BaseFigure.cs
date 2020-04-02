using ChessGame.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures.Interfaces
{
    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            Color = color;
        }
        public ChessColor Color { get; private set; }
    }
}
