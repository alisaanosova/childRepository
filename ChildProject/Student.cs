using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChildProject.Examples;

namespace ChildProject
{
    class Student
    {
        private Person _person;
        private int _groupnumber;
        private Exam[] _exams = {};
        private double _avarage;
        private double Avarage
        {
            get { return _avarage; }
            set { _avarage += value;}
        }
        

        public Student()
        {
            _person = new Person();
            _groupnumber = 0;
        }

        public Student(Person person, int groupnumber)
        {
            _person = person;
            _groupnumber = groupnumber;
            Exam info = new Exam("Math", 12, DateTime.Parse("2.2.2001"));
            AddExams(new[] {info});
            Avarage = info.Valuation;
            info = new Exam("bio", 10, DateTime.Parse("12.2.2001"));
            AddExams(new[] {info});
            Avarage = info.Valuation;
            info = new Exam("geo", 9, DateTime.Parse("22.2.2001"));
            AddExams(new[] {info});
            Avarage = info.Valuation;
        }


        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }
        
           

        public void AddExams(Exam[] exams)
        {
            _exams = _exams.Concat(exams).ToArray();
        }

        public int GroupNumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        public override string ToString()
        {
            return $"{Person}\r\n Group: {GroupNumber} \r\n{(_avarage)/3}\r\n";
        }

        public virtual string ToShortString()
        {
            return "0";

        }
    }
}
