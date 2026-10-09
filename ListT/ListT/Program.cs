using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<T> */

            { /* Empty List */

                List<int> numbers = new List<int>();
                List<string> names = new List<string>(); 
            }

                
            { /* List with initial values */

                List<int> numbers = new List<int> { 10, 20, 30 };
                List<string> names = new List<string> { "Alice", "Bob" };

            }

            { /* Adding items in the List */

                var numbers = new List<int>();

                numbers.Add(10);
                numbers.Add(20);
                numbers.Add(30);
                numbers.Add(40);

                // Now: [10, 20, 30, 40]

            }

            { /* Accessing items by index */

                var numbers = new List<int> { 10, 20, 30 };

                Console.WriteLine(numbers[0]);   // 10
                Console.WriteLine(numbers[2]);   // 30

            }

            { /* Removing Items */

                var numbers = new List<int> { 10, 20, 30, 20 };

                numbers.Remove(20);       // removes the FIRST 20 → { 10, 30, 20 }
                numbers.RemoveAt(0);      // removes item at index 0 → { 30, 20 }
                numbers.RemoveAll(n => n > 25);   // removes all matching → { 20 }
                numbers.Clear();          // removes everything → { }

            }

            { /* Looping through the List */

                var names = new List<string> { "Alice", "Bob", "Carol" };

                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }

            }

            { /* Checking If Something Exists */

                var numbers = new List<int> { 10, 20, 30 };

                bool has20 = numbers.Contains(20);   // true
                bool has99 = numbers.Contains(99);   // false

                int idx = numbers.IndexOf(20);       // 1
                int missing = numbers.IndexOf(99);   // -1

            }

            { /* Useful List<T> Methods */

                var nums = new List<int> { 3, 1, 4, 1, 5 };

                nums.Sort();              // { 1, 1, 3, 4, 5 }
                nums.Reverse();           // { 5, 4, 3, 1, 1 }
                nums.Insert(0, 99);       // insert 99 at index 0
                nums.RemoveAt(0);         // remove first item
                nums.Clear();             // empty the list

            }

            { /* LINQ in List<T> */

                /* LINQ was already used on the top */

                var nums = new List<int> { 3, 1, 4, 1, 5 };

                int max = nums.Max();            // 5
                int sum = nums.Sum();            // 14
                var evens = nums.Where(n => n % 2 == 0).ToList();   // { 4 }

            }

            { /* Converting Between Arrays and Lists */

                /* LINQ was already used on the top */

                // Array → List
                int[] arr = { 1, 2, 3 };
                List<int> list = arr.ToList(); 

                // List → Array
                List<int> list2 = new List<int> { 4, 5, 6 };
                int[] arr2 = list2.ToArray();

            }
        }
    }
}
