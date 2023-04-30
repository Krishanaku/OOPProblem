using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    public class ValueAndReference
    {
        public void valueType()
        {
            int x = 200;
            Console.WriteLine(x);


        }
    }
    public class Person
    {
        public string Name;
        public int Age;

    }
    class Person_Ref
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
