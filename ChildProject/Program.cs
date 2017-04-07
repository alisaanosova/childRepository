using System;
using ChildProject.Calendar;
using ChildProject.Examples;
using ChildProject.lab_1.option_2;

namespace ChildProject
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            MyDateTime act = new MyDateTime();
            MyDateTime date = new MyDateTime(29, 2, 2001);
            MyDateTime date2 = new MyDateTime(1, 2, 2000);
            act.Chrono(ref date, ref date2);
            Console.WriteLine(date.ToString());
            Console.WriteLine(date2.ToString());
            
            act.Calculated(date, date2, out result);
            Console.WriteLine(result);
            //Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));
            //Magazine magazine = new Magazine("IMYA",DateTime.Parse("1.2.2000"), 1 );
            //magazine.AddArticle(new [] {new Article(person, "name", 2), });
            //magazine.AddArticle(new [] {new Article(person, "name1", 3), });
            //magazine.AddArticle(new [] {new Article(person, "name2", 5), });
            //Console.WriteLine(magazine.ToString());
            Console.ReadKey();
        }
    }
}
