using ChessGame.Common;
using ChessGame.Movements;
using ChessGame.Movements.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public interface IFigure
    {
        public ChessColor Color { get; }
        ICollection<IMovement> Move(IMovementStrategy movementStrategy);

    }
}
