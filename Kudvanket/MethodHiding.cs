using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public class Employeee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }

    public class PartTimeEmployeee : Employeee
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " - Contractor");
        }
    }
    public class FullTimeEmployeee : Employeee
    {
    }

    class MethodHiding
    {
        public static void Main(string[] args)
        {
            FullTimeEmployeee FTE = new FullTimeEmployeee();
            FTE.FirstName = "Fulltime";
            FTE.LastName = "Employee";
            FTE.PrintFullName();


            PartTimeEmployeee PTE = new PartTimeEmployeee();
            PTE.FirstName = "Parttime";
            PTE.LastName = "Employee";
            PTE.PrintFullName();
            ((Employeee)PTE).PrintFullName();

            Employeee E = new PartTimeEmployeee();
            E.FirstName = "Parttime";
            E.LastName = "Employee";
            ((Employeee)E).PrintFullName();
        }
    }
}
