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
    /// Interaction logic for SalesInvoice.xaml
    /// </summary>
    public partial class SalesInvoice : Window
    {
        DataTable dt;
        public SalesInvoice()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("Bill_NO", typeof(string));
            dt.Columns.Add("Party_Name", typeof(string));
            dt.Columns.Add("GR_NO", typeof(string));
            dt.Columns.Add("TRP", typeof(string));
            dt.Columns.Add("Discription_of_Goods", typeof(string));
            dt.Columns.Add("Qty", typeof(decimal));
            dt.Columns.Add("Price", typeof(decimal));
        }
      

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source=KAMAKHYA-PC\\sqlexpress;Initial Catalog=Billing;Integrated Security=True");
            //con.Open();
            //decimal a, b, c, e, f, h;
            try
            {
                //a = decimal.Parse(textBox5.Text);
                //b = decimal.Parse(textBox6.Text);
                //e = decimal.Parse(textBox30.Text);
                //// c = (a * b)*(e%100);
                //c = (a * b);
                //f = (c) * (e / 100);
                //h = c + f;
                // MessageBox.Show(""+c);

                DataRow dr = dt.NewRow();
                dr["Date"] = DATEE.Text;
                dr["Bill_NO"] = textBox1.Text;
                dr["Party_Name"] = textBox2.Text;
                dr["GR_NO"] = textBox7.Text;
                dr["TRP"] = textBox8.Text;
                dr["Discription_of_Goods"] = comboBox1.Text;
                dr["Qty"] = textBox5.Text;

                dr["Price"] = textBox6.Text;

                
                dt.Rows.Add(dr);
                dataGrid1.ItemsSource = null;
                dataGrid1.ItemsSource = dt.DefaultView;

                object z = dt.Compute("SUM(Qty)", "");
                textBox3.Text = z.ToString();
                object y = dt.Compute("SUM(Price)", "");
                textBox4.Text = y.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
           
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SPSINGH;Initial Catalog=Billing;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into PurchaseInvoice1 values(@Discription_of_Goods,@Total_Price,@Date,@Bill_No,@Party_Name,@GR_NO,@TRP,@Total_Quantity)", con);
            cmd.Parameters.AddWithValue("@Discription_of_Goods", comboBox1.Text);
           
            cmd.Parameters.AddWithValue("@Total_Price", textBox4.Text);
            cmd.Parameters.AddWithValue("@Date", DATEE.Text);
            cmd.Parameters.AddWithValue("@Bill_No", textBox1.Text);
            cmd.Parameters.AddWithValue("@Party_Name", textBox2.Text);
            cmd.Parameters.AddWithValue("@GR_NO", textBox7.Text);
            cmd.Parameters.AddWithValue("@TRP", textBox8.Text);
            cmd.Parameters.AddWithValue("@Total_Quantity", textBox3.Text);
            
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            comboBox1.Text = string.Empty;
            MessageBox.Show("Record has been saved successfully");
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

       
    }
}
