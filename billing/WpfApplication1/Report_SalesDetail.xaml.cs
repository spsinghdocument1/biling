using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;


namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Report_SalesDetail.xaml
    /// </summary>
    public partial class Report_SalesDetail : Window
    {
        public Report_SalesDetail()
        {
            InitializeComponent();
        }

        private void button60_Click(object sender, RoutedEventArgs e)
        {
            if (DATEE.Text == "" && textBox1.Text == "" && textBox2.Text == "")
            {
               // MessageBox.Show("PlZ enter.....");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice2 ", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            if (DATEE.Text != "" && textBox1.Text != "" && textBox2.Text == "")
            {
                MessageBox.Show("PlZ one enter");
            }

            if (DATEE.Text != "" && textBox1.Text == "" && textBox2.Text != "")
            {
                MessageBox.Show("PlZ one enter");
            }
            if (DATEE.Text == "" && textBox1.Text != "" && textBox2.Text != "")
            {
                MessageBox.Show("PlZ one enter");
            }

            if (DATEE.Text != "" && textBox1.Text == "" && textBox2.Text == "")
            {
               // MessageBox.Show("Right DATEE.Text");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice2 WHERE Date LIKE '" + DATEE.Text + "' ", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();


            }
            if (textBox1.Text != "" && textBox2.Text == "" && DATEE.Text == "")
            {
               // MessageBox.Show("Right textBox1.Text");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice2 WHERE Bill_NO LIKE '" + textBox1.Text + "' ", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            if (DATEE.Text == "" && textBox1.Text == "" && textBox2.Text != "")
            {
               // MessageBox.Show("Right textBox2.Text");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice2 WHERE Party_Name LIKE '" + textBox2.Text + "' ", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();
            }
        }
    }
}
