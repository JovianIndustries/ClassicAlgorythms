using System;
using ClassicAlgorithms;
using System.CodeDom;

namespace Algoritmica
{
    class Algorythms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option...");
            Console.WriteLine("0 - Generic Test File");
            Console.WriteLine("1 - Prime numbers generator and binary search");
            Console.WriteLine("2 - Eight Queen Problem");
            Console.WriteLine("3 - Buy Sell Gold");
            Console.WriteLine("4 - ParallelMatrixComputation");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();

            switch (key.KeyChar)
            {
                case '0':
                    TestClass.Execute();
                    break;
                case '1':
                    BinarySieve.ExecuteBinaryAndSieve();
                    break;
                case '2':
                    EightQueenProblem.Backtracking();
                    break;
                case '3':
                    BuySellGold.Initialize();
                    break;
                case '4':
                    ParallelMatrixMultiplication.ExecuteMultiplyMatrices();
                    break;
            }
        }
    }
}
