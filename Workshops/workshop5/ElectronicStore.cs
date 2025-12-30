using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices;

    public ElectronicsStore()
    {
        devices = new List<ElectronicDevice>();
    }

    // Add a new device
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine(device.Brand + " added to store.");
    }

    // Remove a device
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Contains(device))
        {
            devices.Remove(device);
            Console.WriteLine(device.Brand + " removed from store.");
        }
        else
        {
            Console.WriteLine("Device not found in store.");
        }
    }

    // Display details for all devices
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n=== STORE DEVICE DETAILS ===");

        foreach (ElectronicDevice device in devices)
        {
            device.ShowInfo();   // Polymorphism call

            // Downcasting to access child-specific behaviors
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone phone)
            {
                phone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
