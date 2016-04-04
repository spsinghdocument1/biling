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
    /// Interaction logic for ProductDetails.xaml
    /// </summary>
    public partial class ProductDetails : Window
    {
        public ProductDetails()
        {
            InitializeComponent();
            ad();
            add();
            addd();
            adddd();
        }
        public void ad()
        {

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  Unit_Name from Unit;", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Unit");

            comBox15.ItemsSource = ds.Tables[0].DefaultView;
            comBox15.DisplayMemberPath = ds.Tables[0].Columns["Unit_Name"].ToString();
            comBox15.SelectedValuePath = ds.Tables[0].Columns["Unit_Name"].ToString();
        }
        public void add()
        {

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  Brand_Name from Brand;", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Brand");

            combeBox2.ItemsSource = ds.Tables[0].DefaultView;
            combeBox2.DisplayMemberPath = ds.Tables[0].Columns["Brand_Name"].ToString();
            combeBox2.SelectedValuePath = ds.Tables[0].Columns["Brand_Name"].ToString();
        }
        public void addd()
        {

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  Group_Name from Group_Enter;", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Group_Enter");

            combobox3.ItemsSource = ds.Tables[0].DefaultView;
            combobox3.DisplayMemberPath = ds.Tables[0].Columns["Group_Name"].ToString();
            combobox3.SelectedValuePath = ds.Tables[0].Columns["Group_Name"].ToString();
        }
        public void adddd()
        {

            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select  Tax_Percentage from Tax_Enter;", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tax_Enter");

            combobox4.ItemsSource = ds.Tables[0].DefaultView;
            combobox4.DisplayMemberPath = ds.Tables[0].Columns["Tax_Percentage"].ToString();
            combobox4.SelectedValuePath = ds.Tables[0].Columns["Tax_Percentage"].ToString();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product values(@Products_Name,@ShortCode,@Product_Unit,@Product_Brind,@Product_Group,@Tax_Type,@Measurement,@Sub_Measurement,@Unit_Pack,@Purchase_Price,@Sales_Prices,@Reorder_levess)", con);
            cmd.Parameters.AddWithValue("@Products_Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@ShortCode", textBox2.Text);
            cmd.Parameters.AddWithValue("@Product_Unit", comBox15.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Product_Brind", combeBox2.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Product_Group", combobox3.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Tax_Type", combobox4.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Measurement", comebox4.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Sub_Measurement", comebox5.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Unit_Pack", textBox9.Text);
            cmd.Parameters.AddWithValue("@Purchase_Price", textBox10.Text);
            cmd.Parameters.AddWithValue("@Sales_Prices", textBox11.Text);
            cmd.Parameters.AddWithValue("@Reorder_levess", textBox12.Text);
          
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox12.Text = string.Empty;
            comBox15.Text = string.Empty;
            combeBox2.Text = string.Empty;
            combobox3.Text = string.Empty;
            combobox4.Text = string.Empty;
            comebox4.Text = string.Empty;
            comebox5.Text = string.Empty;
            MessageBox.Show("Record has been saved successfully");

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox9.Text = string.Empty;
                    textBox10.Text = string.Empty;
                    textBox11.Text = string.Empty;
                        textBox12.Text = string.Empty;
                        comBox15.Text = string.Empty;
                        combeBox2.Text = string.Empty;
                        combobox3.Text = string.Empty;
                        combobox4.Text = string.Empty;
                        comebox4.Text = string.Empty;
                        comebox5.Text = string.Empty;
                                    textBox13.Text = string.Empty;

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
        private void btserchDELE_Click(object sender, RoutedEventArgs e)
        {

             try
            {
                SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Product", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("ALL Record has been Delete successfully");
        
        
        }

        private void btserch_Click(object sender, RoutedEventArgs e)
        {
               try
            {
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Products_Name LIKE '" + textBox13.Text + "' ", connection);

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
