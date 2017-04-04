using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject.lab_1.option_2
{
    class Magazine
    {
        private string _name;
        private DateTime _date;
        private int _circulation;
        private Article[] _articles = new Article[] {};

        public Magazine()
        {
            _name = "unknown";
            _date = DateTime.MinValue;
            _circulation = 0;
            
        }

        public Magazine(string name, DateTime date, int circulation)
        {
            _name = name;
            _date = date;
            _circulation = circulation;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public Article[] Articles { get { return _articles; } set { _articles = value; } }
        public void AddArticle(params Article[] art)
        {
            _articles = _articles.Concat(art).ToArray();
        }

        public double AvarageRaiting
        {
            get
            {
                double avarage = 0;
                for (int i = 0; i < _articles.Length; i++)
                {
                    if (_articles.Length == 0)
                        return 0;
                    if (_articles.Length > 0)
                    {
                        avarage += _articles[i]._raiting;
                    }
                }
                return avarage/_articles.Length;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} \r\n Data :{Date} \r\n Circulation: {_circulation} \r\n Raiting: {AvarageRaiting} \r\n ";
        }
    }
}
