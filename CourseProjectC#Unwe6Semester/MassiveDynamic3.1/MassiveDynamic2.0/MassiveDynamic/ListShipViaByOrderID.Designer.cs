namespace MassiveDynamic
{
    partial class ListShipViaByOrderID
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
            this.OrderIDComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByOrderIDButton = new System.Windows.Forms.Button();
            this.ShipViaDataGrid = new System.Windows.Forms.DataGridView();
            this.ordersDataSet1 = new MassiveDynamic.OrdersDataSet1();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MassiveDynamic.OrdersDataSet1TableAdapters.OrdersTableAdapter();
            this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ShipViaDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на потъчката";
            // 
            // OrderIDComboBox
            // 
            this.OrderIDComboBox.DataSource = this.ordersBindingSource;
            this.OrderIDComboBox.DisplayMember = "OrderID";
            this.OrderIDComboBox.FormattingEnabled = true;
            this.OrderIDComboBox.Location = new System.Drawing.Point(210, 33);
            this.OrderIDComboBox.Name = "OrderIDComboBox";
            this.OrderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.OrderIDComboBox.TabIndex = 1;
            this.OrderIDComboBox.ValueMember = "OrderID";
            // 
            // SearchByOrderIDButton
            // 
            this.SearchByOrderIDButton.Location = new System.Drawing.Point(379, 31);
            this.SearchByOrderIDButton.Name = "SearchByOrderIDButton";
            this.SearchByOrderIDButton.Size = new System.Drawing.Size(75, 23);
            this.SearchByOrderIDButton.TabIndex = 2;
            this.SearchByOrderIDButton.Text = "Търси";
            this.SearchByOrderIDButton.UseVisualStyleBackColor = true;
            this.SearchByOrderIDButton.Click += new System.EventHandler(this.SearchByOrderIDButton_Click);
            // 
            // ShipViaDataGrid
            // 
            this.ShipViaDataGrid.AutoGenerateColumns = false;
            this.ShipViaDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShipViaDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shipViaDataGridViewTextBoxColumn});
            this.ShipViaDataGrid.DataSource = this.ordersBindingSource;
            this.ShipViaDataGrid.Location = new System.Drawing.Point(12, 83);
            this.ShipViaDataGrid.Name = "ShipViaDataGrid";
            this.ShipViaDataGrid.Size = new System.Drawing.Size(442, 150);
            this.ShipViaDataGrid.TabIndex = 3;
            this.ShipViaDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ShipViaDataGrid_CellContentClick);
            // 
            // ordersDataSet1
            // 
            this.ordersDataSet1.DataSetName = "OrdersDataSet1";
            this.ordersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.ordersDataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // shipViaDataGridViewTextBoxColumn
            // 
            this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
            // 
            // ListShipViaByOrderID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 262);
            this.Controls.Add(this.ShipViaDataGrid);
            this.Controls.Add(this.SearchByOrderIDButton);
            this.Controls.Add(this.OrderIDComboBox);
            this.Controls.Add(this.label1);
            this.Name = "ListShipViaByOrderID";
            this.Text = "ListShipViaByOrderID";
            this.Load += new System.EventHandler(this.ListShipViaByOrderID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ShipViaDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OrderIDComboBox;
        private System.Windows.Forms.Button SearchByOrderIDButton;
        private System.Windows.Forms.DataGridView ShipViaDataGrid;
        private OrdersDataSet1 ordersDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private OrdersDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
    }
}