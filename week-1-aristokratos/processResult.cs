﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_1_aristokratos
{
    public class processResult
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

        public void processStudentDetails()
        {
            weightedPoint = 0;
            grade = 0;
            for (int i = 0; i < numberOfCourses; i++)
            {
                if (scoreFolder[i] >= 70 && scoreFolder[i] <= 100)
                {
                    gradeUnitFolder.Add(5);
                    gradeFolder.Add('A');
                    point = 5 * courseUnitFolder[i];
                    weightedPointFolder.Add(point);
                    weightedPoint += point;
                    grade += 5;
                    remarkFolder.Add("Excellent");




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
            if (grade > 0)
            {
                CGPA = weightedPoint / grade;
            }
            else
            {
                CGPA = 0;
            }
            
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
    }
}