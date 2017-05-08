using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneXMLList
{
    class PhoneList//надозови класс более внятно. должно нызыватсья что-то типа PhoneXMLRepository
    {
        private List<Phone> _phones; // зачем ты создал здесь телефоны? ты должен вытягивать в каждом методе а не записывать их в память.
        //вдруг в другой части кода тоже будут юзать такой класс и этот документ и у тебя будет несоответсвие данных
            private readonly string _fileAdress;
            public PhoneList(string fileAddress)
            {
                XDocument phone = new XDocument();
                XElement phones = new XElement("items");
                phone.Add(phones);
               
                _fileAdress = fileAddress; // это правильно, но зачем ты в конструкторе делаешь все остальное
                
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

            public void PhoneListShow() //полагаю этот метод просто для удобства? потому что в репозитории его быть не должно
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

        public void PhonesName(string name)//тоже бред. ты должен был достать телефон по имени из конкретного файла 
            //а не из списка телефоном, который есть у тебя заранее
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
