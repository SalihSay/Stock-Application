using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokUygulamasi
{
    public partial class AnaForm : Form
    {
        private readonly bool isAdmin;
        public string connectionString = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public AnaForm(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            
            buttonNewUser.Enabled = isAdmin;

            if (!isAdmin)
            {
                MessageBox.Show("You do not have admin rights. You cannot add new users.");
            }
        }

        private bool CheckIfUserIsAdmin(string username, string password)
        {
            bool isAdmin = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
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

                        if (result != null)
                        {
                            // Debug için sonuç bilgilerini göster
                            MessageBox.Show($"Query Result: {result}");

                            // Sonuç tipini kontrol et
                            if (result is bool)
                            {
                                isAdmin = (bool)result;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }

            return isAdmin;
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            // Production işlemleri burada yapılacak
            ProductionStockForm production=new ProductionStockForm();
            production.Show();
        }

        private void buttonProduction_Click(object sender, EventArgs e)
        {
            // Yeni kullanıcı kayıt işlemleri burada yapılacak
            if (isAdmin)
            {
                NewUserForm newuser = new NewUserForm();
                newuser.Show();
            }
            else
            {
                MessageBox.Show("Only admin users can add new users.");
            }
        }

        private void buttonPCB_Click(object sender, EventArgs e)
        {
            PcbStock pcb=new PcbStock();
            pcb.Show();

        }

        private void buttonStockChanges_Click(object sender, EventArgs e)
        {
            StockChanges changes=new StockChanges();
            changes.Show();
        }
    }
}
