using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Controlers;
using VendeBemVeiculos_Patterns.Domain;
using VendeBemVeiculos_Patterns.TXTDataBase;

namespace VendeBemVeiculos_Patterns
{
    public partial class VehicleFilter : UserControl
    {
        protected StockControl stockControl;
        protected IEnumerable<Vehicle> filteredVehicles;

        public VehicleFilter()
        {
            InitializeComponent();
            this.UpdateStock();
        }

        public string Brand { get { return this.comboBoxBrandVehiclesSearch.Text; } }

        public string Model { get { return this.comboBoxModelVehiclesSearch.Text; } }

        public int Year { get { return Convert.ToInt32(this.comboBoxYearVehicleSearch.Text); } }

        public string Color { get { return this.comboBoxColorVehicleSearch.Text; } }

        protected void ComboBoxBrandVehiclesSearch_Click(object sender, EventArgs e)
        {
            this.comboBoxBrandVehiclesSearch.Items.Clear();

            var brandValues = this.stockControl.GetAtributes(vehicle => vehicle.Brand).ToArray();
            this.comboBoxBrandVehiclesSearch.Items.AddRange(brandValues);
        }

        protected virtual void ComboBoxBrandVehiclesSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand;
            this.filteredVehicles = this.stockControl.FilterDistinct(filter);

            this.comboBoxModelVehiclesSearch.Text = string.Empty;
            this.comboBoxModelVehiclesSearch.Enabled = true;
            this.comboBoxYearVehicleSearch.Text = string.Empty;
            this.comboBoxYearVehicleSearch.Enabled = false;
            this.comboBoxColorVehicleSearch.Text = string.Empty;
            this.comboBoxColorVehicleSearch.Enabled = false;
        }

        protected void ComboBoxModelVehiclesSearch_Click(object sender, EventArgs e)
        {
            this.comboBoxModelVehiclesSearch.Items.Clear();

            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand;
            this.filteredVehicles = this.stockControl.FilterDistinct(filter);

            var modelValues = this.filteredVehicles.Select(vehicle => vehicle.Model).Distinct().ToArray();
            this.comboBoxModelVehiclesSearch.Items.AddRange(modelValues);
        }

        protected virtual void ComboBoxModelVehiclesSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand && vehicle.Model == this.Model;

            this.filteredVehicles = this.stockControl.FilterDistinct(filter);

            this.comboBoxYearVehicleSearch.Text = string.Empty;
            this.comboBoxYearVehicleSearch.Enabled = true;
            this.comboBoxColorVehicleSearch.Text = string.Empty;
            this.comboBoxColorVehicleSearch.Enabled = false;
        }

        protected void ComboBoxYearVehicleSearch_Click(object sender, EventArgs e)
        {
            this.comboBoxYearVehicleSearch.Items.Clear();

            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand && vehicle.Model == this.Model;

            this.filteredVehicles = this.stockControl.FilterDistinct(filter);

            var yearValues = this.filteredVehicles.Select(vehicle => Convert.ToString(vehicle.Year)).Distinct().ToArray();
            this.comboBoxYearVehicleSearch.Items.AddRange(yearValues);
        }

        protected virtual void ComboBoxYearVehicleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand 
                                                    && vehicle.Model == this.Model 
                                                    && vehicle.Year == this.Year;

            this.filteredVehicles = this.stockControl.FilterDistinct(filter);

            this.comboBoxColorVehicleSearch.Text = string.Empty;
            this.comboBoxColorVehicleSearch.Enabled = true;
        }

        protected void ComboBoxColorVehicleSearch_Click(object sender, EventArgs e)
        {
            this.comboBoxColorVehicleSearch.Items.Clear();

            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand
                                                    && vehicle.Model == this.Model
                                                    && vehicle.Year == Year;

            this.filteredVehicles = this.stockControl.FilterDistinct(filter);
            var colorValues = this.filteredVehicles.Select(vehicle => vehicle.Color).Distinct().ToArray();

            this.comboBoxColorVehicleSearch.Items.AddRange(colorValues);
        }

        protected virtual void ComboBoxColorVehicleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func<Vehicle, bool> filter = vehicle => vehicle.Brand == this.Brand
                                                      && vehicle.Model == this.Model
                                                      && vehicle.Year == this.Year
                                                      && vehicle.Color == this.Color;

            this.filteredVehicles = this.stockControl.FilterDistinct(filter);
        }

        public void Clean()
        {
            this.comboBoxBrandVehiclesSearch.Text = string.Empty;
            this.comboBoxModelVehiclesSearch.Text = string.Empty;
            this.comboBoxYearVehicleSearch.Text = string.Empty;
            this.comboBoxColorVehicleSearch.Text = string.Empty;
        }

        public void UpdateStock()
        {
                this.stockControl = new StockControl();
                this.filteredVehicles = this.stockControl.GetAllDistinct();
        }

        protected virtual void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            this.filteredVehicles = this.stockControl.GetAllDistinct();

            this.comboBoxBrandVehiclesSearch.Text = string.Empty;
            this.comboBoxModelVehiclesSearch.Text = string.Empty;
            this.comboBoxModelVehiclesSearch.Enabled = false;
            this.comboBoxYearVehicleSearch.Text = string.Empty;
            this.comboBoxYearVehicleSearch.Enabled = false;
            this.comboBoxColorVehicleSearch.Text = string.Empty;
            this.comboBoxColorVehicleSearch.Enabled = false;
        }
    }
}
