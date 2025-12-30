using System;

public abstract class ElectronicDevice
{
    // Private fields
    private string brand;
    private double price;

    // Encapsulated public properties
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set 
        {
            if (value > 0)
                price = value;
            else
                price = 0;   // Validation example
        }
    }

    // Constructor
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // Abstract method to be implemented by derived classes
    public abstract void ShowInfo();
}
