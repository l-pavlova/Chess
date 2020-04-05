using ChessGame.Board;
using ChessGame.Common;
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
        private const ConsoleColor DarkSquareConsoleColor = ConsoleColor.DarkGray;
        private const ConsoleColor LightSquareConsoleColor = ConsoleColor.Gray;
        private const int CharactersPerRowPerBoardSquare = 9;
        private const int CharactersPerColPerBoardSquare = 9;

        private const int ConsoleRowForPlayerIO = 0;

        public ConsoleRenderer()
        {
            if (Console.WindowWidth < 100 || Console.WindowHeight < 80)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Clear();
                Console.WriteLine("Please, set the Console window and buffer size to 100x80. For best experience use Raster Fonts 8x8!");
                Environment.Exit(0);
            }
        }
        public void RenderBoard(IBoard board)
        {
            var startRowPrint = (Console.WindowWidth / 2) - (board.TotalRows / 2 * CharactersPerRowPerBoardSquare);
            var startColPrint = (Console.WindowHeight / 2) - (board.TotalCols / 2 *CharactersPerColPerBoardSquare);

            var currentRowPrint = startRowPrint;
            var currentColPrint = startColPrint;

            this.PrintBorder(startRowPrint, startColPrint, board.TotalRows, board.TotalCols);

            Console.BackgroundColor = ConsoleColor.White;
            int counter = 1;
            for (int top = 0; top < board.TotalRows; top++)
            {
                for (int left = 0; left < board.TotalCols; left++)
                {
                    currentColPrint = startRowPrint + (left * CharactersPerColPerBoardSquare);
                    currentRowPrint = startColPrint + (top * CharactersPerRowPerBoardSquare);

                    ConsoleColor backgroundColor;
                    if (counter % 2 == 0)
                    {
                        backgroundColor = DarkSquareConsoleColor;
                        Console.BackgroundColor = DarkSquareConsoleColor;
                    }
                    else
                    {
                        backgroundColor = LightSquareConsoleColor;
                        Console.BackgroundColor = LightSquareConsoleColor;
                    }

                    var position = Position.FromArrayCoordinates(top, left, board.TotalRows);

                    var figure = board.GetFigureAtPosition(position);
                    ConsoleHelpers.PrintFigure(figure, backgroundColor, currentRowPrint, currentColPrint);

                    counter++;
                }

                counter++;
            }
        }

        public void RenderMainMenu()
        {
            ConsoleHelpers.SetCursorAtCenter(0);
            Console.WriteLine(Logo);
            Thread.Sleep(1000);
        }
        public void PrintErrorMessage(string errorMessage)
        {
            ConsoleHelpers.ClearRow(0);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition((Console.WindowWidth / 2) - (errorMessage.Length / 2), 0);
            Console.Write(errorMessage);
            Thread.Sleep(2000);
            ConsoleHelpers.ClearRow(0);
        }

        private void PrintBorder(int startRowPrint, int startColPrint, int boardTotalRows, int boardTotalCols)
        {
            var start = startRowPrint + (CharactersPerRowPerBoardSquare / 2);
            for (int i = 0; i < boardTotalCols; i++)
            {
                Console.SetCursorPosition(start + (i *CharactersPerRowPerBoardSquare), startColPrint - 1);
                Console.Write((char)('A' + i));
                Console.SetCursorPosition(start + (i * CharactersPerRowPerBoardSquare), startColPrint + (boardTotalRows * CharactersPerRowPerBoardSquare));
                Console.Write((char)('A' + i));
            }

            start = startColPrint + (CharactersPerColPerBoardSquare / 2);
            for (int i = 0; i < boardTotalRows; i++)
            {
                Console.SetCursorPosition(startRowPrint - 1, start + (i * CharactersPerColPerBoardSquare));
                Console.Write(boardTotalRows - i);
                Console.SetCursorPosition(startRowPrint + (boardTotalCols * CharactersPerColPerBoardSquare), start + (i * CharactersPerColPerBoardSquare));
                Console.Write(boardTotalRows - i);
            }

            // TODO: check math!
            for (int i = startRowPrint - 2; i < startRowPrint + (boardTotalRows * CharactersPerRowPerBoardSquare) + 2; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(i, startColPrint - 2);
                Console.Write(" ");
            }

            for (int i = startRowPrint - 2; i < startRowPrint + (boardTotalRows * CharactersPerRowPerBoardSquare) + 2; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(i, startColPrint + (boardTotalRows * CharactersPerRowPerBoardSquare) + 1);
                Console.Write(" ");
            }

            for (int i = startColPrint - 2; i < startColPrint + (boardTotalCols * CharactersPerColPerBoardSquare) + 2; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(startRowPrint + (boardTotalRows * CharactersPerRowPerBoardSquare) + 1, i);
                Console.Write(" ");
            }

            for (int i = startColPrint - 2; i < startColPrint + (boardTotalCols * CharactersPerColPerBoardSquare) + 2; i++)
            {
                Console.BackgroundColor = DarkSquareConsoleColor;
                Console.SetCursorPosition(startRowPrint - 2, i);
                Console.Write(" ");
            }
        }
    }
}
