using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudvanket
{
    class Circle
    {
        static float PI;
        int _Radius;

        static Circle()
        {
            Circle.PI = 3.141F;
        }

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }

        public float CalculateArea()
        {
            return Circle.PI * this._Radius * this._Radius;
        }
    }


    class Static_Instance
    {
        public static void Main(string[] args)
        {
            Circle C1 = new Circle(5);
            float Area = C1.CalculateArea();

            Console.WriteLine("Area of Cirlce is {0}", Area);
        }
    }
}
