using System;

class Car
{
    
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    
    public void DisplayInfo()
    {
        Console.WriteLine($"Car Information: {Year} {Make} {Model}");
    }

    
    public void Start()
    {
        Console.WriteLine($"The {Make} {Model} is now starting.");
    }

    
    public void Stop()
    {
        Console.WriteLine($"The {Make} {Model} is now stopping.");
    }
}

class Program
{
    static void Main()
    {
    
        Car car1 = new Car("Toyota", "Corolla", 2021);
        Car car2 = new Car("Honda", "Civic", 2022);

        
        car1.DisplayInfo();
        car1.Start();
        car1.Stop();

        car2.DisplayInfo();
        car2.Start();
        car2.Stop();
    }
}
