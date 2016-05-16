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
    public partial class UpdateCustomersForm : Form
    {
        public UpdateCustomersForm()
        {
            InitializeComponent();
        }

        private void UpdateCustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.massiveDynamicDataSet.Customers);

        }

        private void CustomerEditEvent(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                this.Validate();
                this.customersTableAdapter.Update(massiveDynamicDataSet.Customers);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception)
            {

            }
        }
    }
}
