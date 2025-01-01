using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Students
    {
        int _Id;
        string _Name;
        int _PassMarks = 35;

        public string City {  get; set; }
        public string Email {  get; set; }
        

        public int PassMarks
        {
            get 
            { 
                return _PassMarks; 
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name cannot Null or Empty");
                }
                this._Name = value;
            }
            get
            {
                return string.IsNullOrEmpty(_Name) ? "No Name" : this._Name;
            }
        }


        public int Id
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negetive");
                }
                this._Id = value;
            }
            get
            {
                return this._Id;
            }
        }
    }
    class Properties
    {
        public static void Main(string[] args)
        {
            Students C1 = new Students();
            C1.Id = 10;
            C1.Name = "Bilal";


            Console.WriteLine("Student Id is: {0}", C1.Id);
            Console.WriteLine("Student Name is: {0}", C1.Name);
            Console.WriteLine("Student Marks is: {0}", C1.PassMarks);

        }
    }
}
