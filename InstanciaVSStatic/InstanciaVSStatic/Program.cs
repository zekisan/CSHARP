using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InstanciaVSStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Panda p1 = new Panda("Pan Dee");
            Panda p2 = new Panda("Pan Dah");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            Console.WriteLine(Panda.Population); //2 - a propriedade Population é estática

            Console.ReadKey();
        }
    }
}
