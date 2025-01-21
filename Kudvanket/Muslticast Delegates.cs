using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public delegate int SampleDelegate();
    class Muslticast_Delegates
    {
        public static void Main(string[] args)
        {
            SampleDelegate del = new SampleDelegate(SampleMethodOne);
            del += SampleMethodTwo;

            int DelegateReturnValue = del();

            Console.WriteLine(DelegateReturnValue);

        }

        public static int SampleMethodOne()
        {
            return 1;
        }

        public static int SampleMethodTwo()
        {
            return 2;
        }

        public static int SampleMethodThree()
        {
            return 3;
        }
    }
}
