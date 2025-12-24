namespace ConsoleApp1;

public class TriangleType
{
    public void checkTriangle()
    {
        Console.WriteLine("Enter the first side of the triangle:");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second side of the triangle:");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third side of the triangle:");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is equilateral.");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            Console.WriteLine("The triangle is isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is scalene.");
        }
    }
}