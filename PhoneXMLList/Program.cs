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
        public Guid Id = Guid.NewGuid();
    }
    class Program
    {
        static void Main(string[] args)
        {

            PhoneXmlRepository list = new PhoneXmlRepository("SecondPhoneList");
            //list.CleanTheList();
            //List<Phone> phone = new List<Phone>();
            //phone.Add(new Phone() {PhoneModel = "a3333333", PhoneComp = "nokia", Price = 4000});
            //phone.Add(new Phone() {PhoneModel = "a400000", PhoneComp = "nokia", Price = 5000});
            //phone.Add(new Phone() {PhoneModel = "a55555555", PhoneComp = "nokia", Price = 6000});
            //phone.Add(new Phone() {PhoneModel = "a66666", PhoneComp = "nokia", Price = 7000});
            //list.AddPhoneList(phone);
            //list.AddPhone(new Phone() { PhoneModel = "a66666", PhoneComp = "nokia", Price = 10000 });
            //List<Phone> testlist = list.ReadAll();
            list.RemoveByGuid("8831672c-4874-4a55-91b6-347f1f1c5bec");
            Console.ReadKey();
        }
    }
}
