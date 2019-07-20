using System;
using TresCamadas;

namespace UI
{
    class Program
    {

        static void Main(string[] args)
        {
            int infinite = 1;
            do
            {
                UserInterface.showMenu();
                UserInterface.menuInput(Console.ReadLine());
                Console.ReadLine();
            } while (infinite > 0);
        }
    }
}
