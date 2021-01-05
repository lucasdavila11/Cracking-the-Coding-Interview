using System;
using System.Collections.Generic;

namespace CrackingCodingInterview.Service.Services.Matrices
{
    public static class MatrixService
    {
        public static int[] SpiralMatrix(this int[][] matrix)
        {
            //outline the outside of the matrix map
            var leftBound = -1;
            var rightBound = matrix[0].Length;
            var upperBound = -1;
            var lowerBound = matrix.Length;

            var horizontalPosition = 0;
            var verticalPosition = 0;

            var direction = new int[4] { 1, 1, -1, -1 };
            const int DIRECTIONS = 4;
            var currentDirection = 0;

            var spiralMatrix = new List<int>();

            while((horizontalPosition >= leftBound && horizontalPosition <= rightBound) && (verticalPosition >= upperBound && verticalPosition <= lowerBound))
            {
                if(matrix[verticalPosition][horizontalPosition] != '#')
                {
                    spiralMatrix.Add(matrix[verticalPosition][horizontalPosition]);
                    matrix[verticalPosition][horizontalPosition] = '#';
                }

                currentDirection %= DIRECTIONS;
                switch(currentDirection)
                {
                    case 0:
                        if (horizontalPosition == rightBound - 1)
                        {
                            currentDirection++;
                            upperBound++;
                        }
                        else
                        {
                            horizontalPosition += direction[currentDirection];
                        }
                        break;
                    case 1:
                        if (verticalPosition == lowerBound - 1)
                        {
                            currentDirection++;
                            rightBound--;
                        }
                        else
                        {
                            verticalPosition += direction[currentDirection];
                        }
                        break;
                    case 2:
                        if (horizontalPosition == leftBound + 1)
                        {
                            currentDirection++;
                            lowerBound--;
                        }
                        else
                        {
                            horizontalPosition += direction[currentDirection];
                        }
                        break;
                    case 3:
                        if (verticalPosition == upperBound + 1)
                        {
                            currentDirection++;
                            leftBound++;
                        }
                        else
                        {
                            verticalPosition += direction[currentDirection];
                        }
                        break;
                }
            }


            return spiralMatrix.ToArray();
        }

        public static int FindIslands(this int[][] matrix)
        {
            var count = 0;
            int rowLength = matrix.Length;
            int colLength = matrix[0].Length;


            for(int row = 0; row < rowLength; row++)
            {
                for(int col = 0; col < colLength; col++)
                {
                    if(matrix[row][col] == 1)
                    {
                        count++;
                        DFS(matrix, row, col);
                    }
                }
            }

            return count;
        }

        private static void DFS(int[][] matrix, int currentRow, int currentColumn)
        {
            int rowLength = matrix.Length;
            int colLength = matrix[0].Length;

            if (currentRow < rowLength && currentRow >= 0 && currentColumn < colLength && currentColumn >= 0 && matrix[currentRow][currentColumn] == 1)
            {
                matrix[currentRow][currentColumn] = 0;
                DFS(matrix, currentRow + 1, currentColumn);
                DFS(matrix, currentRow - 1, currentColumn);
                DFS(matrix, currentRow, currentColumn + 1);
                DFS(matrix, currentRow, currentColumn - 1);
            }

            return;
        }
    }
}
