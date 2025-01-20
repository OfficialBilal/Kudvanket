using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    public delegate void HelloDelagate(string message);

    class Delegates
    {
        public static void Main(string[] args)
        {
            HelloDelagate del = new HelloDelagate(Hello);
            del("Hello from Delegate");
        }

        public static void Hello(string strMessage) 
        {
            Console.WriteLine(strMessage);
        }
    }
}
