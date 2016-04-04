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
    /// Interaction logic for CostomerDetails.xaml
    /// </summary>
    public partial class CostomerDetails : Window
    {
        public CostomerDetails()
        {
            InitializeComponent();
        }

        

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            try
            {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer_Enter values(@Customer_Name,@Address,@City,@State,@Country,@Pin_Code,@Mobile_Number,@Phone_Number,@E_Mail_Id,@Tin_Number,@CST_Number,@Pan_Number)", con);
            cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Address", textBox2.Text);
            cmd.Parameters.AddWithValue("@City", textBox3.Text);
            cmd.Parameters.AddWithValue("@State", textBox4.Text);
            cmd.Parameters.AddWithValue("@Country", textBox5.Text);
            cmd.Parameters.AddWithValue("@Pin_Code", textBox6.Text);
            cmd.Parameters.AddWithValue("@Mobile_Number", textBox7.Text);
            cmd.Parameters.AddWithValue("@Phone_Number", textBox8.Text);
            cmd.Parameters.AddWithValue("@E_Mail_Id", textBox9.Text);
            cmd.Parameters.AddWithValue("@Tin_Number", textBox10.Text);
            cmd.Parameters.AddWithValue("@CST_Number", textBox11.Text);

            cmd.Parameters.AddWithValue("@Pan_Number", textBox12.Text);
            cmd.ExecuteNonQuery();
            con.Close();
              }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;
            MessageBox.Show("Record has been saved successfully");
           

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            textBox13.Text = string.Empty;

        }



        private void button4_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer_Enter WHERE Customer_Name LIKE '" + textBox13.Text + "' ", connection);

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
        private void button9_Click(object sender, RoutedEventArgs e)
        {
             try
            {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Customer_Enter", con);
            cmd.ExecuteNonQuery();
            con.Close();
            }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             MessageBox.Show("ALL Record has been Delete successfully");


        }

        private void Image_ImageFailed_1(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_2(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void Image_ImageFailed_3(object sender, ExceptionRoutedEventArgs e)
        {

        }

       

    }
}
