using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
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
        private int _highestValuation;

        private double Avarage
        {
            get
            {
                for (int i = 0; i < _exams.Length; i++)
                {
                    _avarage += _exams[i].Valuation;
                }
                
                return _avarage/_exams.Length;
            }

        }

        private int Highest
        {
            get
            {
                _highestValuation = int.MinValue;
                for (int i = 0; i < _exams.Length; i++)
                {
                    if (_exams[i].Valuation > _highestValuation)
                    {
                        _highestValuation = _exams[i].Valuation;
                    }
                }
                return _highestValuation;
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

        public int GroupNumber
        {
            get { return _groupnumber; }
            set { _groupnumber = value; }
        }

        public override string ToString()
        {
            return $"{Person}\r\n Group: {GroupNumber} \r\n{_exams[0]}\r\n{_exams[1]}\r\n{Avarage}\r\n{Highest}";
        }

        public virtual string ToShortString()
        {
            return "0";

        }
    }
}
