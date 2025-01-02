using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    interface I1
    {
        void InterfaceMethod();
    }

    interface I2
    {
        void InterfaceMethod();
    }
    class ExplicitInterfaceImplimentation : I1, I2
    {
        void  I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
        public static void Main(string[] args)
        {
            ExplicitInterfaceImplimentation C = new ExplicitInterfaceImplimentation();
            ((I1)C).InterfaceMethod();
            ((I2)C).InterfaceMethod();

        }
    }
}
