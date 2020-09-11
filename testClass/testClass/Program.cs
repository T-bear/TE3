using System;
using System.Reflection;

public class Person
{
    // Constructor that takes no arguments:
    public Person()
    {
        string Name;
        string title;
        int Atk;
        
    }

    // Constructor that takes one argument:
    public Person(string name, string title, int atk)
    {
        Name = name;
        Title = title;
        Atk = atk;
    }

    // Auto-implemented readonly property:
    public string Name { get; }
    public string Title { get; }
    public int Atk { get; }

    // Method that overrides the base class (System.Object) implementation.
    public override string ToString()
    {
        return Name + " " + Title;
        //return Title;
    }
}
class TestPerson
{
    static void Main()
    {
        // Call the constructor that has no parameters.
        var person = new Person();
        Console.WriteLine(person.Name);

        // Call the constructor that has three parameter.
        var hero = new Person("Gilgamesh", "The hero", 14);
        var villain = new Person("Bob", "The villain", 13);
        Console.WriteLine("The heroes is: " + hero.Name + " " + hero.Title + "\nwith a total attack power of: " + hero.Atk);
        Console.WriteLine("\nThe villain is: " + villain.Name + " " + villain.Title + "\nwith a total attack power of: " + villain.Atk);
        // Get the string representation of the person instance.
        Console.WriteLine(hero);
        Console.WriteLine(villain);
        
        Console.Write("Press enter to exit the program.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
    }
    }