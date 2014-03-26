using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposValorVSTiposReferencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tipos de valor compreendem a maioria dos tipos embutidos (especificamente, todos tipos numéricos, o char,
            //e o bool) bem como um struct personalizado e tipos enumeradores.
            //Tipos de referência compreendem todas as classes, arrays, delegates, e tipos de interface. (Isto inclui
            //o tipo pre-definido string.)
            //A diferença fundamental entre tipos de valor e de referência é como eles são
            //manejados na memória.

            //A definição de uma instância de um tipo de valor sempre copia a instância.
            Point p1 = new Point();
            p1.X = 7;

            Point p2 = p1; //p2 é apenas uma cópia p1, e sempre terá o mesmo valor de p1

            Console.WriteLine("P1: "+p1.X);
            Console.WriteLine("P2: "+p2.X);
            Console.ReadKey();

            p1.X = 9;
            
            Console.WriteLine("P1: " + p1.X);
            Console.WriteLine("P2: " + p2.X);
            Console.ReadKey();

            p2 = p1;

            Console.WriteLine("P1: " + p1.X);
            Console.WriteLine("P2: " + p2.X);
            Console.ReadKey();
        }
    }

    public struct Point { public int X, Y; }
}
