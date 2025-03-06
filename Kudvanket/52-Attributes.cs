using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public class _52_Attributes
    {
        public static void Main(string[] args)
        {
            
            int num = Calculator.Add(new List<int> { 10, 20, 30 });

            Console.WriteLine(num);
        }
    }

    public class Calculator
    {
        [Obsolete("Use Add(List<int> Number) Method", true)]
        public static int Add(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        public static int Add(List<int> Number)
        {
            int Sum = 0;

            foreach (int number in Number)
            {
                Sum = Sum + number;
            }

            return Sum;
        }
    }
}
