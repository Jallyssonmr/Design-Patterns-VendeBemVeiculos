using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Domain
{
    public class Person : IPerson
    {
        private const char DELIMITER = ';';

        public Person(string name, string cpfDocument, string phoneNumber)
        {
            this.Name = name;
            this.CPFDocument = cpfDocument;
            this.PhoneNumber = phoneNumber;
        }

        public string Name { get; private set; }

        public string RGDocument { get; set; }

        public string CPFDocument { get; private set; }

        public string Address { get; set; }

        public string PhoneNumber { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}{DELIMITER}{this.RGDocument}{DELIMITER}{this.CPFDocument}" +
                        $"{DELIMITER}{this.Address}{DELIMITER}{this.PhoneNumber}";
        }
    }
}