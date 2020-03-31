using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Players
{
    public interface IPlayer
    {
        ChessColor Color { get; }

        string Name { get; }
        void AddFigure(IFigure figure);
        void RemoveFigure(IFigure figure);
    }
}
