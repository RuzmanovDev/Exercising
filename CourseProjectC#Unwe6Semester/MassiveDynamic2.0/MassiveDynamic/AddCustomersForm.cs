namespace MassiveDynamic
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
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
            con.ConnectionString = ConfigurationManager.ConnectionStrings["MassiveDynamic.Properties.Settings.MassiveDynamicConnectionString"].ConnectionString;
            //символен низ със заявката към базата данни
            string insertIntoId = "'" + CustomerIdAddTextBox.Text + "'";
            string inserIntoCustomerName = "'" + CompanyNameTextBox.Text + "'";
            string inserIntoCustomerAddress = "'" + AddressTextBox.Text + "'";
            string inserIntoCustomerPhone = "'" + CustomerPhoneTextBox.Text + "'";

            //INSERT INTO table_name (column1,column2,column3,...)  VALUES(value1, value2, value3,...);  Insert into cheatSheet
            string insertCommand = string.Format("insert into Customers (CustomerID,CompanyName,Address,Phone) values({0},{1},{2},{3});", insertIntoId, inserIntoCustomerName, inserIntoCustomerAddress, inserIntoCustomerPhone);

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
