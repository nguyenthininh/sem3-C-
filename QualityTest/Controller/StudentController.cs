using System;
using System.Collections.Generic;
using QualityTest.Models;

namespace QualityTest.Controller
{
    public class StudentController
    {
        public List<Student> StudentList { get; set; } = new List<Student>();
        public void PrintListStudent()
        {
            if (StudentList.Count > 0)
            {
                foreach (Student student in StudentList)
                {
                    Console.WriteLine("=================");
                    Console.WriteLine("FullName: " + student.FullName);
                    Console.WriteLine("RollNumber: " + student.RollNumber);
                    Console.WriteLine("Birthday: " + student.Birthday);
                    Console.WriteLine("Email: " + student.Email);
                    Console.WriteLine("Phone: " + student.Phone);
                    Console.WriteLine("CreateAt: " + student.CreatedAt);
                    Console.WriteLine("Status: " + student.Status);
                }
            }
            else
            {
                Console.WriteLine("No students found.");
            }
        }

        public Student CreateStudent()
        {
            Student st = new Student();
            Console.WriteLine("nhap thong tin sinh viên :");
            Console.WriteLine("FullName: " );
            st.FullName = Console.ReadLine();
            Console.WriteLine("RollNumber: " );
            st.RollNumber = Console.ReadLine();
            Console.WriteLine("Birthday: " );
            st.Birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Email: " );
            st.Email = Console.ReadLine();
            Console.WriteLine("Phone: " );
            st.Phone = Console.ReadLine();
            Console.WriteLine("CreatedAt: " );
            st.CreatedAt = DateTime.Today;
            Console.WriteLine("1 for Active and 0 for Deactive " );
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    st.Status = Student.StudentStatus.Active;
                    break;
                case 0:
                    st.Status = Student.StudentStatus.Deactive;
                    break;
            }

            return st;
            
        }
        
    }
}