using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class ExceptionHandlingAbuse
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Numerator");
                int Numerator;
                bool isNumeratorConvertorSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (isNumeratorConvertorSuccessful)
                {
                    Console.WriteLine("Enter Denomerator");
                    int Denomerator;
                    bool isDenomeratorConvertorSuccessful = Int32.TryParse(Console.ReadLine(), out Denomerator);

                    if (isDenomeratorConvertorSuccessful && Denomerator != 0)
                    {
                        int Result = Numerator / Denomerator;
                        Console.WriteLine("Result = {0}", Result);
                    }
                    else
                    {
                        if (Denomerator == 0)
                        {
                            Console.WriteLine("Denomerator cannot be Zero");
                        }
                        else
                        {
                            Console.WriteLine("Denomerator should be a valid number between {0} to {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                        Console.WriteLine("Numerator should be a valid number between {0} to {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
