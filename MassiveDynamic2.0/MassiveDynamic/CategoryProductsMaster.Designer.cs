namespace MassiveDynamic
{
    partial class CategoryProductsMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryProductsMaster));
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label categoryIDLabel1;
            System.Windows.Forms.Label quantityPerUnitLabel;
            System.Windows.Forms.Label unitPriceLabel;
            this.massiveDynamicDataSet3 = new MassiveDynamic.MassiveDynamicDataSet3();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter = new MassiveDynamic.MassiveDynamicDataSet3TableAdapters.CategoriesTableAdapter();
            this.tableAdapterManager = new MassiveDynamic.MassiveDynamicDataSet3TableAdapters.TableAdapterManager();
            this.categoriesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.categoriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.categoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionComboBox = new System.Windows.Forms.ComboBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new MassiveDynamic.MassiveDynamicDataSet3TableAdapters.ProductsTableAdapter();
            this.productIDComboBox = new System.Windows.Forms.ComboBox();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.categoryIDComboBox1 = new System.Windows.Forms.ComboBox();
            this.quantityPerUnitComboBox = new System.Windows.Forms.ComboBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.categoriesDataSet = new MassiveDynamic.CategoriesDataSet();
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesTableAdapter1 = new MassiveDynamic.CategoriesDataSetTableAdapters.CategoriesTableAdapter();
            this.productsDataSet = new MassiveDynamic.ProductsDataSet();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new MassiveDynamic.ProductsDataSetTableAdapters.ProductsTableAdapter();
            categoryIDLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            categoryIDLabel1 = new System.Windows.Forms.Label();
            quantityPerUnitLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).BeginInit();
            this.categoriesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // massiveDynamicDataSet3
            // 
            this.massiveDynamicDataSet3.DataSetName = "MassiveDynamicDataSet3";
            this.massiveDynamicDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.massiveDynamicDataSet3;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = this.categoriesTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = MassiveDynamic.MassiveDynamicDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // categoriesBindingNavigator
            // 
            this.categoriesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.categoriesBindingNavigator.BindingSource = this.categoriesBindingSource;
            this.categoriesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.categoriesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.categoriesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.categoriesBindingNavigatorSaveItem});
            this.categoriesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.categoriesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.categoriesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.categoriesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.categoriesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.categoriesBindingNavigator.Name = "categoriesBindingNavigator";
            this.categoriesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.categoriesBindingNavigator.Size = new System.Drawing.Size(385, 25);
            this.categoriesBindingNavigator.TabIndex = 0;
            this.categoriesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // categoriesBindingNavigatorSaveItem
            // 
            this.categoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.categoriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriesBindingNavigatorSaveItem.Image")));
            this.categoriesBindingNavigatorSaveItem.Name = "categoriesBindingNavigatorSaveItem";
            this.categoriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.categoriesBindingNavigatorSaveItem.Text = "Save Data";
            this.categoriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.categoriesBindingNavigatorSaveItem_Click);
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(32, 32);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 1;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryID", true));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(121, 29);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryIDComboBox.TabIndex = 2;
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(32, 59);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(83, 13);
            categoryNameLabel.TabIndex = 3;
            categoryNameLabel.Text = "Category Name:";
            // 
            // categoryNameComboBox
            // 
            this.categoryNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "CategoryName", true));
            this.categoryNameComboBox.DataSource = this.categoriesBindingSource1;
            this.categoryNameComboBox.DisplayMember = "CategoryName";
            this.categoryNameComboBox.FormattingEnabled = true;
            this.categoryNameComboBox.Location = new System.Drawing.Point(121, 56);
            this.categoryNameComboBox.Name = "categoryNameComboBox";
            this.categoryNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoryNameComboBox.TabIndex = 4;
            this.categoryNameComboBox.ValueMember = "CategoryID";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(32, 86);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionComboBox
            // 
            this.descriptionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriesBindingSource, "Description", true));
            this.descriptionComboBox.FormattingEnabled = true;
            this.descriptionComboBox.Location = new System.Drawing.Point(121, 83);
            this.descriptionComboBox.Name = "descriptionComboBox";
            this.descriptionComboBox.Size = new System.Drawing.Size(121, 21);
            this.descriptionComboBox.TabIndex = 6;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.massiveDynamicDataSet3;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(32, 121);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(61, 13);
            productIDLabel.TabIndex = 7;
            productIDLabel.Text = "Product ID:";
            // 
            // productIDComboBox
            // 
            this.productIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductID", true));
            this.productIDComboBox.DataSource = this.categoriesBindingSource;
            this.productIDComboBox.DisplayMember = "CategoryName";
            this.productIDComboBox.FormattingEnabled = true;
            this.productIDComboBox.Location = new System.Drawing.Point(128, 118);
            this.productIDComboBox.Name = "productIDComboBox";
            this.productIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.productIDComboBox.TabIndex = 8;
            this.productIDComboBox.ValueMember = "CategoryID";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(32, 148);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(78, 13);
            productNameLabel.TabIndex = 9;
            productNameLabel.Text = "Product Name:";
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductName", true));
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(128, 145);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.productNameComboBox.TabIndex = 10;
            // 
            // categoryIDLabel1
            // 
            categoryIDLabel1.AutoSize = true;
            categoryIDLabel1.Location = new System.Drawing.Point(32, 175);
            categoryIDLabel1.Name = "categoryIDLabel1";
            categoryIDLabel1.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel1.TabIndex = 11;
            categoryIDLabel1.Text = "Category ID:";
            // 
            // categoryIDComboBox1
            // 
            this.categoryIDComboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CategoryID", true));
            this.categoryIDComboBox1.DataSource = this.categoriesBindingSource;
            this.categoryIDComboBox1.DisplayMember = "CategoryName";
            this.categoryIDComboBox1.FormattingEnabled = true;
            this.categoryIDComboBox1.Location = new System.Drawing.Point(128, 172);
            this.categoryIDComboBox1.Name = "categoryIDComboBox1";
            this.categoryIDComboBox1.Size = new System.Drawing.Size(121, 21);
            this.categoryIDComboBox1.TabIndex = 12;
            this.categoryIDComboBox1.ValueMember = "CategoryID";
            // 
            // quantityPerUnitLabel
            // 
            quantityPerUnitLabel.AutoSize = true;
            quantityPerUnitLabel.Location = new System.Drawing.Point(32, 202);
            quantityPerUnitLabel.Name = "quantityPerUnitLabel";
            quantityPerUnitLabel.Size = new System.Drawing.Size(90, 13);
            quantityPerUnitLabel.TabIndex = 13;
            quantityPerUnitLabel.Text = "Quantity Per Unit:";
            // 
            // quantityPerUnitComboBox
            // 
            this.quantityPerUnitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "QuantityPerUnit", true));
            this.quantityPerUnitComboBox.FormattingEnabled = true;
            this.quantityPerUnitComboBox.Location = new System.Drawing.Point(128, 199);
            this.quantityPerUnitComboBox.Name = "quantityPerUnitComboBox";
            this.quantityPerUnitComboBox.Size = new System.Drawing.Size(121, 21);
            this.quantityPerUnitComboBox.TabIndex = 14;
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(32, 229);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 15;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(128, 226);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(121, 20);
            this.unitPriceTextBox.TabIndex = 16;
            // 
            // categoriesDataSet
            // 
            this.categoriesDataSet.DataSetName = "CategoriesDataSet";
            this.categoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataMember = "Categories";
            this.categoriesBindingSource1.DataSource = this.categoriesDataSet;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // productsDataSet
            // 
            this.productsDataSet.DataSetName = "ProductsDataSet";
            this.productsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.productsDataSet;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // CategoryProductsMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 294);
            this.Controls.Add(productIDLabel);
            this.Controls.Add(this.productIDComboBox);
            this.Controls.Add(productNameLabel);
            this.Controls.Add(this.productNameComboBox);
            this.Controls.Add(categoryIDLabel1);
            this.Controls.Add(this.categoryIDComboBox1);
            this.Controls.Add(quantityPerUnitLabel);
            this.Controls.Add(this.quantityPerUnitComboBox);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(categoryNameLabel);
            this.Controls.Add(this.categoryNameComboBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionComboBox);
            this.Controls.Add(this.categoriesBindingNavigator);
            this.Name = "CategoryProductsMaster";
            this.Text = "CategoryProductsMaster";
            this.Load += new System.EventHandler(this.CategoryProductsMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.massiveDynamicDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingNavigator)).EndInit();
            this.categoriesBindingNavigator.ResumeLayout(false);
            this.categoriesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MassiveDynamicDataSet3 massiveDynamicDataSet3;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private MassiveDynamicDataSet3TableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private MassiveDynamicDataSet3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator categoriesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton categoriesBindingNavigatorSaveItem;
        private MassiveDynamicDataSet3TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.ComboBox categoryNameComboBox;
        private System.Windows.Forms.ComboBox descriptionComboBox;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.ComboBox productIDComboBox;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.ComboBox categoryIDComboBox1;
        private System.Windows.Forms.ComboBox quantityPerUnitComboBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private CategoriesDataSet categoriesDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private CategoriesDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private ProductsDataSet productsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}