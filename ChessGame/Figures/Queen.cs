using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using ChessGame.Movements;
using ChessGame.Movements.Strategies;
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
        public override ICollection<IMovement> Move(IMovementStrategy strategy)
        {
            return strategy.GetMovements(this.GetType().Name);
        }
    }
}
