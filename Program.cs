using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Practice:
Develop a custom class Student containing personal information and array of Marks.
Mark is a custom class containing name of a subject and its mark.
Student class also has GetAvgMark (returning average of all marks) and ResetAllMarks (making all student’s marks equal to zero) methods, which you need to implement.
*/

namespace FirstTask
{
    public class Student
    {
        public string name;
        public string surname;
        public int age;
        public Mark[] marks;
        
        public int GetAvgMark()
        {
            int amount = 0;
            for(int i = 0; i < marks.Length; i++)
            {
                amount += marks[i].subjectMark;
            }
            return amount / marks.Length;
        }
        
        public void ResetAllMarks()
        {
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i].subjectMark = 0;
            } 
        }
    }

    public class Mark
    {
        public string subjectName;
        public int subjectMark;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Student firstStudent = new Student();
            //Data input.
            Console.WriteLine("Enter the name of the student: ");
            firstStudent.name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the surname of the student: ");
            firstStudent.surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the age of the student: ");
            firstStudent.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of subjects: ");
            number = Convert.ToInt32(Console.ReadLine());

            firstStudent.marks = new Mark[number];
            for(int i = 0; i < number; i++)
            {
                firstStudent.marks[i] = new Mark();
                Console.WriteLine("Enter the name of the subject: ");
                firstStudent.marks[i].subjectName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Enter the mark of the subject: ");
                firstStudent.marks[i].subjectMark = Convert.ToInt32(Console.ReadLine());
            }
            //Data output.
            Console.WriteLine("The student's name: "+firstStudent.name);
            Console.WriteLine("The student's surname: "+firstStudent.surname);
            Console.WriteLine("The student's age: "+firstStudent.age);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("The name of the subject: "+firstStudent.marks[i].subjectName);
                Console.WriteLine("The mark of the subject: "+firstStudent.marks[i].subjectMark);
            }
            Console.WriteLine("The average of all marks: "+firstStudent.GetAvgMark());

            Console.ReadKey();
        }
    }
}