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
    public partial class MassiveDynamicMainForm : Form
    {
        public MassiveDynamicMainForm()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm();
            addCustomersForm.ShowDialog();
        }

        private void EditCustomersMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCustomersForm update = new UpdateCustomersForm();
            update.ShowDialog();
        }
    }
}
