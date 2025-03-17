using System;

class AdmissionForm
{
    public string Name;
    public string Course;
    public int Age;

    public void DisplayForm()
    {
        Console.WriteLine("Admission Enquiry Form");
        Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
    }
}

class Program
{
    static void Main()
    {
        AdmissionForm form = new AdmissionForm();
        form.Name = "Alice";
        form.Age = 20;
        form.Course = "Computer Science";
        form.DisplayForm();
    }
}
