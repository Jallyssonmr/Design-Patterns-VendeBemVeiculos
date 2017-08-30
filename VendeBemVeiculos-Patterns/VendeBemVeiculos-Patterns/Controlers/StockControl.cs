using System.Collections.Generic;
using System.Linq;
using VendeBemVeiculos_Patterns.Domain;

namespace VendeBemVeiculos_Patterns.Controlers
{
    public class StockControl
    {
        private const char DELIMITER = ';';

        private IDataBase<Vehicle> vehiclesDB;

        public StockControl()
        {
            this.vehiclesDB = new VehiclesTXT();
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
    }
}
