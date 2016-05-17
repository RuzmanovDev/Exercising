namespace MassiveDynamic
{
    partial class DeleteProductForm
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
            this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.productsTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.ProductsTableAdapter();
            this.ProductDeleteButton = new System.Windows.Forms.Button();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на продукта";
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.DataSource = this.productsBindingSource1;
            this.ProductNameComboBox.DisplayMember = "ProductName";
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.Location = new System.Drawing.Point(124, 40);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.ProductNameComboBox.TabIndex = 1;
            this.ProductNameComboBox.ValueMember = "ProductName";
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ProductDeleteButton
            // 
            this.ProductDeleteButton.Location = new System.Drawing.Point(268, 41);
            this.ProductDeleteButton.Name = "ProductDeleteButton";
            this.ProductDeleteButton.Size = new System.Drawing.Size(75, 23);
            this.ProductDeleteButton.TabIndex = 2;
            this.ProductDeleteButton.Text = "Изтриване";
            this.ProductDeleteButton.UseVisualStyleBackColor = true;
            this.ProductDeleteButton.Click += new System.EventHandler(this.ProductDeleteButton_Click);
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.massiveDynamicDataSet;
            // 
            // DeleteProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 103);
            this.Controls.Add(this.ProductDeleteButton);
            this.Controls.Add(this.ProductNameComboBox);
            this.Controls.Add(this.label1);
            this.Name = "DeleteProductForm";
            this.Text = "DeleteProductForm";
            this.Load += new System.EventHandler(this.DeleteProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductNameComboBox;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private MassiveDynamicDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button ProductDeleteButton;
        private System.Windows.Forms.BindingSource productsBindingSource1;
    }
}