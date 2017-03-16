using System;
using ChildProject.Examples;

namespace ChildProject
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
           Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));

            
            Student student = new Student(person,2);
            Exam exam = new Exam("Math", 12, DateTime.Parse("2.2.2001"));
            student.AddExams(new [] {exam});
            student.AddValuation(new[] { exam.Valuation });
            exam = new Exam("bio", 11, DateTime.Parse("12.2.2001"));
            student.AddExams(new []{exam});
            student.AddValuation(new []{exam.Valuation});
            student.Avarage();
            Console.WriteLine(student.ToString());
            VectorClass vec = new VectorClass();
            vec.ConcatVector(new[] { new Exam("asda", 1, DateTime.Parse("2.2.300"))});
            Console.ReadKey();
        }
    }
}
