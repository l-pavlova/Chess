using ChessGame.Board;
using ChessGame.Common.ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

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
            ConsoleHelpers.SetCursorAtCenter();
            Console.WriteLine(Logo);
            Thread.Sleep(1000);
        }
    }
}
