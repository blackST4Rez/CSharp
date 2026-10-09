using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                /* LINQ */

                {/* 1. where */

                    int[] numbers = { 1, 2, 3, 4, 5, 6 };

                    var evens = numbers.Where(n => n % 2 == 0).ToArray();

                    Console.WriteLine($"The even numbers are {string.Join(",", evens)}");
                 };

                {/* 2. select */

                    int[] numbers = { 1, 2, 3, 5, 0, 1, 5 };

                    var selectedNum = numbers.Select(n => n * 5).ToArray();

                    Console.WriteLine($"The selected numbers after the conditions applied are {string.Join((","), selectedNum)}.");

                }

                {/* 3. OrderBy */

                    List<int> numbers = new List<int>{ 22, 32, 34, 213, 13, 45, 66 };

                    var ascOrder = numbers.OrderBy(n => n).ToList();
                    var desOrder = numbers.OrderByDescending(n => n).ToList();

                    Console.WriteLine($"The numbers in the asecending order is {string.Join((","), ascOrder)}");
                    Console.WriteLine($"The numbers in the asecending order is {string.Join((","), desOrder)}");

                }

                {/* 4. First */

                    List<int> numbre = new List<int>{ 123, 344, 567, 789, 120, 493 };

                    var firstEven = numbre.First(n => n % 2 == 0); //First → throws if none found.
                    var firstMax = numbre.First(n => n > 500); //FirstOrDefault → returns default (0, null) if none found. Safer.

                    Console.WriteLine($"The first even number is {string.Join((","), firstEven)}");
                    Console.WriteLine($"The first even number is {string.Join((","), firstMax)}");

                }

                {/* Any/All */

                    List<int> numbre = new List<int> { 11, 22, 33, 44, 56, 77 };

                    var firMatch = numbre.Any(n => n % 2 == 0); //Any → is there at least one that matches?
                    var secMatch = numbre.All(n => n % 2 == 0); //do all items match?

                    Console.WriteLine($"There are some matches. Hence, the condition is {string.Join((","),firMatch)}.");
                    Console.WriteLine($"There are some matches. Hence, the condition is {string.Join((","), secMatch)}.");

                }

                {/* Count / Sum / Min / Max / Average */

                    var nums = new List<int> { 3, 1, 4, 1, 5 };

                    int count = nums.Count();            // 5
                    int count2 = nums.Count(n => n > 1); // 3 (with condition)
                    int sum = nums.Sum();                // 14
                    int min = nums.Min();                // 1
                    int max = nums.Max();                // 5
                    double avg = nums.Average();         // 2.8

                    Console.WriteLine($"The count here is {count}");
                    Console.WriteLine($"The count here is {count2}");
                    Console.WriteLine($"The sum here is {sum}");
                    Console.WriteLine($"The min here is {min}");
                    Console.WriteLine($"The max here is {max}");
                    Console.WriteLine($"The avg here is {avg}");

                }

            }
        }
    }
}
