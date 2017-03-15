using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ChildProject;
using ChildProject.Examples;

namespace secondcalendar
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
//            string globalAnswer;
//            //Person person = new Person(Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()));
//            Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));
            
            Exam exam = new Exam("Math", 12, DateTime.Parse("2.2.2001"));
//            Student student = new Student(person,exam,2);
//            Console.WriteLine(student);
//            
//
//            while (globalAnswer == "y");


			VectorClass val = new VectorClass();
            val.Test(exam);
            Console.ReadKey();
            //вынеси разные задачия в отдельные методы прям здесь в программе. чтоб в мейне был только вызов методов. ато бесит это каждый раз комменить
            //а можно вообще удалить)
        }
    }
}
