using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            // Duck x size is bigger than that other DUCK size Y
            // its return 1
            Debug.Assert(x != null, nameof(x) + " != null");
            Debug.Assert(y != null, nameof(y) + " != null");
            if (x.Size > y.Size)
            {
                return 1;
            }
            else if (x.Size < y.Size)
            {
                // one duck size is smaller than that other one
                // its return -1
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
