using System;

public class Printer
{
    // 1. Print a string message
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    // 2. Print an integer number
    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // 3. Print a message multiple times
    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }
}
