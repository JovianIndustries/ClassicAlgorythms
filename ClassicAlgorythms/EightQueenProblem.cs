using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ClassicAlgorithms
{
    public class EightQueenProblem
    {
        public EightQueenProblem(int N)
        {
            n = N;
        }

        private int n;
        private int[,] board;

        public static void Backtracking()
        {
            //TODO: Add input for number of rows and collumns

            EightQueenProblem eightQueenProblem = new EightQueenProblem(8);

            eightQueenProblem.Initialize();

            eightQueenProblem.DisplaySolution();

            Console.ReadLine();
        }

        private void Initialize()
        {
            board = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = 0;
                }
            }
        }

        private void DisplaySolution()
        {
            for (int i = 0; i < n; i++)
            {
                if (!SolutionFinder(i))
                {

                }
            }
            
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(board[i, j] + (j < n - 1?", ": ""));
                }

                Console.WriteLine();
            }
        }

        private bool CheckPlacement(int row, int col)
        {
            for (int i = 0; i < n; i++)
            {
                if (board[i, col] == 1) return false;
                if (board[col, i] == 1) return false;
            }

            for (int i = row, j = col; i < n && j < n; i++, j++)
            {
                if (board[i, j] == 1) return false;
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1) return false;
            }

            return true;
        }

        private bool SolutionFinder(int row)
        {
            if (row >= n) return true;

            for (int i = 0; i < n; i++)
            {
                    if (CheckPlacement(row, i))
                    {
                        board[row, i] = 1;
                        if (SolutionFinder(i + 1))  return true;
                    }
            }
            return false;
        }
    }
}
