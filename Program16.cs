using System;

public class Boiler
{
    public event EventHandler Alert;

    private int temperature;
    private int pressure;
    private int waterLevel;

    public int Temperature
    {
        get { return temperature; }
        set
        {
            temperature = value;
            CheckAlert();
        }
    }

    public int Pressure
    {
        get { return pressure; }
        set
        {
            pressure = value;
            CheckAlert();
        }
    }

    public int WaterLevel
    {
        get { return waterLevel; }
        set
        {
            waterLevel = value;
            CheckAlert();
        }
    }

    private void CheckAlert()
    {
        if (Temperature > 100 || Pressure > 200 || WaterLevel > 50)
        {
            Alert?.Invoke(this, EventArgs.Empty);
        }
    }
}

class Program
{
    static void Main()
    {
        Boiler boiler = new Boiler();
        boiler.Alert += (sender, e) => { Console.WriteLine("Alert! Conditions exceeded safe limits!"); };

        boiler.Temperature = 105;
        boiler.Pressure = 250;
        boiler.WaterLevel = 60;
    }
}
