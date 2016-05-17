namespace MassiveDynamic
{
    partial class EditOrdersForm
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
            this.EditOrdersDataGrid = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipViaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.OrdersTableAdapter();
            this.ordersShippersDataSet = new MassiveDynamic.OrdersShippersDataSet();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter1 = new MassiveDynamic.OrdersShippersDataSetTableAdapters.OrdersTableAdapter();
            this.exportEditOrdersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrdersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersShippersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditOrdersDataGrid
            // 
            this.EditOrdersDataGrid.AllowUserToAddRows = false;
            this.EditOrdersDataGrid.AllowUserToDeleteRows = false;
            this.EditOrdersDataGrid.AutoGenerateColumns = false;
            this.EditOrdersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditOrdersDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.shipViaDataGridViewTextBoxColumn});
            this.EditOrdersDataGrid.DataSource = this.ordersBindingSource2;
            this.EditOrdersDataGrid.Location = new System.Drawing.Point(0, 0);
            this.EditOrdersDataGrid.Name = "EditOrdersDataGrid";
            this.EditOrdersDataGrid.Size = new System.Drawing.Size(446, 291);
            this.EditOrdersDataGrid.TabIndex = 0;
            this.EditOrdersDataGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditOrdersDataGrid_CellEndEdit);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            // 
            // shipViaDataGridViewTextBoxColumn
            // 
            this.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia";
            this.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource2
            // 
            this.ordersBindingSource2.DataMember = "Orders";
            this.ordersBindingSource2.DataSource = this.massiveDynamicDataSet;
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ordersShippersDataSet
            // 
            this.ordersShippersDataSet.DataSetName = "OrdersShippersDataSet";
            this.ordersShippersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.ordersShippersDataSet;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
            // 
            // exportEditOrdersButton
            // 
            this.exportEditOrdersButton.Location = new System.Drawing.Point(359, 309);
            this.exportEditOrdersButton.Name = "exportEditOrdersButton";
            this.exportEditOrdersButton.Size = new System.Drawing.Size(75, 23);
            this.exportEditOrdersButton.TabIndex = 1;
            this.exportEditOrdersButton.Text = "Export";
            this.exportEditOrdersButton.UseVisualStyleBackColor = true;
            this.exportEditOrdersButton.Click += new System.EventHandler(this.exportEditOrdersButton_Click);
            // 
            // EditOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 355);
            this.Controls.Add(this.exportEditOrdersButton);
            this.Controls.Add(this.EditOrdersDataGrid);
            this.Name = "EditOrdersForm";
            this.Text = "EditOrdersForm";
            this.Load += new System.EventHandler(this.EditOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditOrdersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersShippersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EditOrdersDataGrid;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MassiveDynamicDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipViaDataGridViewTextBoxColumn;
        private OrdersShippersDataSet ordersShippersDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
        private OrdersShippersDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter1;
        private System.Windows.Forms.BindingSource ordersBindingSource2;
        private System.Windows.Forms.Button exportEditOrdersButton;
    }
}