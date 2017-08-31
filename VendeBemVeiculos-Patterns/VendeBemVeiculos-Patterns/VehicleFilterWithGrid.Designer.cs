namespace VendeBemVeiculos_Patterns
{
    partial class VehicleFilterWithGrid
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonClearSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonClearSearch.Location = new System.Drawing.Point(509, 19);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(75, 24);
            this.buttonClearSearch.TabIndex = 44;
            this.buttonClearSearch.Text = "Limpar";
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewStock.Location = new System.Drawing.Point(1, 50);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(752, 150);
            this.dataGridViewStock.TabIndex = 47;
            // 
            // VehicleWithGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.buttonClearSearch);
            this.Name = "VehicleWithGrid";
            this.Size = new System.Drawing.Size(762, 210);
            this.Controls.SetChildIndex(this.buttonClearSearch, 0);
            this.Controls.SetChildIndex(this.dataGridViewStock, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.DataGridView dataGridViewStock;
    }
}
