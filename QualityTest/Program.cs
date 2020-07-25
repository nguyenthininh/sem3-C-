using System;
using System.Collections.Generic;
using QualityTest.Controller;
using QualityTest.Models;

namespace QualityTest
{
    class Program
    {
         public static StudentController st = new StudentController();
        static void Main(string[] args)
        {
            GenerateMenu();
        }
        
        public static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. List Student");
                Console.WriteLine("0. Exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        st.CreateStudent();
                        GenerateMenu();
                        break;
                    case 2:
                        st.PrintListStudent();
                        GenerateMenu();
                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;
                }
            }

        }
    }
}