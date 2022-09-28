// Week One Assignment
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
           


        }


    }
}