using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassiveDynamic
{
    public partial class ProductsCategoryMasterDetail : Form
    {
        public ProductsCategoryMasterDetail()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoryProductsDataSet);

        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoryProductsDataSet);

        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.categoryProductsDataSet);

        }

        private void ProductsCategoryMasterDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.productsDataSet.Products);
            // TODO: This line of code loads data into the 'categoriesDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Fill(this.categoriesDataSet.Categories);
            // TODO: This line of code loads data into the 'categoryProductsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.categoryProductsDataSet.Products);
            // TODO: This line of code loads data into the 'categoryProductsDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.categoryProductsDataSet.Categories);

        }
    }
}
