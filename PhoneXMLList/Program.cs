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
            phones.Add(new Phone() { PhoneModel = "a3310", PhoneComp = "nokia", Price = 4000 });
            phones.Add(new Phone() { PhoneModel = "a3310", PhoneComp = "nokia", Price = 4000 });
            phones.Add(new Phone() { PhoneModel = "a3310", PhoneComp = "nokia", Price = 4000 });
            foreach (Phone p in phones)
            {
                list.PhonesAdd(p.PhoneModel, p.PhoneComp, p.Price);
            }
            list.PhoneListShow();
            Console.ReadKey();
        }
    }
}
