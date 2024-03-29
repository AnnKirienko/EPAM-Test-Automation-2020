﻿using System;

namespace Chess
{
    public class Cell
    {
        char column;
        int row;

        public Cell(char column, int row)
        {
            if ((column >= 'A' && column <= 'H') && (row <= 8 && row >= 1))
            {
                this.column = column;
                this.row = row;
            }
            else
                throw new MyNotCorrectedInputException("Input your cell again:\n");
        }

        private int GetNumberIndexOfLetter()
        {
            return column - 'A' + 1;
        }

        public string GetCellColour()
        {
            if ((this.GetNumberIndexOfLetter() + this.row) % 2 == 0)
            {
                return "Black";
            }
            else
            {
                return "White";
            }
        }

        public bool CanBeInOneVerticalLine(Cell cell)
        {
            return this.column == cell.column;
        }

        public bool CanBeInOneGorizontalLine(Cell cell)
        {
            return this.row == cell.row;
        }

        public bool CanBeInOneDiagonalLine(Cell cell)
        {
            return (Math.Abs(this.row - this.GetNumberIndexOfLetter())) == (Math.Abs(cell.row - cell.GetNumberIndexOfLetter()));
        }


    }
}
