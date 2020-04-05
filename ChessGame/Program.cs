using ChessGame.Engine;
using ChessGame.Engine.Init;
using ChessGame.InputProviders;
using ChessGame.Renderers;
using System;

namespace ChessGame
{
    class Program
    {



        static void Main()
        {
            var renderer = new ConsoleRenderer();

            var inputProvider = new ConsoleInputProvider();

            var chessEngine = new StandartTwoPlayerEngine(renderer, inputProvider);

            var gameInitializationStrategy = new StartInitializationStrategy();

            chessEngine.Initialize(gameInitializationStrategy);
            chessEngine.Start();

            Console.ReadLine();

        }
    }
}
