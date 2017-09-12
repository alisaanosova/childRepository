using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PhoneXMLList
{
    class PhoneXmlRepository : IList
    {
        private readonly string _fileAdress;
        private int copyID = 1;
        public PhoneXmlRepository(string fileAddress)
        {
            _fileAdress = fileAddress; 
        }


        public List<Phone> ReadAll()
        {
            XDocument xDoc = XDocument.Load(_fileAdress+".xml");
            List<Phone> phonesList = new List<Phone>();
            foreach (XElement phoneElement in xDoc.Element("items").Elements("phone"))
            {
                XAttribute idAttribute = phoneElement.Attribute("id");
                XElement nameAttribute = phoneElement.Element("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");
                phonesList.Add(new Phone() {PhoneModel = nameAttribute.Value, PhoneComp = companyElement.Value, Price = int.Parse(priceElement.Value), Id = Guid.Parse(idAttribute.Value)});
            }
            return phonesList;
        }
        public void AddPhone(Phone phone)
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");
            XElement root = xDoc.Element("items");
                 root.Add(new XElement("phone",
                    new XAttribute("id",phone.Id), 
                    new XElement("name", phone.PhoneModel),
                    new XElement("company", phone.PhoneComp),
                    new XElement("price", $"{phone.Price}")));
            xDoc.Save(_fileAdress + ".xml");
        }

        public void AddPhoneList(List<Phone> phoneList)
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");

            XElement root = xDoc.Element("items");
            foreach (Phone xe in phoneList)
            {
                root.Add(new XElement("phone",
                    new XAttribute("id",xe.Id),
                    new XElement("name", xe.PhoneModel),
                    new XElement("company", xe.PhoneComp),
                    new XElement("price", $"{xe.Price}")));
            }
            xDoc.Save(_fileAdress + ".xml");
        }

        public void RemoveByModel(string phoneModel)
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");

            XElement root = xDoc.Element("items");

            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Attribute("name").Value == phoneModel)
                {
                    xe.Remove();
                }
            }
            xDoc.Save(_fileAdress+".xml");
        }

        public void RemoveByCompany(string phoneCompany)
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");

            XElement root = xDoc.Element("items");

            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Element("company").Value == phoneCompany)
                {
                    xe.RemoveAll();
                }
            }
            xDoc.Save(_fileAdress+".xml");
            
        }

        public void RemoveByGuid(string guid)
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");

            XElement root = xDoc.Element("items");
            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Attribute("id").Value == guid)
                {
                    xe.RemoveAll();
                }
            }
            xDoc.Save(_fileAdress + ".xml");

        }

        public void CleanTheList()
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");
            xDoc.Root.RemoveAll();
            xDoc.Save(_fileAdress + ".xml");
        }

        public void CopyList()
        {
            XDocument xDoc = XDocument.Load(_fileAdress + ".xml");
            xDoc.Save(_fileAdress + copyID+".xml");
            copyID++;
        }

        public void MergeFiles(string fileAddres)
        {
            XDocument doc = XDocument.Load(fileAddres+".xml");

            List<Phone> phoneList = new List<Phone>();
            foreach (XElement phoneElement in doc.Element("items").Elements("phone"))
            {
                XAttribute idAttribute = phoneElement.Attribute("id");
                XElement nameAttribute = phoneElement.Element("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");
                phoneList.Add(new Phone() { PhoneModel = nameAttribute.Value, PhoneComp = companyElement.Value, Price = int.Parse(priceElement.Value), Id = Guid.Parse(idAttribute.Value) });
            }
            AddPhoneList(phoneList);
        }
    }
}
