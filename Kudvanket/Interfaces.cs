using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Interfaces
    {
        interface ICustomer1
        {
            void Print1();
        }

        interface ICustomer2 : ICustomer1
        {
            void Print2();
        }
        class Customer : ICustomer2
        {
           public void Print1()
            {
                Console.WriteLine("ICustomer1");
            }

            public void Print2()
            {
                Console.WriteLine("ICustomer2");
            }
        }
        public static void Main(string[] args)
        {
            ICustomer1 C1 = new Customer();
            C1.Print1();
            
        }
    }
}
