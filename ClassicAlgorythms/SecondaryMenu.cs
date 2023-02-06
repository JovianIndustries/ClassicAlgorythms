using System;
using System.Diagnostics;
namespace ClassicAlgorithms
{
    public class SecondaryMenu: IMenuController
    {
        public static void Meh()
        {
            IMenuController alg = new Algorithms() as IMenuController;
            alg.MainMenu(0);
        }

        public void MainMenu(int i)
        {
            Console.WriteLine("This is the localization side for the main menu");
            Console.WriteLine();
        }
    }
}
