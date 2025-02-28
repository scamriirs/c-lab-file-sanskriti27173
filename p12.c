using System;

class Person
{
    // Fields
    private string name;
    private int age;

    // Constructor with parameters
    public Person(string personName, int personAge)
    {
        name = personName;
        age = personAge;
    }

    // Constructor without parameters (default constructor)
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Method to display information
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Using the constructor with parameters
        Person person1 = new Person("Alice", 25);
        person1.DisplayInfo();

        Console.WriteLine(); // Blank line for better readability

        // Using the default constructor
        Person person2 = new Person();
        person2.DisplayInfo();
    }
}
