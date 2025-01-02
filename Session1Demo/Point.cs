using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1Demo
{
    internal struct Point
    {
        public int X;
        public int Y;

        //Constructor:Special Method
        //           1.Named like struct
        //           2.Has No Return type

        //ClR : will generate parameterless Constructor
        //This Constructor will initialized the attribute with the default value

        //Constructor
        //public Point()
        //{
 
        //}

        public Point()
        {
            X = 12;
            Y = 12;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void PrintPoint() 
        {
            Console.WriteLine($"{X},{Y}");
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

    }
}
