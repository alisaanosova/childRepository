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
        private int[] _array = {};
        private double _avarage;
        public void Avarage()
        {
            {
                for (int i = 0; i < _array.Length; i++)
                    _avarage += _array[i];
            }
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
        public void AddValuation(int[] exams)
        {
            _array = _array.Concat(exams).ToArray();
        }

        public int GroupNumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        public override string ToString()
        {
            return $"{Person}\r\n Group: {GroupNumber} \r\n{_exams[0]}\r\n{_exams[1]}\r\n{_avarage/_array.Length}";
        }

        public virtual string ToShortString()
        {
            return "0";

        }
    }
}
