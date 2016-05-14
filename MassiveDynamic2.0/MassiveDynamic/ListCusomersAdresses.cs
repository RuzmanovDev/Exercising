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
    public partial class ListCusomersAdresses : Form
    {
        public ListCusomersAdresses()
        {
            InitializeComponent();
        }

        private void ListCusomersAdresses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.OrderDetails' table. You can move, or remove it, as needed.
            this.orderDetailsTableAdapter.Fill(this.massiveDynamicDataSet.OrderDetails);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.massiveDynamicDataSet.Orders);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.massiveDynamicDataSet.Customers);

        }
        private DataSet GetCusomerOrderDateViaName(string customerName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string command = String.Format("select OrderDate from Customers, Orders where CompanyName='{0}'", NameOfCompanyDropDown.Text);

            SqlCommand com = new SqlCommand(command, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ada.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                return ds;

            }
            catch (Exception exe)
            {

                MessageBox.Show(exe.ToString(), "Message/Съобщение:");
                return null;

            }
            finally
            {
                con.Close();

            }

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            DataSet ds = GetCusomerOrderDateViaName(NameOfCompanyDropDown.SelectedValue.ToString());
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
                resultsGroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Няма намерени резултати!", "Message/Съобщение:");

            }
        }


    }
}
