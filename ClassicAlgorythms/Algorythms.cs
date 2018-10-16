using System;
using System.Collections.Generic;

namespace ClassicAlgorithms
{
    public class Algorythms: IMenuController
    {
        public void MainMenu(int i)
        {
            Console.WriteLine("Select an option...");
            Console.WriteLine("0 - Generic Test File");
            Console.WriteLine("1 - Prime numbers generator and binary search");
            Console.WriteLine("2 - Eight Queen Problem");
            Console.WriteLine("3 - Buy Sell Gold");
            Console.WriteLine("4 - ParallelMatrixComputation");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(i);

            switch (key.KeyChar)
            {
                case '0':
                    SecondaryMenu.Meh();
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

        public static void Main(string[] args)
        {
            List<IMenuController> ShitToExecute = new List<IMenuController>() { new SecondaryMenu() as IMenuController, new Algorythms() as IMenuController};

            foreach(var elem in ShitToExecute)
                elem.MainMenu();
        }
    }
}
