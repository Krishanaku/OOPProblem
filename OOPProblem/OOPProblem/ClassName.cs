using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    public  class ClassName
    {
        //Non Parameterized 
        public void sum()
        {
            Console.WriteLine("Enter Two Number :");
            int firstNum=Convert.ToInt32(Console.ReadLine());
            int secNum=int.Parse(Console.ReadLine());
            int cal = firstNum + secNum;
            Console.WriteLine("Two number sum : "+cal);
        }
        //Parameterized method
        public void sub(int firstVal , int secVal)
        {
            int cal = firstVal - secVal;
            Console.WriteLine("Two number sub : " + cal);
        }
         //returnType method..... 
        public int mul(int firstVal , int secVal)
        {
            int cal = firstVal * secVal;
            return cal;
            

        }
    }
}
