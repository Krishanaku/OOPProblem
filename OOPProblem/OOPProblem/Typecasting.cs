using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    public class Typecasting
    {
        public void TypeImplicit()
        {
            int myInt = 9;
            double myDouble = myInt;       

            Console.WriteLine(myInt);     
            Console.WriteLine(myDouble); 

        }
        public void TypeExplicit()
        {
            double myDouble = 9.78;
            int myInt = (int)myDouble;
            float fVal = 205.3f;
            int fInt = (int)fVal;
            Console.WriteLine(fInt);
            Console.WriteLine(myDouble);   
            Console.WriteLine(myInt);
        }

    }
}
