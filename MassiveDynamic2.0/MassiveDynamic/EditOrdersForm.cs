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
    public partial class EditOrdersForm : Form
    {
        public EditOrdersForm()
        {
            InitializeComponent();
        }

        private void EditOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersShippersDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter1.Fill(this.ordersShippersDataSet.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet.Orders);

        }

        

        private void EditOrdersDataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.ordersTableAdapter.Update(massiveDynamicDataSet.Orders);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception)
            {
                MessageBox.Show("БУМ!", "Съобщение:");

            }
        }
    }
}
