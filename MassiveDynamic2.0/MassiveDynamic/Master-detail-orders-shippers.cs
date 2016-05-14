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
    public partial class Master_detail_orders_shippers : Form
    {
        public Master_detail_orders_shippers()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
 
        }

        private void Master_detail_orders_shippers_Load(object sender, EventArgs e)
        {
            
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           

        }

        private void ordersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
      

        }

        private void buttonSearchShippers_Click(object sender, EventArgs e)
        {

        }

        private void ordersBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
          
        }
    }
}
