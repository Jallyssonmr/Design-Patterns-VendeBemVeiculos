using System;
using VendeBemVeiculos_Patterns.Domain;

namespace VendeBemVeiculos_Patterns.TXTDataBase
{
    class VehicleTXT : TXTDataBase<Vehicle>
    {
        private const int BRAND = 0;
        private const int MODEL = 1;
        private const int YEAR= 2;
        private const int COLOR= 3;
        private const int PRICE = 4;

        private static string filePath = "vehicle.txt";
        private const char DELIMITER = ';';
        private const string BREAK_LINE = "\r\n";

        public VehicleTXT()
        {
            this.FilePath = filePath;
        }
        
        protected override string ConvertInstanceToText(Vehicle vehicle)
        {
            if(vehicle == null) { throw new NullReferenceException(); }

            return $"{vehicle.Brand}{DELIMITER}{vehicle.Model}{DELIMITER}{vehicle.Year}{DELIMITER}{vehicle.Color}" +
                $"{DELIMITER}{vehicle.Price}{BREAK_LINE}";
        }

        protected override Vehicle GetLineContent(string line)
        {
            var data = line.Split(DELIMITER);
            return new Vehicle(data[BRAND], data[MODEL], int.Parse(data[YEAR]), data[COLOR], 
                Convert.ToDouble(data[PRICE]));
        }
    }
}
