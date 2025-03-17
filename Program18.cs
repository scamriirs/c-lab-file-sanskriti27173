using System;

class Program
{
    public delegate void StudentDelegate();

    public static void StudentRecord()
    {
        Console.WriteLine("Student Record: John, Age: 21, Grade: A");
    }

    static void Main()
    {
        StudentDelegate studentDelegate = StudentRecord;
        studentDelegate.Invoke();
    }
}
