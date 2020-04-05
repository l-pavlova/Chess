
using ChessGame.Board;
using ChessGame.Common;
using ChessGame.Engine.Init;
using ChessGame.Figures;
using ChessGame.InputProviders;
using ChessGame.Movements;
using ChessGame.Movements.Strategies;
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
        private readonly IMovementStrategy movementStrategy;


        private int currentPlayerIndex;
        private void ValidateMovements(IFigure figure, IEnumerable<IMovement> availableMovements, Move move)
        {
            var validMoveFound = false;
            var foundException = new Exception();
            foreach (var movement in availableMovements)
            {
                try
                {
                    movement.ValidateMove(figure, this.board, move);
                    validMoveFound = true;
                    break;
                }
                catch (Exception ex)
                {
                    foundException = ex;
                }
            }

            if (!validMoveFound)
            {
                throw foundException;
            }
        }

        private void SetFirstPlayerIndex()
        {
            for (int i = 0; i < this.players.Count; i++)
            {
                if (this.players[i].Color == ChessColor.White)
                {
                    this.currentPlayerIndex = i - 1;
                    return;
                }
            }
        }

        private IPlayer GetNextPlayer()
        {
            this.currentPlayerIndex++;
            if (this.currentPlayerIndex >= this.players.Count)
            {
                this.currentPlayerIndex = 0;
            }

            return this.players[this.currentPlayerIndex];
        }

        private void CheckIfPlayerOwnsFigure(IPlayer player, IFigure figure, Position from)
        {
            if (figure == null)
            {
                throw new InvalidOperationException(string.Format("Position {0}{1} is empty!", from.Col, from.Row));
            }

            if (figure.Color != player.Color)
            {
                throw new InvalidOperationException(string.Format("Figure at {0}{1} is not yours!", from.Col, from.Row));
            }
        }

        private void CheckIfToPositionIsEmpty(IFigure figure, Position to)
        {
            var figureAtPosition = this.board.GetFigureAtPosition(to);
            if (figureAtPosition != null && figureAtPosition.Color == figure.Color)
            {
                throw new InvalidOperationException(string.Format("You already have a figure at {0}{1}!", to.Col, to.Row));
            }
        }

        public IList<IPlayer> Players
        {
            get
            {
                return new List<IPlayer>(this.players);
            }
        }
        public StandartTwoPlayerEngine(IRenderer renderer, IInputProvider provider)
        {
            this.renderer = renderer;
            this.board = new Board.Board();
            this.input = provider;
            this.movementStrategy = new NormalMovementStrategy();
        }

        public void Initialize(IInitStrategy strategy)
        {
            this.players = new List<IPlayer>
            {
                new Player(ChessColor.Black, "Player one" ),
                new Player(ChessColor.White, "Player two")
            };

            SetFirstPlayerIndex();
            strategy.Initialize(this.players, this.board);
            this.renderer.RenderBoard(this.board);

        }


        public void Start()
        {
            while (true)
            {
                IFigure figure = null;
                try
                {
                    var player = this.GetNextPlayer();
                    var move = this.input.GetNextPlayerMove(player);
                    var from = move.From;
                    var to = move.To;
                    figure = this.board.GetFigureAtPosition(from);
                    this.CheckIfPlayerOwnsFigure(player, figure, from);
                    this.CheckIfToPositionIsEmpty(figure, to);

                    var availableMovements = figure.Move(this.movementStrategy);
                    this.ValidateMovements(figure, availableMovements, move);

                    this.board.MoveFigureAtPosition(figure, from, to);
                    this.renderer.RenderBoard(this.board);

                }
                catch (Exception ex)
                {
                    this.currentPlayerIndex--;
                    this.renderer.PrintErrorMessage(string.Format(ex.Message, figure.GetType().Name));
                }
            }
        }

        public void WinningConditions()
        {
            //todo:
            throw new NotImplementedException();
        }

    }
}
