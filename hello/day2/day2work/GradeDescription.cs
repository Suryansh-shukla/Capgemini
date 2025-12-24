namespace ConsoleApp1;

public class GradeDescription
{
    public void describeGrade()
    {
        Console.WriteLine("Enter the grade (E, V, G, A, F):");
        string grade = Console.ReadLine();

        switch (grade)
        {
            case "E":
                Console.WriteLine("Excellent");
                break;
            case "V":
                Console.WriteLine("Very Good");
                break;
            case "G":
                Console.WriteLine("Good");
                break;
            case "A":
                Console.WriteLine("Average");
                break;
            case "F":
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }
}