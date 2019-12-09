using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>();
            List<double> studentGradeList = new List<double>();
            Grade g = new Grade();




            // Collect each 5 students names and grade percent
            for (int i = 0; i < 5; i++)
            {
                Student s = new Student();

                Console.WriteLine("Student Name?");
                s.StudentName = Console.ReadLine();

                Console.WriteLine("Student Grade percentage?");
                s.StudentGradePercent = Convert.ToDouble(Console.ReadLine());

                studentList.Add(s);
            }




            // Used for spacer in console
            Console.WriteLine();




            // Display each students name and letter grade
            for (int i = 0; i < studentList.Count; i++)
            {

                Console.WriteLine("Name: " + studentList[i].StudentName);
                Console.WriteLine("Grade: " + g.ConvertToLetterGrade(studentList[i].StudentGradePercent));
                Console.WriteLine("------------------");

            }




            // Add each students percentage to a list
            for (int i = 0; i < studentList.Count; i++)
            {
                studentGradeList.Add(studentList[i].StudentGradePercent);

            }

            // Get the sum of the percentage list
            double sum = studentGradeList.Sum();
            // Divide sum by 5 (number of students)
            double average = sum / 5;




            // Display average percent and letter grade
            Console.WriteLine("Average grade percent for class %" + average);
            Console.WriteLine("Average Letter grade for class " + g.ConvertToLetterGrade(average));





            Console.ReadKey();
        }
    }
}
