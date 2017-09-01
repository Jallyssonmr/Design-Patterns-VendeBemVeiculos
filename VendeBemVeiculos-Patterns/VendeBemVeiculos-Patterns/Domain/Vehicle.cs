using System;

namespace VendeBemVeiculos_Patterns.Domain
{
    public class Vehicle
    {
        private const char DELIMITER = ';';

        public Vehicle(string brand, string model, int year, string color, double price)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.Price = price;
        }

        public string Brand { get; private set; }

        public string Model { get; private set; }

        public int Year { get; private set; }

        public string Color { get; private set; }

        public double Price { get; private set; }

        public override string ToString()
        {
            return $"{this.Brand}{DELIMITER}{this.Model}{DELIMITER}{this.Year}{DELIMITER}{this.Color}{DELIMITER}{this.Price}";
        }

        public override bool Equals(object obj)
        {
            if((obj is Vehicle) == false)
            {
                return false;
            }

            var vehicleToCompare = (Vehicle)obj;
            return this.Brand == vehicleToCompare.Brand && this.Model == vehicleToCompare.Model 
                                && this.Year == vehicleToCompare.Year && this.Color == vehicleToCompare.Color 
                                && this.Price == vehicleToCompare.Price;
        }

        public override int GetHashCode()
        {
            return this.Brand.GetHashCode() + this.Model.GetHashCode() + this.Year.GetHashCode() + 
                this.Color.GetHashCode() + this.Price.GetHashCode();
        }
    }
}