using Microsoft.AspNetCore.Components;

namespace dotnetapp.Pages
{
    public partial class Calculator : ComponentBase
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public bool HasResult { get; set; }
        public bool ShowError { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;

        public void Add() => Calculate((a, b) => a + b);
        public void Subtract() => Calculate((a, b) => a - b);
        public void Multiply() => Calculate((a, b) => a * b);

        public void Divide()
        {
            if (Num2 == 0)
            {
                ShowError = true;
                HasResult = false;
                ErrorMessage = "Cannot divide by zero";
                return;
            }

            Calculate((a, b) => a / b);
        }

        public void Clear()
        {
            Num1 = 0;
            Num2 = 0;
            Result = 0;
            HasResult = false;
            ShowError = false;
            ErrorMessage = string.Empty;
        }

        private void Calculate(Func<double, double, double> operation)
        {
            ShowError = false;
            HasResult = true;
            Result = operation(Num1, Num2);
        }
    }
}
