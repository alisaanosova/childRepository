using System;
using System.Collections.Generic;
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
        private Exam[] _exams = new Exam[] {};
       
        private double Avarage { get; set; }

        public Student()
        {
            _person = new Person();
            _groupnumber = 0;
        }

        public Student(Person person, int groupnumber)
        {
            _person = person;
            _groupnumber = groupnumber;
            AddExams(new[] { new Exam("Math", 12, DateTime.Parse("2.2.2001")) });
            AddExams(new[] { new Exam("bio", 10, DateTime.Parse("12.2.2001")) });
            AddExams(new[] { new Exam("geo", 9, DateTime.Parse("22.2.2001")) });
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
            return $"{Person}\r\n Group: {GroupNumber} \r\n{_exams[0]}\r\n{_exams[1]}\r\n{_exams[2]}";
        }

        public virtual string ToShortString()
        {
            return "0";

        }
    }
}
