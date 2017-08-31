using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendeBemVeiculos_Patterns.Grids;

namespace VendeBemVeiculos_Patterns
{
    public partial class VehicleFilterWithGrid : VehicleFilter
    {
        public VehicleFilterWithGrid()
        {
            InitializeComponent();
            this.RefreshGridViewStock();
        }

        protected override void ButtonClearSearch_Click(object sender, EventArgs e)
        {
            base.ButtonClearSearch_Click(sender, e);
            this.RefreshGridViewStock();
        }

        protected override void ComboBoxBrandVehiclesSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.ComboBoxBrandVehiclesSearch_SelectedIndexChanged(sender, e);
            this.RefreshGridViewStock();
        }

        protected override void ComboBoxModelVehiclesSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.ComboBoxModelVehiclesSearch_SelectedIndexChanged(sender, e);
            this.RefreshGridViewStock();
        }

        protected override void ComboBoxYearVehicleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.ComboBoxYearVehicleSearch_SelectedIndexChanged(sender, e);
            this.RefreshGridViewStock();
        }

        protected override void ComboBoxColorVehicleSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            base.ComboBoxColorVehicleSearch_SelectedIndexChanged(sender, e);
            this.RefreshGridViewStock();
        }

        public void RefreshGridViewStock()
        {
            var GridOfVehicles = new List<GridStock>();

            var distinctVehicles = this.filteredVehicles.Distinct().OrderBy(vehicle => vehicle.Brand);

            foreach (var vehicle in distinctVehicles)
            {
                var gridStock = new GridStock
                {
                    Brand = vehicle.Brand,
                    Model = vehicle.Model,
                    Year = vehicle.Year,
                    Color = vehicle.Color,
                    Quantity = this.stockControl.Count(vehicle)
                };
                GridOfVehicles.Add(gridStock);
            }
            this.dataGridViewStock.DataSource = GridOfVehicles;
        }
    }
}
