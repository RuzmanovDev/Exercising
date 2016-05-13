using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentSystem
{
    public partial class UpdateEducationForm : Form
    {
        public UpdateEducationForm()
        {
            InitializeComponent();
        }

        private void UpdateEducationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pesho.EducationForm' table. You can move, or remove it, as needed.
            this.educationFormTableAdapter.Fill(this.pesho.EducationForm);

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Validate();
                this.educationFormTableAdapter.Update(this.pesho.EducationForm);
                MessageBox.Show("Промяната е извършена успено!", "Съобщение:");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Промяната не е реализирана!", "Съобщение:");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}