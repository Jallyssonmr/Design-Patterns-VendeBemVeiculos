namespace VendeBemVeiculos_Patterns
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.buttonStockReport = new System.Windows.Forms.Button();
            this.comboBoxBrandNewVehicle = new System.Windows.Forms.ComboBox();
            this.textBoxQuantityNewVehicle = new System.Windows.Forms.TextBox();
            this.labelModelNewVehicle = new System.Windows.Forms.Label();
            this.comboBoxColorNewVehicle = new System.Windows.Forms.ComboBox();
            this.labelQuantityNewVehicle = new System.Windows.Forms.Label();
            this.comboBoxYearNewVehicle = new System.Windows.Forms.ComboBox();
            this.textBoxModelNewVehicle = new System.Windows.Forms.TextBox();
            this.labelBrandNewVehicle = new System.Windows.Forms.Label();
            this.labelYearNewVehicle = new System.Windows.Forms.Label();
            this.labelColorNewVehicle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonCancelNewVehicle = new System.Windows.Forms.Button();
            this.buttonRegisterVehicleToStock = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.comboBoxCpfDocumentSellerSale = new System.Windows.Forms.ComboBox();
            this.comboBoxCpfDocumentCustomerSale = new System.Windows.Forms.ComboBox();
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.labelSeller = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonCancelSale = new System.Windows.Forms.Button();
            this.buttonGenerateSale = new System.Windows.Forms.Button();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCancelarCliente = new System.Windows.Forms.Button();
            this.buttonCadastroCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInputNameCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInputRgDocumentCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputCpfDocumentCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInputPhoneNumberCustomer = new System.Windows.Forms.TextBox();
            this.textBoxInputAddressCustomer = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonCancelarVendedor = new System.Windows.Forms.Button();
            this.buttonCadastarVendedor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxInputSalarySalesman = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInputNameSalesman = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInputRgDocumentSalesman = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxInputCpfDocumentSalesman = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxInputPhoneNumberSalesman = new System.Windows.Forms.TextBox();
            this.textBoxInputAddressSalesman = new System.Windows.Forms.TextBox();
            this.vehicleWithGrid1 = new VendeBemVeiculos_Patterns.VehicleWithGrid();
            this.vehicleFilter1 = new VendeBemVeiculos_Patterns.VehicleFilter();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Controls.Add(this.tabPage5);
            this.tabs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(894, 421);
            this.tabs.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.vehicleWithGrid1);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Estoque";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.buttonStockReport);
            this.panel6.Controls.Add(this.comboBoxBrandNewVehicle);
            this.panel6.Controls.Add(this.textBoxQuantityNewVehicle);
            this.panel6.Controls.Add(this.labelModelNewVehicle);
            this.panel6.Controls.Add(this.comboBoxColorNewVehicle);
            this.panel6.Controls.Add(this.labelQuantityNewVehicle);
            this.panel6.Controls.Add(this.comboBoxYearNewVehicle);
            this.panel6.Controls.Add(this.textBoxModelNewVehicle);
            this.panel6.Controls.Add(this.labelBrandNewVehicle);
            this.panel6.Controls.Add(this.labelYearNewVehicle);
            this.panel6.Controls.Add(this.labelColorNewVehicle);
            this.panel6.Location = new System.Drawing.Point(3, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(880, 106);
            this.panel6.TabIndex = 26;
            // 
            // buttonStockReport
            // 
            this.buttonStockReport.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonStockReport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStockReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStockReport.Location = new System.Drawing.Point(742, 28);
            this.buttonStockReport.Name = "buttonStockReport";
            this.buttonStockReport.Size = new System.Drawing.Size(111, 47);
            this.buttonStockReport.TabIndex = 8;
            this.buttonStockReport.Text = "Gerar Relatório de Estoque";
            this.buttonStockReport.UseVisualStyleBackColor = false;
            // 
            // comboBoxBrandNewVehicle
            // 
            this.comboBoxBrandNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBrandNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxBrandNewVehicle.FormattingEnabled = true;
            this.comboBoxBrandNewVehicle.Items.AddRange(new object[] {
            "AUDI",
            "BMW",
            "CHEVROLET",
            "FIAT",
            "FERRARI",
            "FORD",
            "HONDA",
            "HYUNDAI",
            "JEEP",
            "KIA MOTORS",
            "LAND ROVER",
            "LEXUS",
            "MAZDA",
            "MERCEDES-BENZ",
            "MINI",
            "NISSAN",
            "PEUGEOT",
            "RENAULT",
            "SUZUKI",
            "TOYOTA",
            "VOLKSWAGEN"});
            this.comboBoxBrandNewVehicle.Location = new System.Drawing.Point(5, 27);
            this.comboBoxBrandNewVehicle.Name = "comboBoxBrandNewVehicle";
            this.comboBoxBrandNewVehicle.Size = new System.Drawing.Size(121, 23);
            this.comboBoxBrandNewVehicle.TabIndex = 22;
            // 
            // textBoxQuantityNewVehicle
            // 
            this.textBoxQuantityNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantityNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxQuantityNewVehicle.Location = new System.Drawing.Point(258, 76);
            this.textBoxQuantityNewVehicle.Name = "textBoxQuantityNewVehicle";
            this.textBoxQuantityNewVehicle.Size = new System.Drawing.Size(35, 21);
            this.textBoxQuantityNewVehicle.TabIndex = 14;
            // 
            // labelModelNewVehicle
            // 
            this.labelModelNewVehicle.AutoSize = true;
            this.labelModelNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.labelModelNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelModelNewVehicle.Location = new System.Drawing.Point(181, 8);
            this.labelModelNewVehicle.Name = "labelModelNewVehicle";
            this.labelModelNewVehicle.Size = new System.Drawing.Size(53, 15);
            this.labelModelNewVehicle.TabIndex = 16;
            this.labelModelNewVehicle.Text = "Modelo*";
            // 
            // comboBoxColorNewVehicle
            // 
            this.comboBoxColorNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxColorNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxColorNewVehicle.FormattingEnabled = true;
            this.comboBoxColorNewVehicle.Items.AddRange(new object[] {
            "BRANCO",
            "PRETO",
            "AZUL",
            "AMARELO",
            "VERDE",
            "LARANJA",
            "PRATA"});
            this.comboBoxColorNewVehicle.Location = new System.Drawing.Point(131, 76);
            this.comboBoxColorNewVehicle.Name = "comboBoxColorNewVehicle";
            this.comboBoxColorNewVehicle.Size = new System.Drawing.Size(121, 23);
            this.comboBoxColorNewVehicle.TabIndex = 21;
            // 
            // labelQuantityNewVehicle
            // 
            this.labelQuantityNewVehicle.AutoSize = true;
            this.labelQuantityNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.labelQuantityNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantityNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelQuantityNewVehicle.Location = new System.Drawing.Point(255, 56);
            this.labelQuantityNewVehicle.Name = "labelQuantityNewVehicle";
            this.labelQuantityNewVehicle.Size = new System.Drawing.Size(77, 15);
            this.labelQuantityNewVehicle.TabIndex = 17;
            this.labelQuantityNewVehicle.Text = "Quantidade*";
            // 
            // comboBoxYearNewVehicle
            // 
            this.comboBoxYearNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYearNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxYearNewVehicle.FormattingEnabled = true;
            this.comboBoxYearNewVehicle.Items.AddRange(new object[] {
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.comboBoxYearNewVehicle.Location = new System.Drawing.Point(4, 76);
            this.comboBoxYearNewVehicle.Name = "comboBoxYearNewVehicle";
            this.comboBoxYearNewVehicle.Size = new System.Drawing.Size(121, 23);
            this.comboBoxYearNewVehicle.TabIndex = 20;
            // 
            // textBoxModelNewVehicle
            // 
            this.textBoxModelNewVehicle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxModelNewVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModelNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxModelNewVehicle.Location = new System.Drawing.Point(184, 28);
            this.textBoxModelNewVehicle.Name = "textBoxModelNewVehicle";
            this.textBoxModelNewVehicle.Size = new System.Drawing.Size(172, 21);
            this.textBoxModelNewVehicle.TabIndex = 13;
            // 
            // labelBrandNewVehicle
            // 
            this.labelBrandNewVehicle.AutoSize = true;
            this.labelBrandNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.labelBrandNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrandNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBrandNewVehicle.Location = new System.Drawing.Point(2, 8);
            this.labelBrandNewVehicle.Name = "labelBrandNewVehicle";
            this.labelBrandNewVehicle.Size = new System.Drawing.Size(48, 15);
            this.labelBrandNewVehicle.TabIndex = 15;
            this.labelBrandNewVehicle.Text = "Marca*";
            // 
            // labelYearNewVehicle
            // 
            this.labelYearNewVehicle.AutoSize = true;
            this.labelYearNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.labelYearNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelYearNewVehicle.Location = new System.Drawing.Point(3, 57);
            this.labelYearNewVehicle.Name = "labelYearNewVehicle";
            this.labelYearNewVehicle.Size = new System.Drawing.Size(34, 15);
            this.labelYearNewVehicle.TabIndex = 18;
            this.labelYearNewVehicle.Text = "Ano*";
            // 
            // labelColorNewVehicle
            // 
            this.labelColorNewVehicle.AutoSize = true;
            this.labelColorNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.labelColorNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelColorNewVehicle.Location = new System.Drawing.Point(128, 56);
            this.labelColorNewVehicle.Name = "labelColorNewVehicle";
            this.labelColorNewVehicle.Size = new System.Drawing.Size(32, 15);
            this.labelColorNewVehicle.TabIndex = 19;
            this.labelColorNewVehicle.Text = "Cor*";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.buttonCancelNewVehicle);
            this.panel4.Controls.Add(this.buttonRegisterVehicleToStock);
            this.panel4.Location = new System.Drawing.Point(3, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(880, 32);
            this.panel4.TabIndex = 25;
            // 
            // buttonCancelNewVehicle
            // 
            this.buttonCancelNewVehicle.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelNewVehicle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelNewVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelNewVehicle.Location = new System.Drawing.Point(97, 6);
            this.buttonCancelNewVehicle.Name = "buttonCancelNewVehicle";
            this.buttonCancelNewVehicle.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelNewVehicle.TabIndex = 26;
            this.buttonCancelNewVehicle.Text = "Limpar";
            this.buttonCancelNewVehicle.UseVisualStyleBackColor = false;
            // 
            // buttonRegisterVehicleToStock
            // 
            this.buttonRegisterVehicleToStock.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegisterVehicleToStock.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterVehicleToStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRegisterVehicleToStock.Location = new System.Drawing.Point(11, 6);
            this.buttonRegisterVehicleToStock.Name = "buttonRegisterVehicleToStock";
            this.buttonRegisterVehicleToStock.Size = new System.Drawing.Size(81, 23);
            this.buttonRegisterVehicleToStock.TabIndex = 24;
            this.buttonRegisterVehicleToStock.Text = "Cadastrar";
            this.buttonRegisterVehicleToStock.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.dataGridViewSales);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendas";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.vehicleFilter1);
            this.panel5.Controls.Add(this.comboBoxCpfDocumentSellerSale);
            this.panel5.Controls.Add(this.comboBoxCpfDocumentCustomerSale);
            this.panel5.Controls.Add(this.buttonSalesReport);
            this.panel5.Controls.Add(this.labelSeller);
            this.panel5.Controls.Add(this.labelCustomer);
            this.panel5.Location = new System.Drawing.Point(3, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(880, 111);
            this.panel5.TabIndex = 30;
            // 
            // comboBoxCpfDocumentSellerSale
            // 
            this.comboBoxCpfDocumentSellerSale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCpfDocumentSellerSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxCpfDocumentSellerSale.FormattingEnabled = true;
            this.comboBoxCpfDocumentSellerSale.Location = new System.Drawing.Point(133, 28);
            this.comboBoxCpfDocumentSellerSale.Name = "comboBoxCpfDocumentSellerSale";
            this.comboBoxCpfDocumentSellerSale.Size = new System.Drawing.Size(285, 23);
            this.comboBoxCpfDocumentSellerSale.TabIndex = 27;
            // 
            // comboBoxCpfDocumentCustomerSale
            // 
            this.comboBoxCpfDocumentCustomerSale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCpfDocumentCustomerSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.comboBoxCpfDocumentCustomerSale.FormattingEnabled = true;
            this.comboBoxCpfDocumentCustomerSale.Location = new System.Drawing.Point(6, 28);
            this.comboBoxCpfDocumentCustomerSale.Name = "comboBoxCpfDocumentCustomerSale";
            this.comboBoxCpfDocumentCustomerSale.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCpfDocumentCustomerSale.TabIndex = 26;
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.BackColor = System.Drawing.Color.Transparent;
            this.buttonSalesReport.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSalesReport.Location = new System.Drawing.Point(733, 28);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Size = new System.Drawing.Size(134, 43);
            this.buttonSalesReport.TabIndex = 8;
            this.buttonSalesReport.Text = "Gerar Relatório de Vendas";
            this.buttonSalesReport.UseVisualStyleBackColor = false;
            // 
            // labelSeller
            // 
            this.labelSeller.AutoSize = true;
            this.labelSeller.BackColor = System.Drawing.Color.Transparent;
            this.labelSeller.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSeller.Location = new System.Drawing.Point(130, 8);
            this.labelSeller.Name = "labelSeller";
            this.labelSeller.Size = new System.Drawing.Size(95, 15);
            this.labelSeller.TabIndex = 16;
            this.labelSeller.Text = "Vendedor* (cpf)";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelCustomer.Location = new System.Drawing.Point(3, 8);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(80, 15);
            this.labelCustomer.TabIndex = 15;
            this.labelCustomer.Text = "Cliente* (cpf)";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Controls.Add(this.buttonCancelSale);
            this.panel7.Controls.Add(this.buttonGenerateSale);
            this.panel7.Location = new System.Drawing.Point(3, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(880, 37);
            this.panel7.TabIndex = 29;
            // 
            // buttonCancelSale
            // 
            this.buttonCancelSale.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelSale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelSale.Location = new System.Drawing.Point(85, 9);
            this.buttonCancelSale.Name = "buttonCancelSale";
            this.buttonCancelSale.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelSale.TabIndex = 25;
            this.buttonCancelSale.Text = "Limpar";
            this.buttonCancelSale.UseVisualStyleBackColor = false;
            // 
            // buttonGenerateSale
            // 
            this.buttonGenerateSale.BackColor = System.Drawing.Color.Transparent;
            this.buttonGenerateSale.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateSale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonGenerateSale.Location = new System.Drawing.Point(5, 9);
            this.buttonGenerateSale.Name = "buttonGenerateSale";
            this.buttonGenerateSale.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerateSale.TabIndex = 2;
            this.buttonGenerateSale.Text = "Cadastrar";
            this.buttonGenerateSale.UseVisualStyleBackColor = false;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSales.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewSales.Location = new System.Drawing.Point(3, 151);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(887, 242);
            this.dataGridViewSales.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage3.Controls.Add(this.buttonCancelarCliente);
            this.tabPage3.Controls.Add(this.buttonCadastroCliente);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro cliente";
            // 
            // buttonCancelarCliente
            // 
            this.buttonCancelarCliente.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelarCliente.Location = new System.Drawing.Point(85, 339);
            this.buttonCancelarCliente.Name = "buttonCancelarCliente";
            this.buttonCancelarCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarCliente.TabIndex = 27;
            this.buttonCancelarCliente.Text = "Limpar";
            this.buttonCancelarCliente.UseVisualStyleBackColor = false;
            // 
            // buttonCadastroCliente
            // 
            this.buttonCadastroCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCadastroCliente.Location = new System.Drawing.Point(8, 339);
            this.buttonCadastroCliente.Name = "buttonCadastroCliente";
            this.buttonCadastroCliente.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastroCliente.TabIndex = 11;
            this.buttonCadastroCliente.Text = "Cadastrar";
            this.buttonCadastroCliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.labelNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxInputNameCustomer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxInputRgDocumentCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxInputCpfDocumentCustomer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxInputPhoneNumberCustomer);
            this.panel1.Controls.Add(this.textBoxInputAddressCustomer);
            this.panel1.Location = new System.Drawing.Point(8, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(870, 289);
            this.panel1.TabIndex = 10;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelNome.Location = new System.Drawing.Point(3, 9);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(45, 15);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(2, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereço";
            // 
            // textBoxInputNameCustomer
            // 
            this.textBoxInputNameCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInputNameCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputNameCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputNameCustomer.Location = new System.Drawing.Point(5, 30);
            this.textBoxInputNameCustomer.Name = "textBoxInputNameCustomer";
            this.textBoxInputNameCustomer.Size = new System.Drawing.Size(331, 21);
            this.textBoxInputNameCustomer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(2, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cpf*";
            // 
            // textBoxInputRgDocumentCustomer
            // 
            this.textBoxInputRgDocumentCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputRgDocumentCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputRgDocumentCustomer.Location = new System.Drawing.Point(6, 87);
            this.textBoxInputRgDocumentCustomer.MaxLength = 9;
            this.textBoxInputRgDocumentCustomer.Name = "textBoxInputRgDocumentCustomer";
            this.textBoxInputRgDocumentCustomer.Size = new System.Drawing.Size(137, 21);
            this.textBoxInputRgDocumentCustomer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(2, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Celular*";
            // 
            // textBoxInputCpfDocumentCustomer
            // 
            this.textBoxInputCpfDocumentCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputCpfDocumentCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputCpfDocumentCustomer.Location = new System.Drawing.Point(5, 142);
            this.textBoxInputCpfDocumentCustomer.MaxLength = 11;
            this.textBoxInputCpfDocumentCustomer.Name = "textBoxInputCpfDocumentCustomer";
            this.textBoxInputCpfDocumentCustomer.Size = new System.Drawing.Size(137, 21);
            this.textBoxInputCpfDocumentCustomer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rg";
            // 
            // textBoxInputPhoneNumberCustomer
            // 
            this.textBoxInputPhoneNumberCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputPhoneNumberCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputPhoneNumberCustomer.Location = new System.Drawing.Point(5, 253);
            this.textBoxInputPhoneNumberCustomer.MaxLength = 11;
            this.textBoxInputPhoneNumberCustomer.Name = "textBoxInputPhoneNumberCustomer";
            this.textBoxInputPhoneNumberCustomer.Size = new System.Drawing.Size(117, 21);
            this.textBoxInputPhoneNumberCustomer.TabIndex = 3;
            // 
            // textBoxInputAddressCustomer
            // 
            this.textBoxInputAddressCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInputAddressCustomer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputAddressCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputAddressCustomer.Location = new System.Drawing.Point(5, 195);
            this.textBoxInputAddressCustomer.Name = "textBoxInputAddressCustomer";
            this.textBoxInputAddressCustomer.Size = new System.Drawing.Size(413, 21);
            this.textBoxInputAddressCustomer.TabIndex = 4;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPage5.Controls.Add(this.buttonCancelarVendedor);
            this.tabPage5.Controls.Add(this.buttonCadastarVendedor);
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(886, 388);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cadastro vendedor";
            // 
            // buttonCancelarVendedor
            // 
            this.buttonCancelarVendedor.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancelarVendedor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCancelarVendedor.Location = new System.Drawing.Point(85, 339);
            this.buttonCancelarVendedor.Name = "buttonCancelarVendedor";
            this.buttonCancelarVendedor.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelarVendedor.TabIndex = 29;
            this.buttonCancelarVendedor.Text = "Limpar";
            this.buttonCancelarVendedor.UseVisualStyleBackColor = false;
            // 
            // buttonCadastarVendedor
            // 
            this.buttonCadastarVendedor.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastarVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCadastarVendedor.Location = new System.Drawing.Point(8, 339);
            this.buttonCadastarVendedor.Name = "buttonCadastarVendedor";
            this.buttonCadastarVendedor.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastarVendedor.TabIndex = 13;
            this.buttonCadastarVendedor.Text = "Cadastrar";
            this.buttonCadastarVendedor.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.labelSalary);
            this.panel3.Controls.Add(this.textBoxInputSalarySalesman);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBoxInputNameSalesman);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxInputRgDocumentSalesman);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textBoxInputCpfDocumentSalesman);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxInputPhoneNumberSalesman);
            this.panel3.Controls.Add(this.textBoxInputAddressSalesman);
            this.panel3.Location = new System.Drawing.Point(8, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(870, 289);
            this.panel3.TabIndex = 11;
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSalary.Location = new System.Drawing.Point(135, 231);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(52, 15);
            this.labelSalary.TabIndex = 11;
            this.labelSalary.Text = "Salário*";
            // 
            // textBoxInputSalarySalesman
            // 
            this.textBoxInputSalarySalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputSalarySalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputSalarySalesman.Location = new System.Drawing.Point(138, 253);
            this.textBoxInputSalarySalesman.Name = "textBoxInputSalarySalesman";
            this.textBoxInputSalarySalesman.Size = new System.Drawing.Size(117, 21);
            this.textBoxInputSalarySalesman.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nome*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(2, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Endereço";
            // 
            // textBoxInputNameSalesman
            // 
            this.textBoxInputNameSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInputNameSalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputNameSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputNameSalesman.Location = new System.Drawing.Point(5, 30);
            this.textBoxInputNameSalesman.Name = "textBoxInputNameSalesman";
            this.textBoxInputNameSalesman.Size = new System.Drawing.Size(331, 21);
            this.textBoxInputNameSalesman.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(2, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cpf*";
            // 
            // textBoxInputRgDocumentSalesman
            // 
            this.textBoxInputRgDocumentSalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputRgDocumentSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputRgDocumentSalesman.Location = new System.Drawing.Point(6, 87);
            this.textBoxInputRgDocumentSalesman.MaxLength = 9;
            this.textBoxInputRgDocumentSalesman.Name = "textBoxInputRgDocumentSalesman";
            this.textBoxInputRgDocumentSalesman.Size = new System.Drawing.Size(137, 21);
            this.textBoxInputRgDocumentSalesman.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(2, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Celular*";
            // 
            // textBoxInputCpfDocumentSalesman
            // 
            this.textBoxInputCpfDocumentSalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputCpfDocumentSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputCpfDocumentSalesman.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxInputCpfDocumentSalesman.Location = new System.Drawing.Point(5, 142);
            this.textBoxInputCpfDocumentSalesman.MaxLength = 11;
            this.textBoxInputCpfDocumentSalesman.Name = "textBoxInputCpfDocumentSalesman";
            this.textBoxInputCpfDocumentSalesman.Size = new System.Drawing.Size(137, 21);
            this.textBoxInputCpfDocumentSalesman.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(3, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 6;
            this.label9.Text = "Rg";
            // 
            // textBoxInputPhoneNumberSalesman
            // 
            this.textBoxInputPhoneNumberSalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputPhoneNumberSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputPhoneNumberSalesman.Location = new System.Drawing.Point(5, 253);
            this.textBoxInputPhoneNumberSalesman.MaxLength = 11;
            this.textBoxInputPhoneNumberSalesman.Name = "textBoxInputPhoneNumberSalesman";
            this.textBoxInputPhoneNumberSalesman.Size = new System.Drawing.Size(117, 21);
            this.textBoxInputPhoneNumberSalesman.TabIndex = 3;
            // 
            // textBoxInputAddressSalesman
            // 
            this.textBoxInputAddressSalesman.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxInputAddressSalesman.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInputAddressSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxInputAddressSalesman.Location = new System.Drawing.Point(5, 194);
            this.textBoxInputAddressSalesman.Name = "textBoxInputAddressSalesman";
            this.textBoxInputAddressSalesman.Size = new System.Drawing.Size(413, 21);
            this.textBoxInputAddressSalesman.TabIndex = 4;
            // 
            // vehicleWithGrid1
            // 
            this.vehicleWithGrid1.Location = new System.Drawing.Point(4, 149);
            this.vehicleWithGrid1.Name = "vehicleWithGrid1";
            this.vehicleWithGrid1.Size = new System.Drawing.Size(882, 244);
            this.vehicleWithGrid1.TabIndex = 32;
            // 
            // vehicleFilter1
            // 
            this.vehicleFilter1.Location = new System.Drawing.Point(6, 57);
            this.vehicleFilter1.Name = "vehicleFilter1";
            this.vehicleFilter1.Size = new System.Drawing.Size(617, 54);
            this.vehicleFilter1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 431);
            this.Controls.Add(this.tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button buttonStockReport;
        private System.Windows.Forms.ComboBox comboBoxBrandNewVehicle;
        private System.Windows.Forms.TextBox textBoxQuantityNewVehicle;
        private System.Windows.Forms.Label labelModelNewVehicle;
        private System.Windows.Forms.ComboBox comboBoxColorNewVehicle;
        private System.Windows.Forms.Label labelQuantityNewVehicle;
        private System.Windows.Forms.ComboBox comboBoxYearNewVehicle;
        private System.Windows.Forms.TextBox textBoxModelNewVehicle;
        private System.Windows.Forms.Label labelBrandNewVehicle;
        private System.Windows.Forms.Label labelYearNewVehicle;
        private System.Windows.Forms.Label labelColorNewVehicle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonCancelNewVehicle;
        private System.Windows.Forms.Button buttonRegisterVehicleToStock;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxCpfDocumentSellerSale;
        private System.Windows.Forms.ComboBox comboBoxCpfDocumentCustomerSale;
        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.Label labelSeller;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonCancelSale;
        private System.Windows.Forms.Button buttonGenerateSale;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCancelarCliente;
        private System.Windows.Forms.Button buttonCadastroCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInputNameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInputRgDocumentCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputCpfDocumentCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInputPhoneNumberCustomer;
        private System.Windows.Forms.TextBox textBoxInputAddressCustomer;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonCancelarVendedor;
        private System.Windows.Forms.Button buttonCadastarVendedor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxInputSalarySalesman;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInputNameSalesman;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxInputRgDocumentSalesman;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxInputCpfDocumentSalesman;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxInputPhoneNumberSalesman;
        private System.Windows.Forms.TextBox textBoxInputAddressSalesman;
        private VehicleWithGrid vehicleWithGrid1;
        private VehicleFilter vehicleFilter1;
    }
}

