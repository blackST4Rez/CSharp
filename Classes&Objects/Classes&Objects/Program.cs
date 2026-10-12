using System;

class Animal
{
    public string name;
    public int age;

    public void Greet()
    {
        Console.WriteLine($"{name} says Hello! {name} is {age} years old.");
    }
}

class User
{
    public string emp_name { get; set; }
    public int emp_salary { get; set; }
    public int emp_id { get; set; }

    public User(string name, int salary, int id) 
    {
        emp_name = name;
        emp_salary = salary;
        emp_id = id;
    }

    public void Details()
    {
        Console.WriteLine($"The Salary of {emp_name} with ID {emp_id} is {emp_salary}.");
    }
}

class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    public BankAccount( string owner_name, decimal owner_deposit)
    {
        Owner = owner_name;
        Balance = owner_deposit;
    }

    public void Deposit(decimal value)
    {
        if(value <= 0)
        {
            Console.WriteLine($"The deposit must be at least Rs. 100.");
            return;
        }

        Balance += value;
        Console.WriteLine($"{value} has been deposited from {Owner}. Your new balance is {Balance}");
    }

    public void Withdraw(decimal value)
    {
        if(value <= 0)
        {
            Console.WriteLine($"Cannot withdraw money less than Rs.100");
            return;
        }

        if(value > Balance)
        {
            Console.WriteLine($"Cannot withdraw money more than your current balance.");
        }

        Balance -= value;
        Console.WriteLine($"Rs.{value} has been withdrawn from your account. Your current balance is Rs.{Balance}.");
    }

    public void PrintBalance()
    {
        Console.WriteLine($"{Owner}, your account has balance of {Balance}.");
    }


}

class Program
{
    static void Main()
    {
        {       
            var dog = new Animal();
            dog.name = "Henry";
            dog.age = 5;
            dog.Greet();

            var cat = new Animal();
            cat.name = "Lucy";
            cat.age = 8;
            cat.Greet();
        }

        {
            var Max = new User("Max", 25000, 1);
            var Axl = new User("Axl", 30000, 2);

            Max.Details();
            Axl.Details();
        }

        {
            var Ram = new BankAccount("Ram", 249123.2398m);

            Ram.Deposit(500m);
            Ram.Withdraw(1000m);
            Ram.PrintBalance();

        }
    }
}