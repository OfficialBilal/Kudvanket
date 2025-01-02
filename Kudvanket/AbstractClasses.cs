using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    abstract class Customer()
    {
        public abstract void Print();
    }
    class AbstractClasses : Customer
    { //Abstract Classes cannot be sealed
        public override void Print()
        {
            Console.WriteLine("Abstarct Class");
        }
        public static void Main(string[] args)
        {
            Customer C1 = new AbstractClasses();
            C1.Print();
        }
    }
}
