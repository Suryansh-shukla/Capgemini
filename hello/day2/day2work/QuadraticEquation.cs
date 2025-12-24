namespace ConsoleApp1;

public class QuadraticEquation
{
    int a;
    int b;
    int c;
    double discriminant;
    double root1;
    double root2;
    public void calculate()
    {
        Console.WriteLine("Enter the value of a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of c:");
        c = Convert.ToInt32(Console.ReadLine());

        discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Roots are real and different. Root1: {root1}, Root2: {root2}");
        }
        else if (discriminant == 0)
        {
            root1 = root2 = -b / (2 * a);
            Console.WriteLine($"Roots are real and same. Root: {root1}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"Roots are complex and different. Root1: {realPart} + {imaginaryPart}i, Root2: {realPart} - {imaginaryPart}i");
        }
    }
}
