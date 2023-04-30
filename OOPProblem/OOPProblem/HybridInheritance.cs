using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    class Shape
    {
        public void Display()
        {
            Console.WriteLine("Displaying shape...");
        }
    }

    // base class 2
    class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing circle...");
        }
    }

    // derived class
    class Cylinder : Circle
    {
        public void Fill()
        {
            Console.WriteLine("Filling cylinder...");
        }
    }
}
