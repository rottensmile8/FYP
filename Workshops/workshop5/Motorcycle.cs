using System;

public class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Motorcycle engine stopped.");
    }

    public void DisplayInfo()
    {
        Console.WriteLine("This is a motorcycle.");
    }
}
