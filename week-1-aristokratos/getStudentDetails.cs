using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace week_1_aristokratos
{
    public  class getStudentDetails
    {
        int score, grade, point, courseUnit, numberOfCourses, weightedPoint;
        double CGPA;
        string courseCode;
        string userName;
        string course = "";
        string result = "";
        List<string> courseFolder = new List<string>();
        List<string> courseCodeFolder = new List<string>();
        List<int> scoreFolder = new();
        List<char> gradeFolder = new List<char>();
        List<string> remarkFolder = new List<string>();
        List<int> courseUnitFolder = new List<int>();
        List<int> gradeUnitFolder = new List<int>();
        List<int> weightedPointFolder = new List<int>();
       
        
        public void studentDetails()
        {
            Console.WriteLine("You are welcome to Aristokratos CGPA calculator");
            
            
            Console.WriteLine("Please enter your name");
            userName = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("kindly add the number of courses you took this semester.");

                    numberOfCourses = Convert.ToInt32(Console.ReadLine());
                    if (course != null) { break; }
                    else { Console.WriteLine("Course does not exist!. Please try inputing the right course"); }
                }
                catch
                {
                    Console.WriteLine("Course does not exist!. Please try inputing the right course");
                }
            }

            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine("Kindly enter your course title: ");
                course = Console.ReadLine();

                while (true)
                {
                    try
                    {

                         Console.WriteLine("Kindly enter your course code: ");
                        courseCode = Console.ReadLine();
                        if (course != null) { break; }
                        else { Console.WriteLine("Invalid input!. Please try inputing the correct course code"); }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!. Please try inputing the correct course code");
                    }
                }



                while (true)
                {
                    try
                    {

                        Console.WriteLine("Kindly enter your course unit: ");
                        courseUnit = Convert.ToInt32(Console.ReadLine());
                        if (course != null) { break; }
                        else { Console.WriteLine("Invalid input!. Please try inputing the correct course unit"); }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!. Please try inputing the correct course unit");
                    }
                }


                while (true)
                {
                    try
                    {

                        Console.WriteLine("Kindly enter your course score: ");
                        score = Convert.ToInt32(Console.ReadLine());
                        if (course != null) { break; }
                        else { Console.WriteLine("Invalid input!. Please try inputing the correct score"); }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!. Please try inputing the correct score");
                    }
                }
                
                Console.WriteLine("Kindly add the next course...");
                Console.WriteLine();
                
                

                courseFolder.Add(course);
                courseCodeFolder.Add(courseCode);
                courseUnitFolder.Add(courseUnit);
                scoreFolder.Add(score);
            }
        }

    }
}
