using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneXMLList
{
    class PhoneXmlRepository
    {
        private readonly string _fileAdress;
        private readonly XDocument _phonesDocumentList;
        private List<Phone> _phonesList = new List<Phone>();  
        private int i = 1;
        public PhoneXmlRepository(string fileAddress)
        {
            XDocument phonesDocumenList = XDocument.Load(fileAddress+".xml");
            _phonesDocumentList = phonesDocumenList;
            _fileAdress = fileAddress; 
        }


        public List<Phone> ReadAll()
        {
            int i = 0;
            foreach (XElement phoneElement in _phonesDocumentList.Element("items").Elements("phone"))
            {
                XAttribute idAttribute = phoneElement.Attribute("id");
                XElement nameAttribute = phoneElement.Element("name");
                XElement companyElement = phoneElement.Element("company");
                XElement priceElement = phoneElement.Element("price");
                i++;
                _phonesList.Add(new Phone() {PhoneModel = nameAttribute.Value, PhoneComp = companyElement.Value, Price = int.Parse(priceElement.Value), id = int.Parse(idAttribute.Value)});
            }
            return _phonesList;
        }
        public void AddPhone(string phoneModel, string phoneCompany, int price)
        {
            XElement root = _phonesDocumentList.Element("items");
                 root.Add(new XElement("phone",
                    new XAttribute("id", i++), 
                    new XElement("name", phoneModel),
                    new XElement("company", phoneCompany),
                    new XElement("price", $"{price}")));
            _phonesDocumentList.Save(_fileAdress + ".xml");
        }

        public void AddPhoneList(List<Phone> phoneList)
        {
            XElement root = _phonesDocumentList.Element("items");
            
            foreach (Phone xe in phoneList)
            {
                root.Add(new XElement("phone",
                    new XAttribute("id", i++),
                    new XElement("name", xe.PhoneModel),
                    new XElement("company", xe.PhoneComp),
                    new XElement("price", $"{xe.Price}")));
            }
            _phonesDocumentList.Save(_fileAdress + ".xml");
        }

        public void RemovePhone(string phoneModel)
        {
            XElement root = _phonesDocumentList.Element("items");

            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Attribute("name").Value == phoneModel)
                {
                    xe.Remove();
                }
            }
            _phonesDocumentList.Save(_fileAdress+".xml");
        }

        public void RemoveCompany(string phoneCompany)
        {
            XElement root = _phonesDocumentList.Element("items");

            foreach (XElement xe in root.Elements("phone").ToList())
            {
                if (xe.Element("company").Value == phoneCompany)
                {
                    xe.RemoveAll();
                }
            }
            _phonesDocumentList.Save(_fileAdress+".xml");
        }
    }
}
