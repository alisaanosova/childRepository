using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Student
    {
        private Person _person = new Person();
        private Exam _exam = new Exam();
        private int _groupnumber;
        readonly Exam[] _exams = new Exam[5];
       
        private readonly double avarage;

        public Student()
        {
            _person = new Person();
            _exam = new Exam();
            _groupnumber = 0;
        }

        public Student(Person person, Exam exam, int groupnumber)
        {
            _person = person;
            _exam = exam;
            _groupnumber = groupnumber;
        }

        public void Exams(Exam exam, int i)
        {
            while (i < _exams.Length)
            {
                _exams[i] = exam;
                break;
                
            }
        }

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }

        public Exam Exam
        {
            get { return _exam; }
            set { _exam = value; }
        }

        public int GroupNumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        public override string ToString()
        {
            return $"{_person}\r\n {_exam} \r\n Group: {_groupnumber} \r\n {_exams[0]} \r\n {_exams[1]} \r\n {_exams[2]} \r\n {_exams[3]} \r\n {_exams[4]}" ;
        }
    }
}
