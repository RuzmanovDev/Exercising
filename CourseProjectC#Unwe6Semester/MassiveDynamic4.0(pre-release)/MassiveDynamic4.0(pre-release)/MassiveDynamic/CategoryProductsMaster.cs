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
    public partial class CategoryProductsMaster : Form
    {
        public CategoryProductsMaster()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.massiveDynamicDataSet3);

        }

        private void CategoryProductsMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productsDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter1.Fill(this.productsDataSet.Products);
            // TODO: This line of code loads data into the 'categoriesDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter1.Fill(this.categoriesDataSet.Categories);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet3.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.massiveDynamicDataSet3.Products);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet3.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.massiveDynamicDataSet3.Categories);

        }
    }
}
