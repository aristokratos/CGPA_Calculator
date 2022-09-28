﻿// Week One Assignment
// Challenge

// You are required to write a console application that models a Grade Point Average (GPA) calculator and prints the result.

// Author : Oluwatobiloba Onawale
// Email : <oluwatobiloba.onawale@decagon.dev>
// github : <https://github.com/aristokratos>

using week_1_aristokratos;

namespace CGPACalculator
{
    class CgpaCal
    {
<<<<<<< HEAD
       

        public static void Main()
        {

            getStudentDetails  details = new getStudentDetails();
            getStudentDetails process = new getStudentDetails();
            getStudentDetails info = new getStudentDetails();
            processResult calc = new processResult();
            printTable cgpaTable = new printTable();
            info.studentDetails();
            calc.processStudentDetails();
            cgpaTable.table();
           


=======
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
            Console.WriteLine("You are welcome to Aristokratos CGPA calculator.");
            while (true)
            {
                try
                {
                    Console.WriteLine("kindly add how many courses you took this semester.");
                    numberOfCourses = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Kindly enter your course title: ");
                    course = Console.ReadLine();

                    Console.WriteLine("Kindly enter your course code: ");
                    courseCode = Console.ReadLine();

                    Console.WriteLine("Kindly enter your course unit: ");
                    courseUnit = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Kindly enter your course score: ");
                    score = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Kindly add the next course...");
                    Console.WriteLine();
                    
                    if (course != null) { break; }
                    else { Console.WriteLine("Course does not exist!. Please try inputing the right course!"); }
                }
                catch
                {
                    Console.WriteLine("Course does not exist!. Please try inputing the right course!");
                }
            }
            for (int i = 0; i < numberOfCourses; i++)
            {
               
                courseFolder.Add(course);
                courseCodeFolder.Add(courseCode);
                courseUnitFolder.Add(courseUnit);
                scoreFolder.Add(score);
            }
>>>>>>> 4bd567daa24e68c37b5d097324210f334a8efa0f
        }


<<<<<<< HEAD
=======


                }
                else if (scoreFolder[i] >= 60 && scoreFolder[i] <= 69)
                {
                    gradeUnitFolder.Add(4);
                    gradeFolder.Add('B');
                    point = 4 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 4;
                    remarkFolder.Add("Very Good");



                }
                else if (scoreFolder[i] >= 50 && scoreFolder[i] <= 59)
                {
                    gradeUnitFolder.Add(3);
                    gradeFolder.Add('C');
                    point = 3 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 3;
                    remarkFolder.Add("Good");
                }
                else if (scoreFolder[i] >= 45 && scoreFolder[i] <= 49)
                {
                    gradeUnitFolder.Add(2);
                    gradeFolder.Add('D');
                    point = 2 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 2;
                    remarkFolder.Add("Fair");



                }
                else if (scoreFolder[i] >= 40 && scoreFolder[i] <= 44)
                {
                    gradeUnitFolder.Add(1);
                    gradeFolder.Add('E');
                    point = 1 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 1;
                    remarkFolder.Add("Pass");



                }
                else
                {
                    gradeUnitFolder.Add(0);
                    gradeFolder.Add('F');
                    point = 0 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 0;
                    remarkFolder.Add("Fail");
                }
            }
            CGPA = weightedPoint / grade;
            if (CGPA >= 4.50 && CGPA <= 5.00)
            {
                result += "You are on First Class Division";

            }
            else if (CGPA >= 3.50 && CGPA <= 4.49)
            {
                result += "You are on Second Class(Upper) Division";
            }
            else if (CGPA >= 2.50 && CGPA <= 3.49)
            {
                result += "You are on Second Class(Lower) Division";
            }
            else if (CGPA >= 1.49 && CGPA <= 2.49)
            {
                result += "You are on Third Class Division";
            }
            else
            {
                result += "You are on Pass";
            }
        }
        public void printStudentDetails()
        {
            Console.WriteLine("|--------------|------------|-------------|---------|--------------|----------------------|");
            Console.WriteLine("|Course & Code |COURSE Unit |Grade  Unit  |Grade    |Weighted Point|  Remark |\t");
            Console.WriteLine("|--------------|------------|-------------|---------|--------------|-----------------------|");
            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine($"{courseFolder[i] + courseCodeFolder[i]}  \t| {courseUnitFolder[i]}  \t| {gradeUnitFolder[i]}  \t|{gradeFolder[i]}   \t|\t{weightedPointFolder[i]}    \t |\t{remarkFolder[i]} \t|");
            }
            Console.WriteLine("|--------------|------------|-------------|---------|--------------|-----------------------|");
            Console.WriteLine($"Total Grade Unit Register is {grade}");
            Console.WriteLine($"Total Grade Unit Passed is {grade}");
            Console.WriteLine($"Total Weight Point is {weightedPoint}");
            Console.WriteLine($"Your CGPA is {CGPA} to 2 decimal places");
            Console.WriteLine($"{result}");


            Console.WriteLine("Thank you for using the CGPA calculator, we hope to see you soon. Success!!!");
        }
        public static void Main()
        {
            CgpaCal program = new CgpaCal();
            program.getStudentDetails();
            program.processStudentDetails();
            program.printStudentDetails();


        }


>>>>>>> 4bd567daa24e68c37b5d097324210f334a8efa0f
    }
}