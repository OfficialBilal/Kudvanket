using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Delegates_Usage
    {
        public static void Main(string[] args)
        {
            List<Employeeeee> empList = new List<Employeeeee>();

            empList.Add(new Employeeeee() { Id = 1, Name = "Bilal", Salary = 5000, Experience = 5 });
            empList.Add(new Employeeeee() { Id = 2, Name = "Ali", Salary = 4000, Experience = 4 });
            empList.Add(new Employeeeee() { Id = 3, Name = "Ahmad", Salary = 6000, Experience = 6 });
            empList.Add(new Employeeeee() { Id = 4, Name = "Ismaeel", Salary = 3000, Experience = 3 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employeeeee.PromoteEmployee(empList, isPromotable);
        }

        public static bool Promote(Employeeeee emp)
        {
            if (emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    delegate bool IsPromotable(Employeeeee emp);

    class Employeeeee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PromoteEmployee(List<Employeeeee> employeeslist, IsPromotable IsEligibletoPromote)
        {
            foreach (Employeeeee employee in employeeslist)
            {
                if(IsEligibletoPromote(employee))
                {
                    Console.WriteLine(employee.Name + " Promoted");
                }
            }
        }
    }
}
