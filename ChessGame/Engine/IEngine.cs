using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine
{
    public interface IEngine
    {
        public IEnumerable<IPlayer> Players { get; }
        void Initialize();

        void Start();
        void WinningConditions();
    }
}
