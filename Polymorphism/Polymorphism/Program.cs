using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Parent Class always has virtual in polymorphism
   1. If you want to pass parameter in the child class you must also pass in the parent class nevertheless. 
 */
class Animal
{

    public virtual void MakeSound(string name)
    {
        Console.WriteLine("{name}~~ Animal Sound");
    }
}

/* Child Class always has override in polymorphism
   1. If you want to pass parameter in the child class you must also pass in the parent class nevertheless. 
   2. Method can be tweaked in the child class, but follow the (1.) 
 */
class Dog : Animal
{
    public override void MakeSound(string name)
    {
        Console.WriteLine($"{name}~~ WOof WoOF");
    }
}

class Cat: Animal
{
    public override void MakeSound(string name)
    {
        Console.WriteLine($"{name}~~ MeoW MeoW");
    }
}

/* 
 * Just like Field & Property in Encapsulation, polymorphism follows same set of rules for passing arguments from the main to the Private Fields.
 */
class Person
{
    private string name;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public virtual void Message(string name)
    {
        Console.WriteLine($"Welcome, {name}");
    }
}

class Employee : Person
{
    public override void Message(string name)
    {
        Console.WriteLine($"Welcome, {name}");
    }
}

class Manager : Person
{
    public override void Message(string name)
    {
        Console.WriteLine($"Welcome, {name}");
    }
}

class Marvel
{
    public string name { get; set; }

    public virtual void Character(string character)
    {
        Console.WriteLine($"Here Comessssss {character}.");
    }
}

class Heroes : Marvel
{
    public override void Character(string hero)
    {
        Console.WriteLine($"Here Comessssss {hero}");
    }
}

class Villain : Marvel
{
    public override void Character(string villain)
    {
        Console.WriteLine($"Here Comessssss {villain}");
    }
}


namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Dog Thor = new Dog();
                Cat Fluffy = new Cat();

                Thor.MakeSound("Thor");
                Fluffy.MakeSound("Fluffy");
            }

            {
                Employee Raju = new Employee();
                Manager Kaju = new Manager();

                Raju.Name = "Raju";
                Kaju.Name = "Kaju";

                Raju.Message(Raju.Name);
                Kaju.Message(Kaju.Name);
            }

            {
                Heroes h1 = new Heroes();
                Villain v1 = new Villain();

                h1.name = "Thor";
                v1.name = "Doom";

                h1.Character(h1.name);
                v1.Character(v1.name);
            }
        }
    }
}
