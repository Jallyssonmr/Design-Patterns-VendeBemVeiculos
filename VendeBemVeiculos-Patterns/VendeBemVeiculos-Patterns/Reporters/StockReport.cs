using System.IO;
using System.Linq;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Controlers;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Reporters
{
    public class StockReport : IReport
    {
        private const char DELIMITER = ';';

        public StockReport(StockControl controler)
        {
            this.Controler = controler;
        }

        public StockControl Controler { get; private set; }

        public void Report()
        {
            var fileDialogStock = new SaveFileDialog()
            {
                Filter = "CSV Files (*.csv)|*.csv"
            };

            if (fileDialogStock.ShowDialog() == DialogResult.OK)
            {
                var labelColumns = $"MARCA{DELIMITER}MODELO{DELIMITER}ANO{DELIMITER}COR{DELIMITER}PRECO" +
                    $"{DELIMITER}Quantidade";

                using (var report = new StreamWriter(fileDialogStock.FileName))
                {
                    report.WriteLine(labelColumns);

                    foreach (var vehicle in this.Controler.GetAllDistinct().ToList())
                    {
                        report.WriteLine($"{vehicle.ToString()}{DELIMITER}{this.Controler.Count(vehicle)}");
                    }
                }
            }
        }
    }
}
