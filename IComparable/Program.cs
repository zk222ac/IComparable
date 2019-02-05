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
            // print the ducks
            PrintDucks(ducks);  
            
            // Duck Compare By Size 
            Console.WriteLine("Sorting By Size..............");
            DuckComparerBySize size = new DuckComparerBySize();
            ducks.Sort(size);

            // print the ducks
            PrintDucks(ducks);
            

            // Duck Compare By Kind 
            Console.WriteLine("Sorting By Kind..............");
            DuckComparerByKind kind = new DuckComparerByKind();
            ducks.Sort(kind);

            // print the ducks
            PrintDucks(ducks);

            //........ Sort By Comparer  --> Size then Kind ...................................................
            DuckComparer comparerSizeThenKind = new DuckComparer {SortBy = SortCriteria.SizeThenKind};
            ducks.Sort(comparerSizeThenKind);

            Console.WriteLine("Size then Kind....................");
            // print the ducks
            PrintDucks(ducks);

            //........ Sort By Comparer  --> kind then Size ...................................................
            DuckComparer comparerKindThenSize = new DuckComparer { SortBy = SortCriteria.SizeThenKind };
            ducks.Sort(comparerKindThenSize);
            Console.WriteLine("Kind then Size....................");
            // print the ducks
            PrintDucks(ducks);

            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (var duck in ducks)
            {
                Console.WriteLine(duck.Size + "-inch-" + duck.Kind);
            }

            Console.WriteLine("End of Ducks................................");
        }
    }
}
