using System;

public class Teacher
{
    public string Name;

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English.");
    }

    // This method CANNOT be overridden because it is NOT virtual
    public void SalaryInfo()
    {
        Console.WriteLine("Salary information cannot be changed.");
    }
}
