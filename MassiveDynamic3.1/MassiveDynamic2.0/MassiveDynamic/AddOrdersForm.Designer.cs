namespace MassiveDynamic
{
    partial class AddOrdersForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.OrderDataTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.customerIdDropDown = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.customersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.CustomersTableAdapter();
            this.massiveDynamicDataSet1 = new MassiveDynamic.MassiveDynamicDataSet();
            this.ShipViaComboBox = new System.Windows.Forms.ComboBox();
            this.shippersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shippersTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.ShippersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер на поръчката";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер на клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата на поръчката";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Достави чрез";
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Location = new System.Drawing.Point(151, 24);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.Size = new System.Drawing.Size(121, 20);
            this.OrderIDTextBox.TabIndex = 4;
            // 
            // OrderDataTextBox
            // 
            this.OrderDataTextBox.Location = new System.Drawing.Point(151, 107);
            this.OrderDataTextBox.Name = "OrderDataTextBox";
            this.OrderDataTextBox.Size = new System.Drawing.Size(121, 20);
            this.OrderDataTextBox.TabIndex = 6;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(172, 193);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(100, 23);
            this.AddOrderButton.TabIndex = 8;
            this.AddOrderButton.Text = "Добави";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // customerIdDropDown
            // 
            this.customerIdDropDown.DataSource = this.customersBindingSource;
            this.customerIdDropDown.DisplayMember = "CustomerID";
            this.customerIdDropDown.FormattingEnabled = true;
            this.customerIdDropDown.Location = new System.Drawing.Point(151, 69);
            this.customerIdDropDown.Name = "customerIdDropDown";
            this.customerIdDropDown.Size = new System.Drawing.Size(121, 21);
            this.customerIdDropDown.TabIndex = 9;
            this.customerIdDropDown.ValueMember = "CustomerID";
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
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // massiveDynamicDataSet1
            // 
            this.massiveDynamicDataSet1.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ShipViaComboBox
            // 
            this.ShipViaComboBox.DataSource = this.shippersBindingSource;
            this.ShipViaComboBox.DisplayMember = "ShipperID";
            this.ShipViaComboBox.FormattingEnabled = true;
            this.ShipViaComboBox.Location = new System.Drawing.Point(151, 145);
            this.ShipViaComboBox.Name = "ShipViaComboBox";
            this.ShipViaComboBox.Size = new System.Drawing.Size(121, 21);
            this.ShipViaComboBox.TabIndex = 10;
            this.ShipViaComboBox.ValueMember = "ShipperID";
            // 
            // shippersBindingSource
            // 
            this.shippersBindingSource.DataMember = "Shippers";
            this.shippersBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // shippersTableAdapter
            // 
            this.shippersTableAdapter.ClearBeforeFill = true;
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.ShipViaComboBox);
            this.Controls.Add(this.customerIdDropDown);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.OrderDataTextBox);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrdersForm";
            this.Text = "Добавяне на поръчки";
            this.Load += new System.EventHandler(this.AddOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox OrderIDTextBox;
        private System.Windows.Forms.TextBox OrderDataTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.ComboBox customerIdDropDown;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MassiveDynamicDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private MassiveDynamicDataSet massiveDynamicDataSet1;
        private System.Windows.Forms.ComboBox ShipViaComboBox;
        private System.Windows.Forms.BindingSource shippersBindingSource;
        private MassiveDynamicDataSetTableAdapters.ShippersTableAdapter shippersTableAdapter;
    }
}