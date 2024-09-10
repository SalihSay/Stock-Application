using StokUygulamasi;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace StokUygulamasi
{


    public partial class Admin : Form
    {
        public string connectionstring = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {



        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionstring))
            {
                string query = "SELECT IsAdmin FROM UserTable WHERE Username = @Username AND Password = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && result is bool isAdmin)
                        {
                            // Kullanıcı adını global bir değişkende sakla
                            GlobalVariables.LoggedInUsername = username;

                            if (isAdmin)
                            {
                                MessageBox.Show("Login successful. You have admin rights.");
                            }
                            else
                            {
                                MessageBox.Show("Login successful. You do not have admin rights.");
                            }

                            AnaForm anaForm = new AnaForm(isAdmin);
                            anaForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username or password is incorrect.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred. : {ex.Message}");
                    }
                }
            }
        }
    }
}

