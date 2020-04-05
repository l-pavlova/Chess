using ChessGame.InputProviders;
using ChessGame.Renderers;

namespace ChessGame
{
    internal class StandardTwoPlayerEngine
    {
        private ConsoleRenderer renderer;
        private ConsoleInputProvider inputProvider;

        public StandardTwoPlayerEngine(ConsoleRenderer renderer, ConsoleInputProvider inputProvider)
        {
            this.renderer = renderer;
            this.inputProvider = inputProvider;
        }
    }
}