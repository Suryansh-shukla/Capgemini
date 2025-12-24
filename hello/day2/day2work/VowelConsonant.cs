namespace ConsoleApp1;

public class VowelConsonant
{
    public void check()
    {
        Console.WriteLine("Enter a character:");
        char ch = Convert.ToChar(Console.ReadLine());
        switch(ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine($"{ch} is a Vowel");
                break;
            default:
                Console.WriteLine($"{ch} is a Consonant");
                break;
        }
    }
}