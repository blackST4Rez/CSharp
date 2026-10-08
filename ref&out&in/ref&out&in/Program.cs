using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_in
{
    internal class Program
    {
        static void Main(string[] args)
        {
            { /* Ref */

                void Increment(ref int x)
                {
                    x++;
                }

                int num = 5;
                Increment(ref num);
                Console.WriteLine(num);   // 6  ← changed!}

            }

            {
                /* Out */

                bool TryGetHalf(int number, out int half)
                {
                    if (number % 2 == 0)
                    {
                        half = number / 2;
                        return true;
                    }
                    else
                    {
                        half = 0;
                        return false;
                    }
                }

                int myNumber = 10;

                if (TryGetHalf(myNumber, out int result))
                {
                    Console.WriteLine($"Half of {myNumber} is {result}");
                }
                else
                {
                    Console.WriteLine($"{myNumber} is not even");
                }
            }

            {
                /* In */

                void Add(in int first, in int second)
                {
                    int value = first + second;
                    Console.WriteLine($"The total value is {value}");
                }

                int a = 20;
                int b = 30;

                Add(in a, in b);
            }
        }
    }
}
