namespace MassiveDynamic
{
    using System;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class DeleteCustomesForm : Form
    {
        public DeleteCustomesForm()
        {
            InitializeComponent();
        }

        private void DeleteCustomesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.massiveDynamicDataSet.Customers);

        }

        private void deleteCustomersButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string deleteCommand =
                string.Format("delete from Customers where CustomerID='{0}'", deleteComboBox.SelectedValue);

            SqlCommand com = new SqlCommand(deleteCommand, con);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Данните са изтрити успешно!", "Message/Съобщение");
            }
            catch (Exception)
            {
                MessageBox.Show("ФОЕРВЕРКИ");
            }
            finally
            {
                con.Close();
                this.Close();
            }

        }
    }
}
