using System;
using System.Threading;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;

                Console.Write($"What is {num1} + {num2}? ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (userAnswer == sum)
                {
                    Console.WriteLine("Your answer is correct!");
                }
                else
                {
                    Console.WriteLine($"Not quite! The correct answer is {sum}.");
                }
            }

            {
                Console.Write("Enter a day of the week (1-7): ");
                int day = Convert.ToInt32(Console.ReadLine());

                switch (day)
                {
                    case 1:
                        Console.WriteLine("Sunday");
                        break;
                    case 2:
                        Console.WriteLine("Monday");
                        break;
                    case 3:
                        Console.WriteLine("Tuesday");
                        break;
                    case 4:
                        Console.WriteLine("Wednesday");
                        break;
                    case 5:
                        Console.WriteLine("Thursday");
                        break;
                    case 6:
                        Console.WriteLine("Friday");
                        break;
                    case 7:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Invalid day. Please enter 1-7.");
                        break;
                }
            }

            {
                Console.Write("What is your stand name ? ");
                string stand = Console.ReadLine();
                Console.Write("How many times you wanna this ? ");
                int count = Convert.ToInt32(Console.ReadLine());

                if (count <= 0)
                {
                    Console.WriteLine("You really think you can count below 0 dumahh ?");
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(stand);
                    }
                }

                {
                    //Console.Write("Numbre ? ");
                    //string testNum = Console.ReadLine();
                    //int num = Convert.ToInt32(Console.ReadLine());

                    //int.TryParse(testNum, out num);

                    //Console.WriteLine(num);
                }

                {
                    Console.Write("Numbre ? ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int parsed))
                    {
                        Console.WriteLine($"Success: {parsed}");
                    }
                    else
                    {
                        Console.WriteLine("Not a valid number");
                    }
                }

                {
                    Console.Write("Word ? ");
                    string word = Console.ReadLine();

                    for (int i = 0; i < word.Length; i++)
                    {
                        Console.Write(word[i]);
                        Thread.Sleep(1000);
                    }
                }

                {
                    for (int i = 0; i < 15; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else if (i % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (i % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }

                }

                {
                    string firstName = "Raka";
                    string lastName = "Maharjan";
                    int age = 20;

                    Console.WriteLine("" + firstName + " " + lastName + " is " + age + " years old", firstName, lastName, age);
                    Console.WriteLine("{0} {1} is {2} years old", firstName, lastName, age); //Composite Format

                    string test = string.Concat("firstName, lastName is age years old.");
                    Console.WriteLine(test);
                }

                {
                    Console.Write("Please enter a message : ");
                    string message = Console.ReadLine();

                    for (int i = message.Length; i <= 0; i--)
                    {
                        Console.Write(message[i]);
                        Thread.Sleep(100);
                    }

                }

                {
                    Console.Write("Please give a message : ");
                    string message = Console.ReadLine();

                    for (int i = message.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine($"The reverse for the user given message is" + message[i]);
                    }
                }

                {
                    int[] numbers = new int[3];

                    Console.Write("Numbre One ? ");
                    numbers[0] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Numbre Two ? ");
                    numbers[1] = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Numbre Three ? ");
                    numbers[2] = Convert.ToInt32(Console.ReadLine());


                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i]);
                    }

                    {
                        int[] numbers = new int[5];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write("Numbre ? ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        foreach( int n in numbers ){
                            Console.WriteLine(n);
                        }
                    }

                    {
                        int[] numbers = new int[10];

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.WriteLine($"Enter a number: ");
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        foreach (int num in numbers)
                        {
                            Console.WriteLine($"The sorted array is {num}.");

                            if(num % 2 == 0)
                            {
                                Console.WriteLine(num);
                            }
                            else
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}
