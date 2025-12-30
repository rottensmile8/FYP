// using System;

// public class BankAccount
// {
//     // Private fields
//     private string accountNumber;
//     private double balance;

//     // Public property: AccountNumber (GET only)
//     public string AccountNumber
//     {
//         get { return accountNumber; }
//     }

//     // Public property: Balance (GET only, private SET)
//     public double Balance
//     {
//         get { return balance; }
//         private set
//         {
//             if (value <= 0)
//             {
//                 throw new ArgumentException("Balance cannot be zero or negative");
//             }
//             balance = value;
//         }
//     }

//     // Constructor
//     public BankAccount(string accNo, double initialBalance)
//     {
//         accountNumber = accNo;

//         if (initialBalance <= 0)
//         {
//             throw new ArgumentException("Initial balance must be greater than 0.");
//         }

//         balance = initialBalance;
//     }

//     // Deposit method
//     public void Deposit(double amount)
//     {
//         if (amount <= 0)
//         {
//             Console.WriteLine("Deposit amount must be greater than zero.");
//             return;
//         }

//         balance += amount;
//         Console.WriteLine($"Successfully deposited: Rs {amount}");
//     }

//     // Withdraw method
//     public void Withdraw(double amount)
//     {
//         if (amount <= 0)
//         {
//             Console.WriteLine("Withdrawal amount must be greater than zero.");
//             return;
//         }

//         if (amount > balance)
//         {
//             Console.WriteLine("Insufficient balance.");
//             return;
//         }

//         balance -= amount;
//         Console.WriteLine($"Successfully withdrawn: Rs {amount}");
//     }
// }
