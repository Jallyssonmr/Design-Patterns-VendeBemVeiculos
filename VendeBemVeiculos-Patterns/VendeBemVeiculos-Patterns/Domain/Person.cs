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

        public string Name { get; set; }

        public string RGDocument { get; set; }

        public string CPFDocument { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{this.Name}{DELIMITER}{this.RGDocument}{DELIMITER}{this.CPFDocument}" +
                        $"{DELIMITER}{this.Address}{DELIMITER}{this.PhoneNumber}";
        }
    }
}