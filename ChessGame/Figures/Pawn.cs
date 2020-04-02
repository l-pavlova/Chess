﻿using ChessGame.Common;
using ChessGame.Figures.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Figures
{
    public class Pawn : BaseFigure, IFigure
    {
        public Pawn(ChessColor color) : base(color)
        {

        }
      
    }
}
