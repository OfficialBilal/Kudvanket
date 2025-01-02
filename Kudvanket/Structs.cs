using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Structs
    {
        public struct Customer
        {
            int _id;
            string _name;

            public int ID
            {
                get { return this._id; }
                set { _id = value; }
            }

            public string Name { get => _name; set => _name = value; }

            public Customer(int id, string name)
            {
                this._id = id;
                this._name = name;
            }

            public void PrintDetails()
            {
                Console.WriteLine("ID is {0} and Name is {1}", ID, Name);
            }

        }

        public static void Main(string[] args)
        {
            Customer C1 = new Customer(1, "Bilal");
            C1.PrintDetails();

            Customer C2 = new Customer()
            {
                ID = 1,
                Name = "Muhammad Bilal"
            };

            C2.PrintDetails();
        }
    }
}
