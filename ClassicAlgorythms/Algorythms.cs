using System;
using ClassicAlgorithms;

namespace Algoritmica
{
    class Algorythms
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an option...");
            Console.WriteLine("1 - Prime numbers generator and binary search");
            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case '1':
                    BinarySieve.ExecuteBinaryAndSieve();
                    break;
                case '2':
                    EightQueenProblem.Backtracking();
                    break;
            }

        }
        #region BinaryAndSieve

#endregion

    }
}
