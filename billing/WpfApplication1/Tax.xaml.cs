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
    /// Interaction logic for Tax.xaml
    /// </summary>
    public partial class Tax : Window
    {
        public Tax()
        {
            InitializeComponent();
        }

        private void Button12_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Tax_Enter values(@Tax_Name,@Tax_Percentage)", con);
            cmd.Parameters.AddWithValue("@Tax_Name", textname.Text);
            cmd.Parameters.AddWithValue("@Tax_Percentage", textUnit13.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record has been saved successfully");
            textname.Text = string.Empty;
            textUnit13.Text = string.Empty;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            GRouptname.Text = string.Empty;
            textname.Text = string.Empty;
            textUnit13.Text = string.Empty;
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);

        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Tax_Enter", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("ALL Record has been Delete successfully");
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                            try
                {
                    string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);

                    connection.Open();
                    DataTable dt = new DataTable();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Tax_Enter WHERE Tax_Name LIKE '" + GRouptname.Text + "' ", connection);

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

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_2(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_3(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_4(object sender, ExceptionRoutedEventArgs e)
        {

        }
    }
}
