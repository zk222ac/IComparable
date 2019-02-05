using System.Collections.Generic;
using System.Diagnostics;

namespace IComparable
{
    class DuckComparerByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            // Remember this time the value of kind is a enum type
            // sorting occurs through by Enum default values 
            // for example 
            // Mallard --> 0
            // Muscovy --> 1
            // Decoy   --> 2
            // Duck x size is bigger than that other DUCK size Y
            // its return 1
            Debug.Assert(x != null, nameof(x) + " != null");
            Debug.Assert(y != null, nameof(y) + " != null");
            if (x.Kind > y.Kind)
            {
                return 1;
            }
            else if (x.Kind < y.Kind)
            {
                // one duck size is smaller than that other one
                // its return -1
                return -1;
            }
            else
            {
                // values are same
                return 0;
            }
        }
    }
}
