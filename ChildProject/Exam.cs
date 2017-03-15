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
        public string ItemName { get; set; }
        public int Valuation { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam()
        {
            ItemName = "unknown";
            Valuation = 0;
            ExamDate = DateTime.MinValue;
        }
        public Exam(string itemName, int valuation, DateTime date)
        {
            ItemName = itemName;
            Valuation = valuation;
            ExamDate = date;
        }

        public override string ToString()
        {
            return $"\r\n Item name: {ItemName} \r\n Valuation: {Valuation} \r\n ExamDate: {ExamDate}";
        }

    }
}
