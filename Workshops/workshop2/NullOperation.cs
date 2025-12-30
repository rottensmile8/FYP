using System;

class NullOperation
{
    public void PerformNullChecks()
    {
        string? username = null; 
        string result = (username == null) ? "Username is not available" : username;
        Console.WriteLine(result);

        Console.WriteLine(username ?? "Username is not available (using ??)");

        username ??= "RamKrishna";

        Console.WriteLine("Updated Username: " + username);
    }
}