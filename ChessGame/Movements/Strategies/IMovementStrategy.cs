using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Movements.Strategies
{
    public interface IMovementStrategy
    {
        IList<IMovement> GetMovements(string figure);
    }
}
