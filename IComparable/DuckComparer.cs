using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
    class DuckComparer : IComparer<Duck>
    {
        public SortCriteria SortBy = SortCriteria.SizeThenKind;
        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortCriteria.SizeThenKind)
            {
                Debug.Assert(x != null, nameof(x) + " != null");
                Debug.Assert(y != null, nameof(y) + " != null");
                if (x.Size > y.Size)
                {
                    return 1;
                }
                else if (x.Size < y.Size)
                {
                    return -1;
                }
                else
                {
                    if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                Debug.Assert(x != null, nameof(x) + " != null");
                Debug.Assert(y != null, nameof(y) + " != null");
                if (x.Size > y.Size)
                {
                    return 1;
                }
                else if (x.Size < y.Size)
                {
                    return -1;
                }
                else
                {
                    if (x.Kind > y.Kind)
                    {
                        return 1;
                    }
                    else if (x.Kind < y.Kind)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
