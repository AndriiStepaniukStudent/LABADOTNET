using System;

class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: division by zero.");
            return double.NaN; // NaN - Not a Number
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();

        Console.WriteLine("Enter first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter operation (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = calculator.Add(num1, num2);
                break;
            case '-':
                result = calculator.Subtract(num1, num2);
                break;
            case '*':
                result = calculator.Multiply(num1, num2);
                break;
            case '/':
                result = calculator.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}
