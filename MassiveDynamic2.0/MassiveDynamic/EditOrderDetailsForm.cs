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
    public partial class EditOrderDetailsForm : Form
    {
        public EditOrderDetailsForm()
        {
            InitializeComponent();
        }

        private void EditOrderDetailsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.massiveDynamicDataSet.OrderDetails);

        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.Validate();
                this.orderDetailsTableAdapter.Update(massiveDynamicDataSet.OrderDetails);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception)
            {
                MessageBox.Show("БУМ!", "Съобщение:");

            }
        }
    }
}
