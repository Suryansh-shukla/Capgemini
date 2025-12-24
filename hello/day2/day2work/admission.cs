namespace ConsoleApp1;

public class Admission
{
    int maths;
    int physics;
    int chemistry;
    public void check(){
        Console.WriteLine("Enter the marks of Maths:");
        maths=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks of Physics:");
        physics=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks of Chemistry:");
        chemistry=Convert.ToInt32(Console.ReadLine());
        int total=maths+physics+chemistry;
        if(maths>=65 && physics>=55 && chemistry>=50 && (total>=180|| (maths+physics)>=140)){
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else{
            Console.WriteLine("The candidate is not eligible for admission.");
        }
    }
}
