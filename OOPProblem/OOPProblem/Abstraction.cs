using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
    abstract class Unimal
    {

        // abstract method
        public abstract void makeSound();
    }

    // inheriting from abstract class
    class Uog : Unimal
    {

        // provide implementation of abstract method
        public override void makeSound()
        {

            Console.WriteLine("Bark Bark");

        }

    }
}
