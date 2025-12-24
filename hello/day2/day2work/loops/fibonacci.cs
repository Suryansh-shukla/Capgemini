namespace ConsoleApp1;

public class Fibonacci
{
    int first=0;
    int second=1;
    int next;
    public void generateFibonacci()
    {
        Console.WriteLine("Enter the number of terms for Fibonacci series:");
        int terms = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < terms; i++)
        {
            if (i <= 1)
            {
                next = i;
            }
            else
            {
                next = first + second;
                first = second;
                second = next;
            }
            Console.WriteLine(next);
        }
    }
    
}
