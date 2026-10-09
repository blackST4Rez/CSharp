using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                /* Declaring & Creating Array */

                int[] numbers = new int[5];

                numbers[0] = 10;
                numbers[1] = 20;
                numbers[2] = 30;
                numbers[3] = 40;
                numbers[4] = 50;

                /* Array Initializers in Shorter Syntax */

                int[] num = { 1, 2, 3, 4, 5, 6, 7 };

                for (int i = 0; i < num.Length; i++) {
                    Console.WriteLine($"Array of numbers are {num[i]}");
                }

                /* For each in Array */

                {
                    string[] heroes = { "Shaktiman", "Perman", "Tajoba", "Kattuman" };

                    foreach(string hero in heroes)
                    {
                        Console.WriteLine($"It is {hero}");
                    }
                }

                /* Modifying Array Elements */

                int[] salary = { 100, 200, 300, 400 };

                salary[0] = 200;
                salary[1] = 300;
                salary[2] = 400;
                salary[3] = 500;

                Console.WriteLine($"New Salaries are {salary[1]}");
            }

            {
                /* Arrays are reference types */

                int[] a = { 1, 2, 3 };
                int[] b = a;      // b gets the REFERENCE, not a copy

                b[2] = 999;
                Console.WriteLine(a[2]);   // 99
            }

            {
                /* Useful Array Operations */

                /* 1. Sorting */

                int[] numbers = { 5, 5, 4, 7, 9, 8, 3, 2, 1 };

                Array.Sort(numbers);
                Console.WriteLine(string.Join(",", numbers));

                /* 2. Reverse */

                int[] num = {10 ,9 ,8 ,7 ,6 ,5 ,4 ,3 ,2 ,1};

                Array.Reverse(num);
                Console.WriteLine(string.Join(",", num));

                /* 3. IndexOf */

                int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int idx = Array.IndexOf(values, 5);
                Console.WriteLine($"Index of the given number is {idx}.");

            }

            {
                /* LINQ for powerful array operations */

                    /* LINQ was used at the top already */

                int[] nums = { 3, 1, 4, 1, 5 };

                int max = nums.Max();           // 5
                int min = nums.Min();           // 1
                int sum = nums.Sum();           // 14
                double avg = nums.Average();    // 2.8

                int[] evens = nums.Where(n => n % 2 == 0).ToArray();   // { 4 }
                bool has3 = nums.Contains(3);                          // true

                Console.WriteLine($"Maximum number in nums array is {max}");
            }

            {
                /* Multi-Dimensional Array */

                int[,] grid = {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

                Console.WriteLine(grid[1, 2]);   // 6  (row 1, column 2)
            }
        }
    }
}
