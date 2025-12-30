using System;

class Operators
{
    public void add(int a, int b){
        Console.WriteLine($"Sum: {a + b}");
    }

    public void subtract(int a, int b){
        Console.WriteLine($"Difference: {a - b}");
    }

    public void multiply(int a, int b){
        Console.WriteLine($"Product: {a * b}");
    }

    public void divide(int a, int b){
        if (b !=0)
            Console.WriteLine($"Quotient: {(double) a/b}");
        else
            Console.WriteLine("Number is not divisiable by zero");
    }

    public void OddEvenFinder(int number)
    {
        string result = (number % 2 == 0) ? "even number" : "odd number";
        Console.WriteLine(result);
    }

}

