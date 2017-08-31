using System;
using System.Collections.Generic;
using System.Linq;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.Interfaces;
using VendeBemVeiculos_Patterns.TXTDataBase;

namespace VendeBemVeiculos_Patterns.Controlers
{
    public class StockControl
    {
        private const char DELIMITER = ';';

        private IDataBase<Vehicle> vehiclesDB;

        public StockControl()
        {
            this.vehiclesDB = new VehicleTXT();
            this.Stock = (ICollection<Vehicle>)vehiclesDB.Recover();
        }

        public ICollection<Vehicle> Stock { get; private set; }

        public void Add(Vehicle newVehicle, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.Stock.Add(newVehicle);
                this.vehiclesDB.Update(this.Stock);
            }
        }

        public void Remove(Vehicle vehicleToRemove)
        {
            this.Stock.Remove(vehicleToRemove);
            this.vehiclesDB.Update(this.Stock);
        }

        public int Count(Vehicle vehicleToCount)
        {
            return this.Stock.Where(vehicle => vehicle.Equals(vehicleToCount)).Count();
        }

        public bool IsVehicleAvailable(Vehicle vehicle)
        {
            return this.Stock.Contains(vehicle);
        }

        public IEnumerable<Vehicle> FilterStock(Func<Vehicle, bool> filter)
        {
            return this.Stock.Where(filter).Distinct();
        }

        public IEnumerable<string> GetAtributes(Func<Vehicle, string> atribute)
        {
            return this.Stock.Select(atribute).Distinct();
        }
    }
}