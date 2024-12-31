using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }

    class Inheritence
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.FirstName = "Muhammad";
            FTE.LastName = "Bilal";
            FTE.YearlySalary = 5000000F;
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.FirstName = "Blue";
            PTE.LastName = "Techsy";
            PTE.HourlyRate = 50F;
            PTE.PrintFullName();
        }
    }
}
