using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class EnumTutorial
    {
        public static void Main(string[] args)
        {
            Enum.GetValues(typeof(Gender));
        }
    }
    
    public enum Gender
    {
        Male,
        Female,
        Unknown
    }
}
