using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ChessGame.Common
{
    public class ExceptionMessages
    {
        public const string NotOwnedFigureMessage = "This player doesn't own this figure!";
        public const string AlreadyOwnedFigureMessage = "This player already owns this figure!";
        public const string NullFigureErrorMesage = "Figure cannot be null!";
        public const string FigureOnTheWayErrorMessage = "There is a figure on your way!";
       
    }
}
