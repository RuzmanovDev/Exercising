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
    public partial class Customers_Orders_Master : Form
    {
        public Customers_Orders_Master()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.massiveDynamicDataSet1);

        }

        private void Customers_Orders_Master_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.customersDataSet1.Customers);
            // TODO: This line of code loads data into the 'ordersDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.ordersDataSet1.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet1.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.massiveDynamicDataSet1.Customers);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet1.Orders);

        }
    }
}
