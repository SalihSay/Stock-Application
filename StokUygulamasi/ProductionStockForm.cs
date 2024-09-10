using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StokUygulamasi
{
    public partial class ProductionStockForm : Form
    {
        public string connectionString = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public ProductionStockForm()
        {
            InitializeComponent();
            LoadProducts();
            LoadDataGridView();
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ItemName FROM ProductionTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        comboBoxProduct.Items.Clear(); 
                        while (reader.Read())
                        {
                            comboBoxProduct.Items.Add(reader["ItemName"].ToString());
                            comboBoxDeletedProduction.Items.Add(reader["ItemName"].ToString());
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading products. : {ex.Message}");
                    }
                }
            }
        }
        private void LoadDataGridView()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM ProductionTable";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data. : {ex.Message}");
            }
        }


        private void ProductionStockForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockApplicationDataSet10.ProductionTable' table. You can move, or remove it, as needed.
            this.productionTableTableAdapter4.Fill(this.stockApplicationDataSet10.ProductionTable);

            this.productionTableTableAdapter3.Fill(this.stockApplicationDataSet3.ProductionTable);
            LoadProducts();

            
            //if (comboBoxProduct.Items.Count > 0)
            //{
            //    comboBoxProduct.SelectedIndex = 0;
            //}

            comboBoxProduct.SelectedIndexChanged += new EventHandler(comboBoxProduct_SelectedIndexChanged);
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonArti_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonEksi_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAmount.Text, out int quantity))
            {
                if (quantity > 0) // Negatif stok miktarını engelle
                {
                    quantity--;
                    textBoxAmount.Text = quantity.ToString();
                }
                else
                {
                    MessageBox.Show("Stock quantity cannot be less than zero.");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                        MessageBox.Show($"An error occurred while saving the description. : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close(); 
                    }
                }
            }
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonSave_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonStockChanges_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxComment.Text = "";
            textBoxAmount.Text = "";
            comboBoxProduct.Text = "";
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (comboBoxDeletedProduction.SelectedItem == null)
            {
                MessageBox.Show("Please select the product you want to delete.");
                return;
            }

            string productToDelete = comboBoxDeletedProduction.SelectedItem.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string deleteProductionQuery = "DELETE FROM ProductionTable WHERE ItemName = @ItemName";
                using (SqlCommand command = new SqlCommand(deleteProductionQuery, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", productToDelete);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            string deleteStockChangesQuery = "DELETE FROM StockChanges WHERE ProductName = @ProductName";
                            using (SqlCommand stockChangesCommand = new SqlCommand(deleteStockChangesQuery, connection))
                            {
                                stockChangesCommand.Parameters.AddWithValue("@ProductName", productToDelete);
                                stockChangesCommand.ExecuteNonQuery();
                            }

                            // Seçilen ürünü combobox'dan kaldır
                            comboBoxDeletedProduction.Items.Remove(productToDelete);

                            MessageBox.Show("The product has been deleted successfully.");
                            LoadProducts();
                            LoadDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No items to delete were found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the product: {ex.Message}");
                    }
                }
            }
        }


        private void buttonAddProduct_Click_1(object sender, EventArgs e)
        {
            string newProductName = textBoxNewProduct.Text;

            if (string.IsNullOrWhiteSpace(newProductName))
            {
                MessageBox.Show("Please enter the product name you want to add.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ProductionTable (ItemName,Quantity) VALUES (@ItemName,@Quantity)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ItemName", newProductName);
                    command.Parameters.AddWithValue("@Quantity", textBoxAddAmount.Text);



                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("The new product has been added successfully.");

                        textBoxNewProduct.Clear();
                        LoadProducts();
                        LoadDataGridView();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while adding the product. : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStockChanges_Click_1(object sender, EventArgs e)
        {
            StockChanges changes = new StockChanges();
            changes.Show();
        }

        private void buttonSave_Click_2(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(textBoxAmount.Text, out int newQuantity))
            {
                MessageBox.Show("Enter a valid stock quantity.");
                return;
            }

            string selectedProduct = comboBoxProduct.SelectedItem.ToString();
            string description = textBoxComment.Text;
            string username = GlobalVariables.LoggedInUsername; // Giriş yapan kullanıcının adı

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE ProductionTable SET Quantity = @Quantity, LastUpdatedBy = @Username, LastUpdatedAt = @Date WHERE ItemName = @ItemName";
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
                            MessageBox.Show("No updateable product found.");
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"SQL Error: {sqlEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred. : {ex.Message}");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            textBoxComment.Text = "";
            textBoxAmount.Text = "";
            comboBoxProduct.Text = "";
        }

        private void buttonArti_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAmount.Text, out int quantity))
            {
                quantity++;
                textBoxAmount.Text = quantity.ToString();
            }
        }

        private void buttonEksi_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxAmount.Text, out int quantity))
            {
                quantity--;
                textBoxAmount.Text = quantity.ToString();
            }
        }
        private void buttonUpdateThreshold_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateThreshold(string itemName, int newThreshold)
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



        private void comboBoxProduct_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem != null)
            {
                string selectedProduct = comboBoxProduct.SelectedItem.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Quantity değerini almak için sorgu
                    string queryQuantity = "SELECT Quantity, Threshold FROM ProductionTable WHERE ItemName = @ItemName";
                    using (SqlCommand command = new SqlCommand(queryQuantity, connection))
                    {
                        command.Parameters.AddWithValue("@ItemName", selectedProduct);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                int quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonUpdateThreshold_Click_1(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem == null)
            {
                MessageBox.Show("Please select a product first.");
                return;
            }

            if (int.TryParse(textBoxThreshold.Text, out int newThreshold))
            {
                string selectedProduct = comboBoxProduct.SelectedItem.ToString();

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

   

