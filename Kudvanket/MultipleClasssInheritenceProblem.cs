using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Class");
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Class");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("C Class");
        }
    }

    class D: B //,C 
    {
        //Diamond Problem
    }
    

    class MultipleClasssInheritenceProblem
    {
        public static void Main(string[] args)
        {
            D d = new D();
            d.Print();
        }
    }
}
