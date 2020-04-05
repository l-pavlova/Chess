﻿using ChessGame.Common;
using ChessGame.Movements;
using ChessGame.Movements.Strategies;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures.Interfaces
{
    public abstract class BaseFigure : IFigure
    {
        protected BaseFigure(ChessColor color)
        {
            Color = color;
        }
        public ChessColor Color { get; private set; }
        public abstract ICollection<IMovement> Move(IMovementStrategy strategy);
    }
}
