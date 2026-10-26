using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        public class Animal          // parent (base class)
        {
            public string Name { get; set; }

            public void Eat()
            {
                Console.WriteLine($"{Name} is eating");
            }
        }

        public class Dog : Animal    // child (derived class)
        {
            public void Bark()
            {
                Console.WriteLine($"{Name} says woof!");
            }
        }
        static void Main(string[] args)
        {
            {
                var dog = new Dog();
                dog.Name = "Rex";  
                dog.Eat();           
                dog.Bark();               
            }
        }
    }
}
