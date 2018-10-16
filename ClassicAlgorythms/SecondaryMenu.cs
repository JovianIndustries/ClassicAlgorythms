using System;
using System.Diagnostics;
namespace ClassicAlgorithms
{
    public class SecondaryMenu: IMenuController
    {
        public SecondaryMenu()
        {
        }

        public static void Meh()
        {
            IMenuController alg = new Algorythms() as IMenuController;
            alg.MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("This is the localization side for the main menu");
            Console.WriteLine();
        }
    }
}
