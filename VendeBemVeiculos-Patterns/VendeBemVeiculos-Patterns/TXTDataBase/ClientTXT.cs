using System;
using VendeBemVeiculos_Patterns.Domain;

namespace VendeBemVeiculos_Patterns.TXTDataBase
{
    public class ClientTXT : TXTDataBase<Person>
    {
        private const int NAME = 0;
        private const int RG_DOCUMENT = 1;
        private const int CPF_DOCUMENT = 2;
        private const int ADDRESS = 3;
        private const int PHONE_NUMBER = 4;
        private const char DELIMITER = ';';
        protected const string BREAK_LINE = "\r\n";

        protected override string ConvertInstanceToText(Person person)
        {
            if (person == null) { throw new NullReferenceException(); }
            return $"{person.Name}{DELIMITER}{person.RGDocument}{DELIMITER}{person.CPFDocument}{DELIMITER}{person.Address}" +
                $"{DELIMITER}{person.PhoneNumber}{BREAK_LINE}";
        }

        protected override Person GetLineContent(string line)
        {
            var data = line.Split(DELIMITER);
            var loadedPerson = new Person(data[NAME], data[CPF_DOCUMENT], data[PHONE_NUMBER])
            {
                RGDocument = data[PHONE_NUMBER],
                Address = data[ADDRESS]
            };
            return loadedPerson;
        }
    }
}
