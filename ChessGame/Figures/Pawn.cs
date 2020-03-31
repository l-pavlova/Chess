using ChessGame.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Pawn : IFigure
    {
        public Pawn(ChessColor color)
        {
            this.Color = color;
        }
        public ChessColor Color { get; private set; }

    }
}
