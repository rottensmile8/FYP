using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create object
//         BankAccount bankAccount = new BankAccount("1234", 5000);

//         // Display account number & balance using properties
//         Console.WriteLine("Account Number: " + bankAccount.AccountNumber);
//         Console.WriteLine("Initial Balance: Rs " + bankAccount.Balance);

//         // Deposit and withdraw
//         bankAccount.Deposit(2000);
//         bankAccount.Withdraw(1000);

//         // Remaining balance
//         Console.WriteLine("Remaining Balance: Rs " + bankAccount.Balance);
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         // Object of Car
//         Car car = new Car();
//         car.Brand = "Toyota";
//         car.Speed = 180;
//         car.Seats = 5;

//         // Object of Motorcycle
//         Motorcycle bike = new Motorcycle();
//         bike.Brand = "Yamaha";
//         bike.Speed = 120;
//         bike.HasCarrier = true;

//         // Demonstrate methods and code reuse
//         Console.WriteLine("=== Car Info ===");
//         car.Start();
//         car.DisplayInfo();
//         car.Stop();

//         Console.WriteLine("\n=== Motorcycle Info ===");
//         bike.Start();
//         bike.DisplayInfo();
//         bike.Stop();
//     }
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         Printer printer = new Printer();

//         // Calling Print(string)
//         printer.Print("Hello, this is a message!");

//         // Calling Print(int)
//         printer.Print(100);

//         // Calling Print(string, int)
//         printer.Print("I will be printed 3 times!", 3);

//     }
// }




// class Program
// {
//     static void Main(string[] args)
//     {
//         // Nepali teacher object
//         NepaliTeacher nt = new NepaliTeacher();
//         nt.Name = "Ravi Mahrajan";
//         Console.WriteLine("Teacher: " + nt.Name);
//         nt.Teaching();
//         nt.SalaryInfo();

//         Console.WriteLine();

//         // English teacher object
//         EnglishTeacher et = new EnglishTeacher();
//         et.Name = "Steve Rai";
//         Console.WriteLine("Teacher: " + et.Name);
//         et.Teaching();     // Uses base method
//         et.SalaryInfo();   // Cannot be overridden

//         Console.ReadLine();
//     }
// }



// class Program
// {
//     static void Main(string[] args)
//     {
//         Car car = new Car();
//         Bike bike = new Bike();

//         Console.WriteLine("CAR:");
//         car.Display();
//         car.StartEngine();
//         car.StopEngine();

//         Console.WriteLine();

//         Console.WriteLine("BIKE:");
//         bike.Display();
//         bike.StartEngine();
//         bike.StopEngine();

//         Console.ReadLine();
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        // Create store object
        ElectronicsStore store = new ElectronicsStore();

        // Create devices
        Laptop laptop = new Laptop("Dell", 1200.00);
        Smartphone phone = new Smartphone("Samsung", 999.99);

        // Add devices to store
        store.AddDevice(laptop);
        store.AddDevice(phone);

        // Show details and call child methods
        store.ShowAllDeviceDetails();

        Console.ReadLine();
    }
}
