using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Domain
{
    public class Seller : Person, IEmployee
    {
        private const char DELIMITER = ';';

        public Seller(string name, string cpf, string phoneNumber, double salary)
            : base(name, cpf, phoneNumber)
        {
            this.Salary = salary;
        }

        public double Salary { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}{DELIMITER}{this.RGDocument}{DELIMITER}{this.CPFDocument}{DELIMITER}" +
                            $"{this.Address}{DELIMITER}{this.PhoneNumber}{DELIMITER}{this.Salary}"; ;
        }
    }
}