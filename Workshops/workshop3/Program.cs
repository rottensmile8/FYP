using System;


class Program{
    static void Main(string[] args){
        
        // Prompt for marks
        Console.Write("Enter marks: ");
        string marksInput = Console.ReadLine();
        
        // Prompt for total
        Console.Write("Enter total: ");
        string totalInput = Console.ReadLine();
        
        // Parse inputs using TryParse
        bool marksParsed = int.TryParse(marksInput, out int marks);
        bool totalParsed = int.TryParse(totalInput, out int total);
        
        // Check if parsing succeeded
        if (!marksParsed || !totalParsed)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return;
        }
        
        // Corrected calculation: Cast marks to double for floating-point division
        double percentage = (double)marks / total * 100;
        
        // Print the result
        Console.WriteLine($"Percentage: {percentage}%");
    }
}