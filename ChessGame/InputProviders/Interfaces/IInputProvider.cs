using ChessGame.Common;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.InputProviders
{
    public interface IInputProvider
    {
        IList<IPlayer> GetPlayers(int numberOfPlayers);
        Move GetNextPlayerMove(IPlayer player);
    }
}
