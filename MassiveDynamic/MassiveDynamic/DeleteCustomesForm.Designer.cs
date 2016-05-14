namespace MassiveDynamic
{
    partial class DeleteCustomesForm
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
            this.deleteComboBox = new System.Windows.Forms.ComboBox();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.CustomersTableAdapter();
            this.deleteCustomersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteComboBox
            // 
            this.deleteComboBox.DataSource = this.customersBindingSource1;
            this.deleteComboBox.DisplayMember = "CustomerID";
            this.deleteComboBox.FormattingEnabled = true;
            this.deleteComboBox.Location = new System.Drawing.Point(28, 23);
            this.deleteComboBox.Name = "deleteComboBox";
            this.deleteComboBox.Size = new System.Drawing.Size(121, 21);
            this.deleteComboBox.TabIndex = 0;
            this.deleteComboBox.ValueMember = "CustomerID";
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "Customers";
            this.customersBindingSource1.DataSource = this.massiveDynamicDataSetBindingSource;
            // 
            // massiveDynamicDataSetBindingSource
            // 
            this.massiveDynamicDataSetBindingSource.DataSource = this.massiveDynamicDataSet;
            this.massiveDynamicDataSetBindingSource.Position = 0;
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // deleteCustomersButton
            // 
            this.deleteCustomersButton.Location = new System.Drawing.Point(183, 23);
            this.deleteCustomersButton.Name = "deleteCustomersButton";
            this.deleteCustomersButton.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomersButton.TabIndex = 1;
            this.deleteCustomersButton.Text = "Изтриване";
            this.deleteCustomersButton.UseVisualStyleBackColor = true;
            this.deleteCustomersButton.Click += new System.EventHandler(this.deleteCustomersButton_Click);
            // 
            // DeleteCustomesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 77);
            this.Controls.Add(this.deleteCustomersButton);
            this.Controls.Add(this.deleteComboBox);
            this.Name = "DeleteCustomesForm";
            this.Text = "DeleteCustomesForm";
            this.Load += new System.EventHandler(this.DeleteCustomesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox deleteComboBox;
        private System.Windows.Forms.BindingSource massiveDynamicDataSetBindingSource;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MassiveDynamicDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private System.Windows.Forms.Button deleteCustomersButton;
    }
}