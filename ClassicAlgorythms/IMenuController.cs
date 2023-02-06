using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassicAlgorithms
{
    public interface IMenuController
    {
       void MainMenu(int i);
    }

    public interface ISecondaryMenu<T>
    {
        void SecondaryMenu(T item);
    }
}