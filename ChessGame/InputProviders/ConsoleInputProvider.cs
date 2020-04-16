using ChessGame.Common;
using ChessGame.Common.ConsoleHelpers;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.InputProviders
{
    public class ConsoleInputProvider : IInputProvider
    {
        private const string PlayerNameText = "Enter Player {0} name: ";

        public IList<IPlayer> GetPlayers(int numberOfPlayers)
        {
            var players = new List<IPlayer>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.Clear();
                ConsoleHelpers.SetCursorAtCenter(PlayerNameText.Length);
                Console.Write(string.Format(PlayerNameText, i));
                string name = Console.ReadLine();
                var player = new Player((ChessColor)(i - 1), name);
                players.Add(player);
            }

            return players;
        }
        public Move GetNextPlayerMove(IPlayer player)
        {
            ConsoleHelpers.ClearRow(0);
            Console.SetCursorPosition((Console.WindowWidth / 2) - 10, 0);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("{0} is next: ", player.Name);
            var positionAsString = Console.ReadLine().Trim().ToLower();
            return ConsoleHelpers.CreateMoveFromCommand(positionAsString);
        }


    }
}
