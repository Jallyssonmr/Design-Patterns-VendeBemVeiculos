using System;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Domain
{
    public class Sale
    {
        private const char DELIMITER = ';';
        private const string DATE_TIME_FORMAT = "dd/MM/yyyy HH:mm:ss";

        public Sale(DateTime date, IPerson customer, IEmployee seller, Vehicle vehicle)
        {
            this.Date = date;
            this.Customer = customer;
            this.Seller = seller;
            this.Vehicle = vehicle;
        }

        public IPerson Customer { get; private set; }

        public IEmployee Seller { get; private set; }

        public Vehicle Vehicle { get; private set; }

        public DateTime Date { get; private set; }

        public override string ToString()
        {
            return $"{this.Date.ToString(DATE_TIME_FORMAT)}{DELIMITER}{this.Customer.CPFDocument}{DELIMITER}" +
                        $"{this.Seller.CPFDocument}{DELIMITER}{this.Vehicle.ToString()}";
        }
    }
}