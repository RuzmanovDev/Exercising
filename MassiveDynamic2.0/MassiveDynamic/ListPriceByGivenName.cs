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
    public partial class ListPriceByGivenName : Form
    {
        public ListPriceByGivenName()
        {
            InitializeComponent();
        }

        private void ListPriceByGivenName_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.massiveDynamicDataSet.Products);

        }
        private DataSet GetPriceByGivenName(string customerName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string command = String.Format("select ProductName,UnitPrice from Products where ProductName='TestPC'", ProductNameDropDown.Text);

            SqlCommand com = new SqlCommand(command, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ada.Fill(ds);
                dataGridPriceByGivenName.DataSource = ds.Tables[0];
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
        private void SearchPriceButton_Click(object sender, EventArgs e)
        {
            DataSet ds = GetPriceByGivenName(ProductNameDropDown.SelectedValue.ToString());
            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridPriceByGivenName.DataSource = ds.Tables[0];
                resultGroupBoxListPriceByName.Visible = true;
                MessageBox.Show("{0}");
            }
            else
            {
                MessageBox.Show("Няма намерени резултати!", "Message/Съобщение:");

            }
        }
    }
}
