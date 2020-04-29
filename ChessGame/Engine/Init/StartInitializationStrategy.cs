using ChessGame.Board;
using ChessGame.Common;
using ChessGame.Figures;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Engine.Init
{
    /// <summary>
    /// Standart initialization strategy to begin game
    /// </summary>
    public class StartInitializationStrategy : IInitStrategy
    {
       
        private const int BOARD_SIZE = 8;
        private IList<Type> figureTypes;
        public StartInitializationStrategy()
        {
            this.figureTypes = new List<Type>
            {
                typeof(Rook),
                typeof(Knight),
                typeof(Bishop),
                typeof(Queen),
                typeof(King),
                typeof(Bishop),
                typeof(Knight),
                typeof(Rook)
            };
        }
        public void Initialize(IList<IPlayer> players, IBoard board)
        {
            ValidateStrategy(players, board);
            var firstPlayer = players[0];
            var secondPlayer = players[1];
     
            AddPawnsToBoardRow(firstPlayer, board, 7);
            AddArmyToBoardRow(firstPlayer, board, 8);
     
            AddPawnsToBoardRow(secondPlayer, board, 2);
            AddArmyToBoardRow(secondPlayer, board, 1);
        }
        private void AddPawnsToBoardRow(IPlayer player, IBoard board, int chessRow)
        {
            for (int i = 0; i < BOARD_SIZE; i++)
            {
                var pawn = new Pawn(player.Color);
                player.AddFigure(pawn);
                board.AddFigure(pawn, new Position(chessRow, (char)(i + 'a')));
            }
        }
        private void AddArmyToBoardRow(IPlayer player, IBoard board, int chessRow)
        {
            for(int i=0;i<BOARD_SIZE;i++)
            {
                var figureType = this.figureTypes[i];
                var figureEntity = (IFigure)Activator.CreateInstance(figureType, player.Color);
                player.AddFigure(figureEntity);
                board.AddFigure(figureEntity, new Position(chessRow, (char)(i + 'a')));

            }
        }
        private void ValidateStrategy(ICollection<IPlayer> players, IBoard board)
        {
            if (players.Count != Globals.NUM_PLAYERS)
            {
                throw new InvalidOperationException("This strategy must have two players");
            }
            if (board.TotalCols != BOARD_SIZE || board.TotalRows != BOARD_SIZE)
            {
                throw new InvalidOperationException("This strategy must have different board size");
            }
        }
    }
}
