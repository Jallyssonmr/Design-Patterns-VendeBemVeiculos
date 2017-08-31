namespace VendeBemVeiculos_Patterns.Domain
{
    public class Vehicle
    {
        private const char DELIMITER = ';';

        public Vehicle(string brand, string model, int year, string color)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Color = color;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            return $"{this.Brand}{DELIMITER}{this.Model}{DELIMITER}{this.Year}{DELIMITER}{this.Color}";
        }

        public override bool Equals(object obj)
        {
            if((obj is Vehicle) == false)
            {
                return false;
            }

            var vehicleToCompare = (Vehicle)obj;
            return this.Brand == vehicleToCompare.Brand && this.Model == vehicleToCompare.Model 
                                && this.Year == vehicleToCompare.Year && this.Color == vehicleToCompare.Color;
        }

        public override int GetHashCode()
        {
            return this.Brand.GetHashCode() + this.Model.GetHashCode() + this.Year.GetHashCode() + this.Color.GetHashCode();
        }
    }
}