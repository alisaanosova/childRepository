using System;
using ChildProject.Examples;
using ChildProject.lab_1.option_2;

namespace ChildProject
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));
            Magazine magazine = new Magazine("IMYA",DateTime.Parse("1.2.2000"), 1 );
            magazine.AddArticle(new [] {new Article(person, "name", 2), });
            magazine.AddArticle(new [] {new Article(person, "name1", 3), });
            magazine.AddArticle(new [] {new Article(person, "name2", 5), });
            Console.WriteLine(magazine.ToString());
            Console.ReadKey();
        }
    }
}
