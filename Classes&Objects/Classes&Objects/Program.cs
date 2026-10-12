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
    }
}