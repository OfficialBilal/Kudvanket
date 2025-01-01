using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Student
    {
        int _Id;
        string _Name;
        int _PassMarks = 35;

        public int GetPassMarks()
        {
            return _PassMarks;
        }

        public void SetName(string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new Exception("Student name cannot Null or Empty");
            }
            this._Name = Name;
        }
        public string GetName()
        {
            return string.IsNullOrEmpty(_Name) ? "No Name" : this._Name;
        }


        public void SetID(int id)
        { 
            if (id <= 0)
            {
                throw new Exception("Id cannot be negetive");
            }
            this._Id = id;
        }
        public int GetID()
        {
            return this._Id;
        }

    }
    class WhyProperties
    {
        public static void Main(string[] args)
        {
            Student C1 = new Student();
            C1.SetID(1);
            C1.SetName("test");


            Console.WriteLine("Student Id is: {0}", C1.GetID());
            Console.WriteLine("Student Name is: {0}", C1.GetName());
            Console.WriteLine("Student Marks is: {0}", C1.GetPassMarks());

        }
    }
}
