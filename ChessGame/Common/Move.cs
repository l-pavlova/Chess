using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Common
{
    /// <summary>
    /// Base for movements of figures
    /// </summary>
    public struct Move
    {
        public Move(Position from, Position to)
            : this()
        {
            this.From = from;
            this.To = to;
        }

        public Position From { get; private set; }

        public Position To { get; private set; }
    }
}
