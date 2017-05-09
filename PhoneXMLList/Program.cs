using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneXMLList
{
    class Phone
    {
        public string PhoneModel { get; set; }
        public string PhoneComp { get; set; }
        public int Price { get; set; }
        public int id { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PhoneXmlRepository list = new PhoneXmlRepository("SecondPhoneList");
            List<Phone> phone = new List<Phone>();
            phone.Add(new Phone() {PhoneModel = "a3333333", PhoneComp = "nokia", Price = 4000});
            phone.Add(new Phone() {PhoneModel = "a400000", PhoneComp = "nokia", Price = 5000});
            phone.Add(new Phone() {PhoneModel = "a55555555", PhoneComp = "nokia", Price = 6000});
            phone.Add(new Phone() {PhoneModel = "a66666", PhoneComp = "nokia", Price = 7000});
            list.AddPhoneList(phone);
            List<Phone> phonesList = list.ReadAll();
            list.CopyList();
            Console.ReadKey();
        }
    }
}
