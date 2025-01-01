using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Overloading
    {   /*Overloading mean Multiple method with same name but method should be of different signature
        (Signature include name of method, type of parameter and a kind of paramter)*/
        public static void Main(string[] args)
        {
            Add(20, 20);
        }

        public static void Add(int F, int S)
        {
            Console.WriteLine("Sum is {0}", F+S);
        }

        public static void Add(int F, int S, out int T)
        {
            Console.WriteLine("Sum is {0}", F + S);
            T = F + S;
        }

        public static void Add(int F, int S, int T, float E)
        {
            Console.WriteLine("Sum is {0}", F + S + T + E);
        }

    }
}
