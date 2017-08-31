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

        private static string filePath = @"C:\Users\gabriel.poltronieri\Documents\GitHub\Design-Patterns-VendeBemVeiculos\VendeBemVeiculos-Patterns\VendeBemVeiculos-Patterns\bin\Debug\vehicle.txt";
        private const char DELIMITER = ';';
        private const string BREAK_LINE = "\r\n";

        public VehicleTXT()
        {
            this.FilePath = filePath;
        }
        
        protected override string ConvertInstanceToText(Vehicle vehicle)
        {
            if(vehicle == null) { throw new NullReferenceException(); }

            return $"{vehicle.Brand}{DELIMITER}{vehicle.Model}{DELIMITER}{vehicle.Year}{DELIMITER}{vehicle.Color}{BREAK_LINE}";
        }

        protected override Vehicle GetLineContent(string line)
        {
            var data = line.Split(DELIMITER);
            return new Vehicle(data[BRAND], data[MODEL], int.Parse(data[YEAR]), data[COLOR]);
        }
    }
}
