using System;

public class Smartphone : ElectronicDevice
{
    public bool CameraEnabled { get; set; }

    public Smartphone(string brand, double price)
        : base(brand, price)
    {
        CameraEnabled = false;
    }

    // Child-specific method
    public void EnableCamera()
    {
        CameraEnabled = true;
        Console.WriteLine("Smartphone camera is now ENABLED.");
    }

    // Override abstract method
    public override void ShowInfo()
    {
        Console.WriteLine("----- SMARTPHONE DETAILS -----");
        Console.WriteLine("Brand: " + Brand);
        Console.WriteLine("Price: $" + Price);
        Console.WriteLine("Camera Enabled: " + (CameraEnabled ? "Yes" : "No"));
        Console.WriteLine("-------------------------------");
    }
}
