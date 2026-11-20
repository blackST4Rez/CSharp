using System;
using System.Collections.Generic;
using System.Threading;

class Person
{
    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value >= 0)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age cannot be negative.");
            }
        }
    }
}

class BankAccount
{
    public string Owner { get; set; }

    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal initialBalance)
    {
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
}

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
                    Console.WriteLine("Your answer is correct!");
                else
                    Console.WriteLine($"Not quite! The correct answer is {sum}.");
            }

            {
                Console.Write("Enter a day of the week (1-7): ");
                int day = Convert.ToInt32(Console.ReadLine());

                switch (day)
                {
                    case 1: Console.WriteLine("Sunday"); break;
                    case 2: Console.WriteLine("Monday"); break;
                    case 3: Console.WriteLine("Tuesday"); break;
                    case 4: Console.WriteLine("Wednesday"); break;
                    case 5: Console.WriteLine("Thursday"); break;
                    case 6: Console.WriteLine("Friday"); break;
                    case 7: Console.WriteLine("Saturday"); break;
                    default: Console.WriteLine("Invalid day. Please enter 1-7."); break;
                }
            }

            {
                Console.Write("What is your stand name ? ");
                string stand = Console.ReadLine();
                Console.Write("How many times you wanna this ? ");
                int count = Convert.ToInt32(Console.ReadLine());

                if (count <= 0)
                    Console.WriteLine("You really think you can count below 0 dumahh ?");
                else
                    for (int i = 0; i < count; i++)
                        Console.WriteLine(stand);
            }

            {
                Console.Write("Number ? ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int parsed))
                    Console.WriteLine($"Success: {parsed}");
                else
                    Console.WriteLine("Not a valid number");
            }

            {
                Console.Write("Word ? ");
                string word = Console.ReadLine();

                for (int i = 0; i < word.Length; i++)
                {
                    Console.Write(word[i]);
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
            }

            {
                for (int i = 0; i < 15; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                        Console.WriteLine("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.WriteLine("Fizz");
                    else if (i % 5 == 0)
                        Console.WriteLine("Buzz");
                    else
                        Console.WriteLine(i);
                }
            }

            {
                string firstName = "Raka";
                string lastName = "Maharjan";
                int age = 20;

                Console.WriteLine($"{firstName} {lastName} is {age} years old");
                Console.WriteLine("{0} {1} is {2} years old", firstName, lastName, age);
                Console.WriteLine(string.Concat(firstName, " ", lastName, " is ", age, " years old."));
            }

            {
                Console.Write("Please enter a message : ");
                string message = Console.ReadLine();

                for (int i = message.Length - 1; i >= 0; i--)
                {
                    Console.Write(message[i]);
                    Thread.Sleep(100);
                }
                Console.WriteLine();
            }

            {
                Console.Write("Please give a message : ");
                string message = Console.ReadLine();

                Console.Write("The reverse for the user given message is: ");
                for (int i = message.Length - 1; i >= 0; i--)
                {
                    Console.Write(message[i]);
                }
                Console.WriteLine();
            }

            {
                int[] numbers = new int[3];

                Console.Write("Number One ? ");
                numbers[0] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number Two ? ");
                numbers[1] = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number Three ? ");
                numbers[2] = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < numbers.Length; i++)
                    Console.Write(numbers[i] + " ");
                Console.WriteLine();
            }

            {
                int[] numbers = new int[5];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("Number ? ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (int n in numbers)
                    Console.WriteLine(n);
            }

            {
                int[] numbers = new int[10];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"Enter a number ({i + 1}/10): ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }

                foreach (int num in numbers)
                {
                    if (num % 2 == 0)
                        Console.WriteLine($"{num} is even.");
                    else
                        Console.WriteLine($"{num} is odd.");
                }
            }

            {
                List<int> numbers = new List<int> { 1, 2, 3 };

                foreach (int n in numbers)
                    Console.WriteLine($"The number is {n}.");
            }

            {
                List<int> numbers = new List<int>();

                for (int i = 0; i < 4; i++)
                {
                    Console.Write("Number ? ");
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));
                }

                foreach (int n in numbers)
                    Console.WriteLine($"The number is {n}.");
            }

            {
                Dictionary<int, string> user = new()
                {
                    [191] = "Sam",
                    [192] = "John",
                    [193] = "Von",
                };

                foreach (KeyValuePair<int, string> u in user)
                    Console.WriteLine($"User ID - {u.Key} has been registered under the name {u.Value}");
            }

            {
                Dictionary<string, string> course = new()
                {
                    ["Mathematics"] = "John",
                    ["AI"] = "Sam",
                    ["Java"] = "Tim",
                    ["DotNet"] = "Simon",
                };

                if (course.TryGetValue("AI", out string teacher))
                    Console.WriteLine($"AI course has been assigned to {teacher}.");
            }

            {
                List<int> oddNumber = new List<int>();
                List<int> evenNumber = new List<int>();

                for (int i = 0; i <= 3; i++)
                {
                    Console.Write($"Number {i + 1} is ");
                    string num = Console.ReadLine();
                    int accNum = Convert.ToInt32(num);

                    if (accNum % 2 == 0)
                        evenNumber.Add(accNum);
                    else
                        oddNumber.Add(accNum);
                }

                Console.WriteLine("The odd numbers are:");
                Console.WriteLine(string.Join(", ", oddNumber));

                Console.WriteLine("The even numbers are:");
                Console.WriteLine(string.Join(", ", evenNumber));
            }

            {

                {
                    static void Message()
                    {
                        Console.WriteLine("Za WAAAA Ru DOO");
                    }

                    {
                        Console.Write("Your stand please ? ");
                        string stand = Console.ReadLine();

                        Console.WriteLine(stand);
                        Message();
                    }
                }
                {
                    Console.Write("Name ? ");
                    string person = Console.ReadLine();

                    Message(person);

                    static void Message(string user)
                    {
                        Console.WriteLine($"Welcome, {user}");
                    }

                }
                {
                    BankAccount account = new BankAccount("Raka", 1000);

                    Console.WriteLine(account.Balance);

                    account.Deposit(500);

                    Console.WriteLine(account.Balance);

                }
                {
                    Person person = new Person();

                    person.Age = 22;

                    Console.WriteLine(person.Age);

                    person.Age = -5;

                    Console.WriteLine(person.Age);
                }
            }

        }
    }
}