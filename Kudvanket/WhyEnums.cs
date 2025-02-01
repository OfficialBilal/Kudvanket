using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{ 
    class WhyEnums
    {
        public static void Main(string[] args)
        {
            Costomers[] costomers = new Costomers[3];

            costomers[0] = new Costomers
            {
                Name = "Mark",
                Gender = Gender.Male,
            };
            costomers[1] = new Costomers
            {
                Name = "Marry",
                Gender = Gender.Female
            };
            costomers[2] = new Costomers
            {
                Name = "Same",
                Gender = Gender.Unknown
            };

            foreach (Costomers costomer in costomers)
            {
                Console.WriteLine("Name = {0} and Gendeer = {1}", costomer.Name, GetGender(costomer.Gender));
            }
        }

        public static string GetGender(Gender gender)
        {
            switch(gender)
            {
                case Gender.Unknown: return "Unknown";
                case Gender.Male: return "Male";
                case Gender.Female: return "Female";
                default: return "INvalid Data Detected";
            }
        }
    }

    public enum Genderr
    {
        Unknown,
        Male,
        Female
    }
    public class Costomers
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
