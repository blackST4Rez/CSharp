using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                /* Methods */
                void Greet()
                {
                    Console.WriteLine("Za Warudoooo");
                }

                Greet();   // calls the method → prints "Hello!"
                Greet();
                Greet();// call again — reuse without rewriting
            }

            {
                /* Void vs Return Types */


                void PrintHello()
                {
                    Console.WriteLine("Hello");
                    // no return needed
                }
                PrintHello();

                int Square(int x)
                {
                    return x * x;
                }

                string GetGreeting(string name)
                {
                    return $"Hello, {name}!";
                }

                bool IsAdult(int age)
                {
                    return age >= 18;
                }

                Console.WriteLine(Square(2));
                Console.WriteLine(GetGreeting("Raka"));
                Console.WriteLine(IsAdult(22));
            }

            {
                /* Optional Parameters & Named Arguments */

                //Optional parameters — give a default value

                void Greet(string name, string greeting = "Hello")
                {
                    Console.WriteLine($"{greeting}, {name}!");
                }

                Greet("Alice");                  // Hello, Alice!
                Greet("Bob", "Hi");              // Hi, Bob!
                Greet("Carol", "Hey");           // Hey, Carol!

                //Named arguments — pass by parameter name

                void CreateUser(string name, int age, bool isAdmin)
                {
                    Console.WriteLine($"{name} is {age} years old.");
                    Console.WriteLine($"{name} is Admin or Not ? {isAdmin}.");
                }

                // Positional (must be in order)
                CreateUser("Alice", 30, true);

                // Named (order doesn't matter, more readable)
                CreateUser(name: "Alice", age: 30, isAdmin: true);
                CreateUser(age: 30, isAdmin: true, name: "Alice");   // also works
            }

            {
                /* Method Overloading */

                static int Add(int a, int b)
                {
                    return a + b;
                }

                static double Add(double a, double b)
                {
                    return a + b;
                }

                static int Add(int a, int b, int c)
                {
                    return a + b + c;
                }

                static string Add(string a, string b)
                {
                    return a + b;
                }

                Console.WriteLine(Add(2, 3));           // 5
                Console.WriteLine(Add(2.5, 3.5));       // 6.0
                Console.WriteLine(Add(1, 2, 3));        // 6
                Console.WriteLine(Add("Hello, ", "world")); // Hello, world

            }

        }
    }

}
