using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* If Statement */
            {
                int age = 20;

                if (age >= 18)
                {
                    Console.WriteLine("Adult");
                }
            }

            /* With Else */
            {
                int age = 20;

                if (age >= 18)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Minor");
                }
            }

            /* With Else If */
            {
                int age = 20;

                if (age < 13)
                {
                    Console.WriteLine("Child");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Teenager");
                }
                else if (age < 65)
                {
                    Console.WriteLine("Adult");
                }
                else
                {
                    Console.WriteLine("Senior");
                }
            }

            /* Switch Statement */
            {
                int day = 3;

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("Weekend");
                        break;
                    default:
                        Console.WriteLine("Unknown");
                        break;
                }
            }

            /* Switch Expression */
            //{
            //    int day = 3;

            //    string name = day switch
            //    {
            //        1 => "Monday",
            //        2 => "Tuesday",
            //        3 => "Wednesday",
            //        6 => "Weekend",
            //        _ => "Unknown"
            //    };

            //    Console.WriteLine(name);
            //}

            /* For Loop */
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                }
            }

            /* ForEach Loop */
            {
                int[] numbers = { 1, 2, 3, 4, 5 };

                foreach (int n in numbers)
                {
                    Console.WriteLine(n);
                }
            }

            /* While Loop */
            {
                int i = 0;
                while (i < 5)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }

            /* Do While Loop */
            {
                int i = 0;
                do
                {
                    Console.WriteLine(i);
                    i++;
                } while (i < 5);
            }

            /* Break */
            {
                for (int i = 0; i < 10; i++)
                {
                    if (i == 5)
                        break;
                    Console.WriteLine(i);
                }
            }

            /* Continue */
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 2)
                        continue;
                    Console.WriteLine(i);
                }
            }
        }
    }
}