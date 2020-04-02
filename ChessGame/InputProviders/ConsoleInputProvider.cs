using ChessGame.Common;
using ChessGame.Common.ConsoleHelpers;
using ChessGame.Players;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.InputProviders
{
    public class ConsoleInputProvider
    {
        public ICollection<IPlayer> GetPlayers(int numberOfPlayers)
        {
            Console.Clear();
            ConsoleHelpers.SetCursorAtCenter();
            var players = new List<IPlayer>();
            for (int i = 1; i <= numberOfPlayers; i++)
            {
                Console.WriteLine("Enter player {0} name", i);

                string name = Console.ReadLine();
                var player = new Player((ChessColor)(i - 1), name);
                players.Add(player);
            }
        }
    }
}
