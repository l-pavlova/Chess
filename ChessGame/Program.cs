using ChessGame.InputProviders;
using ChessGame.Renderers;
using System;

namespace ChessGame
{
    class Program
    {
        static void Main()
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();

            IInputProvider provider = new ConsoleInputProvider();
            Console.ReadLine();
            
        }
    }
}
