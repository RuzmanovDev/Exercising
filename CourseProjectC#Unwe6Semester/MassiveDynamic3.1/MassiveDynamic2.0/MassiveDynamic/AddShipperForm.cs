namespace MassiveDynamic
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class AddShipperForm : Form
    {
        public AddShipperForm()
        {
            InitializeComponent();
        }

        private void AddShipperButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;
            string insertShipid = "'" + ShipperIdTextBox.Text + "'";
            string insertShipperName = "'" + ShipperNameTextBox.Text + "'";
            string insertShipperPhone = "'" + ShipperTelephoneTextBox.Text + "'";

            string insertCommand = String.Format("insert into Shippers(ShipperID, CompanyName, Phone) values({0},{1},{2});", insertShipid, insertShipperName, insertShipperPhone);

            SqlCommand com = new SqlCommand(insertCommand, con);

            com.CommandType = CommandType.Text;

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Данните за доставчика са добавени успешно!");
                ShipperIdTextBox.Clear();
                ShipperNameTextBox.Clear();
                ShipperTelephoneTextBox.Clear();

            }
            catch (Exception)
            {
                MessageBox.Show("GARMEJI");
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }
    }
}
