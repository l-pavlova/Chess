﻿using ChessGame.Board;
using ChessGame.Common;
using ChessGame.Figures;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessGame.Movements
{
    public class BishopMovement : IMovement
    {
        private const string BishopInvalidMove = "{0}s can move diagonally!";

        public void ValidateMove(IFigure figure, IBoard board, Move move)
        {
            var rowDistance = Math.Abs(move.From.Row - move.To.Row);
            var colDistance = Math.Abs(move.From.Col - move.To.Col);

            var other = figure.Color == ChessColor.White ? ChessColor.Black : ChessColor.White;

            if (rowDistance != colDistance)
            {
                throw new InvalidOperationException(BishopInvalidMove);
            }

            var from = move.From;
            var to = move.To;

            int rowIndex = from.Row;
            char colIndex = from.Col;

            int rowDirection = from.Row < to.Row ? 1 : -1;
            char colDirection = (char)(from.Col < to.Col ? 1 : -1);

            while (true)
            {
                rowIndex += rowDirection;
                colIndex += colDirection;

                if (to.Row == rowIndex && to.Col == colIndex)
                {
                    var figureAtPositon = board.GetFigureAtPosition(to);

                    if (figureAtPositon != null && figureAtPositon.Color == figure.Color)
                    {
                        throw new InvalidOperationException(ExceptionMessages.FigureOnTheWayErrorMessage);
                    }
                    else
                    {
                        return;
                    }
                }

                var position = Position.FromChessCoordinates(rowIndex, colIndex);
                var figureAtPosition = board.GetFigureAtPosition(position);

                if (figureAtPosition != null)
                {
                    throw new InvalidOperationException(ExceptionMessages.FigureOnTheWayErrorMessage);
                }
            }
        }
    }
}
