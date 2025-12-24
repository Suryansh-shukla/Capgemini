using System;
namespace ConsoleApp1;
public class Student
{
    #region Fields
    int rollno;
    string name;
    string address;
    #endregion
    #region Constructors
    ///<summary>
    /// Default Constructor
    /// </summary>
    public Student()
    {
        rollno = 100;
        name="Dummy";
        address="Dummy City";
    }
    public Student(int rollno, string name, string address)
    {
        this.rollno=rollno;
        this.name=name;
        this.address=address;
    }
    #endregion
    #region Methods
    public void DisplayDetails(Student s)
    {
        System.Console.WriteLine("Roll No: {0}",s.rollno);
        System.Console.WriteLine("Name: {0}",s.name);
        System.Console.WriteLine("Address: {0}",s.address);
    }
    #endregion
}