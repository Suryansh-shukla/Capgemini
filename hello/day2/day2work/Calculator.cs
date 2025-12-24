namespace ConsoleApp1;

public class Calculator
{
    while(true){
        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /):");
        string op = Console.ReadLine();

        double result = 0;

        switch (op)
        {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                    result = num1 / num2;
                break;
            default:
                Console.WriteLine("Error: Invalid operator");
                continue;
        }

        Console.WriteLine($"Result: {result}");
    }
}
