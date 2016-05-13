namespace MassiveDynamic
{
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

    public partial class AddCustomersForm : Form
    {
        public AddCustomersForm()
        {
            InitializeComponent();
        }

        private void AddCustomersButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //символен низ за връзка към базата данни – взема се от файл с име app.config
            con.ConnectionString =
            ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;
            //символен низ със заявката към базата данни
            string insertIntoId = "insert into Customers (CustomerID) values ('" +
           CustomerIdAddTextBox.Text + "')";
            string inserIntoCustomerName = "insert into Customers (CompanyName) values ('" +
           CompanyNameTextBox.Text + "')";
            string inserIntoCustomerAddress = "insert into Customers (Address) values ('" +
          AddressTextBox.Text + "')";
            string inserIntoCustomerPhone = "insert into Customers (Phone) values ('" +
        CustomerPhoneTextBox.Text + "')";
            //създаване на командата
            SqlCommand com = new SqlCommand(insertIntoId, con);
            SqlCommand com1 = new SqlCommand(inserIntoCustomerName, con);
            SqlCommand com2 = new SqlCommand(inserIntoCustomerAddress, con);
            SqlCommand com3 = new SqlCommand(inserIntoCustomerPhone, con);

            //определяне на типа на командата - в конкретния случай е текст
            com.CommandType = CommandType.Text;
            com1.CommandType = CommandType.Text;
            com2.CommandType = CommandType.Text;
            com3.CommandType = CommandType.Text;


            try
            {

                //отваряме връзката към базата данни
                con.Open();
                //изпълняваме командата / в този случай нямаме връщан резултат
                com.ExecuteNonQuery();
                com1.ExecuteNonQuery();
                com2.ExecuteNonQuery();
                com3.ExecuteNonQuery();

                //извеждаме съобщение, че всичко е преминало успешно
                MessageBox.Show("Данните за форма на обучение са добавени успешно!",
               "Message/Съобщение");
                //изчистваме въведената стойност в текстовото поле
                CustomerIdAddTextBox.Clear();
                CompanyNameTextBox.Clear();
                AddressTextBox.Clear();
                CustomerPhoneTextBox.Clear();
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
    }
}
