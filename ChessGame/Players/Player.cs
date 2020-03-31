using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Players
{
    public class Player: IPlayer
    {
        private readonly ICollection<IFigure> figures;

        public ChessColor Color { get; private set; }

        public string Name { get; private set; }

        private void CheckIfFigureExists(IFigure figure)
        {
            if (this.figures.Contains(figure))
            {
                throw new InvalidOperationException(ExceptionMessages.AlreadyOwnedFigureMessage);
            }
        }
        private void CheckIfFigureDoesNotExist(IFigure figure)
        {
            if (!this.figures.Contains(figure))
            {
                throw new InvalidOperationException(ExceptionMessages.NotOwnedFigureMessage);
            }
        }
        public Player(ChessColor color, string name)
        {
            this.figures = new List<IFigure>();
            Color = color;
            Name = name;
        }
        public void AddFigure(IFigure figure)
        {
            //todo:color
            ObjectValidator.CheckForNullObject(figure, ExceptionMessages.NullFigureErrorMesage);
            CheckIfFigureExists(figure);
            this.figures.Add(figure);

        }
        public void RemoveFigure(IFigure figure)
        {//todo:color
            ObjectValidator.CheckForNullObject(figure, ExceptionMessages.NullFigureErrorMesage);
            CheckIfFigureDoesNotExist(figure);
            this.figures.Remove(figure);
        }
    }
}
