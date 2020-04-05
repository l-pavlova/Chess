using ChessGame.Board;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Renderers
{
    public interface IRenderer
    {
        void RenderMainMenu();
        void RenderBoard(IBoard board);
        void PrintErrorMessage(string errorMessage);
    }
}
