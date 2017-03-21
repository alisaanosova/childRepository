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
        private Exam[] _exams = new Exam[] {};

        public double Avarage
        {
            get
            {
                double avarage = 0;
                for (int i = 0; i < _exams.Length; i++)
                {
                    if (_exams.Length == 0)
                        return 0;
                    if (_exams[i].Valuation > 0)
                      avarage += _exams[i].Valuation;
                }
                return avarage / _exams.Length;
            }

        }

        public string Highest
        {
            get
            {
                if (_exams.Length == 0)
                    return "Exams list is empty";
                int max = int.MinValue;
                string result = "";
                for (int i = 0; i < _exams.Length; i++)
                {
                    if (_exams[i].Valuation > max)
                    {
                        max = _exams[i].Valuation;
                        result = _exams[i].ItemName;
                    }
                }
                return result;
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
            return $"{Person}\r\n Group: {GroupNumber} \r\n";
        }

        public virtual string ToShortString()
        {
            return $"{Person}\r\n Group: {GroupNumber} \r\n Avarage valuation: {Avarage} \r\n Highest exam valuation on: {Highest}";

        }
    }
}
