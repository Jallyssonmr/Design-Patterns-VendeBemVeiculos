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
    }
}