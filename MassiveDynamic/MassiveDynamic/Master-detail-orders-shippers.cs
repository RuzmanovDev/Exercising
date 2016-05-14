using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AWModel;

namespace MassiveDynamic
{
    public partial class Master_detail_orders_shippers : Form
    {
        public Master_detail_orders_shippers()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.massiveDynamicDataSet);

        }

        private void Master_detail_orders_shippers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.massiveDynamicDataSet.Shippers);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet.Orders);

        }

      
    }
}
