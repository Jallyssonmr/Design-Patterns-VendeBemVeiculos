using System;
using VendeBemVeiculos_Patterns.Controlers;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.TXTDataBase
{
    public class SalesTXT : TXTDataBase<Sale>
    {
        private const int CLIENT_CPF_DOCUMENT = 0;
        private const int SELLER_CPF_DOCUMENT = 1;
        private const int VEHICLE_BRAND = 2;
        private const int VEHICLE_MODEL = 3;
        private const int VEHICLE_YEAR = 4;
        private const int VEHICLE_COLOR = 5;
        private const int DATE = 6;

        private const string NAME_FILE = "sales.txt";
        private const string DATE_STRING = "dd/MM/yyyy";
        private const char DELIMITER = ';';
        private const string BREAK_LINE = "\r\n";

        private PeopleControl<IPerson> clientsControl;
        private PeopleControl<IEmployee> sellersControl;

        public SalesTXT()
        {
            this.FilePath = NAME_FILE;
            this.clientsControl = new ClientsControl();
            this.sellersControl = new SellersControl();
        }

        protected override string ConvertInstanceToText(Sale sale)
        {
            if (sale == null) { throw new NullReferenceException(); }
            var client = $"{sale.Client.CPFDocument}";
            var seller = $"{sale.Seller.CPFDocument}";
            var vehicle = $"{sale.Vehicle.Brand}{DELIMITER}{sale.Vehicle.Model}{DELIMITER}{sale.Vehicle.Year}{DELIMITER}" +
                $"{sale.Vehicle.Color}";
            var date = sale.Date.ToString(DATE_STRING);
            return $"{date}{DELIMITER}{client}{DELIMITER}{seller}{DELIMITER}{vehicle}{BREAK_LINE}";
        }

        protected override Sale GetLineContent(string line)
        {
            var data = line.Split(DELIMITER);
            var client = this.clientsControl.Select(data[CLIENT_CPF_DOCUMENT]);
            var seller = this.sellersControl.Select(data[SELLER_CPF_DOCUMENT]);
            var vehicle = this.LoadVehicle(data);
            var date = Convert.ToDateTime(data[DATE]);
            var sale = new Sale(date, client, seller, vehicle);
            return sale;
        }

        private Vehicle LoadVehicle(string[] data)
        {
            var brand = data[VEHICLE_BRAND];
            var model = data[VEHICLE_MODEL];
            var year = int.Parse(data[VEHICLE_YEAR]);
            var color = data[VEHICLE_COLOR];
            return new Vehicle(brand, model, year, color);
        }
    }
}
