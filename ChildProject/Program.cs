using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ChildProject;

namespace secondcalendar
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            string globalAnswer;
            //Person person = new Person(Console.ReadLine(), Console.ReadLine(), DateTime.Parse(Console.ReadLine()));
            Person person = new Person("pasha", "ruchkov", DateTime.Parse("2.2.2000"));
            
            Student student = new Student();
            Exam exam = new Exam("Math", 12, DateTime.Parse("2.2.2001"));
            student.Exams(exam, 0);
            exam = new Exam("biol", 11, DateTime.Parse("21.2.2001"));
            student.Exams(exam, 1);
            exam = new Exam("geom", 10, DateTime.Parse("25.2.2001"));
            student.Exams(exam, 2);
            exam = new Exam("astr", 12, DateTime.Parse("28.2.2001"));
            student.Exams(exam, 3);
            exam = new Exam("alch", 11, DateTime.Parse("1.3.2001"));
            student.Exams(exam, 4);
            student = new Student(person,exam,2);
            Console.WriteLine(student);

            
            
            do
            {
                CalendarActions my = new CalendarActions();
                Calendar info = new Calendar();
                
                

                Console.WriteLine("\r\n" + "if you want to perform actions with dates write 'act'.");
                Console.WriteLine("If you want to know whether a leap year write  'leap'");
                Console.Write("Write what you need: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    
                    case "act":
                        #region actions
                        #region enter values
                        {
                            Console.WriteLine("If you want to know the number of days between dates write 'amount'.");
                            Console.WriteLine("If you want to know the number of days from the beginning of our era write 'era'");
                            Console.WriteLine("if you want to arrange the dates in chronological order write 'chrono'.");
                            Console.Write("Write what you need: ");
                            string answer2 = Console.ReadLine();

                            Console.WriteLine("Enter first date.");
                            Console.Write("Enter day: ");
                            int day;
                            bool testday = int.TryParse(Console.ReadLine(), out day);
                            while (!testday ^ day < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testday = int.TryParse(Console.ReadLine(), out day);
                            }
                            Console.Write("Enter month: ");
                            int month;
                            bool testmonth = int.TryParse(Console.ReadLine(), out month);
                            while (!testmonth ^ month < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testmonth = int.TryParse(Console.ReadLine(), out month);
                            }
                            Console.Write("Enter year: ");
                            int year;
                            bool testyear = int.TryParse(Console.ReadLine(), out year);
                            while (!testyear ^ year < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testyear = int.TryParse(Console.ReadLine(), out year);
                            }

                            int daycheck = info.DayOfMounth(year, month);

                            bool test1 = my.isDateValue(year, month, day);

                            int res;
                            if (answer2 == "amount" ^ answer2 == "chrono")
                            {
                                if (test1)
                                {
                                    Console.WriteLine("\n\r" + "Enter second date.");
                                    Console.Write("Enter day: ");
                                    int endday;
                                    bool testendday = int.TryParse(Console.ReadLine(), out endday);
                                    while (!testendday ^ endday < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendday = int.TryParse(Console.ReadLine(), out endday);
                                    }
                                    Console.Write("Enter month: ");
                                    int endmonth;
                                    bool testendmonth = int.TryParse(Console.ReadLine(), out endmonth);
                                    while (!testendmonth ^ endmonth < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendmonth = int.TryParse(Console.ReadLine(), out endmonth);
                                    }
                                    Console.Write("Enter year: ");
                                    int endyear;
                                    bool testendyear = int.TryParse(Console.ReadLine(), out endyear);
                                    while (!testendyear ^ endyear < 0)
                                    {
                                        Console.Write("Incorret value! Try again: ");
                                        testendyear = int.TryParse(Console.ReadLine(), out endyear);
                                    }
#endregion
                                    daycheck = info.DayOfMounth(endyear, endmonth);

                                    bool test2 = my.isDateValue(endyear, endmonth, endday);
                                    if (test2)
                                    {
                                        if (answer2 == "amount")
                                        {
                                            my.Сhronology(ref day, ref month, ref year, ref endday, ref endmonth, ref endyear);
                                            my.daySum(year, endyear, endmonth, endday, day, month, out res);
                                            Console.WriteLine("Amount of days: {0} ", res);
                                        }
                                        else if (answer2 == "chrono")
                                        {
                                            my.Сhronology(ref day, ref month, ref year, ref endday, ref endmonth, ref endyear);
                                            Console.WriteLine("\r\n" + "{0}.{1}.{2}", day, month, year);
                                            Console.WriteLine("{0}.{1}.{2}", endday, endmonth, endyear);
                                        }
                                    }
                                    else
                                        Console.WriteLine("Month {0} have only {1} days.", month, daycheck);
                                }
                            }
                            else if (answer2 == "era")
                            {
                                my.startDays(year, month, day, out res);
                                Console.WriteLine(" {0}", res);
                            }
                            else
                            {
                                Console.WriteLine("Month {0} have only {1} days.", month, daycheck);
                            }


                            break;
                        }
#endregion
                    case "leap":
#region leap year
                        {
                            Console.Write("Enter year: ");
                            int year;
                            bool testyear = int.TryParse(Console.ReadLine(), out year);
                            while (!testyear ^ year < 0)
                            {
                                Console.Write("Incorret value! Try again: ");
                                testyear = int.TryParse(Console.ReadLine(), out year);
                            }

                            bool test = info.Leap(year);
                            if (test)
                            {
                                Console.WriteLine("{0} leap year.", year);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("{0} not a leap year!", year);
                                break;
                            }
                        }

                }
#endregion
                Console.Write("\r\n" + "Try again? y/n;");
                globalAnswer = Console.ReadLine();
            }
            while (globalAnswer == "y");

        }
    }
}
