using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace StokUygulamasi
{

    public static class GlobalVariables
    {
        public static string LoggedInUsername { get; set; }
    }
    public partial class Form1 : Form
    {
        public string connectionstring = "Data Source=SALIH;Initial Catalog=StockApplication;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}