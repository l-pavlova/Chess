using ChessGame.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "Chess game";
        public void RenderBoard(IBoard board)
        {
            
        }

        public void RenderMainMenu()
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2;
            Console.SetCursorPosition(centerRow, centerCol);
            Console.WriteLine(Logo);
        }
    }
}
