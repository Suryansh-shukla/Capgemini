namespace ConsoleApp1;

public class ValidDate
{
    public void isValidDate()//handle 29 feb case as well
    {
        Console.WriteLine("Enter day:");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter month:");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter year:");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isValid = true;

        if (month < 1 || month > 12)
        {
            isValid = false;
        }
        else
        {
            int[] daysInMonth = { 31, (DateTime.IsLeapYear(year) ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day < 1 || day > daysInMonth[month - 1])
            {
                isValid = false;
            }
        }

        if (isValid)
        {
            Console.WriteLine("The date is valid.");
        }
        else
        {
            Console.WriteLine("The date is invalid.");
        }
    }
}