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
        private double _avarage;

        public double Avarage
        {
            get
            {
                for (int i = 0; i < _exams.Length; i++)
                {
                    if (_exams[i].Valuation > 0)
                    {
                       _avarage += _exams[i].Valuation;
                        return _avarage / _exams.Length;
                    }
                }
                return 0;
            }

        }

        public string Highest()
        {
            {
                for (int i = 0; i < _exams.Length; i++)
                {
                    
                    if  (_exams[i].Valuation > 0)
                    {
                        return "Highest valuation on: "+_exams[i].ItemName ;
                    }
                }
                return "Exam list is empty";
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
            return "0";

        }
    }
}
