using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokUygulamasi
{
    public partial class StockChanges : Form
    {
        public string connectionString = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public StockChanges()
        {
            InitializeComponent();
        }

        private void StockChanges_Load(object sender, EventArgs e)
        {
            
            LoadProductNames();
        }

        
        private void LoadProductNames()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT ProductName FROM StockChanges"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        comboBox1.Items.Clear(); 
                        while (reader.Read())
                        {
                            comboBox1.Items.Add(reader["ProductName"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading product names. : {ex.Message}");
                    }
                }
            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedProduct = comboBox1.SelectedItem.ToString();
                LoadProductData(selectedProduct);
            }
        }

        
        private void LoadProductData(string productName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM StockChanges WHERE ProductName = @ProductName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        try
                        {
                            connection.Open();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable; 
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while loading product data: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
