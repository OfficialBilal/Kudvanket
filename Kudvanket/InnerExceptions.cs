using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class InnerExceptions
    {
        public static void Main(string[] args)
        {
            try {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;

                    Console.WriteLine("Result is {0}", result);
                }
                catch (Exception ex)
                {
                    string filepath = @"D:\Dataa.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filepath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Close();
                        Console.WriteLine("There is some error, PLease try again later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " is not present", ex);
                    }
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine("Currunt Exception = {0}", exception.GetType().Name);
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }

        }
    }
}
