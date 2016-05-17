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
    public partial class ListShipViaByOrderID : Form
    {
        public ListShipViaByOrderID()
        {
            InitializeComponent();
        }

        private void ListShipViaByOrderID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ordersDataSet1.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.ordersDataSet1.Orders);

        }

        private DataSet ShipViaByOrderID(string customerName)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string command = String.Format("select ShipVia from Orders where OrderID='{0}'", OrderIDComboBox.Text);

            SqlCommand com = new SqlCommand(command, con);
            com.CommandType = CommandType.Text;
            SqlDataAdapter ada = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            try
            {
                con.Open();
                ada.Fill(ds);
                ShipViaDataGrid.DataSource = ds.Tables[0];
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


        private void SearchByOrderIDButton_Click(object sender, EventArgs e)
        {
            DataSet ds = ShipViaByOrderID(OrderIDComboBox.SelectedValue.ToString());
            if (ds.Tables[0].Rows.Count != 0)
            {
                ShipViaDataGrid.DataSource = ds.Tables[0];
                //  resultGroupBoxListPriceByName.Visible = true;
                MessageBox.Show("Търсенето успешно");
            }
        }

        private void ShipViaDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
