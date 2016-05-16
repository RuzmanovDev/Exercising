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
    public partial class EditProductsForm : Form
    {
        public EditProductsForm()
        {
            InitializeComponent();
        }

        private void EditProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.massiveDynamicDataSet.Products);

        }

        private void EditProductsEvent(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.Validate();
                this.productsTableAdapter.Update(massiveDynamicDataSet.Products);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception)
            {
                MessageBox.Show("BOOM");
            }
        }
    }
}
