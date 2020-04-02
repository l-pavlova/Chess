using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Common.ConsoleHelpers
{
    public static class ConsoleHelpers
    {
        public static void SetCursorAtCenter()
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2;
            Console.SetCursorPosition(centerRow, centerCol);
        }
    }
}
