using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneXMLList
{
    interface IPhoneList
    {
        List<Phone> ReadAll();
        void AddPhone(Phone T);
        void AddPhoneList(List<Phone> T);
        void RemoveByModel(string T);
        void RemoveByCompany(string T);
        void RemoveByGuid(string T);
        void CleanTheList();
    }
}
