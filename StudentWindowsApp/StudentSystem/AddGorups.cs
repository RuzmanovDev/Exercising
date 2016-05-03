namespace StudentSystem
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.Windows.Forms;

    public partial class AddGorups : Form
    {
        public AddGorups()
        {
            InitializeComponent();
        }

        private void AddNumberOfGroup_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            //символен низ за връзка към базата данни – взема се от файл с име app.config
            con.ConnectionString =
            ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
            string command = "insert into EducationForm (EducForm) values ('" + NumberOfGroupTextBox.Text + "')";
            SqlCommand com = new SqlCommand(command, con);
            com.CommandType = CommandType.Text;
            try
            {
                con.Open();
                //изпълняваме командата / в този случай нямаме връщан резултат
                com.ExecuteNonQuery();
                //извеждаме съобщение, че всичко е преминало успешно
                MessageBox.Show("Данните за форма на обучение са добавени успешно!",
                "Message/Съобщение");
                //изчистваме въведената стойност в текстовото поле
                NumberOfGroupTextBox.Clear();
            }
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
