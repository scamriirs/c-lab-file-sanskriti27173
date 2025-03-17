using System;

class MyCollection
{
    private int[] arr = new int[10];

    // Indexer
    public int this[int index]
    {
        get { return arr[index]; }
        set { arr[index] = value; }
    }

    public string this[string index]
    {
        get { return $"You requested element at {index}"; }
    }
}

class Program
{
    static void Main()
    {
        MyCollection collection = new MyCollection();
        collection[0] = 10;
        Console.WriteLine(collection[0]); // 10
        Console.WriteLine(collection["first"]); // You requested element at first
    }
}
