using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IComparable
{
   public class Duck : IComparable<Duck>
   {
       private int _size;
       private KindOfDuck _kind;

       public int Size { get; set; }
       public KindOfDuck Kind { get; set; }

       public int CompareTo(Duck other)
       {
           // one duck size is bigger than that other one
           // its return 1
           if (this.Size > other.Size)
           {
               return 1;
           }
           else if (this.Size < other.Size)
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
    public enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy
    }
}
