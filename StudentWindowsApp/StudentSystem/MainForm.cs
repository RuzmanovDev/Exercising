namespace StudentSystem
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

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

        private void добавянеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddEduDegree eduDegree = new AddEduDegree();
            eduDegree.ShowDialog();
        }

        private void добавянеToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddGorups addGroups = new AddGorups();
            addGroups.ShowDialog();
        }

        private void добавянеToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AddSpecialties addSpecialTies = new AddSpecialties();
            addSpecialTies.ShowDialog();
        }

        private void редактиранеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEducationForm updateEduForm = new UpdateEducationForm();
            updateEduForm.ShowDialog();
        }

        private void фToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
