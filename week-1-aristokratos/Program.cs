// Week One Assignment
// Challenge

// You are required to write a console application that models a Grade Point Average (GPA) calculator and prints the result.

// Author : Oluwatobiloba Onawale
// Email : <oluwatobiloba.onawale@decagon.dev>
// github : <https://github.com/aristokratos>

namespace CGPACalculator
{
    class CgpaCal
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
        public void getStudentDetails()
        {
            Console.WriteLine("Please enter your name");
            Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("You are welcome to Aristokratos CGPA calculator, kindly add how many courses you took this semester.");

                    numberOfCourses = Convert.ToInt32(Console.ReadLine());
                    if (course != null) { break; }
                    else { Console.WriteLine("Course does not exist!. Please try inputing the right course"); }
                }
                catch
                {
                    Console.WriteLine("Course does not exist!. Please try inputing the right course");
                }
            }