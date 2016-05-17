using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MassiveDynamic
{
    public partial class AddOrdersForm : Form
    {
        public AddOrdersForm()
        {
            InitializeComponent();
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //символен низ за връзка към базата данни – взема се от файл с име app.config
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;
            //символен низ със заявката към базата данни
            string insertIntoOrderID = "'" + OrderIDTextBox.Text + "'";
            string inserIntoCustomerID = "'" + customerIdDropDown.Text + "'";
            string inserIntoOrderDate = "'" + OrderDataTextBox.Text + "'";
            string inserIntoShipVia = "'" + ShipViaComboBox.Text + "'";

            //INSERT INTO table_name (column1,column2,column3,...)  VALUES(value1, value2, value3,...);  Insert into cheatSheet
            string insertCommand = string.Format("insert into Orders (OrderID,CustomerID,OrderDate,ShipVia) values({0},{1},{2},{3});", insertIntoOrderID, inserIntoCustomerID, inserIntoOrderDate, inserIntoShipVia);

            SqlCommand com = new SqlCommand(insertCommand, con);

            //определяне на типа на командата - в конкретния случай е текст
            com.CommandType = CommandType.Text;

            try
            {
                //отваряме връзката към базата данни
                con.Open();
                //изпълняваме командата / в този случай нямаме връщан резултат
                com.ExecuteNonQuery();

                //извеждаме съобщение, че всичко е преминало успешно
                MessageBox.Show("Данните са добавени успешно!",
               "Message/Съобщение");
                //изчистваме въведената стойност в текстовото поле
                OrderIDTextBox.Clear();
                OrderDataTextBox.Clear();
            }
            //ако не е преминало всичко успешно, това означава, че е възникнало изключение
            catch (Exception exe)
            {
                //извеждаме съобщение с възникналото изключение
                MessageBox.Show(exe.ToString(), "Message/Съобщение:");
            }
            //затваря се връзката към базата данни
            con.Close();
            //затваря се отворената форма
            this.Close();
        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Shippers' table. You can move, or remove it, as needed.
            this.shippersTableAdapter.Fill(this.massiveDynamicDataSet.Shippers);
            // TODO: This line of code loads data into the 'massiveDynamicDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.massiveDynamicDataSet.Customers);

        }

       
    }
}

