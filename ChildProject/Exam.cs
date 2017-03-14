using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildProject
{
    class Exam
    {
		//переделать на автосвойства, соблюдать ноттацию
		//во всех остальных местах использовать уже свойства и это качается и других классов
        public string _itemName;
        public int _valuation;
        public DateTime _examDate;

        public Exam()
        {
            _itemName = "unknown";
            _valuation = 0;
            _examDate = DateTime.MinValue;
        }
        public Exam(string itemName, int valuation, DateTime date)
        {
            _itemName = itemName;
            _valuation = valuation;
            _examDate = date;
        }

        public override string ToString()
        {
            return $"\r\n Item name: {_itemName} \r\n Valuation: {_valuation} \r\n ExamDate: {_examDate}";
        }

    }
}
