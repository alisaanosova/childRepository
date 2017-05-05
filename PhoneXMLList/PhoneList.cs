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


            private readonly string _fileAdress;
            public PhoneList(string fileAddress)
            {
                XDocument phone = new XDocument();
                XElement phones = new XElement("items");
                phone.Add(phones);
                _fileAdress = fileAddress;
                phone.Save(_fileAdress + ".xml");
            }

            public void PhonesAdd(string phoneModel, string phoneComp, int phonePrice)
            {
                XDocument xDoc = XDocument.Load(_fileAdress + ".xml");
                XElement root = xDoc.Element("items");

                root.Add(new XElement("phone",
                    new XAttribute("name", phoneModel),
                    new XElement("company", phoneComp),
                    new XElement("price", $"{phonePrice}")));
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
                        Console.WriteLine("SmartPhone: {0}", nameAttribute.Value);
                        Console.WriteLine("Company: {0}", companyElement.Value);
                        Console.WriteLine("Price: {0}", priceElement.Value);
                    }
                    Console.WriteLine();
                }
            }
        }
}
