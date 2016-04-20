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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void добавянеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFormOfEdu f2 = new AddFormOfEdu();
            f2.ShowDialog();
        }
    }
}
