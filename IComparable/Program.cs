using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck(){Kind = KindOfDuck.Mallard , Size = 23},
                new Duck(){Kind = KindOfDuck.Decoy , Size = 45},
                new Duck(){Kind = KindOfDuck.Muscovy , Size = 12},
                new Duck(){Kind = KindOfDuck.Decoy , Size = 56},
                new Duck(){Kind = KindOfDuck.Mallard , Size = 22},
                new Duck(){Kind = KindOfDuck.Muscovy , Size = 55}

            };

            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Kind);
                Console.WriteLine(duck.Size);
                Console.WriteLine("\n");

            }
            ducks.Sort();
            Console.WriteLine(".........................");
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Kind);
                Console.WriteLine(duck.Size);
                Console.WriteLine("\n");

            }
            Console.ReadKey();
        }
    }
}
