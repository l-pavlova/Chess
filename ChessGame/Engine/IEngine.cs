using ChessGame.Engine.Init;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine
{
    public interface IEngine
    {
        public IEnumerable<IPlayer> Players { get; }
        void Initialize(IInitStrategy strategy);

        void Start();
        void WinningConditions();
    }
}
