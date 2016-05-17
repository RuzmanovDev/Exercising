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
    public partial class AddProductsForm : Form
    {
        public AddProductsForm()
        {
            InitializeComponent();
        }

        private void AddProoductButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();

            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;

            string insertIntoProductId = "'" + ProductIDTextBox.Text + "'";
            string insertIntoProductName = "'" + ProductNameTextBox.Text + "'";
            string insertIntoCaegoryId = "'" + CategoryIdComboBox.Text + "'";
            string insertIntoQPE = "'" + QuantityPerUnitTextBox.Text + "'";
            string insertIntoUnitPrice = "'" + PriceTextBox.Text + "'";

            string command = string.Format("insert into Products(ProductID,ProductName,CategoryID,QuantityPerUnit,UnitPrice) values ({0},{1},{2},{3},{4})", insertIntoProductId, insertIntoProductName, insertIntoCaegoryId, insertIntoQPE, insertIntoUnitPrice);

            SqlCommand com = new SqlCommand(command, con);

            com.CommandType = CommandType.Text;
            try
            {
                con.Open();
                com.ExecuteNonQuery();

                MessageBox.Show("Данните са добавени успешно!");
                ProductIDTextBox.Clear();
                ProductNameTextBox.Clear();
                QuantityPerUnitTextBox.Clear();
                PriceTextBox.Clear();
            }
            catch (Exception exe)
            {
                //извеждаме съобщение с възникналото изключение
                MessageBox.Show(exe.ToString(), "Message/Съобщение:");
            }
            finally
            {
                con.Close();
                this.Close();
            }
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.massiveDynamicDataSet.Categories);

        }
    }
}