using System.Collections.Generic;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.Interfaces;
using VendeBemVeiculos_Patterns.TXTDataBase;

namespace VendeBemVeiculos_Patterns.Controlers
{
    public class SalesControl
    {
        private const string DATE_TIME_FORMAT = "dd/MM/yyyy HH:mm:ss";

        private IDataBase<Sale> salesDB;

        public SalesControl()
        {
            this.salesDB = new SalesTXT();
            this.UpdateSales();
        }

        public ICollection<Sale> Sales { get; private set; }

        public void Add(Sale sale)
        {
            this.Sales.Add(sale);
            this.salesDB.Update(this.Sales);
        }

        public void UpdateSales()
        {
            this.Sales = (ICollection<Sale>)salesDB.Recover();
        }
    }
}
