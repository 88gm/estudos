using System;
using Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            int infinite = 1;
            do
            {
                Controles.Singleton.showMenu();
                Controles.Singleton.menuInput(Console.ReadLine());
                Console.ReadLine();
            } while (infinite > 0);
        }
    }
}
