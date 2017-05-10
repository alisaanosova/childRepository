using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace PhoneXMLList
{
    class PhoneXmlRepository
    {
        private readonly string _fileAdress;
        private readonly XDocument _phonesDocumentList;//это тоже убрать в метод, потому что у тебя будет не корректная инфа при повторном использовании
        private List<Phone> _phonesList = new List<Phone>();  //это надо убрать, сразу методе создавай лист и возвращай его, тебе не нужно проперти
        private int i = 1;//зачем это?
        private readonly XDocument _phonesDocumentList;
        private readonly List<Phone> _phonesList = new List<Phone>();  
        private int i = 1;
        private int copyID = 1;
        public PhoneXmlRepository(string fileAddress)
        {
            XDocument phonesDocumenList = XDocument.Load(fileAddress+".xml");
            _phonesDocumentList = phonesDocumenList;
            _fileAdress = fileAddress; 
        }


        public List<Phone> ReadAll()
        {//по сути тут надо сразу создать лист и вернуть его. нам не нужно создавать поле
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
        public void AddPhone(string phoneModel, string phoneCompany, int price)//передавай сюда сразу телефон
        {
            //ага. теперь вижу зачем i видно что думал, тогда хвалю))). но это не совсем хороший вариант. **подумай почему
            //да и по сути тебе не надо в этом классе знать сколько элементов там сейчас.
            //можно считать что тебе уже подается корректная инфа и уникальность обеспечивается где-то раньше
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

        public void RemovePhone(string phoneModel)//тут тоже стоит писать наприер ремув бай нейм.ну или по какому параметру удаляешь
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

        public void CleanTheList()
        {
            _phonesDocumentList.Root.RemoveAll();
            _phonesDocumentList.Save(_fileAdress + ".xml");
        }

        public void CopyList()
        {
            _phonesDocumentList.Save(_fileAdress + copyID+".xml");
            copyID++;
        }
    }
}
