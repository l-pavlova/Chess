using ChessGame.Board;
using ChessGame.Common;
using ChessGame.Engine.Init;
using ChessGame.InputProviders;
using ChessGame.Players;
using ChessGame.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine
{
    public class StandartTwoPlayerEngine : IEngine
    {
        private IList<IPlayer> players;
        private readonly IBoard board;
        private readonly IRenderer renderer;
        private readonly IInputProvider input;
        public StandartTwoPlayerEngine(IRenderer renderer, IInputProvider provider, IBoard board)
        {
            this.renderer = renderer;
            this.board = board;
            this.input = provider;
        }

        public void Initialize(IInitStrategy strategy)
        {

            Players = input.GetPlayers(Globals.NUM_PLAYERS);
            strategy.Initialize(Players, this.board);
        }


        public void Start()
        {
            throw new NotImplementedException();
        }

        public void WinningConditions()
        {
            throw new NotImplementedException();
        }



        public IList<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
            set
            {
                //todo::
            }
          
        
        }
    }
}
