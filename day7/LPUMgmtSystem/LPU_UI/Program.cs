using System;
using LPU_Common;
using LPU_DAL;
using LPU_Entity;
using LPU_BL;
using LPU_Exceptions;
namespace LPU_UI
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("     Student Management System    ");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Search Student by ID");
            Console.WriteLine("2. Show All Students");
            Console.WriteLine("3. Add Student Details");
            Console.WriteLine("4. Update Student Details");
            Console.WriteLine("5. Delete Student Details");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            Student_BL sBLObj = null;
            sBLObj = new Student_BL();
            do
            {
                Menu();
                int choice = 0;
                Console.Write("PLease Enter your choice: ");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1://Search Student by ID
                        {
                            int id = 0;
                            try
                            {
                                Console.WriteLine("Enter Student ID to be searched: ");
                                id = Convert.ToInt32(Console.ReadLine());
                                Student sObj = sBLObj.SearchStudentById(id);
                                if(sObj != null) 
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("=============================================");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");
                                    Console.ForegroundColor= ConsoleColor.White;
                                }
                                else 
                                {
                                    Console.WriteLine("Student not found.");
                                }
                            }
                            catch(LPU_Exception e) 
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch(Exception e) 
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 2://Show All Students
                        {
                            try
                            {
                                Console.WriteLine("Enter Student Name for Search:");
                                string name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                {
                                    Console.WriteLine("Student name cannot be empty.");
                                    break;
                                }
                                List<Student> studList = sBLObj.SearchStudentByName(name);
                                if (studList != null)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("ID\t| Name\t| Course\t| Address");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("=============================================");
                                    foreach (var sObj in studList)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine($"{sObj.StudentID}\t| {sObj.Name}\t| {sObj.Course}\t| {sObj.Address}");

                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No Students found.");
                                }
                            }
                            catch (LPU_Exception e)
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are Coming soon....");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            catch (Exception e)
                            {

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("We are Coming soon....");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        }
                     case 3://Add Student Details
                        {
                            break;

                        }
                    case 4://Update Student Details
                        {
                            break;
                        }
                     case 5://Delete Student Details
                        {
                            break;
                        }
                     case 6://Exit from Application
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
            }
            while(true);
        }
    }
}