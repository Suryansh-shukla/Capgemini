namespace ConsoleApp1;

public class QuadrantFinder
{
    public void findQuadrant()
    {
        Console.WriteLine("Enter the x-coordinate:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the y-coordinate:");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in the first quadrant.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in the second quadrant.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in the third quadrant.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in the fourth quadrant.");
        }
    }
}