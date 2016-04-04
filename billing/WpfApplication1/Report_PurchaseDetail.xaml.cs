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
    /// Interaction logic for Report_PurchaseDetail.xaml
    /// </summary>
    public partial class Report_PurchaseDetail : Window
    {
        public Report_PurchaseDetail()
        {
           
            InitializeComponent();
        }
        //public void a()
        //{
        //    i = 1;
        //    if (i == 1)
        //    {

        //    }


        
        private void button5_Click(object sender, RoutedEventArgs e)
        {

            if (datePicker1.Text != "" && datePicker2.Text != "")
            {
                //MessageBox.Show("ssssssssssssss");

                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice1 WHERE Date BETWEEN '" + datePicker1.Text + "' AND '" + datePicker2.Text + "'", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();


            }
            if (textBox1.Text !="")
            {
                //MessageBox.Show("dddddddddddd");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                 SqlConnection connection = new SqlConnection(connectionString);

                 connection.Open();
                 DataTable dt = new DataTable();

                 SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice1 WHERE Bill_No LIKE '" + textBox1.Text + "'", connection);

                 SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                 dataadapter.Fill(dt);

                 dataGrid1.AutoGenerateColumns = true;
                 dataGrid1.ItemsSource = dt.DefaultView;
                 connection.Close();


            }
                

            //}
            //if (datePicker1.Text == "" && teP            
            if (datePicker1.Text == "" && datePicker2.Text == "" && textBox1.Text == "")
            {
                //MessageBox.Show("Fill Billno. or Date");
                string connectionString = "Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT * FROM PurchaseInvoice1", connection);

                SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                dataadapter.Fill(dt);

                dataGrid1.AutoGenerateColumns = true;
                dataGrid1.ItemsSource = dt.DefaultView;
                connection.Close();
            }
            

                






            //stri            tring = "Data Source=HP-PC\\SQLEXPRESS;Initial Catalog=Billing;Integrated Security=True";
                //SqlConnection connection = new SqlConnection(connectionString);

                //connection.Open();
                //DataTable dt = new DataTable();

                //SqlCommand cmd = new SqlCommand("SELECT * FROM purchase_Detail WHERE date BETWEEN '" + datePicker1.Text + "' AND '" + datePicker2.Text + "'", connection);

                //SqlDataAdapter dataadapter = new SqlDataAdapter(cmd);

                //dataadapter.Fill(dt);

                //dataGrid1.AutoGenerateColumns = true;
                //dataGrid1.ItemsSource = dt.DefaultView;
                //connection.Close();
            
           
            }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog myPrintDialog = new PrintDialog();
            if (myPrintDialog.ShowDialog() == true)
            {
                myPrintDialog.PrintVisual(dataGrid1, "Form All Controls Print");
            }
        }
        }
    }


