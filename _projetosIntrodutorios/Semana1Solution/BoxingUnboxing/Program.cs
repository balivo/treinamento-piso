using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            Console.WriteLine(string.Format("Tipo por valor: {0}", i));

            Console.ReadKey();

            object O;

            O = i;
            Console.WriteLine(string.Format("Causa “boxing”: {0}", O));

            Console.ReadKey();

            string S;
            S = O.ToString();
            Console.WriteLine(string.Format("Define S via O: {0}", S));

            Console.ReadKey();

            int x;
            x = (int)O;
            Console.WriteLine(string.Format("Faz “unboxing”: {0}", x));

            Console.ReadKey();
        }
    }
}
