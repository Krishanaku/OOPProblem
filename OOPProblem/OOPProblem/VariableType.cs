using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    public class VariableType
    {
        public void TypeVariable()
        {
            // integer variable
            int myInt = 10;
            Console.WriteLine("myInt: " + myInt);

            // floating point variable
            float myFloat = 3.14f;
            Console.WriteLine("myFloat: " + myFloat);

            // double precision floating point variable
            double myDouble = 2.71828;
            Console.WriteLine("myDouble: " + myDouble);

            // boolean variable
            bool myBool = true;
            Console.WriteLine("myBool: " + myBool);

            // character variable
            char myChar = 'a';
            Console.WriteLine("myChar: " + myChar);

            // string variable
            string myString = "Hello World!";
            Console.WriteLine("myString: " + myString);

            // constant variable
            const int myConst = 100;
            Console.WriteLine("myConst: " + myConst);

            // nullable variable
            int? myNullableInt = null;
            Console.WriteLine("myNullableInt: " + myNullableInt);
        }
    }
}
