namespace MassiveDynamic
{
    partial class ListCusomersAdresses
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NameOfCompanyDropDown = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.SearchButton = new System.Windows.Forms.Button();
            this.customersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.CustomersTableAdapter();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.OrdersTableAdapter();
            this.fKOrderDetailsOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailsTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.OrderDetailsTableAdapter();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet1 = new MassiveDynamic.MassiveDynamicDataSet();
            this.massiveDynamicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            this.resultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на компанията";
            // 
            // NameOfCompanyDropDown
            // 
            this.NameOfCompanyDropDown.DataSource = this.customersBindingSource;
            this.NameOfCompanyDropDown.DisplayMember = "CustomerID";
            this.NameOfCompanyDropDown.FormattingEnabled = true;
            this.NameOfCompanyDropDown.Location = new System.Drawing.Point(140, 28);
            this.NameOfCompanyDropDown.Name = "NameOfCompanyDropDown";
            this.NameOfCompanyDropDown.Size = new System.Drawing.Size(121, 21);
            this.NameOfCompanyDropDown.TabIndex = 1;
            this.NameOfCompanyDropDown.ValueMember = "CustomerID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(291, 28);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Търси";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.Controls.Add(this.dataGridView1);
            this.resultsGroupBox.Location = new System.Drawing.Point(15, 73);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(503, 125);
            this.resultsGroupBox.TabIndex = 4;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Резултати";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.addressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // fKOrderDetailsOrdersBindingSource
            // 
            this.fKOrderDetailsOrdersBindingSource.DataMember = "FK_OrderDetails_Orders";
            this.fKOrderDetailsOrdersBindingSource.DataSource = this.ordersBindingSource;
            // 
            // orderDetailsTableAdapter
            // 
            this.orderDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.massiveDynamicDataSet;
            // 
            // massiveDynamicDataSet1
            // 
            this.massiveDynamicDataSet1.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // massiveDynamicDataSetBindingSource
            // 
            this.massiveDynamicDataSetBindingSource.DataSource = this.massiveDynamicDataSet;
            this.massiveDynamicDataSetBindingSource.Position = 0;
            // 
            // ListCusomersAdresses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 229);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NameOfCompanyDropDown);
            this.Controls.Add(this.label1);
            this.Name = "ListCusomersAdresses";
            this.Text = "ListCusomersAdresses";
            this.Load += new System.EventHandler(this.ListCusomersAdresses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            this.resultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKOrderDetailsOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NameOfCompanyDropDown;
        private System.Windows.Forms.Button SearchButton;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MassiveDynamicDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MassiveDynamicDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource fKOrderDetailsOrdersBindingSource;
        private MassiveDynamicDataSetTableAdapters.OrderDetailsTableAdapter orderDetailsTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private MassiveDynamicDataSet massiveDynamicDataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource massiveDynamicDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
    }
}