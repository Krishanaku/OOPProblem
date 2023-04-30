using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    //Overloding..............................
    public class MathHelper
    {
        public  int Add(int a, int b)
        {
            return a + b;
        }

        public  double Add(double a, double b)
        {
            return a + b;
        }

        public  int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }

    //Overriding
    class Onimal
    {
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }

    class Lion : Onimal
    {
        public override void Eat()
        {
            Console.WriteLine("The lion is eating meat");
        }
    }

    class Giraffe : Onimal
    {
        public override void Eat()
        {
            Console.WriteLine("The giraffe is eating leaves");
        }
    }





}


