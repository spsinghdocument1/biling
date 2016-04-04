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
using System.Data;
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Report_Group.xaml
    /// </summary>
    public partial class Report_Group : Window
    {
        public Report_Group()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (textBox13.Text == "")
            {
                try
                {
                    string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Group_Enter", connection);

                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                    dataadapter.Fill(dt);

                    dataGrid1.AutoGenerateColumns = true;
                    dataGrid1.ItemsSource = dt.DefaultView;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            if (textBox13.Text != "")
            {
                try
                {
                    string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Group_Enter WHERE Group_Name LIKE '" + textBox13.Text + "' ", connection);

                    SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                    dataadapter.Fill(dt);

                    dataGrid1.AutoGenerateColumns = true;
                    dataGrid1.ItemsSource = dt.DefaultView;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
