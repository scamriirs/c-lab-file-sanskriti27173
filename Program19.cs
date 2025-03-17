using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFile = "meters.txt";
        string outputFile = "feet.txt";

        // Reading from meters.txt
        string[] lines = File.ReadAllLines(inputFile);
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            foreach (string line in lines)
            {
                double meters = double.Parse(line);
                double feet = meters * 3.28084;
                writer.WriteLine($"{meters} meters = {feet} feet");
            }
        }
    }
}
