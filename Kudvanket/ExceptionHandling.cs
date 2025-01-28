using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class ExceptionHandling
    {
        public static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"D:\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Plaese check is the file {0} exist", ex.FileName);
            }
            catch(Exception  ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
            }
        }
    }
}
