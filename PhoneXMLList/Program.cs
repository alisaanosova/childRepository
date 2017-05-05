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
    }
    class Program
    {
        static void Main(string[] args)
        {

            PhoneList list = new PhoneList("PhonesList");
            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone() { PhoneModel = "iphone5", PhoneComp = "Apple", Price = 4500 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 7000 });
            phones.Add(new Phone() { PhoneModel = "k5", PhoneComp = "Lenovo", Price = 10000 });
            list.PhonesAdd(phones);
            //list.PhoneListShow();
            list.PhonesName("iphone5");
            Console.ReadKey();
        }
    }
}
