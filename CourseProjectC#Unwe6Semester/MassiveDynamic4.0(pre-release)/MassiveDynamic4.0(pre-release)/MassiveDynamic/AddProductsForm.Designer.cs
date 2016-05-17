namespace MassiveDynamic
{
    partial class AddProductsForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.QuantityPerUnitTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProoductButton = new System.Windows.Forms.Button();
            this.CategoryIdComboBox = new System.Windows.Forms.ComboBox();
            this.massiveDynamicDataSet = new MassiveDynamic.MassiveDynamicDataSet();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new MassiveDynamic.MassiveDynamicDataSetTableAdapters.CategoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID на продукта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Име на продукта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID на категорията";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Наличност на продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Цена";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(144, 20);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 5;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(144, 49);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductNameTextBox.TabIndex = 6;
            // 
            // QuantityPerUnitTextBox
            // 
            this.QuantityPerUnitTextBox.Location = new System.Drawing.Point(144, 109);
            this.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox";
            this.QuantityPerUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.QuantityPerUnitTextBox.TabIndex = 8;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(144, 138);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 9;
            // 
            // AddProoductButton
            // 
            this.AddProoductButton.Location = new System.Drawing.Point(173, 165);
            this.AddProoductButton.Name = "AddProoductButton";
            this.AddProoductButton.Size = new System.Drawing.Size(75, 23);
            this.AddProoductButton.TabIndex = 10;
            this.AddProoductButton.Text = "Добави";
            this.AddProoductButton.UseVisualStyleBackColor = true;
            this.AddProoductButton.Click += new System.EventHandler(this.AddProoductButton_Click);
            // 
            // CategoryIdComboBox
            // 
            this.CategoryIdComboBox.DataSource = this.categoriesBindingSource;
            this.CategoryIdComboBox.DisplayMember = "CategoryID";
            this.CategoryIdComboBox.FormattingEnabled = true;
            this.CategoryIdComboBox.Location = new System.Drawing.Point(144, 76);
            this.CategoryIdComboBox.Name = "CategoryIdComboBox";
            this.CategoryIdComboBox.Size = new System.Drawing.Size(100, 21);
            this.CategoryIdComboBox.TabIndex = 11;
            // 
            // massiveDynamicDataSet
            // 
            this.massiveDynamicDataSet.DataSetName = "MassiveDynamicDataSet";
            this.massiveDynamicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.massiveDynamicDataSet;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // AddProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 201);
            this.Controls.Add(this.CategoryIdComboBox);
            this.Controls.Add(this.AddProoductButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.QuantityPerUnitTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductsForm";
            this.Text = "AddProductsForm";
            this.Load += new System.EventHandler(this.AddProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductIDTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox QuantityPerUnitTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddProoductButton;
        private System.Windows.Forms.ComboBox CategoryIdComboBox;
        private MassiveDynamicDataSet massiveDynamicDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private MassiveDynamicDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
    }
}