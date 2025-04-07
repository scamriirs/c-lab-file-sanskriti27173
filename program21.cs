using System;
using System.Collections.Generic;

namespace StudentDatabase
{
    // The Student class represents each student's data
    public class Student
    {
        public string RegistrationNumber { get; set; }
        public int Age { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        // Constructor to initialize the student details
        public Student(string registrationNumber, int age, string className, string name, string address)
        {
            RegistrationNumber = registrationNumber;
            Age = age;
            Class = className;
            Name = name;
            Address = address;
        }

        // Override ToString() method to display student details in a readable format
        public override string ToString()
        {
            return $"Registration Number: {RegistrationNumber}, Name: {Name}, Age: {Age}, Class: {Class}, Address: {Address}";
        }
    }

    // Main Program class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a list to hold the student objects
            List<Student> students = new List<Student>();

            // Adding 10 student objects to the list
            students.Add(new Student("S001", 20, "10th", "John Doe", "123 Elm St"));
            students.Add(new Student("S002", 21, "12th", "Jane Smith", "456 Oak St"));
            students.Add(new Student("S003", 19, "9th", "Jim Brown", "789 Pine St"));
            students.Add(new Student("S004", 22, "12th", "Jessica White", "321 Maple St"));
            students.Add(new Student("S005", 18, "8th", "Jake Black", "654 Birch St"));
            students.Add(new Student("S006", 20, "10th", "Linda Green", "987 Cedar St"));
            students.Add(new Student("S007", 23, "College", "Liam Blue", "135 Willow St"));
            students.Add(new Student("S008", 19, "9th", "Sophia Grey", "246 Redwood St"));
            students.Add(new Student("S009", 21, "11th", "David Yellow", "753 Cherry St"));
            students.Add(new Student("S010", 18, "8th", "Emily Purple", "369 Spruce St"));

            // Displaying all student details
            Console.WriteLine("Student Database:\n");
            foreach (var student in students)
            {
                Console.WriteLine(student); // This will call ToString() method of the Student class
            }

            // Optional: Add a prompt for the user to press a key before exiting
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
