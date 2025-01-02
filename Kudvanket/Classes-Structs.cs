using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Classes_Structs
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }

            //Classes can have Destructors where as structs cannot have Destructors
            //Class can be parameter less method while structs not allow parameter less method
            ~Customer()
            { 
            }
        }

        public static void Main(string[] args)
        {
            int i = 10;
            int j = i;
            j  = j + 1;

            Console.WriteLine("i value is {0} and j value is {1}", i, j);

            Customer C1 = new Customer();
            C1.ID = 100;
            C1.Name = "Bilal";

            Customer C2 = new Customer();
            C2 = C1;
            C2.Name = "Ali";

            Console.WriteLine("C1.Name is {0} and C2.Name is {1}", C1.Name, C2.Name);

        }
    }
}
