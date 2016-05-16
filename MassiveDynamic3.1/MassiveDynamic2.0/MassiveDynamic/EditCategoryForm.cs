using System;
using System.IO;
using System.Text;
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
                MessageBox.Show("БУМ!", "Съобщение:");

            }
        }




        //export function
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount ; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }












        private void CategoryExportButtom_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");
                ToCsV(EditCategoryGrid, sfd.FileName); // Here dataGridview1 is your grid view name
            }




        }
    }
}