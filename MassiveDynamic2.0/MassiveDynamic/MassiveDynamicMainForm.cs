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
    public partial class MassiveDynamicMainForm : Form
    {
        public MassiveDynamicMainForm()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm();
            addCustomersForm.ShowDialog();
        }

        private void EditCustomersMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomersForm update = new UpdateCustomersForm();
            update.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCustomesForm delete = new DeleteCustomesForm();
            delete.ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Master_detail_orders_shippers md = new Master_detail_orders_shippers();
            md.ShowDialog();
        }

        private void customerNameAdressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCusomersAdresses filter = new ListCusomersAdresses();
            filter.ShowDialog();
        }

        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryForm ad = new AddCategoryForm();
            ad.ShowDialog();
        }

        private void EditCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCategoryForm edit = new EditCategoryForm();
            edit.ShowDialog();

        }

        private void DeleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCategoryForm del = new DeleteCategoryForm();
            del.ShowDialog();
        }

        private void addShipersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddShipperForm add = new AddShipperForm();
            add.ShowDialog();
        }

        private void editShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditShippersForm edit = new EditShippersForm();
            edit.ShowDialog();
        }

        private void deleteShippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteShipperForm del = new DeleteShipperForm();
            del.ShowDialog();

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProductsForm add = new AddProductsForm();
            add.ShowDialog();
        }
    }
}
