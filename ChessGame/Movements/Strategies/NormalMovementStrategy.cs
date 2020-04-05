using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Movements.Strategies
{
    public class NormalMovementStrategy : IMovementStrategy
    {
        private readonly IDictionary<string, IList<IMovement>> movements = new Dictionary<string, IList<IMovement>>
        {
            { "Pawn", new List<IMovement>
                 {
                     new PawnMovement()
                 }
            },
            { "Bishop", new List<IMovement>
                 {
                     new BishopMovement()
                 }
            },
            { "Knight", new List<IMovement>
                 {
                     new KnightMovement()
                 }
            },
            { "King", new List<IMovement>
                 {
                     new KingMovement()
                 }
            },
            { "Rook", new List<IMovement>
                 {
                     new RookMovement()
                 }
            },
            { "Queen", new List<IMovement>
                 {
                     new BishopMovement(),
                     new RookMovement()
                 }
            },
        };

        public IList<IMovement> GetMovements(string figure)
        {
            return this.movements[figure];
        }
    }
}
