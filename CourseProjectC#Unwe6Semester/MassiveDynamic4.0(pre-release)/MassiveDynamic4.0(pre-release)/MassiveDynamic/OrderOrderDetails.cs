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
    public partial class OrderOrderDetails : Form
    {
        public OrderOrderDetails()
        {
            InitializeComponent();
        }

        private void orderDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.massiveDynamicDataSet2);

        }

        private void OrderOrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderDetails._OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter1.Fill(this.orderDetails._OrderDetails);
            // TODO: This line of code loads data into the 'ordersDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.ordersDataSet1.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet2.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet2.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet2.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.massiveDynamicDataSet2.OrderDetails);

        }
    }
}
