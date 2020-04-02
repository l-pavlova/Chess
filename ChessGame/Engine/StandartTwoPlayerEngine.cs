using ChessGame.Board;
using ChessGame.Engine.Init;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine
{
    public class StandartTwoPlayerEngine : IEngine
    {
        private readonly IList<IPlayer> players;
        private readonly IBoard board;

        public void Initialize(IInitStrategy strategy)
        {
            strategy.Initialize(this.players, this.board);
        }


        public void Start()
        {
            throw new NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new NotImplementedException();
        }



        public IEnumerable<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }
    }
}
