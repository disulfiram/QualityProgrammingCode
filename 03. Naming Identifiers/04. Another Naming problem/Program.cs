using System;
using System.Collections.Generic;
using System.Linq;

namespace Minesweeper
{
    public class Minesweeper
    {
        static void Main(string[] arguments)
        {
            const int FIELD_ROWS = 5;
            const int FIELD_COLUMNS = 10;
            const int MAXIMUM_TURNS = 35;

            string command = string.Empty;
            char[,] mineField = CreateMinefield(FIELD_ROWS, FIELD_COLUMNS);
            char[,] mineArray = PlaceMines(FIELD_ROWS, FIELD_COLUMNS);
            int turnCounter = 0;
            bool isGameOver = false;
            List<Score> highScore = new List<Score>(6);
            int row = 0;
            int column = 0;
            bool isFirstTurn = true;
            bool levelComplete = false;

            do
            {
                if (isFirstTurn)
                {
                    Console.WriteLine("Let's play Minesweeper." +
                                      "'top' displays highschore, 'restart' resets the game, 'exit' quits the game.");
                    PrintField(mineField);
                    isFirstTurn = false;
                }
                Console.Write("Input (row,column) : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= mineField.GetLength(0) && column <= mineField.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command.ToLower())
                {
                    case "top":
                        PrintHighScore(highScore);
                        break;
                    case "restart":
                        mineField = CreateMinefield(FIELD_ROWS, FIELD_COLUMNS);
                        mineArray = PlaceMines(FIELD_ROWS, FIELD_COLUMNS);
                        PrintField(mineField);
                        isGameOver = false;
                        isFirstTurn = false;
                        break;
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        break;
                    case "turn":
                        if (mineArray[row, column] != '*')
                        {
                            if (mineArray[row, column] == '-')
                            {
                                MakeTurn(mineField, mineArray, row, column);
                                turnCounter++;
                            }
                            if (MAXIMUM_TURNS == turnCounter)
                            {
                                levelComplete = true;
                            }
                            else
                            {
                                PrintField(mineField);
                            }
                        }
                        else
                        {
                            isGameOver = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nInvalid command. Try again.\n");
                        break;
                }
                if (isGameOver)
                {
                    PrintField(mineArray);
                    Console.Write("\nGameover. Your score is: {0}" + "Input name: ", turnCounter);
                    string playerName = Console.ReadLine();
                    Score t = new Score(playerName, turnCounter);
                    if (highScore.Count < 5)
                    {
                        highScore.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < highScore.Count; i++)
                        {
                            if (highScore[i].Points < t.Points)
                            {
                                highScore.Insert(i, t);
                                highScore.RemoveAt(highScore.Count - 1);
                                break;
                            }
                        }
                    }
                    highScore.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    highScore.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    PrintHighScore(highScore);

                    mineField = CreateMinefield(FIELD_ROWS, FIELD_COLUMNS);
                    mineArray = PlaceMines(FIELD_ROWS, FIELD_COLUMNS);
                    turnCounter = 0;
                    isGameOver = false;
                    isFirstTurn = true;
                }
                if (levelComplete)
                {
                    Console.WriteLine("\nCongratiolations. You beat the game.");
                    PrintField(mineArray);
                    Console.WriteLine("Input name: ");
                    string playerName = Console.ReadLine();
                    Score playerScore = new Score(playerName, turnCounter);
                    highScore.Add(playerScore);
                    PrintHighScore(highScore);
                    mineField = CreateMinefield(FIELD_ROWS, FIELD_COLUMNS);
                    mineArray = PlaceMines(FIELD_ROWS, FIELD_COLUMNS);
                    turnCounter = 0;
                    levelComplete = false;
                    isFirstTurn = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void PrintHighScore(List<Score> playerScore)
        {
            Console.WriteLine("\nHighscore:");
            if (playerScore.Count > 0)
            {
                for (int player = 0; player < playerScore.Count; player++)
                {
                    Console.WriteLine("{0}. {1} --> {2} turns", player + 1, playerScore[player].Name, playerScore[player].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No entries!\n");
            }
        }

        private static void MakeTurn(char[,] mineField, char[,] mineArray, int row, int column)
        {
            char numberOfMinesNextToBlock = CountMinesNextToSquare(mineArray, row, column);
            mineArray[row, column] = numberOfMinesNextToBlock;
            mineField[row, column] = numberOfMinesNextToBlock;
        }

        private static void PrintField(char[,] board)
        {
            int rows = board.GetLength(0);
            int columns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int column = 0; column < columns; column++)
                {
                    Console.Write(string.Format("{0} ", board[row, column]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateMinefield(int fieldRows, int fieldColumns)
        {
            char[,] board = new char[fieldRows, fieldColumns];
            for (int row = 0; row < fieldRows; row++)
            {
                for (int column = 0; column < fieldColumns; column++)
                {
                    board[row, column] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceMines(int fieldRows, int fieldColumns)
        {
            char[,] mineArray = new char[fieldRows, fieldColumns];

            for (int row = 0; row < fieldRows; row++)
            {
                for (int column = 0; column < fieldColumns; column++)
                {
                    mineArray[row, column] = '-';
                }
            }

            List<int> placesOfMines = new List<int>();
            while (placesOfMines.Count < 15)
            {
                Random randomPosition = new Random();
                int newMine = randomPosition.Next(50);
                if (!placesOfMines.Contains(newMine))
                {
                    placesOfMines.Add(newMine);
                }
            }

            foreach (int minePosition in placesOfMines)
            {
                int column = (minePosition / fieldColumns);
                int row = (minePosition % fieldColumns);
                if (row == 0 && minePosition != 0)
                {
                    column--;
                    row = fieldColumns;
                }
                else
                {
                    row++;
                }
                mineArray[column, row - 1] = '*';
            }

            return mineArray;
        }

        private static char CountMinesNextToSquare(char[,] mineArray, int row, int column)
        {
            int numberOfMines = 0;
            int fieldRows = mineArray.GetLength(0);
            int fieldColumns = mineArray.GetLength(1);

            if (row - 1 >= 0)
            {
                if (mineArray[row - 1, column] == '*')
                {
                    numberOfMines++;
                }
            }
            if (row + 1 < fieldRows)
            {
                if (mineArray[row + 1, column] == '*')
                {
                    numberOfMines++;
                }
            }
            if (column - 1 >= 0)
            {
                if (mineArray[row, column - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if (column + 1 < fieldColumns)
            {
                if (mineArray[row, column + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (mineArray[row - 1, column - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row - 1 >= 0) && (column + 1 < fieldColumns))
            {
                if (mineArray[row - 1, column + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row + 1 < fieldRows) && (column - 1 >= 0))
            {
                if (mineArray[row + 1, column - 1] == '*')
                {
                    numberOfMines++;
                }
            }
            if ((row + 1 < fieldRows) && (column + 1 < fieldColumns))
            {
                if (mineArray[row + 1, column + 1] == '*')
                {
                    numberOfMines++;
                }
            }
            return char.Parse(numberOfMines.ToString());
        }
    }
}