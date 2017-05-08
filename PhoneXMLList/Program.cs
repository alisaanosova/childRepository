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
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 5000 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 6000 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 6500 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 6750 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 6800 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 7000 });
            phones.Add(new Phone() { PhoneModel = "galaxy", PhoneComp = "Samsung", Price = 8000 });
            phones.Add(new Phone() { PhoneModel = "k5", PhoneComp = "Lenovo", Price = 10000 });
            list.PhonesAdd(phones);
            //list.PhoneListShow();
            list.PhonesName("iphone5");
            list.PhonePrice(6345);
            Console.ReadKey();
        }
    }
}
