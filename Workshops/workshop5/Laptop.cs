using System;

public class Laptop : ElectronicDevice
{
    public bool BatteryOn { get; set; }

    public Laptop(string brand, double price)
        : base(brand, price)
    {
        BatteryOn = false;
    }

    // Child-specific method
    public void TurnOnBattery()
    {
        BatteryOn = true;
        Console.WriteLine("Laptop battery is now ON.");
    }

    // Override abstract method
    public override void ShowInfo()
    {
        Console.WriteLine("----- LAPTOP DETAILS -----");
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Price: $" + Price);
        Console.WriteLine("Battery Status: " + (BatteryOn ? "On" : "Off"));
        Console.WriteLine("---------------------------");
    }
}
