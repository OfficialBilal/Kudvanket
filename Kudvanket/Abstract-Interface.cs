using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public abstract class Customers
    {
        int id;
        public void Prints()
        {
            Console.WriteLine("Abstract Class");
        }
    }
    public interface ICustomers
    {
        void Prints();
    }

    class Abstract_Interface
    {
        public static void Main(string[] args)
        {

        }
    }
}
