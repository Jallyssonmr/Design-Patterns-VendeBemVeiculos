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
        private ICollection<Vehicle> stock;

        public StockControl()
        {
            this.vehiclesDB = new VehicleTXT();
            this.stock = (ICollection<Vehicle>)vehiclesDB.Recover();
        }

        public void Add(Vehicle newVehicle, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                this.stock.Add(newVehicle);
                this.vehiclesDB.Update(this.stock);
            }
        }

        public void Remove(Vehicle vehicleToRemove)
        {
            this.stock.Remove(vehicleToRemove);
            this.vehiclesDB.Update(this.stock);
        }

        public int Count(Vehicle vehicleToCount)
        {
            return this.stock.Where(vehicle => vehicle.Equals(vehicleToCount)).Count();
        }

        public bool IsVehicleAvailable(Vehicle vehicle)
        {
            return this.stock.Contains(vehicle);
        }

        public IEnumerable<Vehicle> SelectStockDistinct(Func<Vehicle, bool> filter)
        {
            return this.stock.Where(filter).Distinct();
        }

        public IEnumerable<string> GetAtributes(Func<Vehicle, string> atribute)
        {
            return this.stock.Select(atribute).Distinct();
        }
    }
}