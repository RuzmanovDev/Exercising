using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MassiveDynamic
{
    public partial class DeleteOrdersForm : Form
    {
        public DeleteOrdersForm()
        {
            InitializeComponent();
        }

        private void DeleteOrdersButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string deleteCommand =
                string.Format("delete from Orders where OrderId='{0}'", DeleteOrdersComboBox.SelectedValue);

            SqlCommand com = new SqlCommand(deleteCommand, con);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Данните са изтрити успешно!", "Message/Съобщение");
            }
            catch (Exception)
            {
                MessageBox.Show("БУМ!");
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private void DeleteOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet.Orders);

        }
    }
}
