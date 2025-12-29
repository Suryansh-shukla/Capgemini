using System.Collections.Generic;
using LPU_Common;
using LPU_Entity;
using LPU_Exceptions;
namespace LPU_DAL
{
    public class StudentDAO : IStudentCRUD
    {
        ///<summary>
        ///this class and funcitons will be used for CRUD Operations
        ///</summary>
        static List<Student> studentList = null;
        public StudentDAO()
        {
            studentList = new List<Student>()
            {
                new Student(){StudentID=1,Name="Suryansh Shukla",Address="Lucknow",Course=CourseType.CSE},
                new Student(){StudentID=2,Name="Aman Kumar",Address="Delhi",Course=CourseType.IT},
                new Student(){StudentID=3,Name="Rohit Singh",Address="Mumbai",Course=CourseType.Mechanical},
                new Student(){StudentID=4,Name="Anjali Verma",Address="Bangalore",Course=CourseType.Electrical},
                new Student(){StudentID=5,Name="Priya Sharma",Address="Chennai",Course=CourseType.Civil}
            };
        }

        public Student SearchStudentById(int rollNo)
        {
            Student myStud = null;
            if (rollNo != 0)
            {
                myStud = studentList.Find(s => s.StudentID == rollNo);
                if(myStud == null)
                {
                    throw new LPU_Exception("Student Record Not Found");
                }
            }
            else
            {
                   throw new LPU_Exception("Error Generated .......");
            }
            return myStud;

        }

        public List<Student> SearchStudentByName(string name)
        {
            List<Student> data= studentList.FindAll(p=>p.Name==name);
            return data;
        }

        public bool EnrollStudent(Student sObj)
        {
            bool flag = false;
            if (sObj != null) 
            {
                studentList.Add(sObj);
                flag = true;
            }
            return flag;
        }

        public bool UpdateStudentDetails(int id, Student newObj)
        {
            var index = studentList.FindIndex(s => s.StudentID == id);
            if (index == -1 || newObj == null)
            {
                return false;
            }
            studentList[index] = newObj;
            return true;
        }

        public bool DropStudentDetails(int id)
        {
            var student = studentList.Find(s => s.StudentID == id);
            if (student == null)
            {
                return false;
            }
            studentList.Remove(student);
            return true;
        }
    }
}
