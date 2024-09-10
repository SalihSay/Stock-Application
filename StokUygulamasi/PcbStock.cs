using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokUygulamasi
{
    public partial class PcbStock : Form
    {
        public string connectionString = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public PcbStock()
        {
            InitializeComponent();
        }

        private void PcbStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockApplicationDataSet13.PCBTable' table. You can move, or remove it, as needed.
            this.pCBTableTableAdapter4.Fill(this.stockApplicationDataSet13.PCBTable);
            // TODO: This line of code loads data into the 'stockApplicationDataSet11.PCBTable' table. You can move, or remove it, as needed.
            this.pCBTableTableAdapter3.Fill(this.stockApplicationDataSet11.PCBTable);
            this.pCBTableTableAdapter2.Fill(this.stockApplicationDataSet2.PCBTable);
            comboBoxPCB.SelectedIndexChanged += new EventHandler(comboBoxPCB_SelectedIndexChanged);
            LoadProducts();

            //if (comboBoxPCB.Items.Count > 0)
            //{
            //    comboBoxPCB.SelectedIndex = 0;
            //    comboBoxPCB_SelectedIndexChanged(comboBoxPCB, EventArgs.Empty); 
            //}
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemName FROM PCBTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        comboBoxPCB.Items.Clear();
                        comboBoxDeletedPCB.Items.Clear();

                        while (reader.Read())
                        {
                            string itemName = reader["ItemName"].ToString();
                            comboBoxPCB.Items.Add(itemName);
                            comboBoxDeletedPCB.Items.Add(itemName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading products: {ex.Message}");
                    }
                }
            }
        }
        private void UpdateThreshold(string itemName,int newThreshold)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PCBTable SET Threshold = @NewThreshold WHERE ItemName = @ItemName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NewThreshold", newThreshold);
                    command.Parameters.AddWithValue("@ItemName", itemName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Threshold value for the selected product has been updated successfully.");
                            LoadDataGridView();  // Tabloyu güncelle
                            LoadProducts();      // Ürünleri güncelle
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Check if the product exists.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the threshold value: {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void LoadDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PCBTable";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void comboBoxPCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPCB.SelectedItem != null)
            {
                string selectedProduct = comboBoxPCB.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Quantity değerini almak için sorgu
                    string queryQuantity = "SELECT Amount, Threshold FROM PCBTable WHERE ItemName = @ItemName";
                    using (SqlCommand command = new SqlCommand(queryQuantity, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", selectedProduct);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                int quantity = reader.GetInt32(reader.GetOrdinal("Amount"));
                                int threshold = reader.GetInt32(reader.GetOrdinal("Threshold"));

                                // Quantity değerini TextBox'a yaz
                                textBoxAmount.Text = quantity.ToString();

                                // Eğer Quantity, Threshold'dan küçükse uyarı göster
                                if (quantity <= threshold)
                                {
                                    MessageBox.Show($"Warning: Stock for {selectedProduct} is at or below the threshold of {threshold}!",
                                                    "Low Stock Warning",
                                                    MessageBoxButtons.OK,
                                                    MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("The selected item was not found.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while loading the stock quantity: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void buttonArti_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonEksi_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SaveDescription(string productName, string description, string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO StockChanges (ProductName, Description, ChangedBy, ChangeDate) VALUES (@ProductName, @Description, @ChangedBy, @ChangeDate)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@ChangedBy", username);
                    command.Parameters.AddWithValue("@ChangeDate", DateTime.Now);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the description: {ex.Message}");
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedQuantity = dataGridView1.Rows[e.RowIndex].Cells["Amount"].Value;

                if (selectedQuantity != null)
                {
                    if (int.TryParse(selectedQuantity.ToString(), out int quantity))
                    {
                        textBoxAmount.Text = quantity.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Selected quantity is not a valid number.");
                    }
                }
                else
                {
                    MessageBox.Show("Selected quantity is null.");
                }
            }
        }

        private void buttonStockChanges_Click_1(object sender, EventArgs e)
        {
            StockChanges change = new StockChanges();
            change.Show();
        }

        private void buttonDeletePCB_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonAddPCB_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAmount.Text, out int quantity))
            {
                quantity++;
                textBoxAmount.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
            }
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAmount.Text, out int quantity))
            {
                quantity--;
                textBoxAmount.Text = quantity.ToString();
            }
            else
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxAmount.Text, out int newQuantity))
            {
                MessageBox.Show("Invalid amount. Please enter a valid number.");
                return;
            }

            string selectedProduct = comboBoxPCB.SelectedItem.ToString();
            string description = textBoxComment.Text;
            string username = GlobalVariables.LoggedInUsername;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE PCBTable SET Amount = @Quantity, LastUpdatedBy = @Username, LastUpdatedAt = @Date WHERE ItemName = @ItemName";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", newQuantity);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Date", DateTime.Now);
                    command.Parameters.AddWithValue("@ItemName", selectedProduct);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            SaveDescription(selectedProduct, description, username);
                            MessageBox.Show("Stock quantity has been updated successfully.");
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No rows to update were found. Check if the product is available.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the stock quantity: {ex.Message}");
                    }
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxPCB.Text = "";
            textBoxAmount.Text = "";
            textBoxComment.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddPCB_Click(object sender, EventArgs e)
        {
            string newProductName = textBoxNewPCB.Text;

            if (string.IsNullOrWhiteSpace(newProductName))
            {
                MessageBox.Show("Please enter the product name you want to add.");
                return;
            }

            if (!int.TryParse(textBoxAddAmount.Text, out int quantity))
            {
                MessageBox.Show("Invalid quantity. Please enter a valid number.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO PCBTable (ItemName, Amount) VALUES (@ItemName, @Quantity)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", newProductName);
                    command.Parameters.AddWithValue("@Quantity", quantity);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("The product has been added successfully.");
                        LoadProducts();
                        LoadDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the product: {ex.Message}");
                    }
                }
            }
        }

        private void buttonDeletePCB_Click(object sender, EventArgs e)
        {
            if (comboBoxDeletedPCB.SelectedItem == null)
            {
                MessageBox.Show("Please select the product you want to delete.");
                return;
            }

            string productToDelete = comboBoxDeletedPCB.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Silme sorgusu
                        string queryDeletePCB = "DELETE FROM PCBTable WHERE ItemName = @ItemName";
                        using (SqlCommand command = new SqlCommand(queryDeletePCB, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ItemName", productToDelete);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected <= 0)
                            {
                                MessageBox.Show("No items to delete were found.");
                                transaction.Rollback();
                                return;
                            }
                        }

                        // StockChanges tablosundan silme
                        string queryDeleteStockChanges = "DELETE FROM StockChanges WHERE ProductName = @ProductName";
                        using (SqlCommand command = new SqlCommand(queryDeleteStockChanges, connection, transaction))
                        {
                            command.Parameters.AddWithValue("@ProductName", productToDelete);
                            command.ExecuteNonQuery();
                        }

                        // İşlemi tamamla
                        transaction.Commit();

                        // Kullanıcıya başarı mesajı göster
                        MessageBox.Show("The product has been deleted successfully.");

                        // comboBoxDeletedPCB'den seçilen ürünü kaldır
                        comboBoxDeletedPCB.Items.Remove(productToDelete);

                        // Ürünleri ve verileri yenile
                        LoadProducts();
                        LoadDataGridView();
                    }
                    catch (Exception ex)
                    {
                        // İşlem sırasında hata oluşursa işlemi geri al
                        transaction.Rollback();
                        MessageBox.Show($"An error occurred while deleting the product: {ex.Message}");
                    }
                }
            }
        }


        private void comboBoxDeletedPCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void buttonUpdateThreshold_Click(object sender, EventArgs e)
        {
            if (comboBoxPCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (int.TryParse(textBoxThreshold.Text, out int newThreshold))
            {
                string selectedProduct = comboBoxPCB.SelectedItem.ToString();

                // Yeni eşik değerini güncelle
                UpdateThreshold(selectedProduct, newThreshold);
            }
            else
            {
                MessageBox.Show("Please enter a valid number for the threshold.");
            }
        }
    }
}
