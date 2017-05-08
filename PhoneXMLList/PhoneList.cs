using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneXMLList
{
    class PhoneList
    {
        private List<Phone> _phones; 
            private readonly string _fileAdress;
            public PhoneList(string fileAddress)
            {
                XDocument phone = new XDocument();
                XElement phones = new XElement("items");
                phone.Add(phones);
                _fileAdress = fileAddress;
                phone.Save(_fileAdress + ".xml");
            }

            public void PhonesAdd(List<Phone> phones)
            {
                _phones = phones;
                XDocument xDoc = XDocument.Load(_fileAdress + ".xml");
                XElement root = xDoc.Element("items");
                foreach (Phone p in _phones)
                {
                    root.Add(new XElement("phone",
                        new XAttribute("name", p.PhoneModel),
                        new XElement("company", p.PhoneComp),
                        new XElement("price", $"{p.Price}")));
                }
                xDoc.Save(_fileAdress + ".xml");
            }

            public void PhoneListShow()
            {
                XDocument xdoc = XDocument.Load(_fileAdress + ".xml");
                foreach (XElement phoneElement in xdoc.Element("items").Elements("phone"))
                {
                    XAttribute nameAttribute = phoneElement.Attribute("name");
                    XElement companyElement = phoneElement.Element("company");
                    XElement priceElement = phoneElement.Element("price");

                    if (nameAttribute != null && companyElement != null && priceElement != null)
                    {
                        Console.WriteLine("Phone Model: {0}", nameAttribute.Value);
                        Console.WriteLine("Company: {0}", companyElement.Value);
                        Console.WriteLine("Price: {0}", priceElement.Value);
                    }
                    Console.WriteLine();
                }
            }

        public void PhonesName(string name)
        {
            foreach (Phone p in _phones)
            {
                if (p.PhoneModel == name)
                    Console.WriteLine(p.PhoneComp);
            }
        }

        public void PhonePrice(int price)
        {
            int val = 0;
            foreach (Phone p in _phones)
            {
                if (p.Price <= price)
                    val = p.Price;
            }
            Console.WriteLine(val);
        }
   }
}
