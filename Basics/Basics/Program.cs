using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            /* Printing Statement */

            //            Console.WriteLine("Hello, World!");

            //            int a = 23;
            //            string firstName = "Raka";
            //            string lastName = "Maharjan";

            //            /* String Interpolation
            //             - Same as Literals in React
            //             - $ activates the interpolation then we can write variable name to replace the variables value
            //             */

            //            Console.WriteLine($"Welcome Back, {firstName}!");
            //            Console.WriteLine($"You are now {a} years old.");
            //            Console.WriteLine($"Is your lastname {lastName} ?");

            //            /* Type Inference
            //             - C# knows that the score that we are refering to is the int score
            //             - the above is called type inference
            //             */

            //            int score = 50;

            //            Console.WriteLine($"Your score for the Chemistry test is {score}");

            //            score = 99;

            //            Console.WriteLine($"Your scored has increased significantly. It is now {score}. Keep Up !");

            //            /* Constants 
            //             - a value that cannot be changed once declared and initialized
            //             */

            //            const double Pi = 3.14159;

            //            Console.WriteLine($"Value of the Pi is {Pi}.");

            //            string productName = "Coffee";
            //            decimal price = 5.49m;
            //            int quantity = 5;

            //            decimal total = price * quantity;

            //            Console.WriteLine($"Your {productName} is ${total}. Thank You !");

            //            /* Operators */

            //            /* 1. Arithmetic Operators */
            //            int x = 10;
            //            int y = 3;

            //            Console.WriteLine(x + y);   // 13
            //            Console.WriteLine(x - y);   // 7
            //            Console.WriteLine(x * y);   // 30
            //            Console.WriteLine(x / y);   // 3  ← WAIT, this is wrong!
            //            /*
            //             * Here, int / int = int always , which is called integer division.
            //             */
            //            Console.WriteLine(x % y);   // 1  ← remainder

            //            /* 2. Comparison Operators */

            //            int g = 5;
            //            int h = 10;

            //            Console.WriteLine(g == h);   // false  (equal)
            //            Console.WriteLine(g != h);   // true   (not equal)
            //            Console.WriteLine(g < h);    // true
            //            Console.WriteLine(g > h);    // false
            //            Console.WriteLine(g <= h);   // true
            //            Console.WriteLine(g >= h);   // false

            //            /* 3. Logical Operators */

            //            bool isAdult = true;
            //            bool hasTicket = false;

            //            Console.WriteLine(isAdult && hasTicket);   // AND  → false (needs both true)
            //            Console.WriteLine(isAdult || hasTicket);   // OR   → true  (needs at least one true)
            //            Console.WriteLine(!isAdult);               // NOT  → false (flips the value)

            //            /* 4. Shortcut Operators */

            //            int scores = 10;

            //            scores += 5;    // score = score + 5  → 15
            //            scores -= 3;    // score = score - 3  → 12
            //            scores *= 2;    // score = score * 2  → 24
            //            scores /= 4;    // score = score / 4  → 6

            //            Console.WriteLine(scores);

            //            int n = 5;

            //            n++;   // n = n + 1  → 6
            //            n--;   // n = n - 1  → 5
            //            Console.WriteLine(n);

            //            /* 5. Operator Precedence
            //             - Just like math, C# follows an order:

            //             1. () — parentheses first

            //             2. !, unary -

            //             3. *, /, %

            //             4. +, -

            //             5. <, >, <=, >=

            //             6. ==, !=

            //             7. &&

            //             8. || 

            //             */

            //  /* Ternary Operator */

            //  int age = 20;
            //  string category = age >= 18 ? "Adult" : "Minor";
            //  Console.WriteLine(category);   // Adult

            ///* Value Type Assignment */

            //int p = 10;
            //int q = p;      // q gets a COPY of the value 10
            //q = 20;

            //Console.WriteLine(p);   // 10
            //Console.WriteLine(q);   // 20

            ///* Reference Type Assignment */

            //int[] a = { 1, 2, 3 };
            //int[] b = a;      // b gets a COPY OF THE REFERENCE, not the array
            //b[0] = 99;

            //Console.WriteLine(a[0]);   // 99
            //Console.WriteLine(b[0]);   //

            ///* Method Parameters */

            //void Double(int x)
            //{
            //    x = x * 2;
            //}

            //int num = 5;
            //Double(num);
            //Console.WriteLine(num);   // 5  ← unchanged!

            ///* Refence Type Parameters */

            //void AddOne(List<int> list)
            //{
            //    list.Add(99);   // modifies the SAME list
            //}

            //var numbers = new List<int> { 1, 2, 3 };
            //AddOne(numbers);
            //Console.WriteLine(numbers.Count);   // 4  ← changed!

        }
    }
}
