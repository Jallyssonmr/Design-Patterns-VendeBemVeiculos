using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Controlers;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.Interfaces;
using VendeBemVeiculos_Patterns.Reporters;

namespace VendeBemVeiculos_Patterns
{
    public partial class FMain : Form
    {
        private const string INCOMPLETE_FIELDS_MESSAGE = "Preencha todos os campos que contém asterísco (*)";
        private const string INVALID_DATA = "Dados invalidos.";

        private const int VEHICLE_SEARCH = 0;
        private const int BACKSPACE_ASCII = 8;
        private const string BRAND = "brand";
        private const string MODEL = "model";
        private const string YEAR = "year";
        private const string COLOR = "color";
        private const string QUANTITY = "quantity";


        private ClientsControl clientsControl;
        private SellersControl sellersControl;
        private StockControl stockControl;
        private SalesControl salesControl;

        private IReport reporter;

        public FMain()
        {
            this.clientsControl = new ClientsControl();
            this.sellersControl = new SellersControl();
            this.stockControl = new StockControl();
            this.salesControl = new SalesControl();

            InitializeComponent();

            //this.RefreshGridViewSales();
        }
        #region vehicles
        private void RuttonRegisterVehicleToStockClick(object sender, EventArgs e)
        {
            if (this.AnyNewVehicleDataFiedIsEmpty())
            {
                this.MessageMissingData();
                return;
            }
            var valuesVehicle = GetValuesFieldsNewVevhicle();
            var vehicle = new Vehicle(valuesVehicle[BRAND], valuesVehicle[MODEL], int.Parse(valuesVehicle[YEAR]), valuesVehicle[COLOR]);
            this.stockControl.Add(vehicle, int.Parse(valuesVehicle[QUANTITY]));
            this.CleanNewVehicleDataFields();
        }

        private bool AnyNewVehicleDataFiedIsEmpty()
        {
            return string.IsNullOrEmpty(this.textBoxModelNewVehicle.Text) ||
                string.IsNullOrEmpty(this.textBoxQuantityNewVehicle.Text) ||
                string.IsNullOrEmpty(this.comboBoxBrandNewVehicle.Text) ||
                string.IsNullOrEmpty(this.comboBoxYearNewVehicle.Text) ||
                string.IsNullOrEmpty(this.comboBoxColorNewVehicle.Text);
        }

        private IDictionary<string, string> GetValuesFieldsNewVevhicle()
        {
            var valuesVehicles = new Dictionary<string, string>();

            valuesVehicles.Add(BRAND, this.comboBoxBrandNewVehicle.Text.ToUpper());
            valuesVehicles.Add(MODEL, this.textBoxModelNewVehicle.Text.ToUpper());
            valuesVehicles.Add(YEAR, this.comboBoxYearNewVehicle.Text);
            valuesVehicles.Add(COLOR, this.comboBoxColorNewVehicle.Text.ToUpper());
            valuesVehicles.Add(QUANTITY, this.textBoxQuantityNewVehicle.Text);
            return valuesVehicles;
        }

        private void ButtonCancelNewVehicleClick(object sender, EventArgs e)
        {
            this.CleanNewVehicleDataFields();
        }

        private void CleanNewVehicleDataFields()
        {
            this.textBoxModelNewVehicle.Clear();
            this.textBoxQuantityNewVehicle.Clear();

            this.comboBoxBrandNewVehicle.Text = string.Empty;
            this.comboBoxYearNewVehicle.Text = string.Empty;
            this.comboBoxColorNewVehicle.Text = string.Empty;
        }

        private void ButtonStockReportClick(object sender, EventArgs e)
        {
            this.reporter = new StockReport(this.stockControl);
            this.reporter.Report();
        }
        #endregion

        #region sales

        #endregion

        #region clients

        #endregion

        #region sellers

        #endregion


        private void OnlyNumbers(KeyPressEventArgs eventKey)
        {
            if (this.IsNotDecimalOrBackSpace(eventKey.KeyChar)) { this.DisableEventKey(eventKey); }
        }

        private void DisableEventKey(KeyPressEventArgs eventKey)
        {
            eventKey.Handled = true;
        }

        private bool IsNotDecimalOrBackSpace(char keyChar)
        {
            return Char.IsDigit(keyChar) == false && keyChar != (BACKSPACE_ASCII);
        }

        private void MessageMissingData()
        {
            MessageBox.Show(INCOMPLETE_FIELDS_MESSAGE);
        }
    }
}
