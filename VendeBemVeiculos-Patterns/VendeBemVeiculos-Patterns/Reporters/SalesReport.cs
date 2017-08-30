using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Reporters
{
    public class SalesReport : IReport
    {
        private const char DELIMITER = ';';

        public SalesReport(ICollection<Sale> sales)
        {
            this.SalesToReport = sales;
        }

        public ICollection<Sale> SalesToReport { get; private set; }

        public void Report()
        {
            var fileDialogStock = new SaveFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv"
            };

            if (fileDialogStock.ShowDialog() == DialogResult.OK)
            {
                var labelsDateTime = $"DATA{DELIMITER}";
                var labelsColumnsCustomers = $"CLIENTE{DELIMITER}CPF{DELIMITER}";
                var labelsColumnsSalesman = $"VENDEDOR{DELIMITER}CPF{DELIMITER}";
                var labelsColumnsVehicles = $"MARCA{DELIMITER}MODELO{DELIMITER}ANO{DELIMITER}COR";
                var labelsColumns = $"{labelsDateTime}{labelsColumnsCustomers}{labelsColumnsSalesman}{labelsColumnsVehicles}";

                using (var report = new StreamWriter(fileDialogStock.FileName))
                {
                    report.WriteLine(labelsColumns);

                    foreach (var sale in this.SalesToReport)
                    {
                        var customerData = $"{sale.Client.Name}{DELIMITER}{sale.Client.CPFDocument}";
                        var sellerData = $"{sale.Seller.Name}{DELIMITER}{sale.Seller.CPFDocument}";
                        report.WriteLine($"{sale.Date}{DELIMITER}{customerData}{DELIMITER}{sellerData}{DELIMITER}{sale.Vehicle.ToString()}");
                    }
                }
            }
        }
    }
}
