using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProblem
{
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("The animal is eating.");
            }
        }

        public class Mammal : Animal
        {
            public void Walk()
            {
                Console.WriteLine("The mammal is walking.");
            }
        }

        public class Dog : Mammal
        {
            public void Bark()
            {
                Console.WriteLine("The dog is barking.");
            }
        }
 }

