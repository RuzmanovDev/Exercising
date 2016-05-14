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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.massiveDynamicDataSet.Categories);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Customers' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.massiveDynamicDataSet.Categories);

        }

        private void EditCategoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                this.Validate();
                this.categoriesTableAdapter.Update(massiveDynamicDataSet.Categories);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception)
            {

            }
        }
    }
}
