using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StokUygulamasi
{
    public partial class NewUserForm : Form
    {
        public string connectionString = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockApplicationDataSet5.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter1.Fill(this.stockApplicationDataSet5.UserTable);
            // TODO: This line of code loads data into the 'stockApplicationDataSet4.UserTable' table. You can move, or remove it, as needed.
            this.userTableTableAdapter.Fill(this.stockApplicationDataSet4.UserTable);

            LoadUserTableData();
            LoadDataGridView();

        }

        private void LoadUserTableData()
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "SELECT * FROM UserTable";

                
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                
                DataTable dataTable = new DataTable();

                try
                {
                    
                    dataAdapter.Fill(dataTable);

                   
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data. : {ex.Message}");
                }
            }
        }

        private void LoadDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM UserTable";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = false;


            
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            
            string username = row.Cells[1].Value.ToString();
            string password = row.Cells[2].Value.ToString();
            string role = row.Cells[3].Value.ToString();
            string gender = row.Cells[5].Value.ToString();


            textBoxUpdatedUsername.Text = username;
            textBoxUpdatedPassword.Text = password;
            comboBoxUpdatedRole.Text = role;
            comboBoxUpdatedGender.Text = gender;
          
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO UserTable (Username, Password, Role,Gender) VALUES (@Username, @Password, @Role,@Gender)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", textBoxUsername.Text);
                    command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                    command.Parameters.AddWithValue("@Role",comboBoxRole.Text);
                    command.Parameters.AddWithValue("@Gender", comboBoxGender.Text);


                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();

                        LoadUserTableData();

                        MessageBox.Show("User registration created successfully.");
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        comboBoxRole.Text = "";
                        comboBoxGender.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while viewing the description. : {ex.Message}");
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            string usernameToDelete = textBoxDeleteUsername.Text;
            string passwordToDelete = textBoxDeletePassword.Text;

           
            if (string.IsNullOrWhiteSpace(usernameToDelete) || string.IsNullOrWhiteSpace(passwordToDelete))
            {
                MessageBox.Show("Please select the user you want to delete.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "DELETE FROM UserTable WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", usernameToDelete);
                    command.Parameters.AddWithValue("@Password", passwordToDelete);

                    try
                    {
                        
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("The specified user could not be found.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The user has been deleted successfully.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            LoadUserTableData();
                            
                            textBoxDeleteUsername.Clear();
                            textBoxDeletePassword.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the user. : {ex.Message}");
                    }
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUpdatedUsername.Text))
            {
                MessageBox.Show("Please enter the username to update.");
                return;
            }

            
            bool isAdmin = comboBoxUpdatedRole.Text.Equals("Admin", StringComparison.OrdinalIgnoreCase);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = "UPDATE UserTable SET Password = @Password, Role = @Role, Gender = @Gender, IsAdmin = @IsAdmin WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Username", textBoxUpdatedUsername.Text);
                    command.Parameters.AddWithValue("@Password", textBoxUpdatedPassword.Text);
                    command.Parameters.AddWithValue("@Role", comboBoxUpdatedRole.Text); 
                    command.Parameters.AddWithValue("@Gender", comboBoxUpdatedGender.Text); 
                    command.Parameters.AddWithValue("@IsAdmin", isAdmin); 

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User details have been updated successfully.");
                            LoadDataGridView();
                            textBoxUpdatedUsername.Text = "";
                            textBoxUpdatedPassword.Text = "";
                            comboBoxUpdatedRole.Text = "";
                            comboBoxUpdatedGender.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please ensure the username is correct.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating user details: {ex.Message}");
                    }
                }
            }
        }





    }
}
