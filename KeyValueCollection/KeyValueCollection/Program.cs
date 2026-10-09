using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { /* Dictionary<TKey, TValue> — The Key-Value Collection */

                /* Empty Dictionary */

                var phoneBook = new Dictionary<string, string>();

                var ages = new Dictionary<string, int>();

                var prices = new Dictionary<string, decimal>();

            }

            { /* Creating a dictionary with initial values */

                var ages = new Dictionary<string, int>
                {
                    { "Alice", 30 },
                    { "Bob", 25 },
                    { "Carol", 28 }
                };

                /* Basic way of adding items in the dictionary */
                //ages.Add("Alice", 30); // Throws exception if the key already exisits
                //ages.Add("Bob", 25);

                /* More Flexible way to add */
                ages["Carol"] = 28;      // adds if new
                ages["Alice"] = 31;      // updates if exists

                /* Accessing the dictionary value */

                var people = new Dictionary<string, int>
                {
                    { "Alice", 30 },
                    { "Bob", 25 }
                };

                Console.WriteLine(people["Alice"]);   // 30
                Console.WriteLine(people["Bob"]);     // 25

                // 1. Updating the entries

                people["Alice"] = 33;

                // 2. Removing the entries

                people.Remove("Bob");

                // 3. Ask for a name

                Console.Write("Enter a name: ");
                string name = Console.ReadLine();

                // 4. Safe access with TryGetValue

                if (people.TryGetValue(name, out int age))
                {
                    Console.WriteLine($"{name} is {age} years old.");
                }
                else
                {
                    Console.WriteLine($"{name} was not found.");
                }

                { /* Looping through the Dictionary */

                    var staffs = new Dictionary<string, int>
                        {
                            { "Alice", 30 },
                            { "Bob", 25 },
                            { "Carol", 28 }
                        };

                    foreach (var staff in staffs)
                    {
                        Console.WriteLine($"{staff.Key} is {staff.Value}");

                    }

                    /* Count of entries */

                    Console.WriteLine(staffs.Count);

                }

            }
        }
    }
}
