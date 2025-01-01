using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public class Employeeee
    {
        public string FirstName = "Muhammad";
        public string LastName = "Bilal";

        public virtual void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployeeee : Employeeee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - PartTime");
        }
    }
    public class FullTimeEmployeeee : Employeeee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - FullTime");
        }
    }

    public class TamporaryEmployeeee : Employeeee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Tamporary");
        }
    }

    class Polymorphism
    {
        public static void Main(string[] args)
        {
            Employeeee[] employeeee = new Employeeee[4];
            employeeee[0] = new Employeeee();
            employeeee[1] = new PartTimeEmployeeee();
            employeeee[2] = new FullTimeEmployeeee();
            employeeee[3] = new TamporaryEmployeeee();

            foreach (Employeeee e in employeeee)
            {
                e.PrintFullName();
            }

        }
    }
}
