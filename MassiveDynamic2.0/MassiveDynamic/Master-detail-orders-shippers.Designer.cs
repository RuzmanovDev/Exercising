namespace MassiveDynamic
{
    partial class Master_detail_orders_shippers
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
            this.massiveDynamicDataSet1 = new MassiveDynamic.MassiveDynamicDataSet1();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new MassiveDynamic.MassiveDynamicDataSet1TableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new MassiveDynamic.MassiveDynamicDataSet1TableAdapters.TableAdapterManager();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new MassiveDynamic.MassiveDynamicDataSet1TableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // massiveDynamicDataSet1
            // 
            this.massiveDynamicDataSet1.DataSetName = "MassiveDynamicDataSet1";
            this.massiveDynamicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.massiveDynamicDataSet1;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.UpdateOrder = MassiveDynamic.MassiveDynamicDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.massiveDynamicDataSet1;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Master_detail_orders_shippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 423);
            this.Name = "Master_detail_orders_shippers";
            this.Text = "Master_detail_orders_shippers";
            this.Load += new System.EventHandler(this.Master_detail_orders_shippers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MassiveDynamicDataSet1 massiveDynamicDataSet1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private MassiveDynamicDataSet1TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private MassiveDynamicDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private MassiveDynamicDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource;
    }
}