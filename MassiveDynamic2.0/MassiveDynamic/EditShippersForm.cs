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
    public partial class EditShippersForm : Form
    {
        public EditShippersForm()
        {
            InitializeComponent();
        }

        private void EditShippersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.massiveDynamicDataSet.Shippers);

        }

        private void ShippersEditEvent(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.shippersTableAdapter.Update(this.massiveDynamicDataSet.Shippers);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");


            }
            catch (Exception)
            {

                MessageBox.Show("BOOM");

            }
        }
    }
}
