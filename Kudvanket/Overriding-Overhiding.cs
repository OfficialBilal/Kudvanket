using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am from Base Class");
        }
    }

    public class DerivedClass : BaseClass //Overriding
    {
        public override void Print()
        {
            Console.WriteLine("I am from Derived Class");
        }
    }

    public class DerivedClasss : BaseClass //Overhiding
    {
        public new void Print()
        {
            Console.WriteLine("I am from Derived Class");
        }
    }
    public class Overriding_Overhiding
    {
        public static void Main(string[] args)
        {
            BaseClass A = new DerivedClass();
            A.Print();

            BaseClass B = new DerivedClasss();
            B.Print();
        }
    }
}
