namespace MassiveDynamic
{
    partial class ListPriceByGivenName
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
            this.ProductNameDropDown = new System.Windows.Forms.ComboBox();
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.ProductsTableAdapter();
            this.resultGroupBoxListPriceByName = new System.Windows.Forms.GroupBox();
            this.SearchPriceButton = new System.Windows.Forms.Button();
            this.dataGridPriceByGivenName = new System.Windows.Forms.DataGridView();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.resultGroupBoxListPriceByName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriceByGivenName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на продукта";
            // 
            // ProductNameDropDown
            // 
            this.ProductNameDropDown.DataSource = this.productsBindingSource;
            this.ProductNameDropDown.DisplayMember = "ProductName";
            this.ProductNameDropDown.FormattingEnabled = true;
            this.ProductNameDropDown.Location = new System.Drawing.Point(133, 48);
            this.ProductNameDropDown.Name = "ProductNameDropDown";
            this.ProductNameDropDown.Size = new System.Drawing.Size(121, 21);
            this.ProductNameDropDown.TabIndex = 1;
            this.ProductNameDropDown.ValueMember = "ProductName";
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // resultGroupBoxListPriceByName
            // 
            this.resultGroupBoxListPriceByName.Controls.Add(this.dataGridPriceByGivenName);
            this.resultGroupBoxListPriceByName.Location = new System.Drawing.Point(12, 75);
            this.resultGroupBoxListPriceByName.Name = "resultGroupBoxListPriceByName";
            this.resultGroupBoxListPriceByName.Size = new System.Drawing.Size(457, 116);
            this.resultGroupBoxListPriceByName.TabIndex = 2;
            this.resultGroupBoxListPriceByName.TabStop = false;
            this.resultGroupBoxListPriceByName.Text = "Резултати";
            // 
            // SearchPriceButton
            // 
            this.SearchPriceButton.Location = new System.Drawing.Point(270, 45);
            this.SearchPriceButton.Name = "SearchPriceButton";
            this.SearchPriceButton.Size = new System.Drawing.Size(75, 23);
            this.SearchPriceButton.TabIndex = 3;
            this.SearchPriceButton.Text = "Търси";
            this.SearchPriceButton.UseVisualStyleBackColor = true;
            this.SearchPriceButton.Click += new System.EventHandler(this.SearchPriceButton_Click);
            // 
            // dataGridPriceByGivenName
            // 
            this.dataGridPriceByGivenName.AllowUserToAddRows = false;
            this.dataGridPriceByGivenName.AllowUserToDeleteRows = false;
            this.dataGridPriceByGivenName.AutoGenerateColumns = false;
            this.dataGridPriceByGivenName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPriceByGivenName.DataSource = this.massiveDynamicDataSet;
            this.dataGridPriceByGivenName.Location = new System.Drawing.Point(6, 0);
            this.dataGridPriceByGivenName.Name = "dataGridPriceByGivenName";
            this.dataGridPriceByGivenName.ReadOnly = true;
            this.dataGridPriceByGivenName.Size = new System.Drawing.Size(445, 110);
            this.dataGridPriceByGivenName.TabIndex = 0;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.massiveDynamicDataSet;
            // 
            // ListPriceByGivenName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 216);
            this.Controls.Add(this.SearchPriceButton);
            this.Controls.Add(this.resultGroupBoxListPriceByName);
            this.Controls.Add(this.ProductNameDropDown);
            this.Controls.Add(this.label1);
            this.Name = "ListPriceByGivenName";
            this.Text = "ListPriceByGivenName";
            this.Load += new System.EventHandler(this.ListPriceByGivenName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.resultGroupBoxListPriceByName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriceByGivenName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductNameDropDown;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MassiveDynamicDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.GroupBox resultGroupBoxListPriceByName;
        private System.Windows.Forms.Button SearchPriceButton;
        private System.Windows.Forms.DataGridView dataGridPriceByGivenName;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}