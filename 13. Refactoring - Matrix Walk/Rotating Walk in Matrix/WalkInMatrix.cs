namespace RotatingWalkInMatrix
{
    using System;

    public class WalkInMatrix
    {
        /// <summary>
        /// Changes the direction of the walk.
        /// </summary>
        /// <param name="dRow">Row movement.</param>
        /// <param name="dCol">Column movement.</param>
        static void ChangeDirection(int dRow, int dCol, out int dx, out int dy)
        {
            int[] dirRow = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirCol = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;

            //finds current direction of the walk
            for (int count = 0; count < 8; count++)
            {
                if (dirRow[count] == dRow && dirCol[count] == dCol)
                {
                    currentDirection = count;
                    break;
                }
            }

            //assures there is no index out of range
            if (currentDirection == 7)
            {
                dx = dirRow[0];
                dy = dirCol[0];
                return;
            }

            dx = dirRow[currentDirection + 1];
            dy = dirCol[currentDirection + 1];
        }

        /// <summary>
        /// Checks if the dirrection is valid.
        /// </summary>
        /// <param name="matrix">The matrix we are walking in.</param>
        /// <param name="row">Current row.</param>
        /// <param name="col">Current column.</param>
        /// <returns>
        /// True if destination is available.
        /// False if destination is not available.
        /// </returns>
        private static bool CanContinue(int[,] matrix, int row, int col)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for (int i = 0; i < dirX.Length; i++)
            {
                if (row + dirX[i] >= matrix.GetLength(0) || row + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (col + dirY[i] >= matrix.GetLength(0) || col + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[row + dirX[i], col + dirY[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Finds the first available cell in the matrix.
        /// </summary>
        /// <param name="matrix">Matrix we are searching in.</param>
        /// <param name="currentRow">Current row.</param>
        /// <param name="currentColumn">Current column.</param>
        static void FindCell(int[,] matrix, ref int currentRow, ref int currentColumn)
        {
            currentRow = 0;
            currentColumn = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(0); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        currentRow = row;
                        currentColumn = col;
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int matrixSize = 0;

            while (!int.TryParse(input, out matrixSize) || matrixSize < 0 || matrixSize > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
            
            int[,] matrix = WalkInMatrixGenerator(matrixSize);

            MatrixPrint(matrixSize, matrix);
        }

        private static void MatrixPrint(int matrixSize, int[,] matrix)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                for (int col = 0; col < matrixSize; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int[,] WalkInMatrixGenerator(int n)
        {
            int[,] walkMatrix = new int[n, n];
            int cellContent = 1;
            int row = 0;
            int col = 0;

            WalkingThroughTheMatrix(n, walkMatrix, ref cellContent, ref row, ref col);

            FindCell(walkMatrix, ref row, ref col);
            cellContent++;
            
            if (row != 0 && col != 0)
            {
                WalkingThroughTheMatrix(n, walkMatrix, ref cellContent, ref row, ref col);
            }
            return walkMatrix;
        }

        /// <summary>
        /// The actual walk.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="walkMatrix"></param>
        /// <param name="cellContent"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private static void WalkingThroughTheMatrix(int n, int[,] walkMatrix, ref int cellContent, ref int row, ref int col)
        {
            int dRow = 1;
            int dCol = 1;

            walkMatrix[row, col] = cellContent;

            while (CanContinue(walkMatrix, row, col))
            {
                if (row + dRow >= n || row + dRow < 0 || col + dCol >= n || col + dCol < 0 || walkMatrix[row + dRow, col + dCol] != 0)
                {
                    while ((row + dRow >= n || row + dRow < 0 || col + dCol >= n || col + dCol < 0 || walkMatrix[row + dRow, col + dCol] != 0) && n != 1)
                    {
                        ChangeDirection(dRow, dCol, out dRow, out dCol);
                    }
                }
               
                row += dRow;
                col += dCol;
                cellContent++;
                walkMatrix[row, col] = cellContent;
            }
        }
    }
}