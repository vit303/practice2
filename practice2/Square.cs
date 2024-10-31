using System;
using System.Collections.Generic;

namespace practice2
{
    internal class Square
    {
        public List<List<int>> CreateSpiralMatrix(int rows, int columns)
        {
            List<List<int>> matrix = InitializeMatrix(rows, columns);
            FillSpiral(matrix, rows, columns);
            return matrix;
        }

        private List<List<int>> InitializeMatrix(int rows, int columns)
        {
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(new List<int>(new int[columns]));
            }
            return matrix;
        }

        private void FillSpiral(List<List<int>> matrix, int rows, int columns)
        {
            int value = 1;
            int top = 0, bottom = rows - 1;
            int left = 0, right = columns - 1;

            while (top <= bottom && left <= right)
            {
                FillTopRow(matrix, ref value, top, left, right);
                top++;

                FillRightColumn(matrix, ref value, right, top, bottom);
                right--;

                if (top <= bottom)
                {
                    FillBottomRow(matrix, ref value, bottom, right, left);
                    bottom--;
                }

                if (left <= right)
                {
                    FillLeftColumn(matrix, ref value, left, bottom, top);
                    left++;
                }
            }
        }

        private void FillTopRow(List<List<int>> matrix, ref int value, int row, int startCol, int endCol)
        {
            for (int i = startCol; i <= endCol; i++)
            {
                matrix[row][i] = value++;
            }
        }

        private void FillRightColumn(List<List<int>> matrix, ref int value, int col, int startRow, int endRow)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                matrix[i][col] = value++;
            }
        }

        private void FillBottomRow(List<List<int>> matrix, ref int value, int row, int startCol, int endCol)
        {
            for (int i = startCol; i >= endCol; i--)
            {
                matrix[row][i] = value++;
            }
        }

        private void FillLeftColumn(List<List<int>> matrix, ref int value, int col, int startRow, int endRow)
        {
            for (int i = startRow; i >= endRow; i--)
            {
                matrix[i][col] = value++;
            }
        }

        public void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var item in row)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}