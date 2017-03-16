﻿using System;
using ChildProject.Examples;

namespace ChildProject
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));

            
            Student student = new Student(person,2);
            Exam exam = new Exam("Math", 2, DateTime.Parse("2.2.2001"));
            student.AddExams(new [] {exam});
            exam = new Exam("bio", 9, DateTime.Parse("12.2.2001"));
            student.AddExams(new []{exam});
            exam = new Exam("Geo", 9, DateTime.Parse("12.2.2001"));
            student.AddExams(new[] { exam });
            exam = new Exam("Eng", 3, DateTime.Parse("12.2.2001"));
            student.AddExams(new[] { exam });
            exam = new Exam("Alch", 12, DateTime.Parse("12.2.2001"));
            student.AddExams(new[] { exam });

            Console.WriteLine(student.ToString());
            Console.WriteLine("Highest valuation on : {0}",student.Highest());
            Console.WriteLine("Avarage :{0}", student.Avarage);

            VectorClass vec = new VectorClass();
            
            vec.ConcatVector(new[] { new Exam("asda", 1, DateTime.Parse("2.2.300"))});
            Console.ReadKey();
        }
    }
}
