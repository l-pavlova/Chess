using ChessGame.Board;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine.Init
{
    public interface IInitStrategy
    {
        void Initialize(IList<IPlayer> players, IBoard board);
    }
}
